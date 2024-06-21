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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

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
                    DOB = DateTime.Parse(AddDob.Text),
                    Address = AddStudentAddr.Text,
                    Email = AddStudentEmail.Text,
                    Phone = Int32.Parse(AddStudentPhone.Text),
                    Status = AddStudentStat.Text

                }, "Student");

                var data = await RestApiHelpers.GetALL<Student>(new Student(), "Student");
                StudData.DataSource = data;

                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private async void Add_Student_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Student>(new Student(), "Student");

            StudData.DataSource = data;
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(StudId.Text);

            await RestApiHelpers.Update<Student>(new Student()
            {
                ID = Int32.Parse(StudId.Text),
                Matricle = AddStudentMat.Text,
                Department = AddStudentDep.Text,
                Nationality = AddStudentNat.Text,
                Name = AddStudentName.Text,
                Gender = AddStudentGen.Text,
                DOB = DateTime.Parse(AddDob.Text),
                Address = AddStudentAddr.Text,
                Email = AddStudentEmail.Text,
                Phone = Int32.Parse(AddStudentPhone.Text),
                Status = AddStudentStat.Text

            }, "Student", urlid);

            var data = await RestApiHelpers.GetALL<Student>(new Student(), "Student");
            StudData.DataSource = data;

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = StudData.Rows[e.RowIndex];

            StudId.Text = row.Cells[0].Value.ToString();
            AddStudentMat.Text = row.Cells[1].ToString();
            AddStudentDep.Text = row.Cells[2].Value.ToString();
            AddStudentNat.Text = row.Cells[3].Value.ToString();
            AddStudentName.Text = row.Cells[4].Value.ToString();
            AddStudentGen.Text = row.Cells[5].Value.ToString();
            AddDob.Text = row.Cells[6].Value.ToString();
            AddStudentAddr.Text = row.Cells[7].Value.ToString();
            AddStudentEmail.Text = row.Cells[8].Value.ToString();
            AddStudentPhone.Text = row.Cells[9].Value.ToString();
            AddStudentStat.Text = row.Cells[10].Value.ToString();
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(StudId.Text);

            await RestApiHelpers.Delete<Student>(new Student(), "Student", urlid);

            var data = await RestApiHelpers.GetALL<Student>(new Student(), "Student");
            StudData.DataSource = data;

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
