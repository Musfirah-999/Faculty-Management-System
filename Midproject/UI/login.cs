using Microsoft.VisualBasic.ApplicationServices;
using Midproject.DL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Midproject
{

    public partial class login : Form
    {
        private bool isPasswordVisible = false;
        public login()
        {
            InitializeComponent();
        }
       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpassword forgot = new forgotpassword();
            this.Hide();
            forgot.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signUp = new Signup();
            this.Hide();
            signUp.ShowDialog();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string username = user_name.Text.Trim();
            string password = Password.Text.Trim();
            string role = Role.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Username, Password, and Role are required.");
                return;
            }

            string hashedPassword = HashPassword(password);
            DataTable dt = LoginDL.CheckLogin(username, hashedPassword, role);

            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                string roleName = dt.Rows[0]["role_name"].ToString();

                if (roleName == "Admin")
                {
                    this.Hide();
                    new Adminhome(userId).Show();
                }
                else if (roleName == "Department Head")
                {
                    this.Hide();
                    new Headhome(userId).Show();
                }
                else if (roleName == "Faculty")
                {
                    int facultyId = FacultyDL.GetFacultyIdByUserId(userId);
                    this.Hide();
                    new facultyhome(facultyId).Show();
                }
                else
                {
                    MessageBox.Show("Invalid role assigned to user.");
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials or role.");
            }
        }
        
     
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void eye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {

                Password.PasswordChar = '\0';
                eye.Text = "???";
            }
            else
            {

                Password.PasswordChar = '*';
                eye.Text = "???";
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

    
