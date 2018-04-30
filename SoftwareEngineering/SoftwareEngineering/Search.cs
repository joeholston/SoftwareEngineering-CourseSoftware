using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Search
    {
        //create two databases, one for the courses and another for the prereqs
        //the prereq database only holds the course code, shortTitle, and LongTitle
        private List<Course> courseDB = BuildDB.Instance.courseDatabase;
        private List<Course> prereqDB = BuildDB.Instance.prereqDatabase;

        //create one list to hold searched courses and another to hold prereq courses
        public List<Course> searchCourses = new List<Course>();
        public List<Course> prereqCourses = new List<Course>();

        //search for checked boxes look at form one for name

        /*search the course database list for matches to the input string and add them to the searchCourses list
          searchSelection tells us whether to search by course code or course name
               0 = Course Code
               1 = Course Name
         
           meetingDays is a bool array that tells wehether the boxes for Monday through Friday are checked or not
               0 = Monday
               1 = Tuesday
               2 = Wednesday
               3 = Thursday
               4 = Friday
        */
        public void search(string input, int searchSelection, bool[] meetingDays)
        {
            searchCourses.Clear();

            for (int i = 0; i < courseDB.Count; i++)
            {
                //if (meetingDays[0])
                //{
                    if (searchSelection == 0)
                    {
                        if (courseDB[i].courseCode.Contains(input.ToUpper()))
                        {
                            searchCourses.Add(courseDB[i]);
                        }
                    }
                    else if (searchSelection == 1)
                    {
                        //allows for searching both the short or long title of the courses
                        if (courseDB[i].shortTitle.Contains(input.ToUpper()) | courseDB[i].LongTitle.Contains(input.ToUpper()))
                        {
                            searchCourses.Add(courseDB[i]);
                        }
                    }
                //}
            }
        }

        public void searchPrereq(string input, int searchSelection)
        {
            prereqCourses.Clear();

            for (int i = 0; i < prereqDB.Count; i++)
            {
                if (searchSelection == 0)
                {
                    if (prereqDB[i].courseCode.Contains(input.ToUpper()))
                    {
                        prereqCourses.Add(prereqDB[i]);
                    }
                }
                else if (searchSelection == 1)
                {
                    //allows for searching both the short or long title of the courses
                    if (prereqDB[i].shortTitle.Contains(input.ToUpper()) | prereqDB[i].LongTitle.Contains(input.ToUpper()))
                    {
                        prereqCourses.Add(prereqDB[i]);
                    }
                }
            }
        }
    }
}
