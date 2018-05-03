using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Student
    {
        private static Student instance;
        public List<Course> studentCompletedCourses { get; set; }
        public List<Course> studentCourses { get; set; }

        private Student()
        {
            studentCourses = new List<Course>();
            studentCompletedCourses = new List<Course>();
        }

        public void addCourse(Course selectedCourse, bool completed)
        {
            if (selectedCourse != null)
            {
                if (studentCourses==null)
                {
                    studentCourses = new List<Course>();
                }
                if (studentCompletedCourses == null)
                {
                    studentCompletedCourses = new List<Course>();
                }
                if (completed) { studentCompletedCourses.Add(selectedCourse); }
                else{
                    if (!inSchedule(selectedCourse,false))
                    {
                        studentCourses.Add(selectedCourse);
                    }
                } //Add the selected Course to the end of the list
            }
        }


        public void deleteCourse(Course deselectedCourse, bool completed)//completed is true if adding to prereqs, is false if adding to stude
        {
            if (deselectedCourse != null)
            {
                if (completed && studentCompletedCourses != null) { studentCompletedCourses.Remove(deselectedCourse); }//There should not be multiple of the same Course objects, so deleting all instances of the deselected course is fine
                else
                {
                    if (studentCourses != null)
                    {
                        studentCourses.Remove(deselectedCourse);
                    } //There should not be multiple of the same Course objects, so deleting all instances of the deselected course is fine
                }
            }
        }
        static public Course findPreReqCourse(string courseCode)
        {
            List<Course> courseList = BuildDB.Instance.prereqDatabase;
            foreach (Course classSection in courseList)
            {
                if (courseCode == classSection.courseCode)
                {
                    return classSection;
                }
            }
            return null;
        }
        static public List<Course> findCourse(string courseCode)
        {
            List<Course> courseList = BuildDB.Instance.courseDatabase;
            List<Course> addingCourses = new List<Course>();
            foreach (Course classSection in courseList)
            {
                if (courseCode==classSection.courseCode)
                {
                    addingCourses.Add(classSection);
                }
            }
            return addingCourses;
        }
        public bool inSchedule(Course selectedCourse,bool completed)
        {
            if (studentCourses==null)
            {
                return false;
            }
            if (completed)
            {
                foreach (Course courses in studentCompletedCourses)
                {
                    if (courses.courseCode == selectedCourse.courseCode && courses.meetingDays == selectedCourse.meetingDays)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (Course courses in studentCourses)
                {
                    if (courses.courseCode == selectedCourse.courseCode && courses.meetingDays == selectedCourse.meetingDays)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public List<Course> isConflict(Course selectedCourse)
        {
            List<Course> conflicting=new List<Course>();
            if (studentCourses.Count==0)
            {
                return conflicting;
            }
            foreach (Course course in studentCourses)
            {
                if (course.courseCode==selectedCourse.courseCode)
                {
                    return conflicting;
                }
                foreach(char c in course.meetingDays)
                {
                    foreach(char c2 in selectedCourse.meetingDays)
                    {
                        if ((c==c2) && (selectedCourse.beginTime==course.beginTime))
                        {
                            conflicting.Add(course);
                        }
                        else if ((c==c2) &&(selectedCourse.beginTime>course.beginTime && selectedCourse.beginTime<course.endTime))
                        {
                            conflicting.Add(course);
                        }
                        else if ((c==c2) &&(selectedCourse.endTime>course.beginTime &&selectedCourse.endTime<=course.endTime))
                        {
                            conflicting.Add(course);
                        }
                    }
                }
            }
            return conflicting;
        }
        public static Student user
        {
            get
            {
                if (instance == null)
                {
                    instance = new Student();
                }
                return instance;
            }
        }
    }
}