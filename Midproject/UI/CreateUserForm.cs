using Midproject.DL;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Midproject.UI
{
    public partial class Adminfaculty : Form
    {
        public Adminfaculty()
        {
            InitializeComponent();
        }

        public static string userName, userEmail;

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (UserDL.IsUsernameExists(name))
            {
                MessageBox.Show("Username already exists. Try another one.");
                return;
            }

            if (UserDL.IsEmailExists(email))
            {
                MessageBox.Show("Email already exists. Try another one.");
                return;
            }

            string hashedPassword = HashPassword(password);

            bool success = UserDL.AddUser(name, email, hashedPassword);
            if (success)
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                profilemanage p = new profilemanage();
                this.Hide();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        private void ClearForm()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }
        private void Adminfaculty_Load(object sender, EventArgs e)
        {
            
        }
    }
}
