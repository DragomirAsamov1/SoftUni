namespace Logger.Appenders {

    using System;
    using Layouts;
    using ReportLevels;

    public abstract class Appender : IAppender {
        public Appender(ILayout layout) {
           Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public int AppendedMessages { get; protected set; }

        public abstract void Append(DateTime dateTime, ReportLevel reportLevel, string message);
        public override string ToString() => $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, ReportLevel: {ReportLevel.GetType().Name}, Messages appended: {AppendedMessages}";
    }
}
