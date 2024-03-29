﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses {
    public class Family {
        public Family() {
            People = new List<Person>();
        }
        public List<Person> People {get; set;}

        public void AddMember(Person member) {
            People.Add(member);
        }

        public Person GetOldestMember() {
            return People.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public List<Person> GetPeopleAbove() {
            return People.Where(x => x.Age > 30).ToList();
        }
    }
}
