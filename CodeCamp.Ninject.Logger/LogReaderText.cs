using System;
using System.IO;

namespace CodeCamp.Ninject.Logger
{
    public class LogReaderText : ILogReader
    {
        public void ReadLog()
        {
            Console.WriteLine(" Text Log Reader ");

            using (var sr = new StreamReader("appLog.txt"))
            {
                string line;
                int count = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine(string.Format("{0}.- {1}", count, line));
                }
            }
        }
    }
}