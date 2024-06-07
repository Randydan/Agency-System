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

namespace DesktopApp.Add_Forms
{
    public partial class Add_Student : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Student()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string ExistCheck = "SELECT * FROM Students WHERE Name = '" + AddStudentName.Text.Trim() + "'";

                    using (SqlCommand checkStudent = new SqlCommand(ExistCheck, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkStudent);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddStudentName.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Students(Name, Gender, DOB, Address, Email, Phone, Status, Nationality, Department, Matricle) VALUES(@Name, @Gender, @DOB, @Address, @Email, @Phone, @Status, @Nationality, @Department, @Matricle)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name", AddStudentName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Gender", AddStudentGen.Text.Trim());
                                cmd.Parameters.AddWithValue("@DOB", AddDob.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", AddStudentAddr.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", AddStudentEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Phone", AddStudentPhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@Status", AddStudentStat.Text.Trim());
                                cmd.Parameters.AddWithValue("@Nationality", AddStudentNat.Text.Trim());
                                cmd.Parameters.AddWithValue("@Department", AddStudentDep.Text.Trim());
                                cmd.Parameters.AddWithValue("@Matricle", AddStudentMat.Text.Trim());

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
