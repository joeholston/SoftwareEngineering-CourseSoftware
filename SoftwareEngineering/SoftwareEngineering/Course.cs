using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    class Course
    {
        public Course(string cc, string sT, string lT, DateTime bT, DateTime eT, string mD, string b, string r, int e, int c)
        {
            courseCode = cc;
            shortTitle = sT;
            LongTitle = lT;
            beginTime = bT;
            endTime = eT;
            meetingDays = mD;
            building = b;
            room = r;
            enrollment = e;
            capacity = c;
        }
        public string courseCode {get;set;}
        public string shortTitle { get; set; }
        public string LongTitle { get; set; }
        public DateTime beginTime { get; set; }
        public DateTime endTime { get; set; }
        public string meetingDays { get; set; }
        public string building { get; set; }
        public string room { get; set; }
        public int enrollment { get; set; }
        public int capacity { get; set; }
    }
}
