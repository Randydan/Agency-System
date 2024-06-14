using Code_First.Models;
using DesktopApp.Add_Forms;
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

namespace DesktopApp
{
    public partial class Add_Classroom : Form
    {

        public Add_Classroom()
        {
            InitializeComponent();
        }



        private async void AddClassBtn_Click(object sender, EventArgs e)
        {
            if (AddClassName.Text == "" ||
                 AddClassDes.Text == "" ||
                 AddClassLoc.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Classroom>(new Classroom()
                {
                    Name = AddClassName.Text,
                    Description = AddClassDes.Text,
                    Location = AddClassLoc.Text

                }, "Classroom");


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void Administrator_Click_1(object sender, EventArgs e)
        {
            Add_Administrator frm = new();
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

        private async void Add_Classroom_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Classroom>(new Classroom(), "Classroom");

            ClassData.DataSource = data;
        }
    }
}
