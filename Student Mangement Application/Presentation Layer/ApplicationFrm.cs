using Student_Mangement_Application.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mangement_Application.Presentation_Layer
{
    public partial class ApplicationFrm : Form
    {
        DataHandler dh = new DataHandler();
        public ApplicationFrm()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.getData().Tables[0];
            //dataGridView1.DataSource = dh.getModuleCodes();
            cmbModuleCodes.DataSource = dh.getModuleCodes();
            cmbModuleCodes.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Search(txtSearch.Text);
            btnReset.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            this.Close();
            login.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((txtNameSurname.Text == "") && (txtAddress.Text == "") && (txtPhone.Text == "") && (cmbGender.Text == "") && (cmbModuleCodes.Text == ""))
            {
                MessageBox.Show("Cannot insert new details! Please make sure to fill in all necessary fileds before going further.");
            }
            else
            {
                dh.Create(new Students(txtNameSurname.Text, txtImage.Text, birthDatePicker.Value, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCodes.Text));
                dataGridView1.DataSource = dh.getData().Tables[0];
            }
            txtAddress.Clear(); txtImage.Clear(); txtPhone.Clear(); txtNameSurname.Clear(); cmbGender.Text = " "; cmbModuleCodes.Text = " ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Students students = new Students();
            students.StudentNumber = Studentno;
            dh.Update(new Students(txtNameSurname.Text, txtImage.Text, birthDatePicker.Value, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCodes.Text), Studentno);
            txtAddress.Clear(); txtImage.Clear(); txtPhone.Clear(); txtNameSurname.Clear(); cmbGender.Text = " "; cmbModuleCodes.Text = " ";
            dataGridView1.DataSource = dh.getData().Tables[0];
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dh.Delete(Studentno);
            dataGridView1.DataSource = dh.getData().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.getData().Tables[0];
            btnReset.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNameSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtImage.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            birthDatePicker.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            cmbGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbModuleCodes.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To update records please double click on the row of data that you would like to edit and make your changes in the provided input boxes.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
