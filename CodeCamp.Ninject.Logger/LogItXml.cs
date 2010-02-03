using System;
using System.IO;
using System.Xml;

namespace CodeCamp.Ninject.Logger
{
    public class LogItXml : ILogIt
    {
        public void LogIt(DateTime exceptionDate, string exceptionSource, string exceptionMessage)
        {
            Console.WriteLine(" XML Logger ");

            try
            {
                const string fileName = "appLog.xml";
                var xmlDocument = new XmlDocument();

                try
                {
                    xmlDocument.Load(fileName);
                }
                catch (FileNotFoundException)
                {
                    var xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };
                    xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                    xmlWriter.WriteStartElement("Logs");
                    xmlWriter.Close();
                    xmlDocument.Load(fileName);
                }

                XmlNode logRoot = xmlDocument.DocumentElement;
                XmlElement logElement = xmlDocument.CreateElement("log");
                XmlElement dateElement = xmlDocument.CreateElement("exceptionDate");
                XmlElement sourceElement = xmlDocument.CreateElement("exceptionSource");
                XmlElement messageElement = xmlDocument.CreateElement("exceptionMessage");

                XmlText dateText = xmlDocument.CreateTextNode("date");
                dateText.Value = exceptionDate.ToString();
                XmlText sourceText = xmlDocument.CreateTextNode("source");
                sourceText.Value = exceptionSource;
                XmlText messageText = xmlDocument.CreateTextNode("message");
                messageText.Value = exceptionMessage;

                logRoot.AppendChild(logElement);

                dateElement.AppendChild(dateText);
                sourceElement.AppendChild(sourceText);
                messageElement.AppendChild(messageText);

                logElement.AppendChild(dateElement);
                logElement.AppendChild(sourceElement);
                logElement.AppendChild(messageElement);

                xmlDocument.Save(fileName);
            }
            catch (Exception)
            {
                Console.WriteLine(" Ya mejor lo escribo en pantalla ");
            }
        }
    }
}