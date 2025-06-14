namespace Midproject
{
    partial class forgotpassword
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
            linkLabel1 = new LinkLabel();
            eye = new LinkLabel();
            login = new Button();
            confirmpass = new TextBox();
            newpass = new TextBox();
            Email = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(493, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 80);
            label1.TabIndex = 2;
            label1.Text = "Department of Comuter Science\r\nUET Lahore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(eye);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(confirmpass);
            groupBox1.Controls.Add(newpass);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(455, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 465);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(397, 284);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(27, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "👁️";
            linkLabel1.VisitedLinkColor = Color.SteelBlue;
            // 
            // eye
            // 
            eye.BackColor = Color.White;
            eye.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            eye.LinkBehavior = LinkBehavior.NeverUnderline;
            eye.LinkColor = Color.Black;
            eye.Location = new Point(397, 214);
            eye.Name = "eye";
            eye.Size = new Size(27, 20);
            eye.TabIndex = 10;
            eye.TabStop = true;
            eye.Text = "👁️";
            eye.VisitedLinkColor = Color.SteelBlue;
            eye.LinkClicked += eye_LinkClicked;
            // 
            // login
            // 
            login.BackColor = Color.SteelBlue;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.Location = new Point(47, 351);
            login.Name = "login";
            login.Size = new Size(377, 53);
            login.TabIndex = 9;
            login.Text = "Back to Login";
            login.UseVisualStyleBackColor = false;
            login.Click += button1_Click;
            // 
            // confirmpass
            // 
            confirmpass.Location = new Point(47, 284);
            confirmpass.Name = "confirmpass";
            confirmpass.PasswordChar = '*';
            confirmpass.Size = new Size(377, 23);
            confirmpass.TabIndex = 6;
            confirmpass.TextChanged += confirmpass_TextChanged;
            // 
            // newpass
            // 
            newpass.Location = new Point(47, 214);
            newpass.Name = "newpass";
            newpass.PasswordChar = '*';
            newpass.Size = new Size(377, 23);
            newpass.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(47, 135);
            Email.Name = "Email";
            Email.Size = new Size(377, 23);
            Email.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(47, 249);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(47, 179);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 2;
            label4.Text = "New Password:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(47, 97);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 1;
            label3.Text = "Email Address:";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 35);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 0;
            label2.Text = "Forgot password";
            // 
            // forgotpassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 618);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "forgotpassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button login;
        private TextBox confirmpass;
        private TextBox newpass;
        private TextBox Email;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel eye;
    }
}