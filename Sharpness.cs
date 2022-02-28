using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Sharpness : MatrixFilter
    {
        public Sharpness()
        {
            int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = kernel[0, 2] = kernel[2, 0] = kernel[2, 2] = .0f;
            kernel[0, 1] = kernel[1, 0] = kernel[1, 2] = kernel[2, 1] = -1.0f;
            kernel[1, 1] = 5.0f;
        }
    }
}
