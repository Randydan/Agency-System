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


        private async void Add_Classroom_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Classroom>(new Classroom(), "Classroom");

            ClassData.DataSource = data;
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var Id = Int32.Parse(ClassId.Text);

            await RestApiHelpers.Delete<Classroom>(new Classroom(), "Classroom", Id);

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            var Id = Int32.Parse(ClassId.Text);

            await RestApiHelpers.Update<Classroom>(new Classroom()
            {
                ID = Int32.Parse(ClassId.Text),
                Name = AddClassName.Text,
                Description = AddClassDes.Text,
                Location = AddClassLoc.Text

            }, "Classroom", Id);


            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClassData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ClassData.Rows[e.RowIndex];

            ClassId.Text = row.Cells[0].Value.ToString();
            AddClassName.Text = row.Cells[1].Value.ToString();
            AddClassDes.Text = row.Cells[2].Value.ToString();
            AddClassLoc.Text = row.Cells[3].Value.ToString();
        }
    }
}
