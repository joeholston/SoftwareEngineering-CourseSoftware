using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Search
    {
        //create a list to hold searched for courses
        public List<Course> searchCourses = new List<Course>();

        //create a list to hold prereq searched for courses
        public List<Course> prereqCourses = new List<Course>();

        //add a search that will search for prereq courses
        //the prereq database only holds course code, shortTitle, LongTitle

        //create a list of the course database
        private List<Course> courseDB = BuildDB.Instance.courseDatabase;
<<<<<<< HEAD
        //create a list of the prereq database
        private List<Course> prereqDB = BuildDB.Instance.prereqDatabase;

=======
       
>>>>>>> 1ce5d19f9004b5254eaf60cc6fcb7d349142e819
        //variable decide whether user is searching by Course Code or Course Name
        // 0 = Course Code
        // 1 = Course Name

        //search for checked boxes look at form one for name


        //search the course database list for matches to the input string
        public void search(string input, int searchSelection)
        {
            searchCourses.Clear();

            for (int i = 0; i < courseDB.Count; i++)
            {
                //decides whether to search for courseCode or courseName based on searchSelection variable
                if (searchSelection == 0)
                {
                    if (courseDB[i].courseCode.StartsWith(input.ToUpper()))
                    {
                        searchCourses.Add(courseDB[i]);
                    }
                }
                else if (searchSelection == 1)
                {
                    //It will search both the short or long title of the courses
                    if (courseDB[i].shortTitle.StartsWith(input.ToUpper()) | courseDB[i].LongTitle.StartsWith(input.ToUpper()))
                    {
                        searchCourses.Add(courseDB[i]);
                    }
                }
            }
        }
    }
}
