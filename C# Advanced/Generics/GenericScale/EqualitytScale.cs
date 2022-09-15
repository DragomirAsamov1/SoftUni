using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale {
    public class EqualitytScale<T> {
        private T first;
        private T second;
        public EqualitytScale(T first, T second) {
            this.first = first;
            this.second = second;
        }

        public bool AreEqual() {
            return first.Equals(second);
        }
    }
}
