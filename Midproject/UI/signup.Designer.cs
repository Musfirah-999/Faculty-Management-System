namespace Midproject
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            Role = new ComboBox();
            label7 = new Label();
            signupbutton = new Button();
            Email = new TextBox();
            Password = new TextBox();
            user_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            eye = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(441, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 80);
            label1.TabIndex = 2;
            label1.Text = "Department of Comuter Science\r\nUET Lahore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(eye);
            groupBox1.Controls.Add(Role);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(signupbutton);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(user_name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(391, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 482);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Role
            // 
            Role.FormattingEnabled = true;
            Role.Items.AddRange(new object[] { "Admin", "Department Head", "Faculty" });
            Role.Location = new Point(52, 332);
            Role.Name = "Role";
            Role.Size = new Size(372, 23);
            Role.TabIndex = 11;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(47, 233);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 10;
            label7.Text = "Email Address:";
            // 
            // signupbutton
            // 
            signupbutton.BackColor = Color.SteelBlue;
            signupbutton.Cursor = Cursors.Hand;
            signupbutton.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbutton.ForeColor = SystemColors.Control;
            signupbutton.Location = new Point(47, 391);
            signupbutton.Name = "signupbutton";
            signupbutton.Size = new Size(377, 53);
            signupbutton.TabIndex = 9;
            signupbutton.Text = "SignUp";
            signupbutton.UseVisualStyleBackColor = false;
            signupbutton.Click += button1_Click;
            // 
            // Email
            // 
            Email.Location = new Point(47, 259);
            Email.Name = "Email";
            Email.Size = new Size(377, 23);
            Email.TabIndex = 6;
            // 
            // Password
            // 
            Password.Location = new Point(47, 192);
            Password.Name = "Password";
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
            label5.Location = new Point(52, 296);
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
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(185, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 0;
            label2.Text = "SignUp";
            // 
            // eye
            // 
            eye.ActiveLinkColor = Color.SteelBlue;
            eye.BackColor = Color.White;
            eye.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            eye.LinkBehavior = LinkBehavior.NeverUnderline;
            eye.LinkColor = Color.Black;
            eye.Location = new Point(397, 192);
            eye.Name = "eye";
            eye.Size = new Size(27, 20);
            eye.TabIndex = 4;
            eye.TabStop = true;
            eye.Text = "👁️";
            eye.LinkClicked += eye_LinkClicked;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 635);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Signup";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox Role;
        private Label label7;
        private Button signupbutton;
        private TextBox Email;
        private TextBox Password;
        private TextBox user_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel eye;
    }
}