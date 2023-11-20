using Student_Mangement_Application.Business_Layer;
using Student_Mangement_Application.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mangement_Application.Presentation_Layer
{
    public partial class LoginFrm : Form
    {
        FileHandler fHandler = new FileHandler();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginRegister_btn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(fHandler.checkIfValidUser(username, password, fHandler.format())){
                ApplicationFrm app = new ApplicationFrm();
                app.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            FileStore fs = new FileStore();
            List<Students> list = fHandler.format();
            list.Add(new Students(username, password));

            fs.WriteToFile(list);
            ApplicationFrm app = new ApplicationFrm();
            app.Show();
            this.Hide();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
