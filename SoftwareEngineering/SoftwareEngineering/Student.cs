using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Student
    {
        public List<Course> studentCompletedCourses { get; set; }
        public List<Course> studentCourses { get; set; }
        public void addCourse(Course selectedCourse, bool completed)
        {
            if (selectedCourse != null)
            {
                if (studentCourses==null)
                {
                    studentCourses = new List<Course>();
                    studentCompletedCourses = new List<Course>();
                }
                if (completed) { studentCompletedCourses.Add(selectedCourse); }
                else{studentCourses.Add(selectedCourse);} //Add the selected Course to the end of the list
            }
        }
        public void deleteCourse(Course deselectedCourse, bool completed)
        {
            if (deselectedCourse != null)
            {
                if (completed) { studentCompletedCourses.Remove(deselectedCourse); }
                else { studentCourses.Remove(deselectedCourse); } //There should not be multiple of the same Course objects, so deleting all instances of the deselected course is fine
            }
        }
        static public Course findCourse(string courseCode)
        {
            List<Course> courseList = BuildDB.Instance.courseDatabase;
            foreach (Course classSection in courseList)
            {
                if (courseCode==classSection.courseCode)
                {
                    return classSection;
                }
            }
            return null;
        }
    }
}