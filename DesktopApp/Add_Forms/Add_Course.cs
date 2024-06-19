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
    public partial class Add_Course : Form
    {

        public Add_Course()
        {
            InitializeComponent();
        }


        private async void AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (AddCourseName.Text == "" ||
                 AddCourseDes.Text == "" ||
                 AddCourseDep.Text == "" ||
                 AddCourseCode.Text == ""
                 )
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Course>(new Course()
                {
                    Name = AddCourseName.Text,
                    Description = AddCourseDes.Text,
                    Department = AddCourseDep.Text,
                    Code = AddCourseCode.Text

                }, "Course");


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async void Add_Course_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Course>(new Course(), "Course");

            CourseData.DataSource = data;
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(CourseID.Text);

            await RestApiHelpers.Update<Course>(new Course()
            {
                ID = Int32.Parse(CourseID.Text),
                Name = AddCourseName.Text,
                Description = AddCourseDes.Text,
                Department = AddCourseDep.Text,
                Code = AddCourseCode.Text

            }, "Course", urlid);

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CourseData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = CourseData.Rows[e.RowIndex];

            CourseID.Text = row.Cells[0].Value.ToString();
            AddCourseName.Text = row.Cells[1].Value.ToString();
            AddCourseDes.Text = row.Cells[2].Value.ToString();
            AddCourseDep.Text = row.Cells[3].Value.ToString();
            AddCourseCode.Text = row.Cells[4].Value.ToString();

        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(CourseID.Text);

            await RestApiHelpers.Delete<Course>(new Course(), "Course", urlid);

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
