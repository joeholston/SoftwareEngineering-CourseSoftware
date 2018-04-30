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

        private void addToLV(string code, string name, bool selected)
        {
            ListViewItem itm;
            string[] arr = new string[6];
            arr[0] = code;
            arr[1] = name;
            itm = new ListViewItem(arr);
            itm.Checked = selected;
            courseResults.Items.Add(itm);
        }
    }
}
