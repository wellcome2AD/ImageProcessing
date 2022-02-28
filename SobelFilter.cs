using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    class SobelFilter : MatrixFilter
    {
        int _key;
        public SobelFilter(int key)
        {
            _key = key;
            int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY];
            if (key == 1)
            {
                /* по Ох */
                for (int i = 0; i < sizeX; i++)
                    for (int j = -1; j <= 1; j++)
                        kernel[j + 1, i] = j;
                kernel[0, 1]--;
                kernel[2, 1]++;
            }
            else
            {
                //по Oy
                for (int i = 0; i < sizeX; i++)
                    for (int j = -1; j <= 1; j++)
                        kernel[i, j + 1] = j;
                kernel[1, 0]--;
                kernel[1, 2]++;
            }            
        }

        protected override Bitmap postProcessing(Bitmap sourceImage, BackgroundWorker worker)
        {
            if (_key == 0)
            {
                _key = 1;
                Filters filter = new SobelFilter(_key);
                sourceImage = filter.processImage(sourceImage, worker);
            }
            return sourceImage;
        }
    }
}
