using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Erosion : Filters
    {
        bool[,] mask;
        void createMask()
        {
            mask = new bool[,] { { false, true, false }, { true, true, true }, { false, true, false } };
        }
        public Erosion(Bitmap source)
        {
            createMask();
        }

        public static bool greater(Color c1, Color c2)
        {
            return c1.ToArgb() > c2.ToArgb();
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Bitmap resultImage = new Bitmap(w, h);
            int size = 3;
            for (int i = size / 2; i < (w - size / 2); i++)
            {
                worker.ReportProgress((int)((float)i / w * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = size / 2; j < (h - size / 2); j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int size = 3;
            Color max = Color.Black;
            for (int j = -size / 2; j <= size / 2; j++)
                for (int i = -size / 2; i <= size / 2; i++)
                    if (mask[i + size / 2, j + size / 2] && greater(sourceImage.GetPixel(x + i, y + j), max))
                    {
                        max = sourceImage.GetPixel(x + i, y + j);
                    }
            return max;
        }
    }
}
