﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge {
    internal class Person {

        public Person(string name, string id, int age) {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString() {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
