using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    public class Search
    {
        public Search()
        {
            courseDB = BuildDB.Instance.courseDatabase;
            prereqDB = BuildDB.Instance.prereqDatabase;
        }
        //This allows to build a test search without having to build a database
        public Search(int x)
        {
            
        }
        //create two databases, one for the courses and another for the prereqs
        //the prereq database only holds the course code, shortTitle, and LongTitle
        private List<Course> courseDB;
        private List<Course> prereqDB;

        //create one list to hold searched courses and another to hold prereq courses
        public List<Course> searchCourses = new List<Course>();
        public List<Course> prereqCourses = new List<Course>();

        /*searchSelection tells us whether to search by course code or course name
               0 = Course Code
               1 = Course Name
         
           meetingDays is a bool array that tells wehether the boxes for Monday through Friday are checked or not
               0 = Monday
               1 = Tuesday
               2 = Wednesday
               3 = Thursday
               4 = Friday
        */
        public void search(string input, int searchSelection, bool[] meetingDays, String startTime, String endTime)
        {
            searchCourses.Clear();

            for (int i = 0; i < courseDB.Count; i++)
            {
                if (searchMethod(input, searchSelection, i))
                {
                    if (searchDays(meetingDays, i))
                    {
                        if(searchTime(startTime, endTime, i))
                        {
                            searchCourses.Add(courseDB[i]);
                        }
                    }
                }
            }

            
        }
        
        private bool searchMethod(string input, int searchSelection, int i)
        {
            if (searchSelection == 0)
            {
                if (courseDB[i].courseCode.Contains(input.ToUpper()))
                {
                    return true;
                }
            }
            else if (searchSelection == 1)
            {
                if (courseDB[i].shortTitle.Contains(input.ToUpper()) || courseDB[i].LongTitle.Contains(input.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        private bool searchTime(String startTime, String endTime, int i)
        {
            int beginTime = 0;
            switch (startTime)
            {
                case "  8 AM":
                    beginTime = 8;
                    break;
                case "  9 AM":
                    beginTime = 9;
                    break;
                case "10 AM":
                    beginTime = 10;
                    break;
                case "11 AM":
                    beginTime = 11;
                    break;
                case "12 PM":
                    beginTime = 12;
                    break;
                case "  1 PM":
                    beginTime = 13;
                    break;
                case "  2 PM":
                    beginTime = 14;
                    break;
                case "  3 PM":
                    beginTime = 15;
                    break;
                case "  4 PM":
                    beginTime = 16;
                    break;
                case "  5 PM":
                    beginTime = 17;
                    break;
                case "  6 PM":
                    beginTime = 18;
                    break;
                case "  7 PM":
                    beginTime = 19;
                    break;
                case "  8 PM":
                    beginTime = 20;
                    break;
                case "  9 PM":
                    beginTime = 21;
                    break;
            }

            int finishTime = 0;
            switch (endTime)
            {
                case "  8 AM":
                    finishTime = 8;
                    break;
                case "  9 AM":
                    finishTime = 9;
                    break;
                case "10 AM":
                    finishTime = 10;
                    break;
                case "11 AM":
                    finishTime = 11;
                    break;
                case "12 PM":
                    finishTime = 12;
                    break;
                case "  1 PM":
                    finishTime = 13;
                    break;
                case "  2 PM":
                    finishTime = 14;
                    break;
                case "  3 PM":
                    finishTime = 15;
                    break;
                case "  4 PM":
                    finishTime = 16;
                    break;
                case "  5 PM":
                    finishTime = 17;
                    break;
                case "  6 PM":
                    finishTime = 18;
                    break;
                case "  7 PM":
                    finishTime = 19;
                    break;
                case "  8 PM":
                    finishTime = 20;
                    break;
                case "  9 PM":
                    finishTime = 21;
                    break;
            }

            int courseStart = courseDB[i].beginTime.Hour;
            int courseEnd = courseDB[i].endTime.Hour;

            if (courseStart >= beginTime && courseEnd <= finishTime-1)
            {
                return true;
            }
            return false;
        }

        private bool searchDays(bool[] meetingDays, int i)
        {
            switch (boolArrayToString(meetingDays))
            {
                case "00000":
                    if (courseDB[i].meetingDays == "")
                    {
                        return true;
                    }
                    break;
                case "00001":
                    if (courseDB[i].meetingDays == "F")
                    {
                        return true;
                    }
                    break;
                case "00010":
                    if (courseDB[i].meetingDays == "R")
                    {
                        return true;
                    }
                    break;
                case "00011":
                    if (courseDB[i].meetingDays == "RF")
                    {
                        return true;
                    }
                    break;
                case "00100":
                    if (courseDB[i].meetingDays == "W")
                    {
                        return true;
                    }
                    break;
                case "00101":
                    if (courseDB[i].meetingDays == "WF")
                    {
                        return true;
                    }
                    break;
                case "00110":
                    if (courseDB[i].meetingDays == "WR")
                    {
                        return true;
                    }
                    break;
                case "00111":
                    if (courseDB[i].meetingDays == "WRF")
                    {
                        return true;
                    }
                    break;
                case "01000":
                    if (courseDB[i].meetingDays == "T")
                    {
                        return true;
                    }
                    break;
                case "01001":
                    if (courseDB[i].meetingDays == "TF")
                    {
                        return true;
                    }
                    break;
                case "01010":
                    if (courseDB[i].meetingDays == "TR")
                    {
                        return true;
                    }
                    break;
                case "01011":
                    if (courseDB[i].meetingDays == "TRF")
                    {
                        return true;
                    }
                    break;
                case "01100":
                    if (courseDB[i].meetingDays == "TW")
                    {
                        return true;
                    }
                    break;
                case "01101":
                    if (courseDB[i].meetingDays == "TWF")
                    {
                        return true;
                    }
                    break;
                case "01110":
                    if (courseDB[i].meetingDays == "TWR")
                    {
                        return true;
                    }
                    break;
                case "01111":
                    if (courseDB[i].meetingDays == "TWRF")
                    {
                        return true;
                    }
                    break;
                case "10000":
                    if (courseDB[i].meetingDays == "M")
                    {
                        return true;
                    }
                    break;
                case "10001":
                    if (courseDB[i].meetingDays == "MF")
                    {
                        return true;
                    }
                    break;
                case "10010":
                    if (courseDB[i].meetingDays == "MR")
                    {
                        return true;
                    }
                    break;
                case "10011":
                    if (courseDB[i].meetingDays == "MRF")
                    {
                        return true;
                    }
                    break;
                case "10100":
                    if (courseDB[i].meetingDays == "MW")
                    {
                        return true;
                    }
                    break;
                case "10101":
                    if (courseDB[i].meetingDays == "MWF")
                    {
                        return true;
                    }
                    break;
                case "10110":
                    if (courseDB[i].meetingDays == "MWR")
                    {
                        return true;
                    }
                    break;
                case "10111":
                    if (courseDB[i].meetingDays == "MWRF")
                    {
                        return true;
                    }
                    break;
                case "11000":
                    if (courseDB[i].meetingDays == "MT")
                    {
                        return true;
                    }
                    break;
                case "11001":
                    if (courseDB[i].meetingDays == "MTF")
                    {
                        return true;
                    }
                    break;
                case "11010":
                    if (courseDB[i].meetingDays == "MTR")
                    {
                        return true;
                    }
                    break;
                case "11011":
                    if (courseDB[i].meetingDays == "MTRF")
                    {
                        return true;
                    }
                    break;
                case "11100":
                    if (courseDB[i].meetingDays == "MTW")
                    {
                        return true;
                    }
                    break;
                case "11101":
                    if (courseDB[i].meetingDays == "MTWF")
                    {
                        return true;
                    }
                    break;
                case "11110":
                    if (courseDB[i].meetingDays == "MTWR")
                    {
                        return true;
                    }
                    break;
                case "11111":
                        return true;
            }
            return false;
        }

        public String boolArrayToString(bool[] b)
        {
            String s = null;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == true)
                {
                    s = s + "1";
                }
                else
                {
                    s = s + "0";
                }
            }
            return s;
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
