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
            if (
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
                    Course = AddLecDep.Text,
                    Name = AddLecName.Text,
                    Gender = AddLecGen.Text,
                    DoB = DateTime.Parse(AddLecDOB.Text),
                    Address = AddLecAddr.Text,
                    Email = AddLecEmail.Text,
                    Phone = Int32.Parse(AddLecPhone.Text),
                    Status = AddLecStatus.Text

                }, "Lecturer");

                var data = await RestApiHelpers.GetALL<Lecturer>(new Lecturer(), "Lecturer");
                LecData.DataSource = data;

                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async void Lecturer_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Lecturer>(new Lecturer(), "Lecturer");

            LecData.DataSource = data;
        }

        private void LecData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = LecData.Rows[e.RowIndex];

            LecID.Text = row.Cells[0].Value.ToString();
            AddLecDep.Text = row.Cells[1].Value.ToString();
            AddLecName.Text = row.Cells[2].Value.ToString();
            AddLecGen.Text = row.Cells[3].Value.ToString();
            AddLecDOB.Text = row.Cells[4].Value.ToString();
            AddLecAddr.Text = row.Cells[5].Value.ToString();
            AddLecEmail.Text = row.Cells[6].Value.ToString();
            AddLecPhone.Text = row.Cells[7].Value.ToString();
            AddLecStatus.Text = row.Cells[8].Value.ToString();
        }

        private async void updatebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(LecID.Text);

            await RestApiHelpers.Update<Lecturer>(new Lecturer()
            {
                Id = Int32.Parse(LecID.Text),
                Course = AddLecDep.Text,
                Name = AddLecName.Text,
                Gender = AddLecGen.Text,
                DoB = DateTime.Parse(AddLecDOB.Text),
                Address = AddLecAddr.Text,
                Email = AddLecEmail.Text,
                Phone = Int32.Parse(AddLecPhone.Text),
                Status = AddLecStatus.Text

            }, "Lecturer", urlid);

            var data = await RestApiHelpers.GetALL<Lecturer>(new Lecturer(), "Lecturer");
            LecData.DataSource = data;

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async void Deletebtn_Click(Object sender, EventArgs e)
        {
            var urlid = Int32.Parse(LecID.Text);

            await RestApiHelpers.Delete<Lecturer>(new Lecturer(), "Lecturer", urlid);

            var data = await RestApiHelpers.GetALL<Lecturer>(new Lecturer(), "Lecturer");
            LecData.DataSource = data;

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
