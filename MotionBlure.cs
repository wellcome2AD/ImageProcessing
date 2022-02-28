using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class MotionBlure : MatrixFilter
    {
        public MotionBlure()
        {
            int sizeX = 9, sizeY = 9;
            kernel = new float[sizeX, sizeY];

            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    if (i == j)
                        kernel[i, j] = 1.0f / sizeX;
                    else
                        kernel[i, j] = 0.0f;
                }
        }
    }
}
