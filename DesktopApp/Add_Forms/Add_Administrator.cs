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
    public partial class Add_Administrator : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Administrator()
        {
            InitializeComponent();
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkAdminName = "SELECT * FROM Administrators WHERE Name = '" + AddAdminN.Text.Trim() + "'";

                    using (SqlCommand checkAdmin = new SqlCommand(checkAdminName, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkAdmin);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddAdminN.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Administrators(Salary, Department, Post, Name, Gender, Dob, Address, Email, Phone,Status) VALUES(@Salary, @Department, @Post, @Name, @Gender, @Dob, @Address, @Email, @Phone, @Status)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Salary", AddAdminSalary.Text.Trim());
                                cmd.Parameters.AddWithValue("@Department", AddAdminDepartment.Text.Trim());
                                cmd.Parameters.AddWithValue("@Post", AddAdminPost.Text.Trim());
                                cmd.Parameters.AddWithValue("@Name", AddAdminN.Text.Trim());
                                cmd.Parameters.AddWithValue("@Gender", AddAdminGender.Text.Trim());
                                cmd.Parameters.AddWithValue("@Dob", AddAdminDOB.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", AddAdminA.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", AddAdminEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Phone", AddAdminPhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@Status", AddAdminStatus.Text.Trim());

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
    }
}
