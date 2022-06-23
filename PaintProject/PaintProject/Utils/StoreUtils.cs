using System.Drawing;

namespace PaintProject.Utils
{
    public static class StoreUtils
    {
        private static Image image = Image.FromFile(WindowsUtils.GetPathImg(GetTestData.Get("TestValues", "PathImg")));
        public static Image GetStoreImage()
        {
            return image;
        }
    }
}
