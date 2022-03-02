using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Autolevels : Filters
    {
        int Rmin = 255, Rmax = 0, Gmin = 255, Gmax = 0, Bmin = 255, Bmax = 0;
        public Autolevels(Bitmap sourceImage) 
        {
            calculateCoefficient(sourceImage);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color col = sourceImage.GetPixel(x, y);
            Color resCol = Color.FromArgb(Clamp((int)((col.R - Rmin) * 255 / (Rmax - Rmin)), 0, 255),
                                          Clamp((int)((col.G - Gmin) * 255 / (Gmax - Gmin)), 0, 255),
                                          Clamp((int)((col.B - Bmin) * 255 / (Bmax - Bmin)), 0, 255));
            return resCol;
        }
        void calculateCoefficient(Bitmap sourceImage) 
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Color col;
            for (int i = 0; i < w; i++)
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
    }
}
