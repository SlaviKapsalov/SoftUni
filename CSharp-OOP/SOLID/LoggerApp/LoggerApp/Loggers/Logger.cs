using LoggerApp.Appenders;
using LoggerApp.Common;

namespace LoggerApp.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Warning(string dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Warning, message);
        }

        public void Error(string dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Error, message);
        }

        public void Critical(string dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Critical, message);
        }

        public void Fatal(string dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Fatal, message);
        }

        public void Info(string dateTime, string message)
        {
           this.AppendError(dateTime, ReportLevel.Info, message);
        }

        private void AppendError(string dateTime, ReportLevel reportLevel, string message)
        {
            foreach (IAppender appender in this.appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }
    }
}
