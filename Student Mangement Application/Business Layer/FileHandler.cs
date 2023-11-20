using Student_Mangement_Application.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mangement_Application.Data_Layer
{
    internal class FileHandler
    {
        public List<Students> format()
        {
            FileStore fs = new FileStore();
            List<Students> list = new List<Students>();
            foreach (var line in fs.ReadFromFile())
            {
                string[] item = line.Split(';');
                if (item.Length == 2)
                {
                    list.Add(new Students(item[0], item[1]));
                }
            }
            return list;
        }

        public Boolean checkIfValidUser(string user, string pass, List<Students> StudentsList)
        {
            bool isValid = false;
            foreach (Students student in StudentsList)
            {
                if ((user == student.username) && (pass == student.password))
                {
                    isValid = true;
                }
            }

            if (isValid)
            {
                MessageBox.Show($"Welcome User: {user}", "Information", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Information", MessageBoxButtons.OK);
            }

            return isValid;
        }
    }
}
