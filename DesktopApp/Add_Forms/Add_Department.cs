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
    public partial class Add_Department : Form
    {
        public Add_Department()
        {
            InitializeComponent();
        }

        private async void AddDepBtn_Click(object sender, EventArgs e)
        {
            if (AddDepName.Text == "" ||
                  AddDepStudents.Text == "" ||
                  AddDepDes.Text == "" ||
                   AddDepLecturers.Text == "" ||
                  AddDepCourses.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Department>(new Department()
                {
                    Name = AddDepName.Text,
                    Description = AddDepDes.Text,
                    Lecturers = AddDepLecturers.Text,
                    Students = AddDepStudents.Text,
                    Courses = AddDepCourses.Text

                }, "Department");


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            Add_Administrator frm = new();
            frm.Show();
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

        private async void Add_Department_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Department>(new Department(), "Department");

            DepData.DataSource = data;
        }
    }
}
