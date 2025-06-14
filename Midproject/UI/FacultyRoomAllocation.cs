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
    public partial class FacultyRoomAllocation : Form
    {
        public FacultyRoomAllocation()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridViewAllocations.DataSource = FacultyRoomAllocationDL.GetAllAllocations();
            facultycomboBox.DataSource = FacultyRoomAllocationDL.GetFaculty();
            facultycomboBox.DisplayMember = "name";
            facultycomboBox.ValueMember = "faculty_id";

            roomcomboBox.DataSource = FacultyRoomAllocationDL.GetRooms();
            roomcomboBox.DisplayMember = "room_name";
            roomcomboBox.ValueMember = "room_id";

            semestercomboBox.DataSource = FacultyRoomAllocationDL.GetSemesters();
            semestercomboBox.DisplayMember = "semester";
            semestercomboBox.ValueMember = "semester_id";
        }
        private void FacultyRoomAllocation_Load(object sender, EventArgs e)
        {

        }

        private void roomcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int facultyId = Convert.ToInt32(facultycomboBox.SelectedValue);
            int roomId = Convert.ToInt32(roomcomboBox.SelectedValue);
            int semesterId = Convert.ToInt32(semestercomboBox.SelectedValue);

            if (!int.TryParse(textBox.Text.Trim(), out int reservedHours))
            {
                MessageBox.Show("Please enter a valid number for Reserved Hours.");
                return;
            }


            if (FacultyRoomAllocationDL.IsRoomAlreadyAssignedToAnyFaculty(roomId, semesterId))
            {
                MessageBox.Show("This room is already assigned to a faculty in selected semester.");
                return;
            }

            int result = FacultyRoomAllocationDL.AddRoomAllocation(facultyId, roomId, reservedHours, semesterId);
            if (result > 0)
            {
                MessageBox.Show("Room Assigned Successfully");
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed to assign room.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllocations.SelectedRows.Count == 0) { MessageBox.Show("Select a row"); return; }
            int id = Convert.ToInt32(dataGridViewAllocations.SelectedRows[0].Cells["allocation_id"].Value);
            int facultyId = Convert.ToInt32(facultycomboBox.SelectedValue);
            int roomId = Convert.ToInt32(roomcomboBox.SelectedValue);
            int semesterId = Convert.ToInt32(semestercomboBox.SelectedValue);
            int hours = int.TryParse(textBox.Text.Trim(), out int h) ? h : 0;
            if (!int.TryParse(textBox.Text.Trim(), out int reservedHours))
            {
                MessageBox.Show("Please enter a valid number for Reserved Hours.");
                return;
            }


            if (FacultyRoomAllocationDL.IsRoomAlreadyAssignedToAnyFaculty(roomId, semesterId))
            {
                MessageBox.Show("This room is already assigned to a faculty in selected semester.");
                return;
            }

            int result = FacultyRoomAllocationDL.UpdateRoomAllocation(id, facultyId, roomId, hours, semesterId);
            if (result > 0)
            {
                MessageBox.Show("Updated Successfully");
                LoadData();
            }
            else
                MessageBox.Show("Update Failed");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllocations.SelectedRows.Count == 0) { MessageBox.Show("Select a row"); return; }
            int id = Convert.ToInt32(dataGridViewAllocations.SelectedRows[0].Cells["allocation_id"].Value);
            int result = FacultyRoomAllocationDL.DeleteRoomAllocation(id);
            if (result > 0)
            {
                MessageBox.Show("Deleted Successfully");
                LoadData();
            }
            else
                MessageBox.Show("Delete Failed");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Headhome h = new Headhome();
            this.Hide();
            h.ShowDialog();
        }
    }
}
