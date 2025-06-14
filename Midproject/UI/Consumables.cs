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
    public partial class Consumables : Form
    {
        public Consumables()
        {
            InitializeComponent();
            LoadConsumables();
        }
        private void LoadConsumables()
        {
            consumablesDataGridView.DataSource = ConsumableDL.GetAllConsumables();
        }

        private void ClearForm()
        {
            consumableNameTextBox.Clear();
            
            consumablesDataGridView.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string consumablename = consumableNameTextBox.Text.Trim();
            int result = ConsumableDL.AddConsumable(consumablename);
            if (result > 0)
            {
                MessageBox.Show("Consumable added succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConsumables();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add consumable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (consumablesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a consumable to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int consumableid = Convert.ToInt32(consumablesDataGridView.SelectedRows[0].Cells["consumable_id"].Value);
            string consumablename = consumableNameTextBox.Text.Trim();

            int result = ConsumableDL.UpdateConsumable(consumableid, consumablename); 

            if (result > 0)
            {
                MessageBox.Show("Consumable updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConsumables();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update consumable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (consumablesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a consumable to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int consumableid = Convert.ToInt32(consumablesDataGridView.SelectedRows[0].Cells["consumable_id"].Value);
            int result = ConsumableDL.DeleteConsumable(consumableid);
            if (result > 0)
            {

                MessageBox.Show("Consumable deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadConsumables();
                ClearForm();
            }
            else if (result == -1)
            {
                MessageBox.Show("Cannot delete. Consumable_id is used as a foreign key in faculty_requests table.", "Warning");
            }
            else
            {
                MessageBox.Show("Failed to delete consumable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Adminhome home = new Adminhome();
            this.Hide();
            home.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
        }
    }
}
