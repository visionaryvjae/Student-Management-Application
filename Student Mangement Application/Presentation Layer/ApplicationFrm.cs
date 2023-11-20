﻿using Student_Mangement_Application.Business_Layer;
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
    public partial class ApplicationFrm : Form
    {
        DataHandler dh = new DataHandler();
        public ApplicationFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.getData().Tables[0];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dh.Search(txtSearch.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            this.Close();
            login.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dh.Create(new Students(txtStudentNum.Text, txtNameSurname.Text, txtImage.Text, birthDatePicker.Value, cmbGender.Text, txtPhone.Text, txtAddress.Text));
            dataGridView1.DataSource = dh.getData().Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dh.Update(new Students(txtStudentNum.Text, txtNameSurname.Text, txtImage.Text, birthDatePicker.Value, cmbGender.Text, txtPhone.Text, txtAddress.Text));
            dataGridView1.DataSource = dh.getData().Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dh.Delete(dataGridView1.CurrentCell.ToString());
            dataGridView1.DataSource = dh.getData().Tables[0];
        }
    }
}
