using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Autocontrast : Filter
    {
        int countPixel;
        float max_b = 0, min_b = 255;
        public Autocontrast(Bitmap sourceImage)
        {
            calculateMaxMinBrightness(sourceImage);
        }
        private void calculateMaxMinBrightness(Bitmap sourceImage)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    col = sourceImage.GetPixel(i, j);
                    float brightness = calculateBrigthness(col);
                    if (brightness > max_b) 
                    { 
                        max_b = brightness; 
                    }
                    if (brightness < min_b)
                    {
                        min_b = brightness;
                    }
                }
            }
        }
        private static float calculateBrigthness(Color col)
        {
            return 0.299f * col.R + 0.587f * col.G + 0.114f * col.B;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            float brightness = calculateBrigthness(sourceColor);
            float new_brightness = (brightness - min_b) * (255f / (max_b - min_b));
            float coeff = new_brightness / brightness;
            Color resultColor = Color.FromArgb(Clamp((int)(coeff * sourceColor.R), 0, 255),
                                               Clamp((int)(coeff * sourceColor.G), 0, 255),
                                               Clamp((int)(coeff * sourceColor.B), 0, 255));
            return resultColor;
        }
    }
}
