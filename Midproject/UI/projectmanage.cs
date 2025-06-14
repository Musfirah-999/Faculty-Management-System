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
    public partial class projectmanage : Form
    {
        public projectmanage()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            projectsDataGridView.DataSource = ProjectDL.GetAllProjects();
        }

        private void ClearForm()
        {
            projectidTextBox.Clear();
            projectNameTextBox.Clear();
            descriptionTextBox.Clear();
            projectsDataGridView.ClearSelection();
        }
        private void projectmanage_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            int projectId = Convert.ToInt32(projectidTextBox.Text.Trim());
            string projectName = projectNameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            int result = ProjectDL.AddProject(projectId, projectName, description);
            if (result > 0)
            {
                MessageBox.Show("Project added successfully.");
                LoadProjects();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add project.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (projectsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a project to update.");
                return;
            }

            int projectId = Convert.ToInt32(projectsDataGridView.SelectedRows[0].Cells["project_id"].Value);
            string projectName = projectNameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            int result = ProjectDL.UpdateProject(projectId, projectName, description);
            if (result > 0)
            {
                MessageBox.Show("Project updated successfully.");
                LoadProjects();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update project.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (projectsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a project to delete.");
                return;
            }

            int projectId = Convert.ToInt32(projectsDataGridView.SelectedRows[0].Cells["project_id"].Value);
            int result = ProjectDL.DeleteProject(projectId);
            if (result == -1)
            {
                MessageBox.Show("Cannot delete this project. It is used in other tables.");
            }
            else if (result > 0)
            {
                MessageBox.Show("Project deleted successfully.");
                LoadProjects();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to delete project.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Adminhome home = new Adminhome();
            this.Hide();
            home.ShowDialog();
        }
    }

}
