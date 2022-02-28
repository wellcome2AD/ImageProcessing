using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class IncreaseBrightance : Filters
    {
        int coef;
        public IncreaseBrightance(int _coef = 20)
        {
            coef = _coef;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            Color resultColor = Color.FromArgb(Clamp((sourceColor.R + coef), 0, 255),
                                  Clamp((sourceColor.G + coef), 0, 255),
                                  Clamp((sourceColor.B + coef), 0, 255));
            return resultColor;
        }
    }
}
