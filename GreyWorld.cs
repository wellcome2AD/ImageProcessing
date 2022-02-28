using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class GreyWorld : Filters
    {
        int countPixel;
        float avR = 0, avG = 0, avB = 0; //average RGB
        float Avg;
        public GreyWorld(Bitmap sourceImage)
        {
            calculateCoefficient(sourceImage);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color col = sourceImage.GetPixel(x, y);
            Color resCol = Color.FromArgb(Clamp((int)(col.R * Avg / avR), 0, 255),
                                          Clamp((int)(col.G * Avg / avG), 0, 255),
                                          Clamp((int)(col.B * Avg / avB), 0, 255));
            return resCol;
        }

        private void calculateCoefficient(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            countPixel = w * h;
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
    }
}
