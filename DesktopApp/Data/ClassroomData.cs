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

    public partial class ClassroomData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public ClassroomData()
        {
            InitializeComponent();
        }

        private void ClassDat()
        {
            connect.Open();
            string query = "SELECT Name, Description, Location FROM Classrooms";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            ClassData.DataSource = dataTable;
            connect.Close();
        }

        private void ClassroomData_Load(object sender, EventArgs e)
        {
            ClassDat();
        }

        private void ClassData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
