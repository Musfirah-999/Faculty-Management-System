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
    public partial class resourse : Form
    {
        public resourse()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }
    }
}
