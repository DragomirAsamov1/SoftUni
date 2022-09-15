namespace Logger.Loggers {

    using System;
    using Appenders;
    using ReportLevels;
    public class Logger : ILogger {
        public Logger(params IAppender[] appenders) {
            Appenders = appenders;
        }

        public IAppender[] Appenders { get; set; }

        public void Error(string message) {
            Log(ReportLevel.Error, message);
        }

        public void Info(string message) {
            Log(ReportLevel.Info, message);
        }
        public void Critical(string message) {
            Log(ReportLevel.Critical, message);
        }
        public void Fatal(string message) {
            Log(ReportLevel.Fatal, message);
        }

        public void Warning(string message) {
            Log(ReportLevel.Warning, message);
        }

        private void Log(ReportLevel reportLevel, string message) {
            foreach (var appender in Appenders) {
                if (reportLevel >= appender.ReportLevel) {
                    appender.Append(DateTime.Now, reportLevel, message);
                }
            }
        }
    }
}
