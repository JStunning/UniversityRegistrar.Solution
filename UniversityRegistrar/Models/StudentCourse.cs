using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace UniversityRegistrar.Models
{
  public class CategoryCourse
    {       
        public int CategoryCourseId { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public Course Course { get; set; }
        public Category Category { get; set; }
    }
}