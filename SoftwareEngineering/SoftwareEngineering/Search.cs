﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Search
    {
        //create a list to hold searched courses
        public List<Course> searchCourses = new List<Course>();

        //create a list of the course database
        private List<Course> courseDB = BuildDB.Instance.database;

        //search the course database list for matches to the input string
        public void search(string input)
        {
            searchCourses.Clear();
            for (int i = 0; i < courseDB.Count; i++)
            {
                if (courseDB[i].courseCode.StartsWith(input))
                {
                    searchCourses.Add(courseDB[i]);
                }
            }
        }
    }
}
