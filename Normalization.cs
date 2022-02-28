using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    class Normalization : Filters
    {
        int countPixel;
        float avR = 0, avG = 0, avB = 0; //average RGB
        float Avg;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color col = sourceImage.GetPixel(x, y);
            Color resCol = Color.FromArgb(Clamp((col.R * (int)(Avg / avR)), 0, 255),
                                          Clamp((col.G * (int)(Avg / avG)), 0, 255),
                                          Clamp((col.B * (int)(Avg / avB)), 0, 255));
            return resCol;
        }

        private void calculateCoefficient(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            countPixel = w * h;
            for(int i=0; i<w; i++)
                for (int j = 0; j <h; j++)
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
    }
}
/*
        int miR = 0;
        int miG = 0;
        int miB = 0;
        int sigmaR = 0;
        int sigmaG = 0;
        int sigmaB = 0;
        private void calculateCoefficient(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            long sumR = 0; // ????????????
            long sumG = 0;
            long sumB = 0;
            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    sumR += sourceImage.GetPixel(i, j).R;
                    sumG += sourceImage.GetPixel(i, j).G;
                    sumB += sourceImage.GetPixel(i, j).B;
                }
            }
            miR = Clamp((int)(sumR / (w * h)), -128, 127);
            miG = Clamp((int)(sumG / (w * h)), -128, 127);
            miB = Clamp((int)(sumB / (w * h)), -128, 127);

            sumR = 0;
            sumG = 0;
            sumB = 0;

            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    Color color = sourceImage.GetPixel(i, j);
                    sumR += (long)Math.Pow((int)color.R - miR, 2);
                    sumG += (long)Math.Pow((int)color.G - miG, 2);
                    sumB += (long)Math.Pow((int)color.B - miB, 2);
                }
            }
            sumR /= w * h;
            sumG /= w * h;
            sumB /= w * h;

            sigmaR = (int)Math.Sqrt(sumR);
            sigmaG = (int)Math.Sqrt(sumG);
            sigmaB = (int)Math.Sqrt(sumB);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (miR == 0 && miG == 0 && miB == 0 && sigmaR == 0 && sigmaG == 0 && sigmaB == 0)
                calculateCoefficient(sourceImage);

            Color color = sourceImage.GetPixel(x, y);
            byte R = (byte)Clamp(((int)color.R - miR) / sigmaR, -128, 127);
            byte G = (byte)Clamp(((int)color.G - miG) / sigmaG, -128, 127);
            byte B = (byte)Clamp(((int)color.B - miB) / sigmaB, -128, 127);
            Color newColor = Color.FromArgb(R, G, B);

            return newColor;
        }
 */