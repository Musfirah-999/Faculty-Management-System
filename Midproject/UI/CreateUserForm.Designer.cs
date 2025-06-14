namespace Midproject.UI
{
    partial class Adminfaculty
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
            groupBox1 = new GroupBox();
            addButton = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(271, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ControlDarkDark;
            addButton.Location = new Point(109, 235);
            addButton.Name = "addButton";
            addButton.Size = new Size(124, 50);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(28, 175);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password:";
            passwordTextBox.Size = new Size(306, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(28, 119);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email:";
            emailTextBox.Size = new Size(306, 23);
            emailTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(28, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name:";
            nameTextBox.Size = new Size(306, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(380, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 43);
            label1.TabIndex = 1;
            label1.Text = "Add Faculty";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adminfaculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 531);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Adminfaculty";
            Text = "Adminfaculty";
            Load += Adminfaculty_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private TextBox nameTextBox;
        private Button addButton;
        private Label label1;
    }
}