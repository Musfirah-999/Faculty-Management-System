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
    public partial class facultyprojects : Form
    {
        public facultyprojects()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvFacultyProjects.DataSource = FacultyProjectsDL.GetAllFacultyProjects();

            facultyComboBox.DataSource = FacultyProjectsDL.GetAllFaculty();
            facultyComboBox.DisplayMember = "name";
            facultyComboBox.ValueMember = "faculty_id";

            semesterComboBox.DataSource = FacultyProjectsDL.GetAllSemesters();
            semesterComboBox.DisplayMember = "semester_name";
            semesterComboBox.ValueMember = "semester_id";

            projectComboBox.DataSource = FacultyProjectsDL.GetAvailableProjects();
            projectComboBox.DisplayMember = "project_title";
            projectComboBox.ValueMember = "project_id";
        }
        private void facultyprojects_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int facultyId = Convert.ToInt32(facultyComboBox.SelectedValue);
            int semesterId = Convert.ToInt32(semesterComboBox.SelectedValue);
            int projectId = Convert.ToInt32(projectComboBox.SelectedValue);
            int supervisionHours = (int)supervisionHoursUpDown.Value;
            if (supervisionHours <= 0)
            {
                MessageBox.Show("Supervision hours must be at least 1 hour.");
                return;
            }

            if (supervisionHours <= 0)
            {
                MessageBox.Show("Please enter valid supervision hours.");
                return;
            }

            if (FacultyProjectsDL.CheckProjectAssigned(projectId))
            {
                MessageBox.Show("This project is already assigned to another faculty");
                return;
            }

            int result = FacultyProjectsDL.AddFacultyProject(facultyId, semesterId, projectId, supervisionHours);
            if (result > 0)
            {
                MessageBox.Show("Project assigned successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Assignment failed");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvFacultyProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete");
                return;
            }

            int id = Convert.ToInt32(dgvFacultyProjects.SelectedRows[0].Cells["faculty_project_id"].Value);
            int result = FacultyProjectsDL.DeleteFacultyProject(id);
            if (result > 0)
            {
                MessageBox.Show("Deleted successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
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
