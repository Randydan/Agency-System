using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.CodeDom;
using Code_First.Models;

namespace DesktopApp.Add_Forms
{
    public partial class Add_Student : Form
    {

        public Add_Student()
        {
            InitializeComponent();
        }

        private async void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (AddStudentMat.Text == "" ||
                   AddStudentDep.Text == "" ||
                   AddStudentNat.Text == "" ||
                   AddStudentName.Text == "" ||
                   AddStudentGen.Text == "" ||
                   AddDob.Text == "" ||
                   AddStudentAddr.Text == "" ||
                   AddStudentEmail.Text == "" ||
                   AddStudentPhone.Text == "" ||
                   AddStudentStat.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Student>(new Student()
                {
                    Matricle = AddStudentMat.Text,
                    Department = AddStudentDep.Text,
                    Nationality = AddStudentNat.Text,
                    Name = AddStudentName.Text,
                    Gender = AddStudentGen.Text,
                    DOB = AddDob.Text,
                    Address = AddStudentAddr.Text,
                    Email = AddStudentEmail.Text,
                    Phone = Int32.Parse(AddStudentPhone.Text),
                    Status = AddStudentStat.Text

                }, "Student");


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private async void Add_Student_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Student>(new Student(), "Student");

            StudData.DataSource = data;
        }
    }
}
