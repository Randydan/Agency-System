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


        private async void Add_Department_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Department>(new Department(), "Department");

            DepData.DataSource = data;
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(DepID.Text);

            await RestApiHelpers.Update<Department>(new Department()
            {
                ID = Int32.Parse(DepID.Text),
                Name = AddDepName.Text,
                Description = AddDepDes.Text,
                Lecturers = AddDepLecturers.Text,
                Students = AddDepStudents.Text,
                Courses = AddDepCourses.Text

            }, "Department", urlid);

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DepData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DepData.Rows[e.RowIndex];

            DepID.Text = row.Cells[0].Value.ToString();
            AddDepName.Text = row.Cells[1].Value.ToString();
            AddDepDes.Text = row.Cells[2].Value.ToString();
            AddDepLecturers.Text = row.Cells[3].Value.ToString();
            AddDepStudents.Text = row.Cells[4].Value.ToString();
            AddDepCourses.Text = row.Cells[5].Value.ToString();
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(DepID.Text);

            await RestApiHelpers.Delete<Department>(new Department(), "Department", urlid);

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
