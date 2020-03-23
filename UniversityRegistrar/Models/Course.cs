using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace UniversityRegistrar.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<StudentCourse>();
        }
        public int CourseId {get; set;}
        public string CourseName {get; set;}
        public string CourseNumber {get; set;}
        public  ICollection<StudentCourse> Students { get; }
    }
}