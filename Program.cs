using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            this.зашумлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saltAndPepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayleighNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устранениеШумаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alfatrimmedMeanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peakSignaltonoiseRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.фильтрыToolStripMenuItem,
            this.сравнениеToolStripMenuItem});
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
            this.зашумлениеToolStripMenuItem,
            this.устранениеШумаToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // зашумлениеToolStripMenuItem
            // 
            this.зашумлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saltAndPepperToolStripMenuItem,
            this.rayleighNoiseToolStripMenuItem});
            this.зашумлениеToolStripMenuItem.Name = "зашумлениеToolStripMenuItem";
            this.зашумлениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зашумлениеToolStripMenuItem.Text = "Зашумление";
            // 
            // saltAndPepperToolStripMenuItem
            // 
            this.saltAndPepperToolStripMenuItem.Name = "saltAndPepperToolStripMenuItem";
            this.saltAndPepperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saltAndPepperToolStripMenuItem.Text = "Salt and pepper";
            this.saltAndPepperToolStripMenuItem.Click += new System.EventHandler(this.saltAndPepperToolStripMenuItem_Click);
            // 
            // rayleighNoiseToolStripMenuItem
            // 
            this.rayleighNoiseToolStripMenuItem.Name = "rayleighNoiseToolStripMenuItem";
            this.rayleighNoiseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rayleighNoiseToolStripMenuItem.Text = "Rayleigh noise";
            this.rayleighNoiseToolStripMenuItem.Click += new System.EventHandler(this.rayleighNoiseToolStripMenuItem_Click);
            // 
            // устранениеШумаToolStripMenuItem
            // 
            this.устранениеШумаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медианныйToolStripMenuItem,
            this.alfatrimmedMeanToolStripMenuItem});
            this.устранениеШумаToolStripMenuItem.Name = "устранениеШумаToolStripMenuItem";
            this.устранениеШумаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.устранениеШумаToolStripMenuItem.Text = "Устранение шума";
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // alfatrimmedMeanToolStripMenuItem
            // 
            this.alfatrimmedMeanToolStripMenuItem.Name = "alfatrimmedMeanToolStripMenuItem";
            this.alfatrimmedMeanToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.alfatrimmedMeanToolStripMenuItem.Text = "Alfa-trimmed mean";
            this.alfatrimmedMeanToolStripMenuItem.Click += new System.EventHandler(this.alfatrimmedMeanToolStripMenuItem_Click);
            // 
            // сравнениеToolStripMenuItem
            // 
            this.сравнениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSIMToolStripMenuItem,
            this.peakSignaltonoiseRatioToolStripMenuItem});
            this.сравнениеToolStripMenuItem.Name = "сравнениеToolStripMenuItem";
            this.сравнениеToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.сравнениеToolStripMenuItem.Text = "Сравнение";
            // 
            // sSIMToolStripMenuItem
            // 
            this.sSIMToolStripMenuItem.Name = "sSIMToolStripMenuItem";
            this.sSIMToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sSIMToolStripMenuItem.Text = "Structural Similarity Index Measure";
            this.sSIMToolStripMenuItem.Click += new System.EventHandler(this.ssimMToolStripMenuItem_Click);
            // 
            // peakSignaltonoiseRatioToolStripMenuItem
            // 
            this.peakSignaltonoiseRatioToolStripMenuItem.Name = "peakSignaltonoiseRatioToolStripMenuItem";
            this.peakSignaltonoiseRatioToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.peakSignaltonoiseRatioToolStripMenuItem.Text = "Peak signal-to-noise ratio";
            this.peakSignaltonoiseRatioToolStripMenuItem.Click += new System.EventHandler(this.psnrToolStripMenuItem_Click);
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
            this.Text = "Second task";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem зашумлениеToolStripMenuItem;
        private ToolStripMenuItem saltAndPepperToolStripMenuItem;
        private ToolStripMenuItem rayleighNoiseToolStripMenuItem;
        private ToolStripMenuItem устранениеШумаToolStripMenuItem;
        private ToolStripMenuItem медианныйToolStripMenuItem;
        private ToolStripMenuItem alfatrimmedMeanToolStripMenuItem;
        private ToolStripMenuItem сравнениеToolStripMenuItem;
        private ToolStripMenuItem sSIMToolStripMenuItem;
        private ToolStripMenuItem peakSignaltonoiseRatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public partial class Form1 : Form
    {
        Bitmap image;
        Bitmap perfect_image;
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
            perfect_image = new Bitmap(image);
        }
        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
        private void saltAndPepperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                float s_prob = 0.12f, p_prob = 1.0f - s_prob;
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                Random rnd = new Random();
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        Color sourceColor = image.GetPixel(i, j);
                        float prob = (float)rnd.NextDouble();
                        Color resultColor;
                        if (prob < s_prob)
                        {
                            resultColor = Color.FromArgb(0, 0, 0);
                        }
                        else if (prob >= p_prob)
                        {
                            resultColor = Color.FromArgb(255, 255, 255);
                        }
                        else
                        {
                            resultColor = sourceColor;
                        }
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
        private float[] ComputeProb()
        {
            float[] rayleigh = new float[256];
            float sum = 0f;
            double a = 0; //перевод распределения вдоль горизонтальной оси
            double b = 0.4;
            int size = image.Width * image.Height;
            for (int i = 0; i < 256; ++i)
            {
                double step = (float)i * 0.01;
                if (step >= a)
                {
                    rayleigh[i] = (float)((2 / b) * (step - a) * Math.Exp(-Math.Pow(step - a, 2) / b));
                }
                else
                {
                    rayleigh[i] = 0;
                }
                sum += rayleigh[i];
            }

            for (int i = 0; i < 256; i++)
            {
                rayleigh[i] /= sum;
                rayleigh[i] *= size * 0.12f;
                rayleigh[i] = (int)Math.Floor(rayleigh[i]);
            }

            return rayleigh;
        }
        private byte[] ComputeNoise(float[] uniform, int size)
        {
            Random random = new Random();
            int count = 0;
            byte[] noise = new byte[size];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)uniform[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)uniform[i];
            }

            for (int i = 0; i < size - count; i++)
            {
                noise[count + i] = 0;
            }

            noise = noise.OrderBy(x => random.Next()).ToArray();
            return noise;
        }
        private static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
        private void rayleighNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int size = image.Width * image.Height;
                float[] rayleigh = ComputeProb();
                var noise = ComputeNoise(rayleigh, size);
                var resultImage = new Bitmap(image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color color = image.GetPixel(x, y);
                        resultImage.SetPixel(x, y, Color.FromArgb(Clamp(color.R + noise[image.Width * y + x], 0, 255),
                                                                  Clamp(color.G + noise[image.Width * y + x], 0, 255),
                                                                  Clamp(color.B + noise[image.Width * y + x], 0, 255)));
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
        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                int size = 3;
                for (int i = size / 2; i < (w - size / 2); i++)
                {
                    for (int j = size / 2; j < (h - size / 2); j++)
                    {
                        List<Color> pixels_inside_window = new List<Color>();
                        for (int y = -size / 2; y <= size / 2; y++)
                        {
                            for (int x = -size / 2; x <= size / 2; x++)
                            {
                                pixels_inside_window.Add(image.GetPixel(i + x, j + y));
                            }
                        }

                        pixels_inside_window.Sort((color1, color2) => color1.ToArgb() - color2.ToArgb());
                        resultImage.SetPixel(i, j, pixels_inside_window[4]);
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
        private static List<Color> Slice(List<Color> list, int start_index, int element_count)
        {
            List<Color> slice_list = list.Skip(start_index).Take(element_count).ToList();
            return slice_list;
        }
        private Color MeanColor(List<Color> list)
        {
            float mean_Rvalue = .0f;
            float mean_Gvalue = .0f;
            float mean_Bvalue = .0f;
            int element_count = list.Count;

            foreach (var element in list)
            {
                mean_Rvalue += element.R;
                mean_Gvalue += element.G;
                mean_Bvalue += element.B;
            }
            mean_Rvalue /= element_count;
            mean_Gvalue /= element_count;
            mean_Bvalue /= element_count;

            return Color.FromArgb((int)mean_Rvalue, (int)mean_Gvalue, (int)mean_Bvalue);
        }
        private void alfatrimmedMeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                int size = 3;
                for (int i = size / 2; i < (w - size / 2); i++)
                {
                    for (int j = size / 2; j < (h - size / 2); j++)
                    {
                        List<Color> pixels_inside_window = new List<Color>();
                        for (int y = -size / 2; y <= size / 2; y++)
                        {
                            for (int x = -size / 2; x <= size / 2; x++)
                            {
                                pixels_inside_window.Add(image.GetPixel(i + x, j + y));
                            }
                        }

                        pixels_inside_window.Sort((color1, color2) => color1.ToArgb() - color2.ToArgb());
                        int trimmed_count = size;
                        List<Color> slice_list = Slice(pixels_inside_window, trimmed_count, size * size - 2 * trimmed_count);
                        Color mean_color = MeanColor(slice_list);
                        resultImage.SetPixel(i, j, mean_color);
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
        private void ssimMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perfect_image != null)
            {
                float current_SSIM = ComputeCurrentSSIM();
                MessageBox.Show("SSIM = " + current_SSIM.ToString());
            }
            else
            {
                MessageBox.Show("Нет файла для изменения. Для начала откройте файл.", "Ошибка");
            }
        }
        private void psnrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perfect_image != null)
            {
                float current_PSNR = ComputeCurrentPSNR();
                MessageBox.Show("PSNR = " + current_PSNR.ToString());
            }
            else
            {
                MessageBox.Show("Нет файла для изменения. Для начала откройте файл.", "Ошибка");
            }
        }
        private float ComputeCurrentSSIM()
        {
            float L = (float)(Math.Pow(2, 8) - 1f);
            float k1 = 0.01f, k2 = 0.03f;
            float c1 = (float)Math.Pow(k1 * L, 2);
            float c2 = (float)Math.Pow(k2 * L, 2);


            float meanX = ComputeMean(perfect_image), meanY = ComputeMean(image); // nu(x), nu(y)
            float disX = ComputeDis(perfect_image, meanX), disY = ComputeDis(image, meanY); // sigma(x), sigma(y)
            float covXY = ComputeCov(perfect_image, meanX, image, meanY); // sigma(x,y)

            float ssim = (2 * meanX * meanY + c1) * (2 * covXY + c2) / (float)(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + c1)
                / (float)(Math.Pow(disX, 2) + Math.Pow(disY, 2) + c2);
            return ssim;
        }
        private float ComputeCurrentPSNR()
        {
            float mse = ComputeMSE();
            float psnr = 20 * (float)Math.Log10(255 / Math.Sqrt(mse));
            return psnr;
        }
        private float ComputeMSE()
        {
            float sumR = 0f;
            float sumG = 0f;
            float sumB = 0f;
            int w = image.Width, h = image.Height;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sumR += (float)Math.Pow(perfect_image.GetPixel(i, j).R - image.GetPixel(i, j).R, 2);
                    sumG += (float)Math.Pow(perfect_image.GetPixel(i, j).G - image.GetPixel(i, j).G, 2);
                    sumB += (float)Math.Pow(perfect_image.GetPixel(i, j).B - image.GetPixel(i, j).B, 2);
                }
            }
            return (sumR + sumG + sumB) / (float)Math.Pow((w * h), 3);
        }
        private static float ComputeMean(Bitmap image)
        {
            float sum = 0f;
            int w = image.Width, h = image.Height;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sum += GetBrightness(image.GetPixel(i, j));
                }
            }            
            return (sum / (float)(w * h));
        }
        private static float ComputeDis(Bitmap image, float mean)
        {
            float sum = 0f;
            int w = image.Width, h = image.Height;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sum += (float)Math.Pow(GetBrightness(image.GetPixel(i, j)) - mean, 2);
                }
            }
            return (float)Math.Sqrt(sum / ((float)(w * h) - 1f));
        }
        private static float ComputeCov(Bitmap im1, float m1, Bitmap im2, float m2)
        {
            float sum = 0f;
            int w = im1.Width, h = im1.Height;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    sum += (GetBrightness(im1.GetPixel(i, j)) - m1) *
                        (GetBrightness(im2.GetPixel(i, j)) - m2);
                }
            }
            return (sum / ((float)(w * h) - 1f));
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
