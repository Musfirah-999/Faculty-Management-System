using Microsoft.VisualBasic.ApplicationServices;
using Midproject.DL;
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
    public partial class facultyhome : Form
    {
        public int facultyId;
        public string facultyName;

        public facultyhome(int facultyId)
        {
            InitializeComponent();
            this.facultyId = facultyId;
        }


        public facultyhome()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void facultyhome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            facultyrequest fr = new facultyrequest(facultyId);
            this.Hide();
            fr.Show();
        }
    }
}
