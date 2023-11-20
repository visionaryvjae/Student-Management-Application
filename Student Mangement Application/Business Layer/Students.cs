using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mangement_Application.Presentation_Layer
{
    internal class Students
    {
        public string username { get; set; }
        public string password { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentIMG { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Students(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Students(string studentNumber, string studentName, string studentIMG, DateTime dOB, string phone, string address) : this(studentNumber, studentName)
        {
            StudentIMG = studentIMG;
            DOB = dOB;
            Phone = phone;
            Address = address;
        }
    }
}
