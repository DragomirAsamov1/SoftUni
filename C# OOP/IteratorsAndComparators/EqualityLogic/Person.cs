using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic {
    public class Person : IComparable<Person> {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public override int GetHashCode() {
            int nameHash = Name.GetHashCode();
            int ageHash = Age.GetHashCode();

            return nameHash + ageHash;
        }

        public override bool Equals(object obj) {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public int CompareTo(Person other) {
            if (this.Name.CompareTo(other.Name) != 0) {
                return Name.CompareTo(other.Name);
            }

            if (Age.CompareTo(other.Age) != 0) {
                return Age.CompareTo(other.Age);
            }

            return 0;

        }
    }
}
