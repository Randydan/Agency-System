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


                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void Add_Office_Load(object sender, EventArgs e)
        {
            var data = await RestApiHelpers.GetALL<Office>(new Office(), "Office");

            OffData.DataSource = data;
        }
    }

}
