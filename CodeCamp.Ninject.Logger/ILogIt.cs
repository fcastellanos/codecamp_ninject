using System;

namespace CodeCamp.Ninject.Logger
{
    public interface ILogIt
    {
        void LogIt(DateTime exceptionDate, string exceptionSource, string exceptionMessage);
    }
}