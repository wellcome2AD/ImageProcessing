using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    abstract class Filter
    {
        public virtual Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            int w = sourceImage.Width, h = sourceImage.Height;
            Bitmap resultImage = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
            {
                worker.ReportProgress((int)((float)i / w * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < h; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }
            resultImage = postProcessing(resultImage, worker);
            return resultImage;
        }

        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);

        protected virtual Bitmap postProcessing(Bitmap sourceImage, BackgroundWorker worker) { return sourceImage; }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

    }
}
