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

    public partial class CourseData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public CourseData()
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

        private void CourseData_Load(object sender, EventArgs e)
        {
            CourseDat();
        }
    }
}
