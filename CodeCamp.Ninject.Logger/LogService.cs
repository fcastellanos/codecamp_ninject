using System;

namespace CodeCamp.Ninject.Logger
{
    public abstract class LogService
    {
        private readonly ILogIt logIt;
        private readonly ILogReader logReader;

        public LogService(ILogIt logIt, ILogReader logReader)
        {
            this.logIt = logIt;
            this.logReader = logReader;
        }

        public void LogIt(DateTime exceptionDate, string exceptionSource, string exceptionMessage)
        {
            logIt.LogIt(exceptionDate, exceptionSource, exceptionMessage);
            logReader.ReadLog();
        }
    }

    public class XmlLogService : LogService
    {
        public XmlLogService(ILogIt logIt, ILogReader logReader) : base(logIt, logReader)
        {
        }
    }

    public class TextLogService : LogService
    {
        public TextLogService(ILogIt logIt, ILogReader logReader) : base(logIt, logReader)
        {
        }
    }
}
