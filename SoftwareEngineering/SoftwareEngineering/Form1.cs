/*
 * Grove City College- Spring 2018
 * Software Engineering- Team 3
 * Members- Joe Holston, Samuel Beiler, Sarah Trinkle, Wyatt Hough
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareEngineering
{
    public partial class Form1 : Form
    {
        private Student user=new Student();
        private RichTextBox[,] calendar = new RichTextBox[6, 13];

        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            searchDropDown.SelectedIndex = 0;
            startTime.SelectedIndex = 0;
            endTime.SelectedIndex = endTime.Items.Count - 1;
            createLV();
            fillCalendarArray();            
        }

        private void fillCalendarArray()
        { 
            calendar[1, 1] = m1;
            calendar[1, 2] = m2;
            calendar[1, 3] = m3;
            calendar[1, 6] = mNight;
            calendar[1, 8] = m8;
            calendar[1, 9] = m9;
            calendar[1, 10] = m10;
            calendar[1, 11] = m11;
            calendar[1, 12] = m12;
            
            calendar[2, 1] = t1;
            calendar[2, 2] = t230;
            calendar[2, 6] = tNight;
            calendar[2, 8] = t8;
            calendar[2, 10] = t10;
            calendar[2, 11] = t1130;

            calendar[3, 1] = w1;
            calendar[3, 2] = w2;
            calendar[3, 3] = w3;
            calendar[3, 6] = wNight;
            calendar[3, 8] = w8;
            calendar[3, 9] = w9;
            calendar[3, 10] = w10;
            calendar[3, 11] = w11;
            calendar[3, 12] = w12;

            calendar[4, 1] = r1;
            calendar[4, 2] = r230;
            calendar[4, 8] = r8;
            calendar[4, 10] = r10;
            calendar[4, 11] = r1130;

            calendar[5, 1] = f1;
            calendar[5, 2] = f2;
            calendar[5, 3] = f3;
            calendar[5, 8] = f8;
            calendar[5, 9] = f9;
            calendar[5, 10] = f10;
            calendar[5, 11] = f11;
            calendar[5, 12] = f12;
        }
    
        //showCourses was designed to use a code to determine which UI calendar blocks should be shown
        //it will call specialized MWF or TR functions to actually display and edit the calendar blocks
        private void showCourses(Course course, int time, bool show)
        {
            string newTime = appendTime(course.beginTime);
            
            foreach (char c in course.meetingDays)
            {
                if (c == 'M')
                {
                    if (show)
                    {
                        calendar[1, time].Clear();
                        calendar[1, time].AppendText(newTime + "\n" + course.shortTitle);
                    }
                    else
                    {
                        calendar[1, time].Text = calendar[1, time].Tag.ToString();
                    }
                }
                else if (c == 'T')
                {
                    if (show)
                    {
                        calendar[2, time].Clear();
                        calendar[2, time].AppendText(newTime + "\n" + course.shortTitle);
                    }
                    else
                    {
                        calendar[2, time].Text = calendar[2, time].Tag.ToString();
                    }
                }
                else if (c == 'W')
                {
                    if (show)
                    {
                        calendar[3, time].Clear();
                        calendar[3, time].AppendText(newTime + "\n" + course.shortTitle);
                    }
                    else
                    {
                        calendar[3, time].Text = calendar[3, time].Tag.ToString();
                    }
                }
                else if (c == 'R')
                {
                    if (show)
                    {
                        calendar[4, time].Clear();
                        calendar[4, time].AppendText(newTime + "\n" + course.shortTitle);
                    }
                    else
                    {
                        calendar[4, time].Text = calendar[4, time].Tag.ToString();
                    }
                }
                else if (c == 'F')
                {
                    if (show)
                    {
                        calendar[5, time].Clear();
                        calendar[5, time].AppendText(newTime + "\n" + course.shortTitle);
                    }
                    else
                    {
                        calendar[5, time].Text = calendar[5, time].Tag.ToString();
                    }
                }
            }
            
        }

        //createLV creates the List View with the desired preset settings
        private void createLV()
        {
            courseResults.View = View.Details;
            courseResults.GridLines = true;
            courseResults.FullRowSelect = true;

            courseResults.CheckBoxes = true;
        }

        //addToLv takes the desired arguements and adds them as List View Items
        private void addToLV(string code, string name, string days, string time, string location, string seats, bool selected)
        {
            //creates a List View Item
            ListViewItem itm;
            string[] arr = new string[6];
            arr[0] = code;
            arr[1] = name;
            arr[2] = days;
            arr[3] = time;
            arr[4] = location;
            arr[5] = seats;
            itm = new ListViewItem(arr);
            itm.Checked = selected;
            courseResults.Items.Add(itm);
        }

        //courseResults_ItemCheck adds/deletes the desired List View course by calling respective functions
        //this function acts as a handler 
        private void courseResults_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Add/delete the newly checked/unchecked course to studentCourses
            if (e.CurrentValue == CheckState.Checked) //This is when it gets unchecked
            {
                //delete course
                string courseCode = this.courseResults.Items[e.Index].SubItems[0].Text; //Gets the courseCode from the ListView
                Course selectedCourse = Student.findCourse(courseCode); //Gets the Course object from the database array
                user.deleteCourse(selectedCourse, false); //Deletes the course from the student array
                deleteFromCalender(selectedCourse); //Hides the course from the calender
            }
            else
            {
                //add course
                string courseCode = this.courseResults.Items[e.Index].SubItems[0].Text; //Gets the courseCode from the ListView
                Course selectedCourse = Student.findCourse(courseCode); //Gets the Course object from the database array
                user.addCourse(selectedCourse, false); //Adds the course from the student array
                addToCalender(selectedCourse); //Show the new course to the calender
            }
        }

        //getTime takes a DateTime item and returns the simple integer version of the time.
        //This is used for the time code and for printing to the List View and Calendar UI.
        private int getTime(DateTime fullTime)
        {
            string stringTime = fullTime.ToString(); //Set DateTime to a string
            string charTime="";
            bool getFirstTime = false; //Not at the point where the actual start time is.
            bool getTime = false; 
            int time = 0;
            foreach (char c in stringTime)
            {
                if (c==':')
                {
                    break; //Does not need to go to minutes.
                }
                else if(getFirstTime)
                {
                    if (c != 0)
                    {
                        charTime +=c;   //Get the time is int format ex: 01:00:00  is 1
                        getFirstTime = false; //No longer the first number needed.
                    }
                }
                else if(getTime)
                {
                    charTime += c;
                }
                else if (c==' ')
                {
                    getFirstTime = true; //Start getting the time now after the space.
                    getTime = true;  
                }
            }
            time = Int32.Parse(charTime); //Parse the char 

            return time;
        }

        private void addToCalender(Course addedCourse) //Called when a course is added to the schedule
        {
            int time = getTime(addedCourse.beginTime); //Gets the int simple time to use in showing courses
            showCourses(addedCourse, time, true); // Shows the newly added course on the calender
        }
        private void deleteFromCalender(Course deletedCourse) // Called when a course is deleted from the schedule
        {
            int time = getTime(deletedCourse.beginTime); //Gets the int simple time to use in showing courses
            showCourses(deletedCourse, time, false); //, deletedCourse  Hides the deleted course from the calender
        }

        //appendTime is a helper function that adds AM/PM to the simple integer time.
        //This is used when printing time to the calendar and List View.
        private string appendTime(DateTime originalTime)
        {
            string newTime = originalTime.ToString("hh:mm tt");
            return newTime;
        }

        private void advancedSearch_Click(object sender, EventArgs e)
        {
            if(advancedSearch.Checked)
            {
                advancedSearch_Group.Show();
            }
            else
            {
                advancedSearch_Group.Hide();
            }
        }

        private void search()
        {
            courseResults.Items.Clear();
            string searchString = searchBox.Text;
            Search s = new Search();
            s.search(searchString);

            for (int i = 0; i < s.searchCourses.Count; i++)
            {
                Course c = s.searchCourses[i];
                string newTime = appendTime(c.beginTime);
                bool selected = user.inSchedule(c.courseCode);
                addToLV(c.courseCode, c.LongTitle, c.meetingDays, newTime, c.building, c.enrollment.ToString(), selected);
            }
        }

        //searchButton_Click sets the functionality for the search button being clicked.
        //This specifically takes the searchBox string and uses the search algorithm. Then is displays the results on the List View.
        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        
    }
}
