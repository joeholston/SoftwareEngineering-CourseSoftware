namespace SoftwareEngineering
{
    partial class Form1
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchDropDown = new System.Windows.Forms.ComboBox();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.advancedSearch_Group = new System.Windows.Forms.GroupBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.ComboBox();
            this.startTime = new System.Windows.Forms.ComboBox();
            this.searchDay_Friday = new System.Windows.Forms.CheckBox();
            this.searchDay_Monday = new System.Windows.Forms.CheckBox();
            this.searchDay_Thursday = new System.Windows.Forms.CheckBox();
            this.searchDay_Tuesday = new System.Windows.Forms.CheckBox();
            this.searchDay_Wednesday = new System.Windows.Forms.CheckBox();
            this.advancedSearch = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.courseResults = new System.Windows.Forms.ListView();
            this.cCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calendarGroup = new System.Windows.Forms.GroupBox();
            this.wNight = new System.Windows.Forms.RichTextBox();
            this.tNight = new System.Windows.Forms.RichTextBox();
            this.mNight = new System.Windows.Forms.RichTextBox();
            this.r230 = new System.Windows.Forms.RichTextBox();
            this.r1 = new System.Windows.Forms.RichTextBox();
            this.t230 = new System.Windows.Forms.RichTextBox();
            this.t1 = new System.Windows.Forms.RichTextBox();
            this.r1130 = new System.Windows.Forms.RichTextBox();
            this.r10 = new System.Windows.Forms.RichTextBox();
            this.t1130 = new System.Windows.Forms.RichTextBox();
            this.r8 = new System.Windows.Forms.RichTextBox();
            this.fHeader = new System.Windows.Forms.Label();
            this.rHeader = new System.Windows.Forms.Label();
            this.wHeader = new System.Windows.Forms.Label();
            this.tHeader = new System.Windows.Forms.Label();
            this.mHeader = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.RichTextBox();
            this.w3 = new System.Windows.Forms.RichTextBox();
            this.m3 = new System.Windows.Forms.RichTextBox();
            this.f8 = new System.Windows.Forms.RichTextBox();
            this.w8 = new System.Windows.Forms.RichTextBox();
            this.t8 = new System.Windows.Forms.RichTextBox();
            this.m8 = new System.Windows.Forms.RichTextBox();
            this.f9 = new System.Windows.Forms.RichTextBox();
            this.w9 = new System.Windows.Forms.RichTextBox();
            this.m9 = new System.Windows.Forms.RichTextBox();
            this.f10 = new System.Windows.Forms.RichTextBox();
            this.w10 = new System.Windows.Forms.RichTextBox();
            this.t10 = new System.Windows.Forms.RichTextBox();
            this.m10 = new System.Windows.Forms.RichTextBox();
            this.f11 = new System.Windows.Forms.RichTextBox();
            this.w11 = new System.Windows.Forms.RichTextBox();
            this.m11 = new System.Windows.Forms.RichTextBox();
            this.f12 = new System.Windows.Forms.RichTextBox();
            this.w12 = new System.Windows.Forms.RichTextBox();
            this.m12 = new System.Windows.Forms.RichTextBox();
            this.f1 = new System.Windows.Forms.RichTextBox();
            this.w1 = new System.Windows.Forms.RichTextBox();
            this.m1 = new System.Windows.Forms.RichTextBox();
            this.f2 = new System.Windows.Forms.RichTextBox();
            this.w2 = new System.Windows.Forms.RichTextBox();
            this.m2 = new System.Windows.Forms.RichTextBox();
            this.searchGroup.SuspendLayout();
            this.advancedSearch_Group.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.calendarGroup.SuspendLayout();
            this.SuspendLayout();
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
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.advancedSearch_Group);
            this.searchGroup.Controls.Add(this.advancedSearch);
            this.searchGroup.Controls.Add(this.searchButton);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Controls.Add(this.searchDropDown);
            this.searchGroup.Location = new System.Drawing.Point(22, 12);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(727, 117);
            this.searchGroup.TabIndex = 2;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // advancedSearch_Group
            // 
            this.advancedSearch_Group.Controls.Add(this.endLabel);
            this.advancedSearch_Group.Controls.Add(this.startLabel);
            this.advancedSearch_Group.Controls.Add(this.endTime);
            this.advancedSearch_Group.Controls.Add(this.startTime);
            this.advancedSearch_Group.Controls.Add(this.searchDay_Friday);
            this.advancedSearch_Group.Controls.Add(this.searchDay_Monday);
            this.advancedSearch_Group.Controls.Add(this.searchDay_Thursday);
            this.advancedSearch_Group.Controls.Add(this.searchDay_Tuesday);
            this.advancedSearch_Group.Controls.Add(this.searchDay_Wednesday);
            this.advancedSearch_Group.Location = new System.Drawing.Point(42, 65);
            this.advancedSearch_Group.Name = "advancedSearch_Group";
            this.advancedSearch_Group.Size = new System.Drawing.Size(668, 46);
            this.advancedSearch_Group.TabIndex = 66;
            this.advancedSearch_Group.TabStop = false;
            this.advancedSearch_Group.Text = "Advanced Search";
            this.advancedSearch_Group.Visible = false;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(549, 21);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 70;
            this.endLabel.Text = "End:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(417, 21);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(32, 13);
            this.startLabel.TabIndex = 69;
            this.startLabel.Text = "Start:";
            // 
            // endTime
            // 
            this.endTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTime.FormattingEnabled = true;
            this.endTime.Items.AddRange(new object[] {
            "  8 AM",
            "  9 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "  1 PM",
            "  2 PM",
            "  3 PM",
            "  4 PM",
            "  5 PM",
            "  6 PM",
            "  7 PM",
            "  8 PM",
            "  9 PM"});
            this.endTime.Location = new System.Drawing.Point(584, 16);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(65, 21);
            this.endTime.TabIndex = 68;
            // 
            // startTime
            // 
            this.startTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTime.FormattingEnabled = true;
            this.startTime.Items.AddRange(new object[] {
            "  8 AM",
            "  9 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "  1 PM",
            "  2 PM",
            "  3 PM",
            "  4 PM",
            "  5 PM",
            "  6 PM",
            "  7 PM",
            "  8 PM",
            "  9 PM"});
            this.startTime.Location = new System.Drawing.Point(455, 16);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(65, 21);
            this.startTime.TabIndex = 67;
            // 
            // searchDay_Friday
            // 
            this.searchDay_Friday.AutoSize = true;
            this.searchDay_Friday.Checked = true;
            this.searchDay_Friday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchDay_Friday.Location = new System.Drawing.Point(339, 20);
            this.searchDay_Friday.Name = "searchDay_Friday";
            this.searchDay_Friday.Size = new System.Drawing.Size(54, 17);
            this.searchDay_Friday.TabIndex = 9;
            this.searchDay_Friday.Text = "Friday";
            this.searchDay_Friday.UseVisualStyleBackColor = true;
            // 
            // searchDay_Monday
            // 
            this.searchDay_Monday.AutoSize = true;
            this.searchDay_Monday.Checked = true;
            this.searchDay_Monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchDay_Monday.Location = new System.Drawing.Point(31, 20);
            this.searchDay_Monday.Name = "searchDay_Monday";
            this.searchDay_Monday.Size = new System.Drawing.Size(64, 17);
            this.searchDay_Monday.TabIndex = 5;
            this.searchDay_Monday.Text = "Monday";
            this.searchDay_Monday.UseVisualStyleBackColor = true;
            // 
            // searchDay_Thursday
            // 
            this.searchDay_Thursday.AutoSize = true;
            this.searchDay_Thursday.Checked = true;
            this.searchDay_Thursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchDay_Thursday.Location = new System.Drawing.Point(263, 20);
            this.searchDay_Thursday.Name = "searchDay_Thursday";
            this.searchDay_Thursday.Size = new System.Drawing.Size(70, 17);
            this.searchDay_Thursday.TabIndex = 8;
            this.searchDay_Thursday.Text = "Thursday";
            this.searchDay_Thursday.UseVisualStyleBackColor = true;
            // 
            // searchDay_Tuesday
            // 
            this.searchDay_Tuesday.AutoSize = true;
            this.searchDay_Tuesday.Checked = true;
            this.searchDay_Tuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchDay_Tuesday.Location = new System.Drawing.Point(101, 20);
            this.searchDay_Tuesday.Name = "searchDay_Tuesday";
            this.searchDay_Tuesday.Size = new System.Drawing.Size(67, 17);
            this.searchDay_Tuesday.TabIndex = 6;
            this.searchDay_Tuesday.Text = "Tuesday";
            this.searchDay_Tuesday.UseVisualStyleBackColor = true;
            // 
            // searchDay_Wednesday
            // 
            this.searchDay_Wednesday.AutoSize = true;
            this.searchDay_Wednesday.Checked = true;
            this.searchDay_Wednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchDay_Wednesday.Location = new System.Drawing.Point(174, 20);
            this.searchDay_Wednesday.Name = "searchDay_Wednesday";
            this.searchDay_Wednesday.Size = new System.Drawing.Size(83, 17);
            this.searchDay_Wednesday.TabIndex = 7;
            this.searchDay_Wednesday.Text = "Wednesday";
            this.searchDay_Wednesday.UseVisualStyleBackColor = true;
            // 
            // advancedSearch
            // 
            this.advancedSearch.AutoSize = true;
            this.advancedSearch.Location = new System.Drawing.Point(22, 64);
            this.advancedSearch.Name = "advancedSearch";
            this.advancedSearch.Size = new System.Drawing.Size(121, 17);
            this.advancedSearch.TabIndex = 4;
            this.advancedSearch.Text = "   Advanced Search";
            this.advancedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.advancedSearch.UseVisualStyleBackColor = true;
            this.advancedSearch.Click += new System.EventHandler(this.advancedSearch_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(616, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultsGroup
            // 
            this.resultsGroup.Controls.Add(this.courseResults);
            this.resultsGroup.Location = new System.Drawing.Point(769, 12);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(573, 680);
            this.resultsGroup.TabIndex = 3;
            this.resultsGroup.TabStop = false;
            this.resultsGroup.Text = "Results";
            // 
            // courseResults
            // 
            this.courseResults.CheckBoxes = true;
            this.courseResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCode,
            this.cName,
            this.cDay,
            this.cTime,
            this.cLocation,
            this.cSeats});
            this.courseResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseResults.Location = new System.Drawing.Point(8, 33);
            this.courseResults.Margin = new System.Windows.Forms.Padding(5);
            this.courseResults.Name = "courseResults";
            this.courseResults.Size = new System.Drawing.Size(557, 639);
            this.courseResults.TabIndex = 5;
            this.courseResults.UseCompatibleStateImageBehavior = false;
            this.courseResults.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.courseResults_ItemCheck);
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
            // cDay
            // 
            this.cDay.Text = "Days";
            this.cDay.Width = 55;
            // 
            // cTime
            // 
            this.cTime.Text = "Time";
            this.cTime.Width = 70;
            // 
            // cLocation
            // 
            this.cLocation.Text = "Room";
            this.cLocation.Width = 55;
            // 
            // cSeats
            // 
            this.cSeats.Text = "Seats";
            // 
            // calendarGroup
            // 
            this.calendarGroup.Controls.Add(this.wNight);
            this.calendarGroup.Controls.Add(this.tNight);
            this.calendarGroup.Controls.Add(this.mNight);
            this.calendarGroup.Controls.Add(this.r230);
            this.calendarGroup.Controls.Add(this.r1);
            this.calendarGroup.Controls.Add(this.t230);
            this.calendarGroup.Controls.Add(this.t1);
            this.calendarGroup.Controls.Add(this.r1130);
            this.calendarGroup.Controls.Add(this.r10);
            this.calendarGroup.Controls.Add(this.t1130);
            this.calendarGroup.Controls.Add(this.r8);
            this.calendarGroup.Controls.Add(this.fHeader);
            this.calendarGroup.Controls.Add(this.rHeader);
            this.calendarGroup.Controls.Add(this.wHeader);
            this.calendarGroup.Controls.Add(this.tHeader);
            this.calendarGroup.Controls.Add(this.mHeader);
            this.calendarGroup.Controls.Add(this.f3);
            this.calendarGroup.Controls.Add(this.w3);
            this.calendarGroup.Controls.Add(this.m3);
            this.calendarGroup.Controls.Add(this.f8);
            this.calendarGroup.Controls.Add(this.w8);
            this.calendarGroup.Controls.Add(this.t8);
            this.calendarGroup.Controls.Add(this.m8);
            this.calendarGroup.Controls.Add(this.f9);
            this.calendarGroup.Controls.Add(this.w9);
            this.calendarGroup.Controls.Add(this.m9);
            this.calendarGroup.Controls.Add(this.f10);
            this.calendarGroup.Controls.Add(this.w10);
            this.calendarGroup.Controls.Add(this.t10);
            this.calendarGroup.Controls.Add(this.m10);
            this.calendarGroup.Controls.Add(this.f11);
            this.calendarGroup.Controls.Add(this.w11);
            this.calendarGroup.Controls.Add(this.m11);
            this.calendarGroup.Controls.Add(this.f12);
            this.calendarGroup.Controls.Add(this.w12);
            this.calendarGroup.Controls.Add(this.m12);
            this.calendarGroup.Controls.Add(this.f1);
            this.calendarGroup.Controls.Add(this.w1);
            this.calendarGroup.Controls.Add(this.m1);
            this.calendarGroup.Controls.Add(this.f2);
            this.calendarGroup.Controls.Add(this.w2);
            this.calendarGroup.Controls.Add(this.m2);
            this.calendarGroup.Location = new System.Drawing.Point(22, 146);
            this.calendarGroup.Name = "calendarGroup";
            this.calendarGroup.Size = new System.Drawing.Size(727, 546);
            this.calendarGroup.TabIndex = 4;
            this.calendarGroup.TabStop = false;
            this.calendarGroup.Text = "Calendar";
            // 
            // wNight
            // 
            this.wNight.Location = new System.Drawing.Point(296, 490);
            this.wNight.Name = "wNight";
            this.wNight.ReadOnly = true;
            this.wNight.Size = new System.Drawing.Size(135, 48);
            this.wNight.TabIndex = 68;
            this.wNight.Tag = "6:30 - 9:00 PM";
            this.wNight.Text = "6:30 - 9:00 PM";
            // 
            // tNight
            // 
            this.tNight.Location = new System.Drawing.Point(153, 490);
            this.tNight.Name = "tNight";
            this.tNight.ReadOnly = true;
            this.tNight.Size = new System.Drawing.Size(135, 48);
            this.tNight.TabIndex = 67;
            this.tNight.Tag = "6:30 - 9:00 PM";
            this.tNight.Text = "6:30 - 9:00 PM";
            // 
            // mNight
            // 
            this.mNight.Location = new System.Drawing.Point(10, 490);
            this.mNight.Name = "mNight";
            this.mNight.ReadOnly = true;
            this.mNight.Size = new System.Drawing.Size(135, 48);
            this.mNight.TabIndex = 66;
            this.mNight.Tag = "6:30 - 9:00 PM";
            this.mNight.Text = "6:30 - 9:00 PM";
            // 
            // r230
            // 
            this.r230.Location = new System.Drawing.Point(439, 406);
            this.r230.Name = "r230";
            this.r230.ReadOnly = true;
            this.r230.Size = new System.Drawing.Size(135, 67);
            this.r230.TabIndex = 65;
            this.r230.Tag = "2:30 - 3:45 PM";
            this.r230.Text = "2:30 - 3:45 PM";
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(439, 327);
            this.r1.Name = "r1";
            this.r1.ReadOnly = true;
            this.r1.Size = new System.Drawing.Size(135, 67);
            this.r1.TabIndex = 64;
            this.r1.Tag = "1 - 2:15 PM";
            this.r1.Text = "1 - 2:15 PM";
            // 
            // t230
            // 
            this.t230.Location = new System.Drawing.Point(153, 406);
            this.t230.Name = "t230";
            this.t230.ReadOnly = true;
            this.t230.Size = new System.Drawing.Size(135, 67);
            this.t230.TabIndex = 63;
            this.t230.Tag = "2:30 - 3:45 PM";
            this.t230.Text = "2:30 - 3:45 PM";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(153, 327);
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Size = new System.Drawing.Size(135, 67);
            this.t1.TabIndex = 62;
            this.t1.Tag = "1 - 2:15 PM";
            this.t1.Text = "1 - 2:15 PM";
            // 
            // r1130
            // 
            this.r1130.Location = new System.Drawing.Point(439, 242);
            this.r1130.Name = "r1130";
            this.r1130.ReadOnly = true;
            this.r1130.Size = new System.Drawing.Size(135, 67);
            this.r1130.TabIndex = 61;
            this.r1130.Tag = "11:30 - 12:45 PM";
            this.r1130.Text = "11:30 - 12:45 PM";
            // 
            // r10
            // 
            this.r10.Location = new System.Drawing.Point(439, 166);
            this.r10.Name = "r10";
            this.r10.ReadOnly = true;
            this.r10.Size = new System.Drawing.Size(135, 67);
            this.r10.TabIndex = 60;
            this.r10.Tag = "10:05 - 11:20 AM";
            this.r10.Text = "10:05 - 11:20 AM";
            // 
            // t1130
            // 
            this.t1130.Location = new System.Drawing.Point(153, 242);
            this.t1130.Name = "t1130";
            this.t1130.ReadOnly = true;
            this.t1130.Size = new System.Drawing.Size(135, 67);
            this.t1130.TabIndex = 59;
            this.t1130.Tag = "11:30 - 12:45 PM";
            this.t1130.Text = "11:30 - 12:45 PM";
            // 
            // r8
            // 
            this.r8.Location = new System.Drawing.Point(439, 51);
            this.r8.Name = "r8";
            this.r8.ReadOnly = true;
            this.r8.Size = new System.Drawing.Size(135, 70);
            this.r8.TabIndex = 58;
            this.r8.Tag = "8 - 9:15 AM";
            this.r8.Text = "8 - 9:15 AM";
            // 
            // fHeader
            // 
            this.fHeader.AutoSize = true;
            this.fHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fHeader.Location = new System.Drawing.Point(623, 24);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(41, 13);
            this.fHeader.TabIndex = 57;
            this.fHeader.Text = "Friday";
            this.fHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rHeader
            // 
            this.rHeader.AutoSize = true;
            this.rHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rHeader.Location = new System.Drawing.Point(480, 24);
            this.rHeader.Name = "rHeader";
            this.rHeader.Size = new System.Drawing.Size(59, 13);
            this.rHeader.TabIndex = 56;
            this.rHeader.Text = "Thursday";
            // 
            // wHeader
            // 
            this.wHeader.AutoSize = true;
            this.wHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wHeader.Location = new System.Drawing.Point(332, 24);
            this.wHeader.Name = "wHeader";
            this.wHeader.Size = new System.Drawing.Size(73, 13);
            this.wHeader.TabIndex = 55;
            this.wHeader.Text = "Wednesday";
            // 
            // tHeader
            // 
            this.tHeader.AutoSize = true;
            this.tHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHeader.Location = new System.Drawing.Point(196, 24);
            this.tHeader.Name = "tHeader";
            this.tHeader.Size = new System.Drawing.Size(55, 13);
            this.tHeader.TabIndex = 54;
            this.tHeader.Text = "Tuesday";
            // 
            // mHeader
            // 
            this.mHeader.AutoSize = true;
            this.mHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHeader.Location = new System.Drawing.Point(54, 24);
            this.mHeader.Name = "mHeader";
            this.mHeader.Size = new System.Drawing.Size(51, 13);
            this.mHeader.TabIndex = 53;
            this.mHeader.Text = "Monday";
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(582, 431);
            this.f3.Name = "f3";
            this.f3.ReadOnly = true;
            this.f3.Size = new System.Drawing.Size(135, 48);
            this.f3.TabIndex = 52;
            this.f3.Tag = "3 PM";
            this.f3.Text = "3 PM";
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(296, 437);
            this.w3.Name = "w3";
            this.w3.ReadOnly = true;
            this.w3.Size = new System.Drawing.Size(135, 48);
            this.w3.TabIndex = 50;
            this.w3.Tag = "3 PM";
            this.w3.Text = "3 PM";
            // 
            // m3
            // 
            this.m3.Location = new System.Drawing.Point(10, 437);
            this.m3.Name = "m3";
            this.m3.ReadOnly = true;
            this.m3.Size = new System.Drawing.Size(135, 48);
            this.m3.TabIndex = 48;
            this.m3.Tag = "3 PM";
            this.m3.Text = "3 PM";
            // 
            // f8
            // 
            this.f8.Location = new System.Drawing.Point(582, 51);
            this.f8.Name = "f8";
            this.f8.ReadOnly = true;
            this.f8.Size = new System.Drawing.Size(135, 48);
            this.f8.TabIndex = 42;
            this.f8.Tag = "8 AM";
            this.f8.Text = "8 AM";
            // 
            // w8
            // 
            this.w8.Location = new System.Drawing.Point(296, 51);
            this.w8.Name = "w8";
            this.w8.ReadOnly = true;
            this.w8.Size = new System.Drawing.Size(135, 48);
            this.w8.TabIndex = 40;
            this.w8.Tag = "8 AM";
            this.w8.Text = "8 AM";
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(153, 51);
            this.t8.Name = "t8";
            this.t8.ReadOnly = true;
            this.t8.Size = new System.Drawing.Size(135, 70);
            this.t8.TabIndex = 39;
            this.t8.Tag = "8 - 9:15 AM";
            this.t8.Text = "8 - 9:15 AM";
            // 
            // m8
            // 
            this.m8.Location = new System.Drawing.Point(10, 51);
            this.m8.Name = "m8";
            this.m8.ReadOnly = true;
            this.m8.Size = new System.Drawing.Size(135, 48);
            this.m8.TabIndex = 38;
            this.m8.Tag = "8 AM";
            this.m8.Text = "8 AM";
            // 
            // f9
            // 
            this.f9.Location = new System.Drawing.Point(582, 107);
            this.f9.Name = "f9";
            this.f9.ReadOnly = true;
            this.f9.Size = new System.Drawing.Size(135, 48);
            this.f9.TabIndex = 37;
            this.f9.Tag = "9 AM";
            this.f9.Text = "9 AM";
            // 
            // w9
            // 
            this.w9.Location = new System.Drawing.Point(296, 107);
            this.w9.Name = "w9";
            this.w9.ReadOnly = true;
            this.w9.Size = new System.Drawing.Size(135, 48);
            this.w9.TabIndex = 35;
            this.w9.Tag = "9 AM";
            this.w9.Text = "9 AM";
            // 
            // m9
            // 
            this.m9.Location = new System.Drawing.Point(10, 107);
            this.m9.Name = "m9";
            this.m9.ReadOnly = true;
            this.m9.Size = new System.Drawing.Size(135, 48);
            this.m9.TabIndex = 33;
            this.m9.Tag = "9 AM";
            this.m9.Text = "9 AM";
            // 
            // f10
            // 
            this.f10.Location = new System.Drawing.Point(582, 161);
            this.f10.Name = "f10";
            this.f10.ReadOnly = true;
            this.f10.Size = new System.Drawing.Size(135, 48);
            this.f10.TabIndex = 32;
            this.f10.Tag = "10 AM";
            this.f10.Text = "10 AM";
            // 
            // w10
            // 
            this.w10.Location = new System.Drawing.Point(295, 162);
            this.w10.Name = "w10";
            this.w10.ReadOnly = true;
            this.w10.Size = new System.Drawing.Size(135, 48);
            this.w10.TabIndex = 30;
            this.w10.Tag = "10 AM";
            this.w10.Text = "10 AM";
            // 
            // t10
            // 
            this.t10.Location = new System.Drawing.Point(153, 166);
            this.t10.Name = "t10";
            this.t10.ReadOnly = true;
            this.t10.Size = new System.Drawing.Size(135, 67);
            this.t10.TabIndex = 29;
            this.t10.Tag = "10:05 - 11:20 AM";
            this.t10.Text = "10:05 - 11:20 AM";
            // 
            // m10
            // 
            this.m10.Location = new System.Drawing.Point(10, 162);
            this.m10.Name = "m10";
            this.m10.ReadOnly = true;
            this.m10.Size = new System.Drawing.Size(135, 48);
            this.m10.TabIndex = 28;
            this.m10.Tag = "10 AM";
            this.m10.Text = "10 AM";
            // 
            // f11
            // 
            this.f11.Location = new System.Drawing.Point(582, 215);
            this.f11.Name = "f11";
            this.f11.ReadOnly = true;
            this.f11.Size = new System.Drawing.Size(135, 48);
            this.f11.TabIndex = 27;
            this.f11.Tag = "11 AM";
            this.f11.Text = "11 AM";
            // 
            // w11
            // 
            this.w11.Location = new System.Drawing.Point(295, 217);
            this.w11.Name = "w11";
            this.w11.ReadOnly = true;
            this.w11.Size = new System.Drawing.Size(135, 48);
            this.w11.TabIndex = 25;
            this.w11.Tag = "11 AM";
            this.w11.Text = "11 AM";
            // 
            // m11
            // 
            this.m11.Location = new System.Drawing.Point(10, 217);
            this.m11.Name = "m11";
            this.m11.ReadOnly = true;
            this.m11.Size = new System.Drawing.Size(135, 48);
            this.m11.TabIndex = 23;
            this.m11.Tag = "11 AM";
            this.m11.Text = "11 AM";
            // 
            // f12
            // 
            this.f12.Location = new System.Drawing.Point(582, 269);
            this.f12.Name = "f12";
            this.f12.ReadOnly = true;
            this.f12.Size = new System.Drawing.Size(135, 48);
            this.f12.TabIndex = 22;
            this.f12.Tag = "12 PM";
            this.f12.Text = "12 PM";
            // 
            // w12
            // 
            this.w12.Location = new System.Drawing.Point(296, 272);
            this.w12.Name = "w12";
            this.w12.ReadOnly = true;
            this.w12.Size = new System.Drawing.Size(135, 48);
            this.w12.TabIndex = 20;
            this.w12.Tag = "12 PM";
            this.w12.Text = "12 PM";
            // 
            // m12
            // 
            this.m12.Location = new System.Drawing.Point(10, 272);
            this.m12.Name = "m12";
            this.m12.ReadOnly = true;
            this.m12.Size = new System.Drawing.Size(135, 48);
            this.m12.TabIndex = 18;
            this.m12.Tag = "12 PM";
            this.m12.Text = "12 PM";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(582, 323);
            this.f1.Name = "f1";
            this.f1.ReadOnly = true;
            this.f1.Size = new System.Drawing.Size(135, 48);
            this.f1.TabIndex = 17;
            this.f1.Tag = "1 PM";
            this.f1.Text = "1 PM";
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(295, 327);
            this.w1.Name = "w1";
            this.w1.ReadOnly = true;
            this.w1.Size = new System.Drawing.Size(135, 48);
            this.w1.TabIndex = 15;
            this.w1.Tag = "1 PM";
            this.w1.Text = "1 PM";
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(10, 327);
            this.m1.Name = "m1";
            this.m1.ReadOnly = true;
            this.m1.Size = new System.Drawing.Size(135, 48);
            this.m1.TabIndex = 13;
            this.m1.Tag = "1 PM";
            this.m1.Text = "1 PM";
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(582, 377);
            this.f2.Name = "f2";
            this.f2.ReadOnly = true;
            this.f2.Size = new System.Drawing.Size(135, 48);
            this.f2.TabIndex = 12;
            this.f2.Tag = "2 PM";
            this.f2.Text = "2 PM";
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(295, 382);
            this.w2.Name = "w2";
            this.w2.ReadOnly = true;
            this.w2.Size = new System.Drawing.Size(135, 48);
            this.w2.TabIndex = 10;
            this.w2.Tag = "2 PM";
            this.w2.Text = "2 PM";
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(10, 382);
            this.m2.Name = "m2";
            this.m2.ReadOnly = true;
            this.m2.Size = new System.Drawing.Size(135, 48);
            this.m2.TabIndex = 8;
            this.m2.Tag = "2 PM";
            this.m2.Text = "2 PM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 704);
            this.Controls.Add(this.calendarGroup);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.searchGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.advancedSearch_Group.ResumeLayout(false);
            this.advancedSearch_Group.PerformLayout();
            this.resultsGroup.ResumeLayout(false);
            this.calendarGroup.ResumeLayout(false);
            this.calendarGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchDropDown;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.GroupBox resultsGroup;
        private System.Windows.Forms.GroupBox calendarGroup;
        private System.Windows.Forms.RichTextBox f3;
        private System.Windows.Forms.RichTextBox w3;
        private System.Windows.Forms.RichTextBox m3;
        private System.Windows.Forms.RichTextBox f8;
        private System.Windows.Forms.RichTextBox w8;
        private System.Windows.Forms.RichTextBox t8;
        private System.Windows.Forms.RichTextBox m8;
        private System.Windows.Forms.RichTextBox f9;
        private System.Windows.Forms.RichTextBox w9;
        private System.Windows.Forms.RichTextBox m9;
        private System.Windows.Forms.RichTextBox f10;
        private System.Windows.Forms.RichTextBox w10;
        private System.Windows.Forms.RichTextBox t10;
        private System.Windows.Forms.RichTextBox m10;
        private System.Windows.Forms.RichTextBox f11;
        private System.Windows.Forms.RichTextBox w11;
        private System.Windows.Forms.RichTextBox m11;
        private System.Windows.Forms.RichTextBox f12;
        private System.Windows.Forms.RichTextBox w12;
        private System.Windows.Forms.RichTextBox m12;
        private System.Windows.Forms.RichTextBox f1;
        private System.Windows.Forms.RichTextBox w1;
        private System.Windows.Forms.RichTextBox m1;
        private System.Windows.Forms.RichTextBox f2;
        private System.Windows.Forms.RichTextBox w2;
        private System.Windows.Forms.RichTextBox m2;
        private System.Windows.Forms.Label fHeader;
        private System.Windows.Forms.Label rHeader;
        private System.Windows.Forms.Label wHeader;
        private System.Windows.Forms.Label tHeader;
        private System.Windows.Forms.Label mHeader;
        private System.Windows.Forms.RichTextBox r8;
        private System.Windows.Forms.RichTextBox r230;
        private System.Windows.Forms.RichTextBox r1;
        private System.Windows.Forms.RichTextBox t230;
        private System.Windows.Forms.RichTextBox t1;
        private System.Windows.Forms.RichTextBox r1130;
        private System.Windows.Forms.RichTextBox r10;
        private System.Windows.Forms.RichTextBox t1130;
        private System.Windows.Forms.ListView courseResults;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader cCode;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cDay;
        private System.Windows.Forms.ColumnHeader cLocation;
        private System.Windows.Forms.ColumnHeader cSeats;
        private System.Windows.Forms.ColumnHeader cTime;
        private System.Windows.Forms.CheckBox advancedSearch;
        private System.Windows.Forms.CheckBox searchDay_Monday;
        private System.Windows.Forms.CheckBox searchDay_Tuesday;
        private System.Windows.Forms.CheckBox searchDay_Wednesday;
        private System.Windows.Forms.CheckBox searchDay_Thursday;
        private System.Windows.Forms.CheckBox searchDay_Friday;
        private System.Windows.Forms.GroupBox advancedSearch_Group;
        private System.Windows.Forms.ComboBox endTime;
        private System.Windows.Forms.ComboBox startTime;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.RichTextBox wNight;
        private System.Windows.Forms.RichTextBox tNight;
        private System.Windows.Forms.RichTextBox mNight;
    }
}

