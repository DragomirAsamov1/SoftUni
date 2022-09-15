using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString {
    public class Box<T> {
        public Box(T value) {
            Value = value;
        }
        public T Value { get; private set; }

        public override string ToString() {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
