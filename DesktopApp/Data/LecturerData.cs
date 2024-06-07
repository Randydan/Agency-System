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
    public partial class LecturerData : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public LecturerData()
        {
            InitializeComponent();
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

        private void LecturerData_Load(object sender, EventArgs e)
        {
            LecturerDat();
        }
    }
}
