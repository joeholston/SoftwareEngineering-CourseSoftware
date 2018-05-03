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
using System.IO;


namespace SoftwareEngineering
{
    public partial class Form1 : Form
    {
        private Student user = Student.user;
        private RichTextBox[,] calendar = new RichTextBox[6, 13];

        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            searchDropDown.SelectedIndex = 0;
            startTime.SelectedIndex = 0;
            endTime.SelectedIndex = endTime.Items.Count - 1;
            createLV(courseResults);
            createLV(studentListView);
            fillCalendarArray();
            hideAllLabs();

            searchDropDown_prereq.SelectedIndex = 0;
            createLV(courseResults_prereq);
            createLV(studentListView_prereq);
        }

        private void fillCalendarArray()
        { 
            calendar[1, 1] = m1;
            calendar[1, 2] = m2;
            calendar[1, 3] = m3;
            calendar[1, 4] = m4;
            calendar[1, 6] = mNight;
            calendar[1, 8] = m8;
            calendar[1, 9] = m9;
            calendar[1, 10] = m10;
            calendar[1, 11] = m11;
            calendar[1, 12] = m12;
            
            calendar[2, 1] = t1;
            calendar[2, 2] = t230;
            calendar[2, 4] = t4;
            calendar[2, 6] = tNight;
            calendar[2, 8] = t8;
            calendar[2, 10] = t10;
            calendar[2, 11] = t1130;

            calendar[3, 1] = w1;
            calendar[3, 2] = w2;
            calendar[3, 3] = w3;
            calendar[3, 4] = w4;
            calendar[3, 6] = wNight;
            calendar[3, 8] = w8;
            calendar[3, 9] = w9;
            calendar[3, 10] = w10;
            calendar[3, 11] = w11;
            calendar[3, 12] = w12;

            calendar[4, 1] = r1;
            calendar[4, 2] = r230;
            calendar[4, 4] = r4;
            calendar[4, 8] = r8;
            calendar[4, 10] = r10;
            calendar[4, 11] = r1130;

            calendar[5, 1] = f1;
            calendar[5, 2] = f2;
            calendar[5, 3] = f3;
            calendar[5, 4] = f4;
            calendar[5, 8] = f8;
            calendar[5, 9] = f9;
            calendar[5, 10] = f10;
            calendar[5, 11] = f11;
            calendar[5, 12] = f12;
        }

        private void hideAllLabs()
        {
            mLab_11_12.Hide();
            mLab_2_4.Hide();
            mLab_2_5.Hide();

            tLab_10_1.Hide();
            tLab_10_11.Hide();
            tLab_1_3.Hide();
            tLab_225_415.Hide();
            tLab_230_5.Hide();
            tLab_230_530.Hide();
            tLab_2_5.Hide();
            tLab_3_5.Hide();

            wLab_9_10.Hide();
            wLab_1_5.Hide();
            wLab_2_5.Hide();
            wLab_330_530.Hide();
            wLab_3_4.Hide();

            rLab_10_1.Hide();
            rLab_10_11.Hide();
            rLab_230_430.Hide();
            rLab_230_5.Hide();
            rLab_230_530.Hide();
            rLab_2_5.Hide();

            fLab_9_10.Hide();
            fLab_1_3.Hide();
            fLab_2_5.Hide();
            fLab_3_4.Hide();
        }

        private void updateLabBox(RichTextBox lab, Course course, bool show)
        {
            if (!show)
            {
                lab.Hide();
            }
            else
            {
                lab.Show();
                lab.BringToFront();
                lab.Clear();
                lab.AppendText(appendTime(course.beginTime) + "\n" + course.shortTitle);
                lab.Font = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
            }
        }

