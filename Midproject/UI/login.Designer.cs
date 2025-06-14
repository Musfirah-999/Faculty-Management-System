namespace Midproject
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            eye = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label8 = new Label();
            Role = new ComboBox();
            loginbutton = new Button();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            Password = new TextBox();
            user_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(eye);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Role);
            groupBox1.Controls.Add(loginbutton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(user_name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(405, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 503);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // eye
            // 
            eye.ActiveLinkColor = Color.SteelBlue;
            eye.BackColor = Color.White;
            eye.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            eye.LinkBehavior = LinkBehavior.NeverUnderline;
            eye.LinkColor = Color.Black;
            eye.Location = new Point(395, 194);
            eye.Name = "eye";
            eye.Size = new Size(27, 20);
            eye.TabIndex = 2;
            eye.TabStop = true;
            eye.Text = "👁️";
            eye.LinkClicked += eye_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.SteelBlue;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(266, 459);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 21);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register Now";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(101, 459);
            label8.Name = "label8";
            label8.Size = new Size(195, 23);
            label8.TabIndex = 12;
            label8.Text = "Don't have account?";
            // 
            // Role
            // 
            Role.FormattingEnabled = true;
            Role.Items.AddRange(new object[] { "Admin", "Department Head", "Faculty " });
            Role.Location = new Point(47, 268);
            Role.Name = "Role";
            Role.Size = new Size(377, 23);
            Role.TabIndex = 11;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.SteelBlue;
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(47, 393);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(377, 53);
            loginbutton.TabIndex = 9;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(47, 321);
            label6.Name = "label6";
            label6.Size = new Size(385, 23);
            label6.TabIndex = 8;
            label6.Text = "---------------------------OR----------------------------------";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.SteelBlue;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(166, 356);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 21);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgotpassword?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Password
            // 
            Password.Location = new Point(47, 194);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(377, 23);
            Password.TabIndex = 5;
            // 
            // user_name
            // 
            user_name.Location = new Point(47, 113);
            user_name.Name = "user_name";
            user_name.Size = new Size(377, 23);
            user_name.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(47, 232);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 3;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(47, 157);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(47, 75);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(185, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(442, 34);
            label1.Name = "label1";
            label1.Size = new Size(372, 80);
            label1.TabIndex = 1;
            label1.Text = "Department of Comuter Science\r\nUET Lahore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 670);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "login";
            Load += login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private LinkLabel linkLabel1;
        private TextBox Password;
        private TextBox user_name;
        private Label label5;
        private Label label4;
        private Button loginbutton;
        private ComboBox Role;
        private Label label8;
        private LinkLabel linkLabel2;
        private LinkLabel eye;
    }
}
