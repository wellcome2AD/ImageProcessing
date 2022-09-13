﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Average : MatrixFilter
    {
        public Average()
        {
            int size = 3;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = 1f / (size * size);
                }
            }
        }
    }
}
