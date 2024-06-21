using Code_First.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Add_Forms
{
    public partial class Add_Office : Form
    {
        public Add_Office()
        {
            InitializeComponent();
        }

        private async void AddOfficeBtn_Click(object sender, EventArgs e)
        {
            if (AddOfficeDep.Text == "" ||
                   AddOfficeDes.Text == "" ||
                   AddOfficeAddr.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await RestApiHelpers.Post<Office>(new Office()
                {
                    Department = AddOfficeDep.Text,
                    Description = AddOfficeDes.Text,
                    Address = AddOfficeAddr.Text

                }, "Office");

                var data = await RestApiHelpers.GetALL<Office>(new Office(), "Office");
                OffData.DataSource = data;


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Add_Office_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Office>(new Office(), "Office");

            OffData.DataSource = data;
        }

        private async void Updatebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(OffID.Text);

            await RestApiHelpers.Update<Office>(new Office()
            {
                ID = Int32.Parse(OffID.Text),
                Department = AddOfficeDep.Text,
                Description = AddOfficeDes.Text,
                Address = AddOfficeAddr.Text

            }, "Office", urlid);

            var data = await RestApiHelpers.GetALL<Office>(new Office(), "Office");
            OffData.DataSource = data;

            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OffData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = OffData.Rows[e.RowIndex];

            OffID.Text = row.Cells[0].Value.ToString();
            AddOfficeDep.Text = row.Cells[1].Value.ToString();
            AddOfficeDes.Text = row.Cells[2].Value.ToString();
            AddOfficeAddr.Text = row.Cells[3].Value.ToString();
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            var urlid = Int32.Parse(OffID.Text);

            await RestApiHelpers.Delete<Office>(new Office(), "Office", urlid);

            var data = await RestApiHelpers.GetALL<Office>(new Office(), "Office");
            OffData.DataSource = data;

            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
