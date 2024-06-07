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
    public partial class Add_Department : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Department()
        {
            InitializeComponent();
        }
        private void DepartmentDat()
        {
            connect.Open();
            string query = "SELECT Name, Description, Courses, Students,Lecturers FROM Departments";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            DepData.DataSource = dataTable;
            connect.Close();
        }

        private void AddDepBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string existCheck = "SELECT * FROM Departments WHERE Name = '" + AddDepName.Text.Trim() + "'";

                    using (SqlCommand checkCourse = new SqlCommand(existCheck, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkCourse);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddDepName.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Departments(Name, Description, Courses, Students,Lecturers) VALUES(@Name, @Description, @Courses, @Students, @Lecturers)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name", AddDepName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", AddDepDes.Text.Trim());
                                cmd.Parameters.AddWithValue("@Courses", AddDepCourses.Text.Trim());
                                cmd.Parameters.AddWithValue("@Students", AddDepStudents.Text.Trim());
                                cmd.Parameters.AddWithValue("@Lecturers", AddDepLecturers.Text.Trim());

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

        private void Administrator_Click(object sender, EventArgs e)
        {
            Add_Administrator frm = new();
            frm.Show();
        }

        private void Classroom_Click(object sender, EventArgs e)
        {
            Add_Classroom frm = new();
            frm.Show();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Add_Student frm = new();
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

        private void Add_Department_Load(object sender, EventArgs e)
        {
            DepartmentDat();
        }
    }
}
