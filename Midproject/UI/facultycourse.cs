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
    public partial class facultycourse : Form
    {
        public facultycourse()
        {
            InitializeComponent();
            LoadData();

        }
        FacultyCourseDL fcDL = new FacultyCourseDL();

        private void LoadData()
        {
            DataTable dt = FacultyCourseDL.GetAllFacultyCourses();
            dataGridViewFacultyCourses.DataSource = dt;
        }
        private void LoadDropdowns()
        {
           
            facultycomboBox.DataSource = FacultyCourseDL.GetFaculty();
            facultycomboBox.DisplayMember = "faculty_id";
            facultycomboBox.ValueMember = "faculty_id";


            coursecomboBox.DataSource = FacultyCourseDL.GetCourses();
            coursecomboBox.DisplayMember = "course_id";
            coursecomboBox.ValueMember = "course_id";

            
            semestercomboBox.DataSource = FacultyCourseDL.GetSemesters();
            semestercomboBox.DisplayMember = "semester_id";
            semestercomboBox.ValueMember = "semester_id";
        }
        private void LoadFacultyCourses()
        {
            dataGridViewFacultyCourses.DataSource = FacultyCourseDL.GetAllFacultyCourses();
        }

        private void facultycourse_Load(object sender, EventArgs e)
        {

            LoadDropdowns();
            LoadFacultyCourses();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int facultyId = Convert.ToInt32(facultycomboBox.SelectedValue);
            int courseId = Convert.ToInt32(coursecomboBox.SelectedValue);
            int semesterId = Convert.ToInt32(semestercomboBox.SelectedValue);

            int result = FacultyCourseDL.AddFacultyCourse(facultyId, courseId, semesterId);
            if (result == -1)
            {
                MessageBox.Show("This course is already assigned in this semester.");
            }
            else
            {
                MessageBox.Show("Faculty Course Assigned Successfully.");
                LoadFacultyCourses();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (dataGridViewFacultyCourses.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewFacultyCourses.SelectedRows[0].Cells["faculty_course_id"].Value);
                int facultyId = Convert.ToInt32(facultycomboBox.SelectedValue);
                int courseId = Convert.ToInt32(coursecomboBox.SelectedValue);
                int semesterId = Convert.ToInt32(semestercomboBox.SelectedValue);

                int result = FacultyCourseDL.UpdateFacultyCourse(id, facultyId, courseId, semesterId);
                if (result == -1)
                {
                    MessageBox.Show("This course is already assigned in this semester.");
                }
                else
                {
                    MessageBox.Show("Updated Successfully.");
                    LoadFacultyCourses();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewFacultyCourses.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewFacultyCourses.SelectedRows[0].Cells["faculty_course_id"].Value);
                int result = FacultyCourseDL.DeleteFacultyCourse(id);
                if (result > 0)
                {
                    MessageBox.Show("Deleted Successfully.");
                    LoadFacultyCourses();
                }
                else
                {
                    MessageBox.Show("Delete Failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
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
