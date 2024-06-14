using Code_First.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Add_Forms
{
    public partial class Add_Lecturer : Form
    {
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        private async void AddLecBtn_Click(object sender, EventArgs e)
        {
            if (AddLecSalary.Text == "" ||
           AddLecDep.Text == "" ||
           AddLecName.Text == "" ||
           AddLecGen.Text == "" ||
           AddLecDOB.Text == "" ||
           AddLecAddr.Text == "" ||
           AddLecEmail.Text == "" ||
           AddLecPhone.Text == "" ||
           AddLecStatus.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Lecturer>(new Lecturer()
                {
                    Salary = Int32.Parse(AddLecSalary.Text),
                    Course = AddLecDep.Text,
                    Name = AddLecName.Text,
                    Gender = AddLecGen.Text,
                    Dob = AddLecDOB.Text,
                    Address = AddLecAddr.Text,
                    Email = AddLecEmail.Text,
                    Phone = Int32.Parse(AddLecPhone.Text),
                    Status = AddLecStatus.Text

                }, "Lecturer");


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Administrator_Click(object sender, EventArgs e)
        {
            Add_Administrator frm = new();
            frm.Show();
        }


        private void Classroom_Click_1(object sender, EventArgs e)
        {
            Add_Classroom frm = new();
            frm.Show();
        }

        private void Student_Click_1(object sender, EventArgs e)
        {
            Add_Student frm = new();
            frm.Show();
        }

        private void Office_Click(object sender, EventArgs e)
        {
            Add_Office frm = new();
            frm.Show();
        }

        private void Course_Click(object sender, EventArgs e)
        {
            Add_Course frm = new();
            frm.Show();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Add_Department frm = new();
            frm.Show();
        }


        private async void Lecturer_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Lecturer>(new Lecturer(), "Lecturer");

            LecData.DataSource = data;
        }
    }
}
