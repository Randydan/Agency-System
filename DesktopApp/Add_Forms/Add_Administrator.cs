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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;

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
                await RestApiHelpers.Post<Administrators>(new Administrators()
                {
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

            var data = await RestApiHelpers.GetALL<Administrators>(new Administrators(), "Administrator");

            AdminData.DataSource = data;

        }

        private async void UpdateAdmin_Click(object sender, EventArgs e)
        {
            await RestApiHelpers.Update<Administrators>(new Administrators()
            {
                // Id = Int32.Parse(),
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

            }, "Administrator", AdminId);


            MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = AdminData.Rows[e.RowIndex];

            var AdminId = row.Cells[0].Value.ToString();

            AddAdminSalary.Text = row.Cells[1].Value.ToString();
            AddAdminDepartment.Text = row.Cells[2].Value.ToString();
            AddAdminPost.Text = row.Cells[3].Value.ToString();
            AddAdminN.Text = row.Cells[4].Value.ToString();
            AddAdminGender.Text = row.Cells[5].Value.ToString();
            AddAdminDOB.Text = row.Cells[6].Value.ToString();
            AddAdminA.Text = row.Cells[7].Value.ToString();
            AddAdminEmail.Text = row.Cells[8].Value.ToString();
            AddAdminPhone.Text = row.Cells[9].Value.ToString();
            AddAdminStatus.Text = row.Cells[10].Value.ToString();
        }
    }
}
