using System.Drawing;

namespace PaintProject.Utils
{
    public static class ComparisonUtils
    {
        public static bool ComparisonImages(Image expectedImg, Image actualImg)
        {
            string img1_ref, img2_ref;
            Bitmap img1 = new Bitmap(expectedImg);
            Bitmap img2 = new Bitmap(actualImg);
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
