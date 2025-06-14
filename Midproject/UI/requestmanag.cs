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
    public partial class requestmanage : Form
    {
        public requestmanage()
        {
            InitializeComponent();
        }
        private void LoadRequests()
        {
            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    string query = @"SELECT r.request_id, u.username, r.resource_requested, 
                                     r.description, r.status, r.request_date 
                                     FROM requests r 
                                     JOIN users u ON r.user_id = u.user_id";

                    using (var adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        requestsGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading requests: " + ex.Message);
            }
        }

        private void UpdateRequestStatus(string newStatus)
        {
            if (requestsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId = Convert.ToInt32(requestsGridView.SelectedRows[0].Cells["request_id"].Value);

            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    string query = "UPDATE requests SET status = @status WHERE request_id = @requestId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@requestId", requestId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Request status updated to {newStatus}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRequests();
            }
            catch (Exception ex)
            {
                ShowError("Error updating request status: " + ex.Message);
            }
        }



        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void requestmanage_Load(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            UpdateRequestStatus("Approved");

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
        
            UpdateRequestStatus("Rejected");
        }
    
    }
}
