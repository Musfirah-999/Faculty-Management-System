
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
    public partial class profilemanage : Form
    {
        private int userId;
        public profilemanage(int userId, string name, string email)
        {
            InitializeComponent();
            this.userId = userId;
            nameTextBox.Text = name;
            emailTextBox.Text = email;
            LoadFacultyData();
        }

        public profilemanage()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void profilemanage_Load(object sender, EventArgs e)
        {
         
        }
        private void LoadFacultyData()
        {
            facultyDataGridView.DataSource = ProfileDL.GetAllFaculty();
        }
       

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string researchArea = researchAreaTextBox.Text.Trim();
            int teachingHours = int.TryParse(teachingHoursTextBox.Text.Trim(), out int h) ? h : 0;
            int desigId = GetManualDesignationId(designationComboBox.SelectedItem?.ToString());

            if (desigId == 0 || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int result = ProfileDL.AddFaculty(name, email, contact, desigId, researchArea, teachingHours);
            if (result > 0)
            {
                MessageBox.Show("Faculty added successfully.");
                LoadFacultyData();
            }
            else
            {
                MessageBox.Show("Faculty addition failed.");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            Adminhome admin = new Adminhome();
            this.Hide();
            admin.ShowDialog();
        }
      

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (facultyDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            int facultyId = Convert.ToInt32(facultyDataGridView.SelectedRows[0].Cells["faculty_id"].Value);
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string researchArea = researchAreaTextBox.Text.Trim();
            int teachingHours = int.TryParse(teachingHoursTextBox.Text.Trim(), out int h) ? h : 0;
            string designation = designationComboBox.SelectedItem?.ToString();
            int designationId = GetManualDesignationId(designation);

            int result = ProfileDL.UpdateFaculty(facultyId, name, email, contact, designationId, researchArea, teachingHours);
            if (result > 0)
            {
                MessageBox.Show("Updated successfully.");
                LoadFacultyData();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private int GetManualDesignationId(string designation)
        {
            if (designation == "Lecturer") return 4;
            if (designation == "Assistant Professor") return 5;
            if (designation == "Associate Professor") return 6;
            if (designation == "Professor") return 7;
            return 0;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (facultyDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            int facultyId = Convert.ToInt32(facultyDataGridView.SelectedRows[0].Cells["faculty_id"].Value);
            int result = ProfileDL.DeleteFaculty(facultyId);
            if (result > 0)
            {
                MessageBox.Show("Deleted successfully.");
                LoadFacultyData();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }
       
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void facultyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facultyDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
