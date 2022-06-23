using NUnit.Framework;
using PaintProject.Logs.LogHelper;
using PaintProject.Utils;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace PaintProject.Hooks
{
    [Binding]
    public class BeforeScenarioHook
    {
        [BeforeScenario]
        public void StartWinAppDriver()
        {
            Logger.Write("Запускаю WinAppDriver");
            if (Process.GetProcessesByName(TestContext.CurrentContext.TestDirectory + GetTestData.Get("TestValues", "PathWinDriver")).Length == 0)
                Process.Start(TestContext.CurrentContext.TestDirectory + GetTestData.Get("TestValues", "PathWinDriver"));
        }
    }
}
