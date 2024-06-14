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
    }
}
