using Microsoft.VisualBasic.ApplicationServices;
using Student_Mangement_Application.Data_Layer;
using Student_Mangement_Application.Presentation_Layer;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mangement_Application.Business_Layer
{
    internal class DataHandler
    {
        public string conn = "Data Source=VISIONARY-VJAE\\SQLEXPRESS02;Initial Catalog=\"Student Management System\";Integrated Security=True";
        public DataSet getData()
        {
            string query = "SELECT * from Students; SELECT *  from Modules";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable Search(string searcVal)
        {
            string query = "SELECT * from Students WHERE StudentName LIKE '" +searcVal+ "'";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Delete(string StudentNumber)
        {
            string query = "DELETE * from Students WHERE StudentNumber = '"+StudentNumber+ "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
        }

        public void Update(Students student)
        {
            string query = $"UPDATE Students SET StudentNumber = '{student.StudentNumber}', StudentName = '{student.StudentName}', StudentImage = '{student.StudentIMG}', DateOfBirth = '{student.DOB}', Gender = '{student.Gender}', Phone = '{student.Phone}', Address = '{student.Address}' WHERE StudentName = '{student.StudentNumber}'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
        }

        public void Create(Students student)
        {
            string query = $"INSERT INTO Students (StudentNumber, StudentName, StudentImage, DateOfBirth, Gender, Phone, Address) " +
                $"VALUES ('{student.StudentNumber}', '{student.StudentName}', '{student.StudentIMG}', '{student.DOB}', '{student.Gender}', '{student.Phone}', '{student.Address}')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
        }
    }
}
