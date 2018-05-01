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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            searchDropDown.SelectedIndex = 0;
            createLV_courseResults();
            createLV_student();
        }

        //createLV creates the List View with the desired preset settings
        private void createLV_courseResults()
        {
            courseResults.View = View.Details;
            courseResults.GridLines = true;
            courseResults.FullRowSelect = true;

            courseResults.CheckBoxes = true;
        }

        private void createLV_student()
        {
            studentListView.View = View.Details;
            studentListView.GridLines = true;
            studentListView.FullRowSelect = true;

            studentListView.CheckBoxes = true;
        }

        private void addToLV(ListView lv, string code, string name)
        {
            ListViewItem itm;
            string[] arr = new string[6];
            arr[0] = code;
            arr[1] = name;
            itm = new ListViewItem(arr);
            //itm.Checked = selected;
            lv.Items.Add(itm);
        }

        private void search()
        {
            courseResults.Items.Clear();
            string searchString = searchBox.Text;
            Search s = new Search();

            s.searchPrereq(searchString, searchDropDown.SelectedIndex);
           
            if (s.prereqCourses.Count != 0)
            {
                for (int i = 0; i < s.prereqCourses.Count; i++)
                {
                    Course c = s.prereqCourses[i];
                    string newTime = appendTime(c.beginTime);
                    //bool selected = user.inSchedule(c.courseCode);
                    addToLV(courseResults, c.courseCode, c.LongTitle);
                }
            }
            else
            {
                MessageBox.Show("No Results: Please Search Again.", "", MessageBoxButtons.OK);
                searchBox.Focus();
                searchBox.SelectionStart = 0;
                searchBox.SelectionLength = searchBox.Text.Length;
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private string appendTime(DateTime originalTime)
        {
            string newTime = originalTime.ToString("hh:mm tt");
            return newTime;
        }

        private void courseResults_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == false)
            {
                
            }
            else
            {
                addToLV(studentListView, e.Item.SubItems[0].Text, e.Item.SubItems[1].Text);
            }
        }
    }
}
