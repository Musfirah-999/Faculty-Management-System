using Midproject.DL;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Midproject.UI.profilemanage;
using System.Windows.Forms.VisualStyles;

namespace Midproject.UI
{
    public partial class facultyrequest : Form
    {
        public string facultyName;
        public int facultyId;
      

        public facultyrequest(int facultyId)
        {
            InitializeComponent();
            this.facultyId = facultyId;

            LoadConsumables();
            LoadRequests();
        }
        public facultyrequest(string facultyName)
        {
            InitializeComponent();
            this.facultyName = facultyName;
            LoadRequests();
            LoadConsumables();
        }
      
        public facultyrequest()
        {
            InitializeComponent();
        }
        private void LoadConsumables()
        {
            DataTable dt = FacultyRequestDL.GetConsumableItems();
            comboBoxConsumables.DataSource = dt;
            comboBoxConsumables.DisplayMember = "item_name";
            comboBoxConsumables.ValueMember = "consumable_id";
        }

        private void LoadRequests()
        {
            dataGridViewRequests.DataSource = FacultyRequestDL.GetRequestsByFacultyId(facultyId);
        }
        private void facultyrequest_Load(object sender, EventArgs e)
        {
            LoadConsumables();
            LoadRequests();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(comboBoxConsumables.SelectedValue);
            int quantity = int.TryParse(quantitytextBox.Text.Trim(), out int q) ? q : 0;

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter valid quantity.");
                return;
            }

            int result = FacultyRequestDL.InsertRequest(facultyId, itemId, quantity);
            if (result > 0)
            {
                MessageBox.Show("Request submitted successfully.");
                LoadRequests();
                quantitytextBox.Clear();
            }
            else
            {
                MessageBox.Show("Failed to submit request.");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            facultyhome f = new facultyhome();
            this.Hide();
            f.ShowDialog();
        }
    }
}
