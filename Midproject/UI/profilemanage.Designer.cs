namespace Midproject.UI
{
    partial class profilemanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilemanage));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            facultyDataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            designationComboBox = new ComboBox();
            teachingHoursTextBox = new TextBox();
            researchAreaTextBox = new TextBox();
            contactTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facultyDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 673);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.SteelBlue;
            clearButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(25, 533);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(211, 48);
            clearButton.TabIndex = 13;
            clearButton.Text = "Back";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(25, 444);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 48);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete faculty member";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(25, 355);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(211, 48);
            updateButton.TabIndex = 11;
            updateButton.Text = "Edit faculty member";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(25, 259);
            addButton.Name = "addButton";
            addButton.Size = new Size(211, 48);
            addButton.TabIndex = 10;
            addButton.Text = "Add faculty member";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(25, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 172);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(67, 614);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 3;
            label5.Text = "Log off";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.SteelBlue;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(485, 18);
            label7.Name = "label7";
            label7.Size = new Size(436, 57);
            label7.TabIndex = 7;
            label7.Text = "Welcome to Faculty Profile Management Panel\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // facultyDataGridView
            // 
            facultyDataGridView.AllowUserToAddRows = false;
            facultyDataGridView.AllowUserToDeleteRows = false;
            facultyDataGridView.AllowUserToOrderColumns = true;
            facultyDataGridView.BackgroundColor = Color.SteelBlue;
            facultyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facultyDataGridView.Location = new Point(307, 435);
            facultyDataGridView.Name = "facultyDataGridView";
            facultyDataGridView.Size = new Size(783, 150);
            facultyDataGridView.TabIndex = 8;
            facultyDataGridView.CellClick += facultyDataGridView_CellClick_1;
            facultyDataGridView.CellContentClick += facultyDataGridView_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(designationComboBox);
            groupBox2.Controls.Add(teachingHoursTextBox);
            groupBox2.Controls.Add(researchAreaTextBox);
            groupBox2.Controls.Add(contactTextBox);
            groupBox2.Controls.Add(emailTextBox);
            groupBox2.Controls.Add(nameTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(307, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(783, 267);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // designationComboBox
            // 
            designationComboBox.ForeColor = SystemColors.WindowFrame;
            designationComboBox.FormattingEnabled = true;
            designationComboBox.Items.AddRange(new object[] { "Lecturer", "Assistant Professor", "Associate Professor", "Professor" });
            designationComboBox.Location = new Point(390, 75);
            designationComboBox.Name = "designationComboBox";
            designationComboBox.Size = new Size(326, 23);
            designationComboBox.TabIndex = 10;
            designationComboBox.Text = "Designation:";
            // 
            // teachingHoursTextBox
            // 
            teachingHoursTextBox.Location = new Point(390, 224);
            teachingHoursTextBox.Name = "teachingHoursTextBox";
            teachingHoursTextBox.PlaceholderText = "Total teaching hours:";
            teachingHoursTextBox.Size = new Size(326, 23);
            teachingHoursTextBox.TabIndex = 9;
            // 
            // researchAreaTextBox
            // 
            researchAreaTextBox.Location = new Point(390, 154);
            researchAreaTextBox.Name = "researchAreaTextBox";
            researchAreaTextBox.PlaceholderText = "Reasarch area:";
            researchAreaTextBox.Size = new Size(326, 23);
            researchAreaTextBox.TabIndex = 8;
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(26, 200);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.PlaceholderText = "Contact:";
            contactTextBox.Size = new Size(326, 23);
            contactTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(26, 118);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email:";
            emailTextBox.Size = new Size(326, 23);
            emailTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(26, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name:";
            nameTextBox.Size = new Size(326, 23);
            nameTextBox.TabIndex = 4;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(67, 614);
            label9.Name = "label9";
            label9.Size = new Size(106, 31);
            label9.TabIndex = 3;
            label9.Text = "Log off";
            // 
            // profilemanage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 730);
            Controls.Add(groupBox2);
            Controls.Add(facultyDataGridView);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "profilemanage";
            Text = "profilemanage";
            Load += profilemanage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)facultyDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label7;
        private DataGridView facultyDataGridView;
        private GroupBox groupBox2;
        private TextBox nameTextBox;
        private Label label9;
        private TextBox teachingHoursTextBox;
        private TextBox researchAreaTextBox;
        private TextBox contactTextBox;
        private TextBox emailTextBox;
        private ComboBox designationComboBox;
        private Button addButton;
        private Button clearButton;
        private Button deleteButton;
        private Button updateButton;
    }
}