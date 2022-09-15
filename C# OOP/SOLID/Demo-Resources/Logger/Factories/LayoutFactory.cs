namespace Logger.Factories {

    using System;
    using Layouts;

    public class LayoutFactory {
        public static ILayout CreateLayout(string type) {
            switch (type) {
                case "SimpleLayout":
                    return new SimpleLayout();
                case "XmlLayout":
                    return new XmlLayout();
                default:
                    throw new InvalidOperationException("Missing type!");
            };
        }
    }
}
