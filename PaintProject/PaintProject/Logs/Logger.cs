namespace PaintProject.Logs
{
    using System;
    using System.IO;
    using System.Text;

    namespace LogHelper
    {
        public static class Logger
        {
            private static object sync = new object();
            public static void Write(string message)
            {
                string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                if (!Directory.Exists(pathToLog))
                    Directory.CreateDirectory(pathToLog); 
                string filename = Path.Combine(pathToLog, string.Format("{0}_{1:dd.MM.yyy}.log",
                AppDomain.CurrentDomain.FriendlyName, DateTime.Now));
                string fullText = string.Format("[{0:dd.MM.yyy HH:mm:ss.fff}] {1}\r\n",
                DateTime.Now, message);
                lock (sync)
                {
                    File.AppendAllText(filename, fullText, Encoding.GetEncoding("UTF-8"));
                }
            }
        }
    }
}
