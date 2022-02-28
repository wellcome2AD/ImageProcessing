using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filter
{
    public class TestFilter
    {
        static float[,] kernel = null;

        public static void CreateKernelOx()
        {
            int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = -1; j <= 1; j++)
                    kernel[i, j + 1] = j;
            kernel[1, 0]--;
            kernel[1, 2]++;
        }
        public static void CreateKernelOy()
        {
            int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = -1; j <= 1; j++)
                    kernel[j + 1, i] = j;
            kernel[0, 1]--;
            kernel[2, 1]++;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static Bitmap Execute(Bitmap source)
        {
            CreateKernelOx();
            Bitmap imOx = ProcessImage(source);
            CreateKernelOy();
            Bitmap imOy = ProcessImage(source);
            int w = source.Width, h = source.Height;
            Bitmap resIm = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    Color color1 = imOx.GetPixel(i, j);
                    Color color2 = imOy.GetPixel(i, j);
                    int R1 = color1.R;
                    int G1 = color1.G;
                    int B1 = color1.B;

                    int R2 = color2.R;
                    int G2 = color2.G;
                    int B2 = color2.B;

                    int R3 = Clamp((int)Math.Sqrt(R1 * R1 + R2 * R2), 0, 255);
                    int G3 = Clamp((int)Math.Sqrt(G1 * G1 + G2 * G2), 0, 255);
                    int B3 = Clamp((int)Math.Sqrt(B1 * B1 + B2 * B2), 0, 255);

                    Color color3 = Color.FromArgb(R3, G3, B3);
                    resIm.SetPixel(i, j, color3);
                }

            return resIm;
        }

        public static Bitmap ProcessImage(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Bitmap resultImage = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
            }
            return resultImage;
        }

        protected static Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            double resultR = 0, resultG = 0, resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                  Clamp((int)resultB, 0, 255));
        }
    }
}

/*namespace Filter
{
    public class TestFilter
    {
        static float avR = 0, avG = 0, avB = 0; //average RGB
        static float Avg;

        private static void calculateCoefficient(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            int countPixel = w * h;
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    col = sourceImage.GetPixel(i, j);
                    avR += col.R;
                    avG += col.G;
                    avB += col.B;
                }
            avR /= countPixel;
            avG /= countPixel;
            avB /= countPixel;
            Avg = (avR + avG + avB) / 3;
        }

        public static Bitmap Execute(Bitmap sourceImage)
        {
            calculateCoefficient(sourceImage);
            int w = sourceImage.Width;
            int h = sourceImage.Height;
            Color sourceColor;
            Bitmap resultImage = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    sourceColor = sourceImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            return resultImage;
        }

        protected static Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color col = sourceImage.GetPixel(x, y);
            Color resCol = Color.FromArgb(Clamp((int)(col.R * Avg / avR), 0, 255),
                                          Clamp((int)(col.G * Avg / avG), 0, 255),
                                          Clamp((int)(col.B * Avg / avB), 0, 255));
            return resCol;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
}*/