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
            addToLV("COMP 141  A", "Programming 1", "MWF 1PM", "STEM 326", "6");
            addToLV("COMP 141  B", "Programming 1", "MWF 2PM", "STEM 326", "6");
            addToLV("COMP 450  A", "--", "MWF 12PM", "--", "6");
            addToLV("ACCT 202  A", "--", "MWF 8am", "--", "6");
            addToLV("BIOL 234  A", "--", "MWF 9am", "--", "6");
            addToLV("BIOL 234  B", "--", "MWF 10am", "--", "6");
            addToLV("ACCT 302  B", "--", "MWF 11am", "--", "6");
            addToLV("MECE 416  A", "--", "TR 1005", "--", "6");
            addToLV("MUSI 103  A", "--", "TR 1130", "--", "6");
            addToLV("PHYE 102  A", "--", "TR 1130", "--", "6");
            addToLV("POLS 308  A", "--", "TR 230", "--", "6");
            addToLV("POLS 204  A", "--", "MWF 3pm", "--", "6");
            addToLV("PHIL 312  A", "--", "TR 1pm", "--", "6");
            showAllCourses(false);
            //showCourses(1345, 2, true);
        }
    

        private void showCourses(int code, int time, bool show)
        {
            switch (code)
            {
                case 135: //mwf
                    mwf(135, time, show);
                    break;
                case 24: //tr
                    tr(24, time, show);
                    break;
                case 1: //m
                    mwf(1, time, show);
                    break;
                case 2: //t
                    tr(2, time, show);
                    break;
                case 3: //w
                    mwf(3, time, show);
                    break;
                case 4: //r
                    tr(4, time, show);
                    break;
                case 5: //f
                    mwf(5, time, show);
                    break;
                case 13: //mw
                    mwf(13, time, show);
                    break;
                case 35: //wf
                    mwf(35, time, show);
                    break;
                case 15: //mf
                    mwf(15, time, show);
                    break;
                case 1235: //mtwf
                    mwf(135, time, show);
                    tr(2, time, show);
                    /*
                    switch (time)
                    {
                        case 8:
                            tr(2, time, show);
                            break;
                        case 10:
                            tr(2, time, show);
                            break;
                        case 11:
                            tr(2, time, show);
                            break;
                        case 1:
                            tr(2, time, show);
                            break;
                        case 13:
                            tr(2, time, show);
                            break;
                        case 2:
                            tr(2, 23, show);
                            break;
                        case 14:
                            tr(2, 23, show);
                            break;
                        default:
                            break;
                    }*/
                    break;
                case 1345: //mwrf
                    mwf(135, time, show);
                    tr(4, time, show);
                    /*
                    switch (time)
                    {
                        case 8:
                            tr(4, time, show);
                            break;
                        case 10:
                            tr(4, time, show);
                            break;
                        case 11:
                            tr(4, 113, show);
                            break;
                        case 1:
                            tr(4, time, show);
                            break;
                        case 13:
                            tr(4, time, show);
                            break;
                        case 2:
                            tr(4, 23, show);
                            break;
                        case 143:
                            tr(4, 23, show);
                            break;
                        default:
                            break;
                    }*/
                    break;
                default:
                    break;

            }
        }

        private void mwf(int code, int time, bool show)
        {
            RichTextBox m;
            RichTextBox w;
            RichTextBox f;

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

            if (show)
            {
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

        private void tr(int code, int time, bool show)
        {
            RichTextBox t;
            RichTextBox r;

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

            if (show)
            {
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

        private void showAllCourses(bool show)
        {
            if (show)
            {
                mwf(135, 8, true);
                mwf(135, 9, true);
                mwf(135, 10, true);
                mwf(135, 11, true);
                mwf(135, 12, true);
                mwf(135, 1, true);
                mwf(135, 2, true);
                mwf(135, 3, true);
                tr(24, 8, true);
                tr(24, 10, true);
                tr(24, 11, true);
                tr(24, 1, true);
                tr(24, 2, true);
            }
            else
            {
                mwf(135, 8, false);
                mwf(135, 9, false);
                mwf(135, 10, false);
                mwf(135, 11, false);
                mwf(135, 12, false);
                mwf(135, 1, false);
                mwf(135, 2, false);
                mwf(135, 3, false);
                tr(24, 8, false);
                tr(24, 10, false);
                tr(24, 11, false);
                tr(24, 1, false);
                tr(24, 2, false);
            }
        }

        private void createLV()
        {
            courseResults.View = View.Details;
            courseResults.GridLines = true;
            courseResults.FullRowSelect = true;

            courseResults.CheckBoxes = true;
        }

        private void addToLV(string code, string name, string time, string location, string seats)
        {
            ListViewItem itm;
            string[] arr = new string[5];
            arr[0] = code;
            arr[1] = name;
            arr[2] = time;
            arr[3] = location;
            arr[4] = seats;
            itm = new ListViewItem(arr);
            courseResults.Items.Add(itm);
        }

        private void courseResults_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Add/delete the newly checked/unchecked course to studentCourses
            if (e.CurrentValue == CheckState.Checked) //This is when it gets unchecked
            {
                //delete course
                string courseCode = this.courseResults.Items[e.Index].SubItems[0].Text; //Gets the courseCode from the ListView
                Course selectedCourse = Student.findCourse(courseCode); //Gets the Course object from the database array
                user.deleteCourse(selectedCourse); //Deletes the course from the student array
                deleteFromCalender(selectedCourse); //Hides the course from the calender
            }
            else
            {
                //add course
                string courseCode = this.courseResults.Items[e.Index].SubItems[0].Text; //Gets the courseCode from the ListView
                Course selectedCourse = Student.findCourse(courseCode); //Gets the Course object from the database array
                user.addCourse(selectedCourse); //Adds the course from the student array
                addToCalender(selectedCourse); //Show the new course to the calender
            }
        }
        private int getDayCode(string meetingDays)  //Get the code of which days are meeting
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
    }
}
