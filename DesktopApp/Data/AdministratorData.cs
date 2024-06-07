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
    public partial class AdministratorData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public AdministratorData()
        {
            InitializeComponent();
        }

        private void AdminDat()
        {
            connect.Open();
            string query = "SELECT Name, Salary, Department, Post, Gender, Dob, Address, Email, Phone,Status FROM Administrators";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            AdminData.DataSource = dataTable;
            connect.Close();
        }

        private void AdministratorData_Load(object sender, EventArgs e)
        {
            AdminDat();
        }

        private void AdminData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
