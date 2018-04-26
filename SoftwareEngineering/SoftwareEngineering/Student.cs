﻿using System;
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
                }
                if (studentCompletedCourses == null)
                {
                    studentCompletedCourses = new List<Course>();
                }
                if (completed) { studentCompletedCourses.Add(selectedCourse); }
                else{
                    if (!inSchedule(selectedCourse.courseCode))
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
        public bool inSchedule(string courseCode)
        {
            if (studentCourses==null)
            {
                return false;
            }
            foreach (Course courses in studentCourses)
            {
                if (courses.courseCode == courseCode)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isConflict(Course selectedCourse)
        {
            if (studentCourses==null)
            {
                return false;
            }
            foreach (Course course in studentCourses)
            {
                foreach(char c in course.meetingDays)
                {
                    foreach(char c2 in selectedCourse.meetingDays)
                    {
                        if ((c==c2) && (selectedCourse.beginTime==course.beginTime))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}