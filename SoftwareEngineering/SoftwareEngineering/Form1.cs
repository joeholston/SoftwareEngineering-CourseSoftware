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

        public Form1()
        {
            InitializeComponent();

            createLV();
        }
    
        //showCourses was designed to use a code to determine which UI calendar blocks should be shown
        //it will call specialized MWF or TR functions to actually display and edit the calendar blocks
        private void showCourses(int code, int time, bool show, Course c)
        {
            switch (code)
            {
                case 135: //mwf
                    mwf(135, time, show, c);
                    break;
                case 24: //tr
                    tr(24, time, show, c);
                    break;
                case 1: //m
                    mwf(1, time, show, c);
                    break;
                case 2: //t
                    tr(2, time, show, c);
                    break;
                case 3: //w
                    mwf(3, time, show, c);
                    break;
                case 4: //r
                    tr(4, time, show, c);
                    break;
                case 5: //f
                    mwf(5, time, show, c);
                    break;
                case 13: //mw
                    mwf(13, time, show, c);
                    break;
                case 35: //wf
                    mwf(35, time, show, c);
                    break;
                case 15: //mf
                    mwf(15, time, show, c);
                    break;
                case 1235: //mtwf
                    mwf(135, time, show, c);
                    tr(2, time, show, c);
                    break;
                case 1345: //mwrf
                    mwf(135, time, show, c);
                    tr(4, time, show, c);
                    break;
                default:
                    break;

            }
        }

        //mwf was designed to show the specific mwf calendar UI blocks
        private void mwf(int code, int time, bool show, Course c)
        {
            RichTextBox m;
            RichTextBox w;
            RichTextBox f;

            //this switch statement determines which mwf time slot should be edited
            switch (time)
            {
                case 8:
                    m = m8;
                    w = w8;
                    f = f8;
                    break;
                case 9:
                    m = m9;
                    w = w9;
                    f = f9;
                    break;
                case 10:
                    m = m10;
                    w = w10;
                    f = f10;
                    break;
                case 11:
                    m = m11;
                    w = w11;
                    f = f11;
                    break;
                case 12:
                    m = m12;
                    w = w12;
                    f = f12;
                    break;
                case 1:
                    m = m1;
                    w = w1;
                    f = f1;
                    break;
                case 13:
                    m = m1;
                    w = w1;
                    f = f1;
                    break;
                case 2:
                    m = m2;
                    w = w2;
                    f = f2;
                    break;
                case 14:
                    m = m2;
                    w = w2;
                    f = f2;
                    break;
                case 3:
                    m = m3;
                    w = w3;
                    f = f3;
                    break;
                case 15:
                    m = m3;
                    w = w3;
                    f = f3;
                    break;
                default:
                    m = m8;
                    w = w8;
                    f = f8;
                    break;
            }

            //this checks to see if the blocks should be hidden or shown
            if (show)
            {
                //here, the UI blocks are cleared and then filled with the desired content
                m.Clear();
                w.Clear();
                f.Clear();
                string newTime = appendTime(c.beginTime);
                m.AppendText(newTime + "\n" + c.shortTitle);
                w.AppendText(newTime + "\n" + c.shortTitle);
                f.AppendText(newTime + "\n" + c.shortTitle);

                //this switch statement uses the code system to determine which blocks to show or hide
                switch (code)
                {
                    case 135:
                        m.Show();
                        w.Show();
                        f.Show();
                        break;
                    case 1:
                        m.Show();
                        break;
                    case 3:
                        w.Show();
                        break;
                    case 5:
                        f.Show();
                        break;
                    case 13:
                        m.Show();
                        w.Show();
                        break;
                    case 15:
                        m.Show();
                        f.Show();
                        break;
                    case 35:
                        w.Show();
                        f.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (code)
                {
                    case 135:
                        m.Hide();
                        w.Hide();
                        f.Hide();
                        break;
                    case 1:
                        m.Hide();
                        break;
                    case 3:
                        w.Hide();
                        break;
                    case 5:
                        f.Hide();
                        break;
                    case 13:
                        m.Hide();
                        w.Hide();
                        break;
                    case 15:
                        m.Hide();
                        f.Hide();
                        break;
                    case 35:
                        w.Hide();
                        f.Hide();
                        break;
                    default:
                        break;
                }
            }
        }

        //tr was designed to show the specific tr calendar UI blocks
        private void tr(int code, int time, bool show, Course c)
        {
            RichTextBox t;
            RichTextBox r;

            //this switch statement determines which tr time slot should be edited
            switch (time)
            {
                case 8:
                    t = t8;
                    r = r8;
                    break;
                case 10:
                    t = t10;
                    r = r10;
                    break;
                case 11:
                    t = t1130;
                    r = r1130;
                    break;
                case 1:
                    t = t1;
                    r = r1;
                    break;
                case 13:
                    t = t1;
                    r = r1;
                    break;
                case 2:
                    t = t230;
                    r = r230;
                    break;
                case 14:
                    t = t230;
                    r = r230;
                    break;

                default:
                    t = t8;
                    r = r8;
                    break;
            }

            //this checks to see if the blocks should be hidden or shown
            if (show)
            {
                //here the blocks are cleared and filled with the desired content
                t.Clear();
                r.Clear();
                string newTime = appendTime(c.beginTime);
                t.AppendText(newTime + "\n" + c.shortTitle);
                r.AppendText(newTime + "\n" + c.shortTitle);

                //this switch statement uses the code system to display the desired UI blocks
                switch (code)
                {
                    case 24:
                        t.Show();
                        r.Show();
                        break;
                    case 2:
                        t.Show();
                        break;
                    case 4:
                        r.Show();
                        break;
                    default:
                        break;
                }   
            }
            else
            {
                switch (code)
                {
                    case 24:
                        t.Hide();
                        r.Hide();
                        break;
                    case 2:
                        t.Hide();
                        break;
                    case 4:
                        r.Hide();
                        break;
                    default:
                        break;
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
        //getDayCode is an algorithm to determine what code should be used from the meetingDays string. This creates a unified system.
        private int getDayCode(string meetingDays)
        {
            int daycode = 0;
            foreach (char c in meetingDays)
            {
                if (c == 'M')
                {
                    daycode = daycode * 10 + 1; //Monday is day 1
                }
                else if (c == 'T')
                {
                    daycode = daycode * 10 + 2; //Tuesday is day 2
                }
                else if (c == 'W')
                {
                    daycode = daycode * 10 + 3; //Wednesday is day 3
                }
                else if (c == 'R')
                {
                    daycode = daycode * 10 + 4; //Thursday is day 4
                }
                else if (c == 'F')
                {
                    daycode = daycode * 10 + 5; //Friday is day 5
                }
            }
            return daycode;
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
            int daycode = getDayCode(addedCourse.meetingDays); //Gets the code for the meeting days to use in showing courses
            int time = getTime(addedCourse.beginTime); //Gets the int simple time to use in showing courses
            showCourses(daycode, time, true, addedCourse); // Shows the newly added course on the calender
        }
        private void deleteFromCalender(Course deletedCourse) // Called when a course is deleted from the schedule
        {
            int daycode = getDayCode(deletedCourse.meetingDays); //Gets the code for the meeting days to use in the showing courses
            int time = getTime(deletedCourse.beginTime); //Gets the int simple time to use in showing courses
            showCourses(daycode, time, false, deletedCourse); //, deletedCourse  Hides the deleted course from the calender
        }

    //searchButton_Click sets the functionality for the search button being clicked.
        //This specifically takes the searchBox string and uses the search algorithm. Then is displays the results on the List View.
        private void searchButton_Click(object sender, EventArgs e)
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
                addToLV(c.courseCode, c.shortTitle, c.meetingDays, newTime, c.room, c.enrollment.ToString(),selected);
            }
        }

        //appendTime is a helper function that adds AM/PM to the simple integer time.
        //This is used when printing time to the calendar and List View.
        private string appendTime(DateTime originalTime)
        {
            string newTime = originalTime.ToString("hh:mm tt");
            return newTime;
        }
    }
}
