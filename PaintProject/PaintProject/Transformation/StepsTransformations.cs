using NUnit.Framework;
using PaintProject.Utils;
using System.Collections.Generic;
using System.Drawing;
using TechTalk.SpecFlow;

namespace PaintProject.Transformation
{
    [Binding]
    public class StepsTransformations
    {
        [StepArgumentTransformation]
        public string GetPaintDriverName(string itemInStock)
        {
            if (itemInStock == "@GetPaintDriverName()")
                return GetTestData.Get("TestValues", "PaintName");
            else
                return itemInStock;
        }

        [StepArgumentTransformation]
        public string GetPathImg(string itemInStock)
        {
            if (itemInStock == "@GetPathImg()")
                return GetTestData.Get("TestValues", "PathImg");
            else
                return itemInStock;
        }

        [StepArgumentTransformation]
        public List<Image> GetOriginalAndStorePicture(string itemInStock)
        {
            if (itemInStock == "@GetOriginalAndStorePicture()")
            {
                List<Image> images = new List<Image>();
                images.Add(StoreUtils.GetStoreImage());
                images.Add(Image.FromFile(TestContext.CurrentContext.TestDirectory + GetTestData.Get("TestValues", "PathImg")));
                return images;
            }
            else
                return null;
        }
    }
}
