using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    class Emboss : MatrixFilter
    {
        public Emboss()
        {
            int sizeX = 3, sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[1, 2] = kernel[0,1] = 1.0f;
            kernel[1, 0] = kernel[2, 1] = -1.0f;
        }

        protected override Bitmap postProcessing(Bitmap sourceImage, BackgroundWorker worker)
        {
            Filters filter = new IncreaseBrightance(100);
            Bitmap resultImage = filter.processImage(sourceImage, worker);
            filter = new GrayScaleFilter();
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
}
