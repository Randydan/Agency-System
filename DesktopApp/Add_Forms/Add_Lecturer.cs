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
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        private void AddLecBtn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string ExistCheck = "SELECT * FROM Lecturers WHERE Name = '" + AddLecName.Text.Trim() + "'";

                    using (SqlCommand checkLecturer = new SqlCommand(ExistCheck, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkLecturer);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(AddLecName.Text + " already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO Administrators(Name, Gender, Dob, Address, Email, Phone, Status ,Course, ,Salary) VALUES(@Name, @Gender, @Dob, @Address, @Email, @Phone, @Status, @Course, @Salary)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name", AddLecName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Gender", AddLecGen.Text.Trim());
                                cmd.Parameters.AddWithValue("@Dob", AddLecDOB.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", AddLecAddr.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", AddLecEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Phone", AddLecPhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@Status", AddLecStatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@Course", AddLecCourse.Text.Trim());
                                cmd.Parameters.AddWithValue("@Salary", AddLecSalary.Text.Trim());

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


        private void Classroom_Click_1(object sender, EventArgs e)
        {
            Add_Classroom frm = new();
            frm.Show();
        }

        private void Student_Click_1(object sender, EventArgs e)
        {
            Add_Student frm = new();
            frm.Show();
        }

        private void Office_Click(object sender, EventArgs e)
        {
            Add_Office frm = new();
            frm.Show();
        }

        private void Course_Click(object sender, EventArgs e)
        {
            Add_Course frm = new();
            frm.Show();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Add_Department frm = new();
            frm.Show();
        }

        private void LecturerDat()
        {
            connect.Open();
            string query = "SELECT Name, Gender, Dob, Address, Email, Phone, Status ,Course ,Salary FROM Lecturers";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            LecData.DataSource = dataTable;
            connect.Close();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            LecturerDat();
        }
    }
}
