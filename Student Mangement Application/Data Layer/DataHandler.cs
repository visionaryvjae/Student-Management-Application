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
        public string connString = "Data Source=VISIONARY-VJAE\\SQLEXPRESS02;Initial Catalog=\"Student Management System\";Integrated Security=True";
        public DataSet getData()
        {
            string query = "SELECT * from Students; SELECT *  from Modules";

            SqlDataAdapter da = new SqlDataAdapter(query, connString);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
