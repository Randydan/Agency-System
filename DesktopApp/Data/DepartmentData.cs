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
    public partial class DepartmentData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public DepartmentData()
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

        private void DepartmentData_Load(object sender, EventArgs e)
        {
            DepartmentDat();
        }
    }
}
