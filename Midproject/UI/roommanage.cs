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
    public partial class roommanage : Form
    {
        public roommanage()
        {
            InitializeComponent();
            LoadRooms();
            LoadRoomTypes();

        }

        private void roommanage_Load(object sender, EventArgs e)
        {

        }
        private void LoadRooms()
        {
            roomsDataGridView.DataSource = RoomDL.GetAllRooms();
        }
        private void LoadRoomTypes()
        {
            roomtypecomboBox.Items.Add("Classroom");
            roomtypecomboBox.Items.Add("Lab");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }

        private void ClearForm()
        {
            roomNameTextBox.Clear();
            roomidTextBox.Clear();
            roomcapacityTextBox.Clear();
            roomtypecomboBox.SelectedIndex = -1;
            roomsDataGridView.ClearSelection();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string RoomName = roomNameTextBox.Text.Trim();
            string RoomType = roomtypecomboBox.SelectedItem?.ToString();
            int RoomCapacity = int.Parse(roomcapacityTextBox.Text.Trim());
            int Roomid = int.Parse(roomidTextBox.Text.Trim());
            int result = RoomDL.addRooms(Roomid, RoomName, RoomType, RoomCapacity);
            if (result > 0)
            {
                MessageBox.Show("Room added succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (roomsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int Roomid = Convert.ToInt32(roomsDataGridView.SelectedRows[0].Cells["room_id"].Value);
            string RoomName = roomNameTextBox.Text.Trim();
            string RoomType = roomtypecomboBox.SelectedItem?.ToString();
            int RoomCapacity;
            if (!int.TryParse(roomcapacityTextBox.Text.Trim(), out RoomCapacity))
            {
                MessageBox.Show("Please enter a valid numeric Room Capacity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (string.IsNullOrWhiteSpace(RoomName) || string.IsNullOrWhiteSpace(RoomType))
            {
                MessageBox.Show("Please enter Room Name and select Room Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int result = RoomDL.Updaterooms(Roomid, RoomName, RoomType, RoomCapacity);
            if (result > 0)
            {
                MessageBox.Show("Room updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Adminhome a = new Adminhome();
            this.Hide();
            a.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(roomsDataGridView.SelectedRows.Count==0)
            {
                MessageBox.Show("Please select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int roomid = Convert.ToInt32(roomsDataGridView.SelectedRows[0].Cells["room_id"].Value);
            int result = RoomDL.DeleteRoom(roomid);
            if(result >0 )
            {

                MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
                ClearForm();
            }
            else if (result == -1)
            {
                MessageBox.Show("Cannot delete. room_id is used as a foreign key in another table.", "Warning");
            }
            else
            {
                MessageBox.Show("Failed to delete room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