        //showCourses was designed to use a code to determine which UI calendar blocks should be shown
        //it will call specialized MWF or TR functions to actually display and edit the calendar blocks
        private void showCourses(Course course, int time, bool show)
        {
            //add to student list view
            if (show)
            {
                addToLV(studentListView, course, true);
            }
            //remove from student list view
            else
            {
                foreach(ListViewItem item in studentListView.Items)
                {
                    if (item.SubItems[0].Text.Equals(course.courseCode))
                    {
                        studentListView.Items.Remove(item);
                    }
                }
            }

            //if it is a lab
            if(course.courseCode[course.courseCode.Length - 1] == 'L')
            {
                foreach (char c in course.meetingDays)
                {
                    if (c == 'M')
                    {
                        switch (appendTime(course.beginTime))
                        {
                            case "11:00 AM":
                                updateLabBox(mLab_11_12, course, show);
                                break;
                            case "02:00 PM":
                                switch (appendTime(course.endTime))
                                {
                                    case "03:59 PM":
                                        updateLabBox(mLab_2_4, course, show);
                                        break;
                                    case "04:59 PM":
                                        updateLabBox(mLab_2_5, course, show);
                                        break;
                                }
                                break;
                        }
                    }
                    else if (c == 'T')
                    {
                        switch (appendTime(course.beginTime))
                        {
                            case "10:05 AM":
                                switch (appendTime(course.endTime))
                                {
                                    case "10:59 AM":
                                        updateLabBox(tLab_10_11, course, show);
                                        break;
                                    case "12:59 PM":
                                        updateLabBox(tLab_10_1, course, show);
                                        break;
                                }
                                break;
                            case "01:00 PM":
                                updateLabBox(tLab_1_3, course, show);
                                break;
                            case "02:25 PM":
                                updateLabBox(tLab_225_415, course, show);
                                break;
                            case "02:30 PM":
                                switch (appendTime(course.endTime))
                                {
                                    case "04:59 PM":
                                        updateLabBox(tLab_230_5, course, show);
                                        break;
                                    case "05:29 PM":
                                        updateLabBox(tLab_230_530, course, show);
                                        break;
                                }
                                break;
                            case "03:00 PM":
                                updateLabBox(tLab_3_5, course, show);
                                break;
                        }
                    }
                    else if (c == 'W')
                    {
                        switch (appendTime(course.beginTime))
                        {
                            case "09:00 AM":
                                updateLabBox(wLab_9_10, course, show);
                                break;
                            case "01:00 PM":
                                updateLabBox(wLab_1_5, course, show);
                                break;
                            case "02:00 PM":
                                updateLabBox(wLab_2_5, course, show);
                                break;
                            case "03:00 PM":
                                updateLabBox(wLab_3_4, course, show);
                                break;
                            case "03:30 PM":
                                updateLabBox(wLab_330_530, course, show);
                                break;
                        }

                    }
                    else if (c == 'R')
                    {
                        switch (appendTime(course.beginTime))
                        {
                            case "10:05 AM":
                                switch (appendTime(course.endTime))
                                {
                                    case "12:59 PM":
                                        updateLabBox(rLab_10_1, course, show);
                                        break;
                                    case "10:29 AM":
                                        updateLabBox(rLab_10_11, course, show);
                                        break;
                                }
                                break;
                            case "02:30 PM":
                                switch (appendTime(course.endTime))
                                {
                                    case "04:29 PM":
                                        updateLabBox(rLab_230_430, course, show);
                                        break;
                                    case "04:59 PM":
                                        updateLabBox(rLab_230_5, course, show);
                                        break;
                                    case "05:29 PM":
                                        updateLabBox(rLab_230_530, course, show);
                                        break;
                                }
                                break;
                            case "02:00 PM":
                                updateLabBox(rLab_2_5, course, show);
                                break;
                        }

                    }
                    else if (c == 'F')
                    {
                        switch (appendTime(course.beginTime))
                        {
                            case "09:00 AM":
                                updateLabBox(fLab_9_10, course, show);
                                break;
                            case "01:00 PM":
                                updateLabBox(fLab_1_3, course, show);
                                break;
                            case "02:00 PM":
                                updateLabBox(fLab_2_5, course, show);
                                break;
                            case "03:00 PM":
                                updateLabBox(fLab_3_4, course, show);
                                break;
                        }
                    }
                }
            }
            else
            {
                //adding/removing from calendar
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
        }

        private void clearCalendar()
        {
            //MWF
            for(int i = 1; i <= 5; i += 2)
            {
                resetCalendarBox(i, 8);
                resetCalendarBox(i, 9);
                resetCalendarBox(i, 10);
                resetCalendarBox(i, 11);
                resetCalendarBox(i, 12);
                resetCalendarBox(i, 1);
                resetCalendarBox(i, 2);
                resetCalendarBox(i, 3);
                resetCalendarBox(i, 4);
                if (i == 1 || i == 3)
                {
                    resetCalendarBox(i, 6);
                }
            }
            for (int i = 2; i <= 4; i += 2)
            {
                resetCalendarBox(i, 8);
                resetCalendarBox(i, 10);
                resetCalendarBox(i, 1);
                resetCalendarBox(i, 1);
                resetCalendarBox(i, 2);
                resetCalendarBox(i, 4);
                if (i == 2)
                {
                    resetCalendarBox(i, 6);
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
        private void createLV(ListView lv)
        {
            lv.View = View.Details;
            lv.GridLines = true;
            lv.FullRowSelect = true;
            
            lv.CheckBoxes = true;
        }

        //addToLv takes the desired arguements and adds them as List View Items
        private void addToLV(ListView lv, Course c, bool selected)
        {
            //creates a List View Item
            foreach (ListViewItem course in lv.Items)
            {
                if (course.SubItems[0].Text==c.courseCode && course.SubItems[2].Text==c.meetingDays)
                {
                    return;
                }
            }
            ListViewItem itm;
            string[] arr = new string[7];
            arr[0] = c.courseCode;
            arr[1] = c.LongTitle;
            arr[2] = c.meetingDays;
            arr[3] = appendTime(c.beginTime);
            arr[4] = c.building;
            arr[5] = c.enrollment.ToString();
            arr[6] = "true";  //IS the first time having this item in the LV 
            itm = new ListViewItem(arr);
            itm.Checked = selected;
            lv.Items.Add(itm);
        }

        private void addToLV_prereq(ListView lv, string code, string name)
        {
            ListViewItem itm;
            string[] arr = new string[6];
            arr[0] = code;
            arr[1] = name;
            itm = new ListViewItem(arr);
            lv.Items.Add(itm);
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

                // make all the boxes checked when you hide the advanced search
                prereqButton.Checked = true;
                searchDay_Monday.Checked = true;
                searchDay_Tuesday.Checked = true;
                searchDay_Wednesday.Checked = true;
                searchDay_Thursday.Checked = true;
                searchDay_Friday.Checked = true;
                startTime.SelectedIndex = 0;
                endTime.SelectedIndex = endTime.Items.Count - 1;
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
            if (!prereqButton.Checked)
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
                    bool selected = user.inSchedule(c,false);
                    addToLV(courseResults, c, selected);
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

        private void search_prereq()
        {
            courseResults_prereq.Items.Clear();
            string searchString = searchBox_prereq.Text;
            Search s = new Search();

            s.searchPrereq(searchString, searchDropDown_prereq.SelectedIndex);

            if (s.prereqCourses.Count != 0)
            {
                for (int i = 0; i < s.prereqCourses.Count; i++)
                {
                    Course c = s.prereqCourses[i];
                    string newTime = appendTime(c.beginTime);
                    //bool selected = user.inSchedule(c.courseCode);
                    addToLV_prereq(courseResults_prereq, c.courseCode, c.LongTitle);
                }
            }
            else
            {
                MessageBox.Show("No Results: Please Search Again.", "", MessageBoxButtons.OK);
                searchBox_prereq.Focus();
                searchBox_prereq.SelectionStart = 0;
                searchBox_prereq.SelectionLength = searchBox_prereq.Text.Length;
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

        private void searchButton_prereq_Click(object sender, EventArgs e)
        {
            search_prereq();
        }

        private void searchBox_prereq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_prereq();
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
                if (user.inSchedule(selectedCourses[0],false)) //If one is in, both will be
                {
                    foreach (Course selectedCourse in selectedCourses)
                    {
                        user.deleteCourse(selectedCourse, false); //Deletes the course from the student array
                        deleteFromCalender(selectedCourse); //Hides the course from the calender
                    }
                    foreach (ListViewItem item in courseResults.Items)
                    {
                        if (item.SubItems[0].Text == courseCode)
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
                Course conflicting1 = null;
                Course conflicting2 = null;
                if (selectedCourses.Count == 2)
                {
                    conflicting1 = user.isConflict(selectedCourses[0]);
                    conflicting2 = user.isConflict(selectedCourses[1]);
                    if (conflicting1 == null && conflicting2 == null)
                    {
                        user.addCourse(selectedCourses[0], false);
                        user.addCourse(selectedCourses[1], false);
                        addToCalender(selectedCourses[0]);
                        addToCalender(selectedCourses[1]);
                        foreach (ListViewItem item in courseResults.Items)
                        {
                            if (item.SubItems[0].Text == courseCode)
                            {
                                item.Checked = true;
                            }
                        }

                    }
                    else if (conflicting1 != null && conflicting2 != null)
                    {
                        DialogResult conflictBox1 = System.Windows.Forms.MessageBox.Show("Conflicting Courses!\nDo you want to replace the current " + selectedCourses[0].meetingDays + "- " + appendTime(selectedCourses[0].beginTime) + " class AND the current " + selectedCourses[1].meetingDays + "- " + appendTime(selectedCourses[1].beginTime) + " class?", "", MessageBoxButtons.YesNo);
                        if (conflictBox1 == DialogResult.Yes)
                        {
                            foreach (ListViewItem item in courseResults.Items)
                            {
                                if (item.SubItems[0].Text == conflicting1.courseCode || item.SubItems[0].Text == conflicting2.courseCode)
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
                                if (course.courseCode == conflicting1.courseCode || course.courseCode == conflicting2.courseCode)
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
                        else if (conflictBox1 == DialogResult.No)
                        {
                            e.Item.Checked = false;
                        }
                    }
                    else
                    {
                        int i = 0;
                        if (conflicting2 != null)
                        {
                            i = 1;
                        }
                        DialogResult  conflictBox2 = System.Windows.Forms.MessageBox.Show("Conflicting Courses!\nDo you want to replace the current " + selectedCourses[i].meetingDays + "- " + appendTime(selectedCourses[i].beginTime) + " class?", "", MessageBoxButtons.YesNo);
                        if (conflictBox2 == DialogResult.Yes)
                        {
                            foreach (ListViewItem item in courseResults.Items)
                            {
                                if (i==0 && item.SubItems[0].Text == conflicting1.courseCode)
                                {
                                    item.Checked = false;
                                }
                                else if(i==1 && item.SubItems[0].Text==conflicting2.courseCode)
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
                                if (i == 0 && course.courseCode == conflicting1.courseCode)
                                {
                                    user.deleteCourse(course, false);
                                }
                                else if (i == 1 && course.courseCode == conflicting2.courseCode)
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
                        else if (conflictBox2 == DialogResult.No)
                        {
                            e.Item.Checked = false;
                        }
                    }
                }
                else if (selectedCourses.Count == 1)
                {
                    Course conflicting = user.isConflict(selectedCourses[0]);
                    if (conflicting == null)
                    {
                        user.addCourse(selectedCourses[0], false); //Adds the course from the student array
                        addToCalender(selectedCourses[0]); //Show the new course to the calender
                    }
                    else
                    {
                        DialogResult conflictBox3 = System.Windows.Forms.MessageBox.Show("Conflicting Course!\nDo you want to replace the current " + selectedCourses[0].meetingDays + "- " + appendTime(selectedCourses[0].beginTime) + " class?", "", MessageBoxButtons.YesNo);
                        if (conflictBox3 == DialogResult.Yes)
                        {
                            foreach (ListViewItem item in courseResults.Items)
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
                        else if (conflictBox3 == DialogResult.No)
                        {
                            e.Item.Checked = false;
                        }
                    }
                }
            }
        }

        private void courseResults_prereq_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string courseCode = e.Item.SubItems[0].Text;
            Course selected = Student.findPreReqCourse(courseCode);
            if (e.Item.Checked == false)
            {

                if (user.inSchedule(selected,true))
                {
                    user.deleteCourse(selected, true);
                }
            }
            else
            {
                user.addCourse(selected, true);
                addToLV_prereq(studentListView_prereq, e.Item.SubItems[0].Text, e.Item.SubItems[1].Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text|*.txt";
            save.Title = "Save Student Schedule";

            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                StringBuilder output = new StringBuilder();
                for(int i = 0; i < user.studentCourses.Count; i++)
                {
                    output.Append(user.studentCourses[i].courseCode.ToString());
                    output.Append(',');
                }
                writer.Write(output);
                writer.Dispose();
                writer.Close();
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Filter = "Text|*.txt";
            load.Title = "Load Student Schedule";

            if(load.ShowDialog() == DialogResult.OK)
            {
                clearCalendar();
                hideAllLabs();
                user.studentCourses.Clear();

                StreamReader reader = new StreamReader(load.OpenFile());
                List<string> inputFromFile = reader.ReadToEnd().Split(',').ToList<string>();
                for(int i = 0; i< inputFromFile.Count-1; i++)
                {
                    List<Course> coursesFromFile = new List<Course>();
                    coursesFromFile = Student.findCourse(inputFromFile[i]);
                    for (int j = 0; j < coursesFromFile.Count; j++)
                    {
                        user.studentCourses.Add(coursesFromFile[j]);
                    }              
                }
                reader.Close();
                addALL();
                
            }
        }

<<<<<<< Updated upstream
=======
        private void studentListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            List<Course> selectedCourses = Student.findCourse(e.Item.SubItems[0].Text);
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Item",e.Item);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "ItemChecked Event");
            if (e.Item.SubItems[6].Text != "true")
            {
                if (e.Item.Checked == false)
                {
                    foreach (Course course in selectedCourses)
                    {
                        user.deleteCourse(course, false);
                        deleteFromCalender(course);
                    }
                    foreach (ListViewItem course in courseResults.Items)
                    {
                        if (course.SubItems[0].Text == e.Item.SubItems[0].Text)
                        {
                            course.Checked = false;
                        }
                    }
                }
            }
            e.Item.SubItems[6].Text = "false";
        }
>>>>>>> Stashed changes
    }
}
