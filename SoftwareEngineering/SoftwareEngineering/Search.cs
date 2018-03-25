using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Search
    {
        private List<Course> searchCourses = new List<Course>();

        private List<Course> courseDB = new List<Course>();

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
