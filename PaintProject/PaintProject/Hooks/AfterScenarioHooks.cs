using PaintProject.Logs.LogHelper;
using PaintProject.Utils;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace PaintProject.Hooks
{
    [Binding]
    public class AfterScenarioHooks
    {
        [AfterScenario]
        public void CloseWinAppDriver()
        {
            Logger.Write("Закрываю WinAppDriver");
            foreach (Process proc in Process.GetProcessesByName(GetTestData.Get("TestValues", "WinDriverName")))
            {
                proc.Kill();
            };
        }
    }
}
