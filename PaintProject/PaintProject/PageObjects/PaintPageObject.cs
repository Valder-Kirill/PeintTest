using NUnit.Framework;
using PaintProject.Drivers;
using System.Linq;

namespace PaintProject.PageObjects
{
    public static class PaintPageObject
    {
        private static string mainMenuBtnLoc  = "Меню приложения";
        private static string openFileBtnLoc = "Открыть";
        private static string selectBtnLoc = "Выделить";
        private static string selectAllBtnLoc = "Выделить все";
        private static string cutBtnLoc = "Вырезать";
        private static string dontSaveBtnLoc = "Не сохранять";

        public static void UploadImg(string src)
        {
            PaintDriver.GetDriver().FindElementByName(mainMenuBtnLoc).Click();
            PaintDriver.GetDriver().FindElementByName(openFileBtnLoc).SendKeys(TestContext.CurrentContext.TestDirectory + src);
        }

        public static void ClickSelectAdvanced()
        {
            PaintDriver.GetDriver().FindElementsByName(selectBtnLoc).AsQueryable().Last().Click();
        }

        public static void ClickSelectAll()
        {
            PaintDriver.GetDriver().FindElementByName(selectAllBtnLoc).Click();
        }

        public static void ClickCut()
        {
            PaintDriver.GetDriver().FindElementByName(cutBtnLoc).Click();
        }

        public static void ClosePaint()
        {
            PaintDriver.GetDriver().CloseApp();
        }

        public static bool DialogWindowIsOpened()
        {
            return PaintDriver.GetDriver().FindElementByName(dontSaveBtnLoc).Displayed;
        }

        public static void RejectResultDialogWindow()
        {
            PaintDriver.GetDriver().FindElementByName(dontSaveBtnLoc).Click();
        }
    }
}
