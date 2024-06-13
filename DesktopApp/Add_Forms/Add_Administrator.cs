using DesktopApp.Add_Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Code_First.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesktopApp
{
    public partial class Add_Administrator : Form
    {
        public Add_Administrator()
        {
            InitializeComponent();
           
        }

        private async void AddAdminBtn_Click(object sender, EventArgs e)
        {
            if (AddAdminSalary.Text == "" ||
            AddAdminDepartment.Text == "" ||
            AddAdminPost.Text == "" ||
            AddAdminN.Text == "" ||
            AddAdminGender.Text == "" ||
            AddAdminDOB.Text == "" ||
            AddAdminA.Text == "" ||
            AddAdminEmail.Text == "" ||
            AddAdminPhone.Text == "" ||
            AddAdminStatus.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Administrators>(new Administrators() {
                Salary = Int32.Parse(AddAdminSalary.Text),
                Department = AddAdminDepartment.Text,
                Post = AddAdminPost.Text,
                Name = AddAdminN.Text,
                Gender = AddAdminGender.Text,
                Dob = AddAdminDOB.Text,
                Address = AddAdminA.Text,
                Email = AddAdminEmail.Text,
               Phone = Int32.Parse(AddAdminPhone.Text),
               Status = AddAdminStatus.Text

                }, "Administrator");


               MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Add_Administrator_Load(object sender, EventArgs e)
        {

            var data = await RestApiHelpers.GetALL();

            AdminData.DataSource = data;

        }

        private void Classroom_Click(object sender, EventArgs e)
        {
            Add_Classroom frm = new();
            frm.Show();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Add_Student frm = new();
            frm.Show();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Add_Department frm = new();
            frm.Show();
        }

        private void Course_Click(object sender, EventArgs e)
        {
            Add_Course frm = new();
            frm.Show();
        }

        private void Lecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer frm = new();
            frm.Show();
        }

        private void Office_Click(object sender, EventArgs e)
        {
            Add_Office frm = new();
            frm.Show();
        }

        private void AdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
