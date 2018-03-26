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
            this.searchButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.courseResults = new System.Windows.Forms.ListView();
            this.cCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calendarGroup = new System.Windows.Forms.GroupBox();
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
            this.cTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchGroup.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.calendarGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(147, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(427, 20);
            this.searchBox.TabIndex = 0;
            // 
            // searchDropDown
            // 
            this.searchDropDown.FormattingEnabled = true;
            this.searchDropDown.Items.AddRange(new object[] {
            "Course Code"});
            this.searchDropDown.Location = new System.Drawing.Point(22, 30);
            this.searchDropDown.Name = "searchDropDown";
            this.searchDropDown.Size = new System.Drawing.Size(102, 21);
            this.searchDropDown.TabIndex = 1;
            this.searchDropDown.Text = "Course Code";
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.searchButton);
            this.searchGroup.Controls.Add(this.dateTimePicker);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Controls.Add(this.searchDropDown);
            this.searchGroup.Location = new System.Drawing.Point(12, 12);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(595, 111);
            this.searchGroup.TabIndex = 2;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(499, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(22, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Visible = false;
            // 
            // resultsGroup
            // 
            this.resultsGroup.Controls.Add(this.courseResults);
            this.resultsGroup.Location = new System.Drawing.Point(613, 12);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(466, 600);
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
            this.courseResults.Location = new System.Drawing.Point(6, 31);
            this.courseResults.Margin = new System.Windows.Forms.Padding(5);
            this.courseResults.Name = "courseResults";
            this.courseResults.Size = new System.Drawing.Size(454, 563);
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
            this.cName.Width = 140;
            // 
            // cDay
            // 
            this.cDay.Text = "Days";
            this.cDay.Width = 50;
            // 
            // cLocation
            // 
            this.cLocation.Text = "Room";
            this.cLocation.Width = 50;
            // 
            // cSeats
            // 
            this.cSeats.Text = "Seats";
            // 
            // calendarGroup
            // 
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
            this.calendarGroup.Location = new System.Drawing.Point(12, 129);
            this.calendarGroup.Name = "calendarGroup";
            this.calendarGroup.Size = new System.Drawing.Size(595, 483);
            this.calendarGroup.TabIndex = 4;
            this.calendarGroup.TabStop = false;
            this.calendarGroup.Text = "Calendar";
            // 
            // r230
            // 
            this.r230.Location = new System.Drawing.Point(360, 405);
            this.r230.Name = "r230";
            this.r230.Size = new System.Drawing.Size(107, 67);
            this.r230.TabIndex = 65;
            this.r230.Text = "2:30 - 3:45 PM";
            // 
            // r1
            // 
            this.r1.Location = new System.Drawing.Point(360, 326);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(107, 67);
            this.r1.TabIndex = 64;
            this.r1.Text = "1 - 2:15 PM";
            // 
            // t230
            // 
            this.t230.Location = new System.Drawing.Point(124, 405);
            this.t230.Name = "t230";
            this.t230.Size = new System.Drawing.Size(107, 67);
            this.t230.TabIndex = 63;
            this.t230.Text = "2:30 - 3:45 PM";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(124, 326);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(107, 67);
            this.t1.TabIndex = 62;
            this.t1.Text = "1 - 2:15 PM";
            // 
            // r1130
            // 
            this.r1130.Location = new System.Drawing.Point(360, 238);
            this.r1130.Name = "r1130";
            this.r1130.Size = new System.Drawing.Size(107, 67);
            this.r1130.TabIndex = 61;
            this.r1130.Text = "11:30 - 12:45 PM";
            // 
            // r10
            // 
            this.r10.Location = new System.Drawing.Point(360, 165);
            this.r10.Name = "r10";
            this.r10.Size = new System.Drawing.Size(107, 67);
            this.r10.TabIndex = 60;
            this.r10.Text = "10:05 - 11:20 AM";
            // 
            // t1130
            // 
            this.t1130.Location = new System.Drawing.Point(124, 238);
            this.t1130.Name = "t1130";
            this.t1130.Size = new System.Drawing.Size(107, 67);
            this.t1130.TabIndex = 59;
            this.t1130.Text = "11:30 - 12:45 PM";
            // 
            // r8
            // 
            this.r8.Location = new System.Drawing.Point(362, 51);
            this.r8.Name = "r8";
            this.r8.Size = new System.Drawing.Size(107, 67);
            this.r8.TabIndex = 58;
            this.r8.Text = "8 - 9:15AM";
            // 
            // fHeader
            // 
            this.fHeader.AutoSize = true;
            this.fHeader.Location = new System.Drawing.Point(516, 24);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(35, 13);
            this.fHeader.TabIndex = 57;
            this.fHeader.Text = "Friday";
            this.fHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rHeader
            // 
            this.rHeader.AutoSize = true;
            this.rHeader.Location = new System.Drawing.Point(390, 24);
            this.rHeader.Name = "rHeader";
            this.rHeader.Size = new System.Drawing.Size(51, 13);
            this.rHeader.TabIndex = 56;
            this.rHeader.Text = "Thursday";
            // 
            // wHeader
            // 
            this.wHeader.AutoSize = true;
            this.wHeader.Location = new System.Drawing.Point(265, 24);
            this.wHeader.Name = "wHeader";
            this.wHeader.Size = new System.Drawing.Size(64, 13);
            this.wHeader.TabIndex = 55;
            this.wHeader.Text = "Wednesday";
            // 
            // tHeader
            // 
            this.tHeader.AutoSize = true;
            this.tHeader.Location = new System.Drawing.Point(155, 24);
            this.tHeader.Name = "tHeader";
            this.tHeader.Size = new System.Drawing.Size(48, 13);
            this.tHeader.TabIndex = 54;
            this.tHeader.Text = "Tuesday";
            // 
            // mHeader
            // 
            this.mHeader.AutoSize = true;
            this.mHeader.Location = new System.Drawing.Point(39, 24);
            this.mHeader.Name = "mHeader";
            this.mHeader.Size = new System.Drawing.Size(45, 13);
            this.mHeader.TabIndex = 53;
            this.mHeader.Text = "Monday";
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(480, 429);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(107, 48);
            this.f3.TabIndex = 52;
            this.f3.Text = "3 PM";
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(243, 436);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(107, 48);
            this.w3.TabIndex = 50;
            this.w3.Text = "3 PM";
            // 
            // m3
            // 
            this.m3.Location = new System.Drawing.Point(6, 436);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(107, 48);
            this.m3.TabIndex = 48;
            this.m3.Text = "3 PM";
            // 
            // f8
            // 
            this.f8.Location = new System.Drawing.Point(480, 51);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(107, 48);
            this.f8.TabIndex = 42;
            this.f8.Text = "8 AM";
            // 
            // w8
            // 
            this.w8.Location = new System.Drawing.Point(244, 51);
            this.w8.Name = "w8";
            this.w8.Size = new System.Drawing.Size(107, 48);
            this.w8.TabIndex = 40;
            this.w8.Text = "8 AM";
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(126, 51);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(107, 67);
            this.t8.TabIndex = 39;
            this.t8.Text = "8 - 9:15 AM";
            // 
            // m8
            // 
            this.m8.Location = new System.Drawing.Point(8, 51);
            this.m8.Name = "m8";
            this.m8.Size = new System.Drawing.Size(107, 48);
            this.m8.TabIndex = 38;
            this.m8.Text = "8 AM";
            // 
            // f9
            // 
            this.f9.Location = new System.Drawing.Point(480, 105);
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size(107, 48);
            this.f9.TabIndex = 37;
            this.f9.Text = "9 AM";
            // 
            // w9
            // 
            this.w9.Location = new System.Drawing.Point(243, 106);
            this.w9.Name = "w9";
            this.w9.Size = new System.Drawing.Size(107, 48);
            this.w9.TabIndex = 35;
            this.w9.Text = "9 AM";
            // 
            // m9
            // 
            this.m9.Location = new System.Drawing.Point(6, 106);
            this.m9.Name = "m9";
            this.m9.Size = new System.Drawing.Size(107, 48);
            this.m9.TabIndex = 33;
            this.m9.Text = "9 AM";
            // 
            // f10
            // 
            this.f10.Location = new System.Drawing.Point(478, 159);
            this.f10.Name = "f10";
            this.f10.Size = new System.Drawing.Size(107, 48);
            this.f10.TabIndex = 32;
            this.f10.Text = "10 AM";
            // 
            // w10
            // 
            this.w10.Location = new System.Drawing.Point(242, 161);
            this.w10.Name = "w10";
            this.w10.Size = new System.Drawing.Size(107, 48);
            this.w10.TabIndex = 30;
            this.w10.Text = "10 AM";
            // 
            // t10
            // 
            this.t10.Location = new System.Drawing.Point(124, 165);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(107, 67);
            this.t10.TabIndex = 29;
            this.t10.Text = "10:05 - 11:20 AM";
            // 
            // m10
            // 
            this.m10.Location = new System.Drawing.Point(6, 161);
            this.m10.Name = "m10";
            this.m10.Size = new System.Drawing.Size(107, 48);
            this.m10.TabIndex = 28;
            this.m10.Text = "10 AM";
            // 
            // f11
            // 
            this.f11.Location = new System.Drawing.Point(478, 213);
            this.f11.Name = "f11";
            this.f11.Size = new System.Drawing.Size(107, 48);
            this.f11.TabIndex = 27;
            this.f11.Text = "11 AM";
            // 
            // w11
            // 
            this.w11.Location = new System.Drawing.Point(242, 216);
            this.w11.Name = "w11";
            this.w11.Size = new System.Drawing.Size(107, 48);
            this.w11.TabIndex = 25;
            this.w11.Text = "11 AM";
            // 
            // m11
            // 
            this.m11.Location = new System.Drawing.Point(6, 216);
            this.m11.Name = "m11";
            this.m11.Size = new System.Drawing.Size(107, 48);
            this.m11.TabIndex = 23;
            this.m11.Text = "11 AM";
            // 
            // f12
            // 
            this.f12.Location = new System.Drawing.Point(480, 267);
            this.f12.Name = "f12";
            this.f12.Size = new System.Drawing.Size(107, 48);
            this.f12.TabIndex = 22;
            this.f12.Text = "12 PM";
            // 
            // w12
            // 
            this.w12.Location = new System.Drawing.Point(243, 271);
            this.w12.Name = "w12";
            this.w12.Size = new System.Drawing.Size(107, 48);
            this.w12.TabIndex = 20;
            this.w12.Text = "12 PM";
            // 
            // m12
            // 
            this.m12.Location = new System.Drawing.Point(6, 271);
            this.m12.Name = "m12";
            this.m12.Size = new System.Drawing.Size(107, 48);
            this.m12.TabIndex = 18;
            this.m12.Text = "12 PM";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(478, 321);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(107, 48);
            this.f1.TabIndex = 17;
            this.f1.Text = "1 PM";
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(242, 326);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(107, 48);
            this.w1.TabIndex = 15;
            this.w1.Text = "1 PM";
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(6, 326);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(107, 48);
            this.m1.TabIndex = 13;
            this.m1.Text = "1 PM";
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(478, 375);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(107, 48);
            this.f2.TabIndex = 12;
            this.f2.Text = "2 PM";
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(242, 381);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(107, 48);
            this.w2.TabIndex = 10;
            this.w2.Text = "2 PM";
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(6, 381);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(107, 48);
            this.m2.TabIndex = 8;
            this.m2.Text = "2 PM";
            // 
            // cTime
            // 
            this.cTime.Text = "Time";
            this.cTime.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 624);
            this.Controls.Add(this.calendarGroup);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.searchGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.resultsGroup.ResumeLayout(false);
            this.calendarGroup.ResumeLayout(false);
            this.calendarGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchDropDown;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
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
    }
}

