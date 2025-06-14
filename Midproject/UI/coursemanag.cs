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

namespace Midproject
{
    public partial class Coursemanage : Form
    {
        public Coursemanage()
        {
            InitializeComponent();
            LoadCourses();
            LoadCourseTypes();
        }
        private void LoadCourses()
        {
            coursesDataGridView.DataSource = CourseDL.GetAllCourses();
        }

        private void LoadCourseTypes()
        {
            courseTypeComboBox.Items.Add("Theory");
            courseTypeComboBox.Items.Add("Lab");
        }


        private void Coursemanage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string courseName = courseNameTextBox.Text.Trim();
            string courseType = courseTypeComboBox.SelectedItem?.ToString();
            string creditText = creditHoursTextBox.Text.Trim();
            string contactText = contactHoursTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName) || string.IsNullOrWhiteSpace(courseType) ||
                string.IsNullOrWhiteSpace(creditText) || string.IsNullOrWhiteSpace(contactText))
            {
                MessageBox.Show("Please fill all fields before adding the course.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int creditHours, contactHours;
            if (!int.TryParse(creditText, out creditHours))
            {
                MessageBox.Show("Please enter valid credit hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(contactText, out contactHours))
            {
                MessageBox.Show("Please enter valid contact hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

     
            int result = CourseDL.AddCourse(courseName, courseType, creditHours, contactHours);
            if (result > 0)
            {
                MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {

            if (coursesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = Convert.ToInt32(coursesDataGridView.SelectedRows[0].Cells["course_id"].Value);
            string courseName = courseNameTextBox.Text.Trim();
            string courseType = courseTypeComboBox.Text;
            int creditHours, contactHours;
            if (!int.TryParse(creditHoursTextBox.Text.Trim(), out creditHours))
            {
                MessageBox.Show("Please enter valid credit hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(contactHoursTextBox.Text.Trim(), out contactHours))
            {
                MessageBox.Show("Please enter valid contact hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = CourseDL.UpdateCourse(courseId, courseName, courseType, creditHours, contactHours);
            if (result > 0)
            {
                MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            courseNameTextBox.Clear();
            creditHoursTextBox.Clear();
            contactHoursTextBox.Clear();
            courseTypeComboBox.SelectedIndex = -1;
            coursesDataGridView.ClearSelection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (coursesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = Convert.ToInt32(coursesDataGridView.SelectedRows[0].Cells["course_id"].Value);
            int result = CourseDL.DeleteCourse(courseId);
            if (result > 0)
            {
                MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
                ClearForm();
            }
            else if (result == -1)
            {
                MessageBox.Show("Cannot delete. course_id is used as a foreign key in another table.", "Warning");
            }
            else
            {
                MessageBox.Show("Failed to delete course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void coursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            Adminhome admin = new Adminhome();
            this.Hide();
            admin.ShowDialog();
        }
    }

}
