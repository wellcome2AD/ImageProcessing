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
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полутонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глобальныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияПоГистограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашумлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saltAndPepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayleighNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.устранениеШумаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.матричныеToolStripMenuItem,
            this.глобальныеToolStripMenuItem,
            this.зашумлениеToolStripMenuItem,
            this.устранениеШумаToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полутонаToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // полутонаToolStripMenuItem
            // 
            this.полутонаToolStripMenuItem.Name = "полутонаToolStripMenuItem";
            this.полутонаToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.полутонаToolStripMenuItem.Text = "Бинаризация";
            this.полутонаToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            this.матричныеToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияПоМетодуНиблэкаToolStripMenuItem_Click);
            // 
            // бинаризацияПоМетодуНиблэкаToolStripMenuItem
            // 
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem.Name = "бинаризацияПоМетодуНиблэкаToolStripMenuItem";
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem.Text = "Бинаризация по методу Ниблэка";
            this.бинаризацияПоМетодуНиблэкаToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияПоМетодуНиблэкаToolStripMenuItem_Click);
            // 
            // глобальныеToolStripMenuItem
            // 
            this.глобальныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бинаризацияПоГистограммеToolStripMenuItem});
            this.глобальныеToolStripMenuItem.Name = "глобальныеToolStripMenuItem";
            this.глобальныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.глобальныеToolStripMenuItem.Text = "Глобальные";
            // 
            // бинаризацияПоГистограммеToolStripMenuItem
            // 
            this.бинаризацияПоГистограммеToolStripMenuItem.Name = "бинаризацияПоГистограммеToolStripMenuItem";
            this.бинаризацияПоГистограммеToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.бинаризацияПоГистограммеToolStripMenuItem.Text = "Бинаризация по гистограмме";
            this.бинаризацияПоГистограммеToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияПоГистограммеToolStripMenuItem_Click);
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
            this.saltAndPepperToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saltAndPepperToolStripMenuItem.Text = "Salt and pepper";
            this.saltAndPepperToolStripMenuItem.Click += new System.EventHandler(this.saltAndPepperToolStripMenuItem_Click);
            // 
            // rayleighNoiseToolStripMenuItem
            // 
            this.rayleighNoiseToolStripMenuItem.Name = "rayleighNoiseToolStripMenuItem";
            this.rayleighNoiseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rayleighNoiseToolStripMenuItem.Text = "Rayleigh noise";
            this.rayleighNoiseToolStripMenuItem.Click += new System.EventHandler(this.rayleighNoiseToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // устранениеШумаToolStripMenuItem
            // 
            this.устранениеШумаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медианныйToolStripMenuItem});
            this.устранениеШумаToolStripMenuItem.Name = "устранениеШумаToolStripMenuItem";
            this.устранениеШумаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.устранениеШумаToolStripMenuItem.Text = "Устранение шума";
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem полутонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private ToolStripMenuItem бинаризацияПоМетодуНиблэкаToolStripMenuItem;
        private ToolStripMenuItem глобальныеToolStripMenuItem;
        private ToolStripMenuItem бинаризацияПоГистограммеToolStripMenuItem;
        private ToolStripMenuItem зашумлениеToolStripMenuItem;
        private ToolStripMenuItem saltAndPepperToolStripMenuItem;
        private ToolStripMenuItem rayleighNoiseToolStripMenuItem;
        private ToolStripMenuItem устранениеШумаToolStripMenuItem;
        private ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
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
        private float[] computeProb()
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
        private byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
        private void rayleighNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int size = image.Width * image.Height;
                float[] rayleigh = computeProb();
                var noise = ComputeNoise(rayleigh, size);
                var resultImage = new Bitmap(image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color color = image.GetPixel(x, y);
                        var newValue = Clamp(GetBrightness(color) +
                            noise[image.Width * y + x], 0, 255);

                        resultImage.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));

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
        private void бинаризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int threshold = 128;
                int w = image.Width, h = image.Height;
                Bitmap resultImage = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        Color sourceColor = image.GetPixel(i, j);
                        Color resultColor = binarization(sourceColor, threshold);
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
        private void бинаризацияПоМетодуНиблэкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int w_size = 3;                
                int w = image.Width, h = image.Height;

                Bitmap resultImage = new Bitmap(w, h);
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        int radiusX = w_size / 2;
                        int radiusY = w_size / 2;

                        double average_color = 0;
                        for (int l = -radiusY; l <= radiusY; l++) // вычисление мю
                        {
                            for (int k = -radiusX; k <= radiusX; k++)
                            {
                                int idX = Clamp(i + k, 0, image.Width - 1);
                                int idY = Clamp(j + l, 0, image.Height - 1);
                                Color neighborColor = image.GetPixel(idX, idY);
                                average_color += neighborColor.R;                                
                            }
                        }
                        average_color = average_color / (w_size * w_size);

                        double sigma = 0;
                        for (int l = -radiusY; l <= radiusY; l++) // вычисление сигмы
                        {
                            for (int k = -radiusX; k <= radiusX; k++)
                            {
                                int idX = Clamp(i + k, 0, image.Width - 1);
                                int idY = Clamp(j + l, 0, image.Height - 1);
                                Color neighborColor = image.GetPixel(idX, idY);
                                sigma += (neighborColor.R - average_color) * (neighborColor.R - average_color);
                            }
                        }
                        sigma = Math.Sqrt(sigma / (w_size * w_size));

                        double coef_k = -0.2;
                        int threshold = (int)(average_color + coef_k * sigma);

                        Color sourceColor = image.GetPixel(i, j);
                        Color resultColor = binarization(sourceColor, threshold);
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
        private int[] makeGistogram(Bitmap image)
        {
            int color_num = 256;
            int[] gist = new int[color_num];
            for(int i=0; i < color_num; ++i)
            {
                gist[i] = 0;
            }
            int w = image.Width, h = image.Height;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color sourceColor = image.GetPixel(i, j);
                    ++gist[sourceColor.R];
                }
            }
            return gist;
        }
        private void бинаризацияПоГистограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                int[] gist = makeGistogram(image);
                int sum = image.Width * image.Height;
                int color_num = 256;
                
                float five_per = sum / 100f * 5f;
                float value = five_per;
                for (int index = 0; value > 0; ++index)
                {
                    value -= gist[index];
                    if(value >= 0)
                    {
                        gist[index] = 0;
                    }
                    else 
                    {
                        gist[index] = (int)(-value);
                    }
                }                

                value = five_per;
                for (int index = color_num - 1; value > 0; --index)
                {
                    value -= gist[index];
                    if (value >= 0)
                    {
                        gist[index] = 0;
                    }
                    else
                    {
                        gist[index] = (int)(-value);
                    }
                }

                int h = 0;
                for(int i=0; i<color_num; ++i)
                {
                    h += gist[i];
                }

                int threshold = 0;
                for (int i = 0; i < color_num; ++i)
                {
                    threshold += gist[i] * i;
                }
                threshold /= h;

                int width = image.Width, height = image.Height;
                Bitmap resultImage = new Bitmap(width, height);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Color sourceColor = image.GetPixel(i, j);
                        Color resultColor = binarization(sourceColor, threshold);
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
        private Color binarization(Color sourceColor, int threshold)
        {
            int val;
            if (sourceColor.R < threshold)
            {
                val = 0;
            }
            else
            {
                val = 255;
            }
            return Color.FromArgb(val, val, val);
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
        private int[] calculateCoefficient(Bitmap sourceImage)
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
