using Midproject.DL;
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
    public partial class facultyadminrole : Form
    {
        public facultyadminrole()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboFaculty.SelectedValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["faculty_id"].Value);
                roletextBox.Text = dataGridView1.SelectedRows[0].Cells["role_name"].Value.ToString();
                comboSemester.SelectedValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["semester_id"].Value);
            }
        }

        private void facultyadminrole_Load(object sender, EventArgs e)
        {
            LoadAdminRoles();
            LoadFaculty();
            LoadSemesters();
        }

        private void LoadAdminRoles()
        {
            dataGridView1.DataSource = FacultyAdminRoleDL.GetAllRoles();
        }

        private void LoadFaculty()
        {
            comboFaculty.DataSource = FacultyAdminRoleDL.GetFaculty();
            comboFaculty.DisplayMember = "name";
            comboFaculty.ValueMember = "faculty_id";
        }

        private void LoadSemesters()
        {
            comboSemester.DataSource = FacultyAdminRoleDL.GetSemesters();
            comboSemester.DisplayMember = "name";
            comboSemester.ValueMember = "semester_id";
        }


        private void addButton_Click(object sender, EventArgs e)
        {

            int facultyId = Convert.ToInt32(comboFaculty.SelectedValue);
            string roleName = roletextBox.Text.Trim();
            int semesterId = Convert.ToInt32(comboSemester.SelectedValue);

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Please enter a role name.");
                return;
            }

            bool result = FacultyAdminRoleDL.AddAdminRole(facultyId, roleName, semesterId);
            MessageBox.Show(result ? "Admin Role Assigned Successfully." : "Failed to Assign Admin Role.");

            LoadAdminRoles();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            int facultyId = Convert.ToInt32(comboFaculty.SelectedValue);
            string roleName = roletextBox.Text.Trim();
            int semesterId = Convert.ToInt32(comboSemester.SelectedValue);

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Please enter a role name.");
                return;
            }

            int result = FacultyAdminRoleDL.UpdateAdminRole(id, facultyId, roleName, semesterId);
            if (result > 0)

                MessageBox.Show("Updated Successfully.");
            else
                MessageBox.Show("Update Failed.");

            LoadAdminRoles();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            bool result = FacultyAdminRoleDL.DeleteAdminRole(id);
            MessageBox.Show(result ? "Deleted Successfully." : "Delete Failed.");

            LoadAdminRoles();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Headhome h = new Headhome();
            this.Hide();
            h.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }
    }
}
