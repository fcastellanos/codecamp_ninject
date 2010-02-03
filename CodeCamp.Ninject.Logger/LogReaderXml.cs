using System;
using System.Linq;
using System.Xml.Linq;

namespace CodeCamp.Ninject.Logger
{
    public class LogReaderXml : ILogReader
    {
        public void ReadLog()
        {
            Console.WriteLine(" XML Log Reader ");

            var logs = from c in XElement.Load("appLog.xml").Elements("log") select c;

            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}