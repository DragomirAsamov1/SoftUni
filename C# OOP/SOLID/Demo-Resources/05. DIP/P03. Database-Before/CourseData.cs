using System;
using System.Collections.Generic;
using System.Text;

namespace P03._Database_Before {
    public class CourseData : ICourseData {
        public IEnumerable<int> CourseIds() {
            //return course ids
            return null;
        }

        public IEnumerable<string> CourseNames() {
            //return course names
            return null;
        }

        public string GetCourseById(int id) {
            //return course
            return null; 
        }

        public IEnumerable<string> Search(string substring) {
            //return courses
            return null;
        }
    }
}
