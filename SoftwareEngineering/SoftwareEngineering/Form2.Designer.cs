namespace SoftwareEngineering
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarGroup = new System.Windows.Forms.GroupBox();
            this.studentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.courseResults = new System.Windows.Forms.ListView();
            this.cCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchDropDown = new System.Windows.Forms.ComboBox();
            this.calendarGroup.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarGroup
            // 
            this.calendarGroup.Controls.Add(this.studentListView);
            this.calendarGroup.Location = new System.Drawing.Point(17, 92);
            this.calendarGroup.Name = "calendarGroup";
            this.calendarGroup.Size = new System.Drawing.Size(727, 584);
            this.calendarGroup.TabIndex = 7;
            this.calendarGroup.TabStop = false;
            this.calendarGroup.Text = "Calendar";
            // 
            // studentListView
            // 
            this.studentListView.CheckBoxes = true;
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.studentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListView.Location = new System.Drawing.Point(8, 21);
            this.studentListView.Margin = new System.Windows.Forms.Padding(5);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(711, 555);
            this.studentListView.TabIndex = 6;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Code";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            this.columnHeader2.Width = 200;
            // 
            // resultsGroup
            // 
            this.resultsGroup.Controls.Add(this.courseResults);
            this.resultsGroup.Location = new System.Drawing.Point(772, 21);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(573, 655);
            this.resultsGroup.TabIndex = 6;
            this.resultsGroup.TabStop = false;
            this.resultsGroup.Text = "Results";
            // 
            // courseResults
            // 
            this.courseResults.CheckBoxes = true;
            this.courseResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCode,
            this.cName});
            this.courseResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseResults.Location = new System.Drawing.Point(8, 21);
            this.courseResults.Margin = new System.Windows.Forms.Padding(5);
            this.courseResults.Name = "courseResults";
            this.courseResults.Size = new System.Drawing.Size(557, 626);
            this.courseResults.TabIndex = 5;
            this.courseResults.UseCompatibleStateImageBehavior = false;
            this.courseResults.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.courseResults_ItemChecked);
            // 
            // cCode
            // 
            this.cCode.Text = "Course Code";
            this.cCode.Width = 110;
            // 
            // cName
            // 
            this.cName.Text = "Course Name";
            this.cName.Width = 200;
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.searchButton);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Controls.Add(this.searchDropDown);
            this.searchGroup.Location = new System.Drawing.Point(17, 21);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(727, 65);
            this.searchGroup.TabIndex = 5;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(616, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(144, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(427, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // searchDropDown
            // 
            this.searchDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchDropDown.FormattingEnabled = true;
            this.searchDropDown.Items.AddRange(new object[] {
            "Course Code",
            "Course Name"});
            this.searchDropDown.Location = new System.Drawing.Point(22, 25);
            this.searchDropDown.Name = "searchDropDown";
            this.searchDropDown.Size = new System.Drawing.Size(102, 21);
            this.searchDropDown.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 704);
            this.Controls.Add(this.calendarGroup);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.searchGroup);
            this.Name = "Form2";
            this.Text = "GCC++: Add Completed Courses";
            this.calendarGroup.ResumeLayout(false);
            this.resultsGroup.ResumeLayout(false);
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calendarGroup;
        private System.Windows.Forms.GroupBox resultsGroup;
        private System.Windows.Forms.ListView courseResults;
        private System.Windows.Forms.ColumnHeader cCode;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchDropDown;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}