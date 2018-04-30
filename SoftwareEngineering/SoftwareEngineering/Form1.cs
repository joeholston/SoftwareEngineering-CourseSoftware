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
            foreach (char c in course.meetingDays)
            {
                if (c == 'M')
                {
                    if (show)
                    {
                        updateCalendarBox(course, 1, time);
                    }
                    else
                    {
                        resetCalendarBox(1, time);
                    }
                }
                else if (c == 'T')
                {
                    if (show)
                    {
                        updateCalendarBox(course, 2, time);
                    }
                    else
                    {
                        resetCalendarBox(2, time);
                    }
                }
                else if (c == 'W')
                {
                    if (show)
                    {
                        updateCalendarBox(course, 3, time);
                    }
                    else
                    {
                        resetCalendarBox(3, time);
                    }
                }
                else if (c == 'R')
                {
                    if (show)
                    {
                        updateCalendarBox(course, 4, time);
                    }
                    else
                    {
                        resetCalendarBox(4, time);
                    }
                }
                else if (c == 'F')
                {
                    if (show)
                    {
                        updateCalendarBox(course, 5, time);
                    }
                    else
                    {
                        resetCalendarBox(5, time);
                    }
                }
            }
            
        }

        private void updateCalendarBox(Course course, int day, int time)
        {
            string newTime = appendTime(course.beginTime);
            calendar[day, time].Clear();
            calendar[day, time].AppendText(newTime + "\n" + course.shortTitle);
            calendar[day, time].Font = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
        }

        private void resetCalendarBox(int day, int time)
        {
            calendar[day, time].Text = calendar[day, time].Tag.ToString();
            calendar[day, time].Font = SystemFonts.DefaultFont;
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

            bool[] meetingdays = new bool[5];
            meetingdays[0] = searchDay_Monday.Checked; 
            meetingdays[1] = searchDay_Tuesday.Checked;
            meetingdays[2] = searchDay_Wednesday.Checked;
            meetingdays[3] = searchDay_Thursday.Checked;
            meetingdays[4] = searchDay_Friday.Checked;

            s.search(searchString, searchDropDown.SelectedIndex, meetingdays);
            if (false)
            {
                if(user.studentCompletedCourses !=  null)
                {
                    for (int i = 0; i < s.searchCourses.Count; i++)
                    {
                        for (int k = 0; k < s.searchCourses[i].prerequisiteCourses.Count; k++)
                        {
                            bool met = false;
                            for (int j = 0; j < user.studentCompletedCourses.Count; j++)
                            {
                                if (s.searchCourses[i].prerequisiteCourses[k] == user.studentCompletedCourses[j].courseCode)
                               {
                                    met = true;
                                }
                            }
                            if (!met)
                            {
                                s.searchCourses.Remove(s.searchCourses[i]);
                                i--;
                                break;
                            }
                        }
                    }
                }
            }
            if (s.searchCourses.Count != 0)
            {
                for (int i = 0; i < s.searchCourses.Count; i++)
                {
                    Course c = s.searchCourses[i];
                    string newTime = appendTime(c.beginTime);
                    bool selected = user.inSchedule(c.courseCode);
                    addToLV(c.courseCode, c.LongTitle, c.meetingDays, newTime, c.building, c.enrollment.ToString(), selected);
                }
            }
            else
            {
                MessageBox.Show("No Results: Please Search Again.", "",MessageBoxButtons.OK);
                searchBox.Focus();
                searchBox.SelectionStart = 0;
                searchBox.SelectionLength = searchBox.Text.Length;
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
        public void addALL()
        {
            if (user.studentCourses != null)
            {
                foreach (Course courses in user.studentCourses)
                {
                    addToCalender(courses);
                }
            }
        }

        //courseResults_ItemChecked adds/deletes the desired List View course by calling respective functions
        //this function acts as a handler for after an item is checked/unchecked.
        private void courseResults_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            //Add/delete the newly checked/unchecked course to studentCourses
            if (e.Item.Checked == false) //This is when it gets unchecked
            {
                //delete course
                string courseCode = e.Item.SubItems[0].Text; //Gets the courseCode from the ListView
                List<Course> selectedCourses = Student.findCourse(courseCode); //Gets the Course object from the database array
                if (user.inSchedule(courseCode))
                {
                    foreach (Course selectedCourse in selectedCourses)
                    {
                        user.deleteCourse(selectedCourse, false); //Deletes the course from the student array
                        deleteFromCalender(selectedCourse); //Hides the course from the calender
                    }
                    foreach (ListViewItem item in courseResults.Items)
                    {
                        if (item.SubItems[0].Text==courseCode)
                        {
                            item.Checked = false;
                        }
                    }
                }
            }
            else
            {
                //add course
                string courseCode = e.Item.SubItems[0].Text; //Gets the courseCode from the ListView
                List<Course> selectedCourses = Student.findCourse(courseCode); //Gets the Course object from the database array
                Course conflicting = user.isConflict(selectedCourses[0]); //FIX
                if (conflicting==null)
                {
                    foreach (Course selectedCourse in selectedCourses)
                    {
                        user.addCourse(selectedCourse, false); //Adds the course from the student array
                        addToCalender(selectedCourse); //Show the new course to the calender
                    }
                    foreach (ListViewItem item in courseResults.Items)
                    {
                        if (item.SubItems[0].Text == courseCode)
                        {
                            item.Checked = true;
                        }
                    }

                }
                else
                {
                    DialogResult conflictBox = System.Windows.Forms.MessageBox.Show("Conflicting Course!\nDo you want to replace the current " + selectedCourses[0].meetingDays + "- " + appendTime(selectedCourses[0].beginTime) + " class?" , "", MessageBoxButtons.YesNo);
                    if (conflictBox == DialogResult.Yes)
                    {
                        foreach(ListViewItem item in courseResults.Items)
                        {
                            if (item.SubItems[0].Text == conflicting.courseCode)
                            {
                                item.Checked = false;
                            }
                            else if (item.SubItems[0].Text == courseCode)
                            {
                                item.Checked = true;
                            }
                        }
                        foreach (Course course in user.studentCourses)
                        {
                            if (course.courseCode == conflicting.courseCode)
                            {
                                user.deleteCourse(course, false);
                            }
                        }
                        foreach (Course selected in selectedCourses)
                        {
                            user.addCourse(selected, false);
                            addToCalender(selected); //Show the new course to the calender
                        }   
                    }
                    else if (conflictBox == DialogResult.No)
                    {
                        e.Item.Checked = false;
                    }
                }
            }
        }

        private void completedCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 prereqForm = new Form2();
            prereqForm.Show();
        }
    }
}
