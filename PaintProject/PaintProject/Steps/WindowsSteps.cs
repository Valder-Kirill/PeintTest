using NUnit.Framework;
using PaintProject.Drivers;
using PaintProject.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TechTalk.SpecFlow;
using PaintProject.Logs.LogHelper;

namespace PaintProject.Steps
{
    [Binding]
    public sealed class WindowsSteps
    {
        [Given(@"If there are open '(.*)' application instances, close them")]
        public void GivenIfThereAreOpenApplicationInstancesCloseThem(string procName)
        {
            Logger.Write($"Закрываю инстансы {procName}, если открыты");
            WindowsUtils.ProcessKill(procName);
        }

        [When(@"Open '(.*)' application")]
        public void WhenOpenApplication(string appName)
        {
            Logger.Write($"Запускаю приложение {appName}");
            PaintDriver.SetDriver(appName);
        }

        [Then(@"'(.*)' application is opened")]
        public void ThenApplicationIsOpened(string appName)
        {
            Logger.Write($"Проверяю запуск приложения {appName}");
            Assert.IsTrue(WindowsUtils.GetAppCount(appName) > 0, "App is not opened");
        }

        [Then(@"The pictures '(.*)' is not different")]
        public void ThenThePicturesIsNotDifferent(List<Image> imgs)
        {
            Logger.Write($"Сравниваю ожидаемое изображение и актуальное");
            Assert.IsTrue(ComparisonUtils.ComparisonImages(imgs.AsQueryable().First(), imgs.AsQueryable().Last()), "Images are not equal");
        }

    }
}
