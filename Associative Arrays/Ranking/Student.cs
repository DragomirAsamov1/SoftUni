using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking {
    internal class Student {
        public string Name { get; set; }
        public Dictionary<string, int> ContestsWithPoints { get; }

        public Student(string name) {
            Name = name;
            ContestsWithPoints = new Dictionary<string, int>();
        }

    }
}
