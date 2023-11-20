using Student_Mangement_Application.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mangement_Application.Data_Layer
{
    internal class FileStore
    {
        public string textfile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "studentsLD.txt");
        public List<string> ReadFromFile()
        {
            List<string> data = new List<string>();
            data = File.ReadAllLines(textfile).ToList();
            return data;

        }

        public void WriteToFile(List<Students> students)
        {
            using (StreamWriter writer = new StreamWriter(textfile))
            {
                foreach (Students student in students)
                {
                    writer.WriteLine($"{student.username};{student.password}");
                }
            }

            //File.WriteAllLines(textfile, $"{users.userName}-{users.password}");

            MessageBox.Show("Written to file successfully. Please Check bin/debug folder");

        }

        public void WriteToFile(List<string> students)
        {
            using (StreamWriter writer = new StreamWriter(textfile))
            {
                foreach (string student in students)
                {
                    writer.WriteLine(student);
                }
            }

            //File.WriteAllLines(textfile, $"{users.userName}-{users.password}");

            MessageBox.Show("Written to file successfully. Please Check bin/debug folder");

        }
    }
}
