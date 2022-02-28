using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ImageProcessing
{
    class Shift : Filters
    {
        int shift = 50;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int width = sourceImage.Width;
            if (x <= shift)
                return Color.Black;
            return sourceImage.GetPixel((x + width - shift) % width, y);
        }
    }
}
