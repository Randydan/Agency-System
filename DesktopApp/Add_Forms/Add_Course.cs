using DesktopApp.Data;
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
    public partial class Add_Course : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Course()
        {
            InitializeComponent();
        }

        private void CourseDat()
        {
            connect.Open();
            string query = "SELECT Name, Description, Code, Department FROM Courses";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            CourseDatas.DataSource = dataTable;
            connect.Close();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string existCheck = "SELECT * FROM Courses WHERE Name = '" + AddCourseName.Text.Trim() + "'";

                    using (SqlCommand checkCourse = new SqlCommand(existCheck, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkCourse);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddCourseName.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Courses(Name, Description, Code, Department) VALUES(@Name, @Description, @Code, @Department)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name", AddCourseName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", AddCourseDes.Text.Trim());
                                cmd.Parameters.AddWithValue("@Code", AddCourseCode.Text.Trim());
                                cmd.Parameters.AddWithValue("@Department", AddCourseDep.Text.Trim());

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

        private void Add_Course_Load(object sender, EventArgs e)
        {
            CourseDat();
        }
    }
}
