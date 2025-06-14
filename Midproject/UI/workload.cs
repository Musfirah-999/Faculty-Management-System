using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midproject.UI
{
    public partial class workload : Form
    {
        public workload()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            facultycourse f = new facultycourse();
            this.Hide();
            f.ShowDialog();
        }

        private void workload_Load(object sender, EventArgs e)
        {

        }
    }
}
