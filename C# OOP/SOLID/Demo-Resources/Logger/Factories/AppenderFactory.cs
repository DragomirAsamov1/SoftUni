namespace Logger.Factories {

    using System;
    using Appenders;
    using global::Appenders;
    using Layouts;
    using LogFiles;
    using ReportLevels;

    public class AppenderFactory {
        public static IAppender CreateAppender(
            string type,
            ILayout layout,
            ReportLevel reportLevel = ReportLevel.Info) {
            IAppender appender = type switch {
                "ConsoleAppender" => new ConsoleAppender(layout),
                "FileAppender" => new FileAppender(layout, new LogFile()),
                _ => throw new InvalidOperationException("Missing type")
            };

            appender.ReportLevel = reportLevel;

            return appender;
        }
    }
}
