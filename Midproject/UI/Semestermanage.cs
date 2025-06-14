using Midproject.DL;
using MySql.Data.MySqlClient;
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
    public partial class Semestermanage : Form
    {
        public Semestermanage()
        {
            InitializeComponent();
            LoadSemesters();
            LoadTerms();
        }

        private void LoadSemesters()
        {
            semesterDataGridView.DataSource = SemesterDl.GetAllSemesters();
        }

        private void LoadTerms()
        {
            termComboBox.Items.Add("Spring");
            termComboBox.Items.Add("Summer");
            termComboBox.Items.Add("Fall");
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Adminhome home = new Adminhome();
            this.Hide();
            home.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string term = termComboBox.SelectedItem?.ToString();
            int year;
            if (string.IsNullOrEmpty(term) || !int.TryParse(yearTextBox.Text.Trim(), out year))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = SemesterDl.AddSemester(term, year);
            if (result > 0)
            {
                MessageBox.Show("Semester added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSemesters();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (semesterDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a semester to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int semesterId = Convert.ToInt32(semesterDataGridView.SelectedRows[0].Cells["semester_id"].Value);
            string term = termComboBox.SelectedItem?.ToString();
            int year;
            if (string.IsNullOrEmpty(term) || !int.TryParse(yearTextBox.Text.Trim(), out year))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = SemesterDl.UpdateSemester(semesterId, term, year);
            if (result > 0)
            {
                MessageBox.Show("Semester updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSemesters();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (semesterDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a semester to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int semesterId = Convert.ToInt32(semesterDataGridView.SelectedRows[0].Cells["semester_id"].Value);
            int result = SemesterDl.DeleteSemester(semesterId);

            if (result > 0)
            {
                MessageBox.Show("Semester deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSemesters();
            }
            else if (result == -1)
            {
                MessageBox.Show("Cannot delete semester. It is used as a foreign key in another table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Failed to delete semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            termComboBox.SelectedIndex = -1;
            yearTextBox.Clear();
        }
        private void semesterDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (semesterDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = semesterDataGridView.SelectedRows[0];
                termComboBox.SelectedItem = selectedRow.Cells["term"].Value.ToString();
                yearTextBox.Text = selectedRow.Cells["year"].Value.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void Semestermanage_Load(object sender, EventArgs e)
        {

        }
    }
}
