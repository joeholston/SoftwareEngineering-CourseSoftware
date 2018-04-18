using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoftwareEngineering
{
    public class BuildDB
    {
        private static BuildDB instance;
        public List<Course> prereqDatabase { get; set; }
        public List<Course> courseDatabase { get; set; }
        private BuildDB() 
        {
            List<Course> courseDB = new List<Course>();
            List<Course> prereqDB = new List<Course>();
            using (StreamReader reader = new StreamReader("CourseDB_WithFictionalCapacities.csv"))
            {
                var line = reader.ReadLine();
                //int j = -1;
                while (!reader.EndOfStream)
                {
                    //j++;
                    line = reader.ReadLine();
                    string[] inputs = line.Split(';');
                    int numInputs = inputs.Length;
                    for (int i = 0; i < numInputs; i++)
                    {
                        //Console.Write(values[i]);
                        //Console.Write("\r\n");
                        if (inputs[i] == "NULL")
                        {
                            inputs[i] = null;
                        }
                    }
                    DateTime value3;
                    DateTime value4;
                    if (inputs[3] == null)
                    {
                        value3 = DateTime.MinValue;
                        value4 = DateTime.MinValue;
                    }
                    else
                    {
                        value3 = DateTime.Parse(inputs[3]);
                        value4 = DateTime.Parse(inputs[4]);
                    }

                    List<String> prereqs = new List<String>();
                    if(numInputs > 10)
                    {
                        int incrementor = numInputs;
                        while (incrementor != 10)
                        {
                            incrementor--;
                            prereqs.Add(inputs[incrementor]);                            
                        }
                    }
                    courseDB.Add(new Course(inputs[0], inputs[1], inputs[2], value3, value4, inputs[5], inputs[6], inputs[7], int.Parse(inputs[8]), int.Parse(inputs[9]), prereqs));
                    prereqDB.Add(new Course(inputs[0].Substring(0,8), inputs[1], inputs[2]));
                    //Console.Write(courseDB[j].courseCode + "\r\n" + courseDB[j].beginTime + "\r\n" + courseDB[j].capacity + "\r\n");
                }
                courseDatabase = courseDB;
                prereqDatabase = prereqDB;
                reader.Close();
            }
        }
        public static BuildDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BuildDB();
                }
                return instance;
            }
        }
    }
}
