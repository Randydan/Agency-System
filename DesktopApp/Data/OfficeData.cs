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
    public partial class OfficeData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public OfficeData()
        {
            InitializeComponent();
        }

        private void OfficeDat()
        {
            connect.Open();
            string query = "SELECT Department, Description, Address FROM Offices";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            OffData.DataSource = dataTable;
            connect.Close();
        }

        private void OfficeData_Load(object sender, EventArgs e)
        {
            OfficeDat();
        }
    }
}
