using P03._Database_Before;
using System.Collections.Generic;

namespace P03._Database
{
    public class CoursesProperty
    {
        public ICourseData Data { get; set; }
        public void PrintAll() {
            var courses = Data.CourseNames();
            //print courses
        }

        public void PrintIds() {
            var courseIds = Data.CourseIds();
            //print course ids
        }

        public void PrintById(int id) {
            var course = Data.GetCourseById(id);
            //print course
        }

        public void Search(ICourseData data, string substring) {
            var courses = Data.Search(substring);
            //print courses
        }
    }
}