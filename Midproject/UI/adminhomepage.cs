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
    public partial class Adminhome : Form
    {
        public Adminhome(int user_id)
        {
            InitializeComponent();
        }
        public Adminhome()
        {
            InitializeComponent();
        }

        private void Adminhome_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Adminfaculty f = new Adminfaculty();
            this.Hide();
            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            projectmanage request = new projectmanage();
            this.Hide();
            request.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Semestermanage sem = new Semestermanage();
            this.Hide();
            sem.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Coursemanage course = new Coursemanage();
            this.Hide();
            course.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            roommanage room = new roommanage();
            this.Hide();
            room.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Consumables con = new Consumables();
            this.Hide();
            con.ShowDialog();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            report r = new report();
            this.Hide();
            r.ShowDialog();
        }
    }
}
