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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

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
            
            {
                await RestApiHelpers.Post<Administrators>(new Administrators()
                {
                    Salary = Int32.Parse(AddAdminSalary.Text),
                    Department = AddAdminDepartment.Text,
                    Post = AddAdminPost.Text,
                    Name = AddAdminN.Text,
                    Gender = AddAdminGender.Text,
                    Dob = DateTime.Parse(AddAdminDOB.Text),
                    Address = AddAdminA.Text,
                    Email = AddAdminEmail.Text,
                    Phone = Int32.Parse(AddAdminPhone.Text),
                    Status = AddAdminStatus.Text

                }, "Administrator");

                var data = await RestApiHelpers.GetALL<Administrators>(new Administrators(), "Administrator");
                AdminData.DataSource = data;

                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Add_Administrator_Load(object sender, EventArgs e)
        {

            var data = await RestApiHelpers.GetALL<Administrators>(new Administrators(), "Administrator");

            AdminData.DataSource = data;

        }


        private void AdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = AdminData.Rows[e.RowIndex];

            AdminId.Text = row.Cells[0].Value.ToString();
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

        private async void UpdateAdmin_Click(object sender, EventArgs e)
        {
            var urlId = Int32.Parse(AdminId.Text);

            await RestApiHelpers.Update<Administrators>(new Administrators()
            {
                Id = Int32.Parse(AdminId.Text),
                Salary = Int32.Parse(AddAdminSalary.Text),
                Department = AddAdminDepartment.Text,
                Post = AddAdminPost.Text,
                Name = AddAdminN.Text,
                Gender = AddAdminGender.Text,
                Dob = DateTime.Parse(AddAdminDOB.Text),
                Address = AddAdminA.Text,
                Email = AddAdminEmail.Text,
                Phone = Int32.Parse(AddAdminPhone.Text),
                Status = AddAdminStatus.Text

            }, "Administrator", urlId);

            var data = await RestApiHelpers.GetALL<Administrators>(new Administrators(), "Administrator");
            AdminData.DataSource = data;

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var Id = Int32.Parse(AdminId.Text);

            await RestApiHelpers.Delete<Administrators>(new Administrators(), "Administrator", Id);

            var data = await RestApiHelpers.GetALL<Administrators>(new Administrators(), "Administrator");
            AdminData.DataSource = data;

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
