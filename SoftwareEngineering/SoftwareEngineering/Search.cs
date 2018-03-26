using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Search
    {
        //create a list to hold searched courses
        private List<Course> searchCourses = new List<Course>();

        //create a list of the course database
        private List<Course> courseDB = BuildDB.Instance.database;

        //search the course database list for matches to the input string
        //      searches for a direct match of course code, short title, and long title
        public Search(string input)
        {
            for (int i = 0; i < courseDB.Count; i++)
            {
                if (input == courseDB[i].courseCode | input == courseDB[i].shortTitle | input == courseDB[i].LongTitle)
                {
                    searchCourses.Add(courseDB[i]);
                }
            }
        }
    }
}
