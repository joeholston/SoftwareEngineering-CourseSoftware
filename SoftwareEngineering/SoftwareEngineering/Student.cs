using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Student
    {
        private List<Course> studentCourses { get; set; }
        public void addCourse(Course selectedCourse)
        {
            studentCourses.Add(selectedCourse); //Add the selected Course to the end of the list
        }
        public void deleteCourse(Course deselectedCourse)
        {
            studentCourses.Remove(deselectedCourse); //There should not be multiple of the same Course objects, so deleting all instances of the deselected course is fine.
        }
    }
}