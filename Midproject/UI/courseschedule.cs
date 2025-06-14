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
    public partial class courseschedule : Form
    {
        public courseschedule()
        {
            InitializeComponent();
            LoadData();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }
        private void LoadData()
        {
            scheduleDataGridView.DataSource = coursescheduleDL.GetAllSchedules();

            facultycomboBox.DataSource = coursescheduleDL.GetFacultyCourseIds();
            facultycomboBox.DisplayMember = "DisplayText";
            facultycomboBox.ValueMember = "faculty_course_id";

            roomcomboBox.DataSource = coursescheduleDL.GetRooms();
            roomcomboBox.DisplayMember = "room_name";
            roomcomboBox.ValueMember = "room_id";

            daycomboBox.Items.Clear();
            daycomboBox.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
        }



        private void courseschedule_Load(object sender, EventArgs e)
        {

        }

        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int facultyCourseId = Convert.ToInt32(facultycomboBox.SelectedValue);
            int roomId = Convert.ToInt32(roomcomboBox.SelectedValue);
            string day = daycomboBox.SelectedItem?.ToString();
            string startTime = dateTimePicker1.Value.ToString("HH:mm:ss");
            string endTime = dateTimePicker2.Value.ToString("HH:mm:ss");

            if (string.IsNullOrEmpty(day))
            {
                MessageBox.Show("Please select a day.");
                return;
            }

            if (coursescheduleDL.IsScheduleConflict(facultyCourseId, day))
            {
                MessageBox.Show("Schedule already exists for this faculty-course on the selected day.");
                return;
            }

            int result = coursescheduleDL.AddSchedule(facultyCourseId, roomId, day, startTime, endTime);
            if (result > 0)
            {
                MessageBox.Show("Schedule Added Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to add schedule");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a schedule to update");
                return;
            }

            int id = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells["schedule_id"].Value);
            int facultyCourseId = Convert.ToInt32(facultycomboBox.SelectedValue);
            int roomId = Convert.ToInt32(roomcomboBox.SelectedValue);
            string day = daycomboBox.SelectedItem?.ToString();
            string startTime = dateTimePicker1.Value.ToString("HH:mm:ss");
            string endTime = dateTimePicker2.Value.ToString("HH:mm:ss");

            if (string.IsNullOrEmpty(day))
            {
                MessageBox.Show("Please select a day.");
                return;
            }

            int result = coursescheduleDL.UpdateSchedule(id, facultyCourseId, roomId, day, startTime, endTime);
            if (result > 0)
            {
                MessageBox.Show("Schedule Updated Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a schedule to delete");
                return;
            }

            int id = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells["schedule_id"].Value);
            int result = coursescheduleDL.DeleteSchedule(id);
            if (result > 0)
            {
                MessageBox.Show("Schedule Deleted Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete Failed");
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
