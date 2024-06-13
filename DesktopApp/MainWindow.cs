using DesktopApp.Add_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Department_Click(object sender, EventArgs e)
        {
            Add_Department frm = new();
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
    }
}
