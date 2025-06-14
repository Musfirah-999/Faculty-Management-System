using Midproject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midproject
{
    public partial class Headhome : Form
    {
        public Headhome(int user_id)
        {
            InitializeComponent();
        }
        public Headhome()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            requestmanage request = new requestmanage();
            this.Hide();
            request.ShowDialog();
        }

        private void Headhome_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Workloadassign_Click(object sender, EventArgs e)
        {
            workload w = new workload();
            this.Hide();
            w.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            FacultyRoomAllocation f = new FacultyRoomAllocation();
            this.Hide();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            report r = new report();
            this.Hide();
            r.ShowDialog();
        }
    }
}
