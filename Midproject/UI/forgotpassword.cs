using Midproject.DL;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Midproject
{
    public partial class forgotpassword : Form
    {
        private bool isPasswordVisible = false;
        public forgotpassword()
        {
            InitializeComponent();

           
            eye.Text = "👁️";
            eye.Font = new Font("Segoe UI Emoji", 12); 
            eye.LinkBehavior = LinkBehavior.NeverUnderline; 
            eye.LinkColor = Color.Black; 
            eye.ActiveLinkColor = Color.Black; 
            eye.Cursor = Cursors.Hand;

            
            newpass.PasswordChar = '*';
            confirmpass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string newPassword = newpass.Text.Trim();
            string confirmPassword = confirmpass.Text.Trim();

         
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    if (conn == null)
                    {
                        MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                 
                    string verifyQuery = "SELECT user_id FROM users WHERE email = @email";
                    using (var verifyCmd = new MySqlCommand(verifyQuery, conn))
                    {
                        verifyCmd.Parameters.AddWithValue("@email", email);

                        object userId = verifyCmd.ExecuteScalar();

                        if (userId == null)
                        {
                            MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string hashedPassword = HashPassword(newPassword);

                  
                    string updateQuery = "UPDATE users SET password_hash = @password WHERE email = @email";
                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@password", hashedPassword);
                        updateCmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            this.Hide(); 
                            login loginForm = new login();
                            loginForm.Show(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void ClearForm()
        {
            Email.Clear();
            newpass.Clear();
            confirmpass.Clear();
        }

        private void eye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
              
                newpass.PasswordChar = '\0';
                confirmpass.PasswordChar = '\0'; 
                eye.Text = "👁️"; 
            }
            else
            {
               
                newpass.PasswordChar = '*'; 
                confirmpass.PasswordChar = '*'; 
                eye.Text = "👁️"; 
            }
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
           
            if (newpass.Text != confirmpass.Text)
            {
                
            }
            else
            {
               
            }
        }
    }
}