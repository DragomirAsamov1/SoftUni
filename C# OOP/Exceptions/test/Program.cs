using System;
using System.Collections.Generic;
using System.Linq;

namespace test {
    public class Program {
        static void Main(string[] args) {
            Sample sample = new Sample();

        }
    }

    class Sample {
        static int i;
        int j;
        public void proc1() {
            i = 11;
            j = 12;
        }
        public static void proc2() {
            i = 1;
            j = 2;
        }
        static Sample() {
            i = 0;
            j = 0;
        }
    }
}
