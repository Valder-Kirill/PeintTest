using NUnit.Framework;
using PaintProject.Logs;
using PaintProject.Logs.LogHelper;
using PaintProject.PageObjects;
using TechTalk.SpecFlow;

namespace PaintProject.Steps
{
    [Binding]
    public class PaintSteps
    {
        [When(@"Click on Select advanced")]
        public void WhenClickOnSelectAdvanced()
        {
            Logger.Write("Нажимаю на 'Выделить (расширенный)' в Paint");
            PaintPageObject.ClickSelectAdvanced();
        }

        [When(@"Upload image '(.*)'")]
        public void WhenUploadImage(string picName)
        {
            Logger.Write("Загружаю картинку в Paint");
            PaintPageObject.UploadImg(picName);
        }

        [When(@"Choose Select All")]
        public void WhenChooseSelectAll()
        {
            Logger.Write("Нажимаю 'выделить всё' в Paint");
            PaintPageObject.ClickSelectAll();
        }

        [When(@"Click Cut")]
        public void WhenClockCut()
        {
            Logger.Write("Нажимаю 'вырезать' в Paint");
            PaintPageObject.ClickCut();
        }

        [When(@"Close Paint")]
        public void WhenClosePaint()
        {
            Logger.Write("Закрываю Paint");
            PaintPageObject.ClosePaint();
        }

        [Then(@"A dialog appeared with a suggestion to save the results")]
        public void ThenADialogAppearedWithASuggestionToSaveTheResults()
        {
            Logger.Write("Проверяю открытие диалогового окна по закритию Paint");
            Assert.IsTrue(PaintPageObject.DialogWindowIsOpened(), "Dialog window not opened");
        }

        [When(@"Reject result")]
        public void WhenRejectResult()
        {
            Logger.Write("Отменяю сохранение картинки при закрытии Paint");
            PaintPageObject.RejectResultDialogWindow();
        }
    }
}
