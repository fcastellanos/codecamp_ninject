using Ninject.Core;

namespace CodeCamp.Ninject.Logger
{
    public class CustomModule : StandardModule
    {
        public override void Load()
        {
            Bind<ILogIt>().To<LogItText>().ForMembersOf<TextLogService>();
            Bind<ILogReader>().To<LogReaderText>().ForMembersOf<TextLogService>();

            Bind<ILogIt>().To<LogItXml>().ForMembersOf<XmlLogService>();
            Bind<ILogReader>().To<LogReaderXml>().ForMembersOf<XmlLogService>();
        }
    }
}