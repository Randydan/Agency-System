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

namespace DesktopApp.Data
{
    public partial class StudentData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public StudentData()
        {
            InitializeComponent();
        }

        private void StudentDat()
        {
            connect.Open();
            string query = "SELECT Name, Gender, DOB, Address, Email, Phone, Status, Nationality, Department, Matricle FROM Students";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            StudData.DataSource = dataTable;
            connect.Close();
        }
        private void StudentData_Load(object sender, EventArgs e)
        {
            StudentDat();
        }
    }
}
