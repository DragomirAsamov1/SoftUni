using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Layouts {
    public abstract class Layout : ILayout {
        protected Layout(string format) {
            Format = format;
        }

        public string Format { get; }
    }
}
