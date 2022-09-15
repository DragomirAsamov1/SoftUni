namespace Appenders {

    using System;
    using Logger.Appenders;
    using Logger.Layouts;
    using Logger.ReportLevels;

    public class ConsoleAppender : Appender {
        public ConsoleAppender(ILayout layout) : base(layout) {
        }

        public override void Append(DateTime dateTime, ReportLevel reportLevel, string message) {
            string output = string.Format(
                Layout.Format,
                dateTime,
                reportLevel,
                message);

            AppendedMessages++;

            Console.WriteLine(output);
        }
    }
}
