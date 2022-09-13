using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (image == null)
            {
                MessageBox.Show("Нет файла для сохранения. Для начала откройте файл.", "Ошибка");
            }
            else if (dialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(dialog.FileName);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filter)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }
        private void полутонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        private void autocontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Autocontrast(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void averageФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Average();
            backgroundWorker1.RunWorkerAsync(filter);
        }        
        private void отменаButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
