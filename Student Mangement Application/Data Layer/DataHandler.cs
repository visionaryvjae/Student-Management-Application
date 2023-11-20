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
            string query = "SELECT * from Students WHERE StudentName LIKE '%" +searcVal+ "%'";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Delete(string StudentNumber)
        {
            string query = "DELETE from Students WHERE StudentNumber = '"+StudentNumber+ "'";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand comm = new SqlCommand(query, connection);
            connection.Open();
            int n = comm.ExecuteNonQuery();

            MessageBox.Show($"Successfully deleted {n} row(s)!", "information", MessageBoxButtons.OKCancel);
            connection.Close();
        }

        public void Update(Students student, string StudentNum)
        {
            string query = $"UPDATE Students SET StudentName = '{student.StudentName}', StudentImage = '{student.StudentIMG}', DateOfBirth = '{student.DOB}', Gender = '{student.Gender}', Phone = '{student.Phone}', Address = '{student.Address}, ModuleCode = {student.ModuleCode}' WHERE StudentNumber = '{StudentNum}'";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand comm = new SqlCommand(query, connection);
            int n = comm.ExecuteNonQuery();

            MessageBox.Show($"Updated successfully!", "information", MessageBoxButtons.OKCancel);
            connection.Close();
        }

        public void Create(Students student)
        {
            //(StudentName, StudentImage, DateOfBirth, Gender, Phone, Address, ModuleCode)
            string query = $"INSERT INTO Students VALUES ('{student.StudentName}', '{student.StudentIMG}', '{student.DOB}', '{student.Gender}', '{student.Phone}', '{student.Address}', '{student.ModuleCode}')";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand comm = new SqlCommand(query, connection);
            int n = comm.ExecuteNonQuery();
            
            MessageBox.Show($"{n} row(s) affected", "information", MessageBoxButtons.OKCancel);
            connection.Close();
        }

        public DataTable getModuleNum()
        {
            string query = "SELECT ModuleCode from Modules";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
