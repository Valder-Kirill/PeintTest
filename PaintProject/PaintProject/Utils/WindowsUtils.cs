using NUnit.Framework;
using System.Diagnostics;

namespace PaintProject.Utils
{
    public static class WindowsUtils
    {
        public static void ProcessKill(string procName)
        {
            foreach (Process proc in Process.GetProcessesByName(procName))
            {
                proc.Kill();
            };
        }

        public static int GetAppCount(string appName)
        {
            return Process.GetProcessesByName(appName).Length;
        }

        public static string GetPathImg(string imgName)
        {
            return TestContext.CurrentContext.TestDirectory + imgName;
        }
    }
}
