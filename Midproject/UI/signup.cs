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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Midproject
{
    public partial class Signup : Form
    {
        private bool isPasswordVisible = false;
        public Signup()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            Role.Items.Clear();
            DataTable dt = SignupDL.GetUserRoles();
            foreach (DataRow row in dt.Rows)
            {
                Role.Items.Add(row["value"].ToString());
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            string username = user_name.Text.Trim();
            string password = Password.Text.Trim();
            string email = Email.Text.Trim();
            string selectedRole = Role.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roleId = SignupDL.GetRoleId(selectedRole);
            if (roleId == null)
            {
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);

            bool success = SignupDL.InsertUser(username, email, hashedPassword, roleId);
            if (success)
            {
                MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                login l = new login();
                this.Hide();
                l.ShowDialog();
            }
            else
            {
                MessageBox.Show("Signup Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {

            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void ClearForm()
        {
            user_name.Clear();
            Password.Clear();
            Email.Clear();
            Role.SelectedIndex = -1;
        }

        private void eye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {

                Password.PasswordChar = '\0';
                eye.Text = "👁️";
            }
            else
            {

                Password.PasswordChar = '*';
                eye.Text = "👁️";
            }
        }
    }
}


