namespace Midproject.UI
{
    partial class facultyprojects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facultyprojects));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            supervisionHoursUpDown = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            semesterComboBox = new ComboBox();
            projectComboBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            facultyComboBox = new ComboBox();
            dgvFacultyProjects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supervisionHoursUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacultyProjects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(clearButton);
            groupBox1.Controls.Add(deleteButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 704);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.SteelBlue;
            clearButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(28, 462);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(211, 48);
            clearButton.TabIndex = 14;
            clearButton.Text = "Back";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(28, 339);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 48);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete ";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(28, 211);
            addButton.Name = "addButton";
            addButton.Size = new Size(211, 48);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(28, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 172);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(78, 584);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 3;
            label5.Text = "Log off";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(431, 23);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 19;
            label8.Text = "Welcome to Project Schedule Management Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(supervisionHoursUpDown);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(semesterComboBox);
            groupBox2.Controls.Add(projectComboBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(facultyComboBox);
            groupBox2.Location = new Point(411, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 366);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // supervisionHoursUpDown
            // 
            supervisionHoursUpDown.Location = new Point(33, 301);
            supervisionHoursUpDown.Name = "supervisionHoursUpDown";
            supervisionHoursUpDown.Size = new Size(280, 23);
            supervisionHoursUpDown.TabIndex = 27;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 259);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 26;
            label2.Text = "Select supervison hours:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 106);
            label4.Name = "label4";
            label4.Size = new Size(215, 23);
            label4.TabIndex = 23;
            label4.Text = "Select semester:";
            // 
            // semesterComboBox
            // 
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(25, 141);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(288, 23);
            semesterComboBox.TabIndex = 22;
            // 
            // projectComboBox
            // 
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(25, 222);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(288, 23);
            projectComboBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(28, 186);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 17;
            label3.Text = "Select project:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 15;
            label1.Text = "Select faculty_course:";
            // 
            // facultyComboBox
            // 
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(28, 64);
            facultyComboBox.Name = "facultyComboBox";
            facultyComboBox.Size = new Size(288, 23);
            facultyComboBox.TabIndex = 0;
            // 
            // dgvFacultyProjects
            // 
            dgvFacultyProjects.BackgroundColor = Color.SteelBlue;
            dgvFacultyProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacultyProjects.Location = new Point(327, 491);
            dgvFacultyProjects.Name = "dgvFacultyProjects";
            dgvFacultyProjects.Size = new Size(588, 127);
            dgvFacultyProjects.TabIndex = 21;
            // 
            // facultyprojects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dgvFacultyProjects);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "facultyprojects";
            Text = "facultyprojects";
            Load += facultyprojects_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supervisionHoursUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacultyProjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button clearButton;
        private Button deleteButton;
        private Button addButton;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label8;
        private GroupBox groupBox2;
        private Label label2;
        private Label label4;
        private ComboBox semesterComboBox;
        private ComboBox projectComboBox;
        private Label label3;
        private Label label1;
        private ComboBox facultyComboBox;
        private DataGridView dgvFacultyProjects;
        private NumericUpDown supervisionHoursUpDown;
    }
}