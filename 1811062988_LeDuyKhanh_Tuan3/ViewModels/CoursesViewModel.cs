using _1811062988_LeDuyKhanh_Tuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811062988_LeDuyKhanh_Tuan3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}