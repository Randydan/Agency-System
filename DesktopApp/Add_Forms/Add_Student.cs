using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.CodeDom;

namespace DesktopApp.Add_Forms
{
    public partial class Add_Student : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=KING-DAN;Initial Catalog=Code_First;Integrated Security=True");
        public Add_Student()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
