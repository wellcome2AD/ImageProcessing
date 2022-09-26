using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полутонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полутонаToolStripMenuItem,
            this.autocontrastToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // полутонаToolStripMenuItem
            // 
            this.полутонаToolStripMenuItem.Name = "полутонаToolStripMenuItem";
            this.полутонаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.полутонаToolStripMenuItem.Text = "Полутона";
            this.полутонаToolStripMenuItem.Click += new System.EventHandler(this.полутонаToolStripMenuItem_Click);
            // 
            // autocontrastToolStripMenuItem
            // 
            this.autocontrastToolStripMenuItem.Name = "autocontrastToolStripMenuItem";
            this.autocontrastToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.autocontrastToolStripMenuItem.Text = "Autocontrast";
            this.autocontrastToolStripMenuItem.Click += new System.EventHandler(this.autocontrastToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageФильтрToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // averageФильтрToolStripMenuItem
            // 
            this.averageФильтрToolStripMenuItem.Name = "averageФильтрToolStripMenuItem";
            this.averageФильтрToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.averageФильтрToolStripMenuItem.Text = "Average фильтр";
            this.averageФильтрToolStripMenuItem.Click += new System.EventHandler(this.averageФильтрToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "First task";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem полутонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autocontrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
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
        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
        private void полутонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        Color sourceColor = image.GetPixel(i, j);
                        double Intensity = 0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B;
                        Color resultColor = Color.FromArgb(Clamp((int)Intensity, 0, 255),
                                                           Clamp((int)Intensity, 0, 255),
                                                           Clamp((int)Intensity, 0, 255));
                        resultImage.SetPixel(i, j, resultColor);
                    }
                }

                pictureBox1.Image = resultImage;
                image = resultImage;
            }
            else
            {
                MessageBox.Show("Нет файла для изменения. Для начала откройте файл.", "Ошибка");
            }
        }
        int[] calculateCoefficient(Bitmap sourceImage)
        {
            int Rmin = 255, Rmax = 0, Gmin = 255, Gmax = 0, Bmin = 255, Bmax = 0;
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    col = sourceImage.GetPixel(i, j);
                    Rmax = (col.R > Rmax) ? col.R : Rmax;
                    Rmin = (col.R < Rmin) ? col.R : Rmin;
                    Gmax = (col.G > Gmax) ? col.G : Gmax;
                    Gmin = (col.G < Gmin) ? col.G : Gmin;
                    Bmax = (col.B > Bmax) ? col.B : Bmax;
                    Bmin = (col.B < Bmin) ? col.B : Bmin;
                }
            }
            int[] brightnesses = { Rmin, Rmax, Gmin, Gmax, Bmin, Bmax };
            return brightnesses;
        }
        private void autocontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int[] brightnesses = calculateCoefficient(image);
                int Rmin = brightnesses[0];
                int Rmax = brightnesses[1];
                int Gmin = brightnesses[2];
                int Gmax = brightnesses[3];
                int Bmin = brightnesses[4];
                int Bmax = brightnesses[5];
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        Color sourceColor = image.GetPixel(i, j);
                        Color resultColor = Color.FromArgb(Clamp((int)((sourceColor.R - Rmin) * 255 / (Rmax - Rmin)), 0, 255),
                                                           Clamp((int)((sourceColor.G - Gmin) * 255 / (Gmax - Gmin)), 0, 255),
                                                           Clamp((int)((sourceColor.B - Bmin) * 255 / (Bmax - Bmin)), 0, 255));
                        resultImage.SetPixel(i, j, resultColor);
                    }
                }

                pictureBox1.Image = resultImage;
                image = resultImage;
            }
            else
            {
                MessageBox.Show("Нет файла для изменения. Для начала откройте файл.", "Ошибка");
            }
        }
        private void averageФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int size = 3;
                float[,] kernel = new float[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        kernel[i, j] = 1f / (size * size);
                    }
                }

                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        int radiusX = kernel.GetLength(0) / 2;
                        int radiusY = kernel.GetLength(1) / 2;
                        float resultR = 0, resultG = 0, resultB = 0;

                        for (int l = -radiusY; l <= radiusY; l++)
                        {
                            for (int k = -radiusX; k <= radiusX; k++)
                            {
                                int idX = Clamp(i + k, 0, image.Width - 1);
                                int idY = Clamp(j + l, 0, image.Height - 1);
                                Color neighborColor = image.GetPixel(idX, idY);
                                resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                                resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                                resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                            }
                        }
                        Color resultColor = Color.FromArgb(Clamp((int)resultR, 0, 255),
                                                           Clamp((int)resultG, 0, 255),
                                                           Clamp((int)resultB, 0, 255));
                        resultImage.SetPixel(i, j, resultColor);
                    }
                }

                pictureBox1.Image = resultImage;
                image = resultImage;
            }
            else
            {
                MessageBox.Show("Нет файла для изменения. Для начала откройте файл.", "Ошибка");
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
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
