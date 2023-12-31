﻿using System;
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
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ModuleCode { get; set; }

        public Students(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Students(string studentName, string studentIMG, DateTime dOB, string gender, string phone, string address, string moduleCode)
        {
            StudentName = studentName;
            StudentIMG = studentIMG;
            DOB = dOB;
            Gender = gender;
            Phone = phone;
            Address = address;
            ModuleCode = moduleCode;
        }

        public Students()
        {

        }
    }
}
