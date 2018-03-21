using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoftwareEngineering
{
    class BuildDB
    {
        public List<Course> buildDB()
        {
            List<Course> courseDB = new List<Course>();
            using (StreamReader reader = new StreamReader("CourseDB_WithFictionalCapacities.csv"))
            {
                var line = reader.ReadLine();
                int j = -1;
                while (!reader.EndOfStream)
                {
                    j++;
                    line = reader.ReadLine();
                    string[] values = line.Split(';');
                    for (int i = 0; i < values.Length; i++)
                    {
                        Console.Write(values[i]);
                        Console.Write("\r\n");
                        if(values[i] == "NULL")
                        {
                            values[i] = null;
                        }
                    }
                    DateTime value3;
                    DateTime value4;
                    if (values[3] == null)
                    {
                        value3 = DateTime.MinValue;
                        value4 = DateTime.MinValue;
                    }
                    else
                    {
                        value3 = DateTime.Parse(values[3]);
                        value4 = DateTime.Parse(values[4]);
                    }
                    courseDB.Add(new Course(values[0], values[1], values[2], value3, value4, values[5], values[6], values[7], int.Parse(values[8]), int.Parse(values[9])));
                    Console.Write(courseDB[j].courseCode + "\r\n" + courseDB[j].beginTime + "\r\n" + courseDB[j].capacity + "\r\n");
                }
            }
            return courseDB;
        }
    }
}
