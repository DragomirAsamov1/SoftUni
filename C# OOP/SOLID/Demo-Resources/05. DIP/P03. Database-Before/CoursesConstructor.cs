﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03._Database_Before {
    public class CoursesConstructor {
        private readonly ICourseData data;

        public CoursesConstructor() :this (new CourseData()) {

        }

        public CoursesConstructor(ICourseData data) {
            this.data = data;
        }

        public void PrintAll() {
            var courses = data.CourseNames();
            //print courses
        }

        public void PrintIds() {
            var courseIds = data.CourseIds();
            //print course ids
        }

        public void PrintById(int id) {
            var course = data.GetCourseById(id);
            //print course
        }

        public void Search(ICourseData data, string substring) {
            var courses = data.Search(substring);
            //print courses
        }
    }
}
