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
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Office()
        {
            InitializeComponent();
        }

        private void AddOfficeBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string ExistCheck = "SELECT * FROM Offices WHERE Name = '" + AddOfficeDes.Text.Trim() + "'";

                    using (SqlCommand checkOffice = new SqlCommand(ExistCheck, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkOffice);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddOfficeDes.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Offices(Department, Description, Address) VALUES(@Department, @Description, @Address)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Department", AddOfficeDep.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", AddOfficeDes.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", AddOfficeAddr.Text.Trim());

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }
        private void OfficeDat()
        {
            connect.Open();
            string query = "SELECT Department, Description, Address FROM Offices";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            OffData.DataSource = dataTable;
            connect.Close();
        }

        private void Add_Office_Load(object sender, EventArgs e)
        {
            OfficeDat();
        }
    }

}
