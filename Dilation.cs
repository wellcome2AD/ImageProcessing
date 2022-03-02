using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Dilation //: Filters
    {
        bool[,] mask;
        void createMask()
        {
            mask = new bool[,] { { false, true, false }, { true, true, true }, { false, true, false } };
        }
        public Dilation(Bitmap source)
        {
            createMask();
        }

        public Bitmap Execute(Bitmap source)
        {
            // Width, Height – размеры исходного и результирующего изображений
            // MW, MH – размеры структурного множества
            int Width = source.Width;
            int Height = source.Height;
            int MW = 3, MH = 3;
            Bitmap result = new Bitmap(Width, Height);
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Color max = Color.Black;
                    for (int j = -MH / 2; j <= MH / 2; j++)
                    {
                        for (int i = -MW / 2; i <= MW / 2; i++)
                        {
                            if (x + i < 0 || x + i >= Width || y + j < 0 || y + j >= Height)
                                continue;
                            if (mask[i + MW / 2, j + MH / 2] && greater(source.GetPixel(x + i, y + j), max))
                            {
                                max = source.GetPixel(x + i, y + j);
                            }
                        }
                    }
                    result.SetPixel(x, y, max);
                }
            }
            return result;
        }
        public static bool greater(Color c1, Color c2)
        {
            return c1.ToArgb() > c2.ToArgb();
        }
        
        /*public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Bitmap resultImage = new Bitmap(w, h);
            for (int i = 0; i < h; i++)
            {
                worker.ReportProgress((int)((float)i / w * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < w; j++)
                {
                    resultImage.SetPixel(j, i, calculateNewPixelColor(sourceImage, j, i));
                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int Width = sourceImage.Width, Height = sourceImage.Height;
            int size = 3;
            Color max = Color.Black;
            for (int j = -size / 2; j <= size / 2; j++) {
                for (int i = -size / 2; i <= size / 2; i++)
                {
                    if (x + i < 0 || x + i >= Width || y + j < 0 || y + j >= Height)
                        continue;
                    if (mask[i + size / 2, j + size / 2] && greater(sourceImage.GetPixel(x + i, y + j), max))
                    {
                        max = sourceImage.GetPixel(x + i, y + j);
                    }
                }
            }
            return max;
        }*/
    }
}
