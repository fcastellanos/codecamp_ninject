using System;
using System.IO;

namespace CodeCamp.Ninject.Logger
{
    public class LogItText : ILogIt
    {
        public void LogIt(DateTime exceptionDate, string exceptionSource, string exceptionMessage)
        {
            Console.WriteLine(" Text Logger ");
            using (var sw = new StreamWriter("appLog.txt", true))
            {
                sw.WriteLine(string.Format("{0};{1};{2}", exceptionDate, exceptionSource, exceptionMessage));
            }
        }
    }
}