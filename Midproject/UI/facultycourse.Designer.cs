namespace Midproject.UI
{
    partial class facultycourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facultycourse));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            dataGridViewFacultyCourses = new DataGridView();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            semestercomboBox = new ComboBox();
            coursecomboBox = new ComboBox();
            facultycomboBox = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacultyCourses).BeginInit();
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
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 704);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.SteelBlue;
            clearButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(28, 488);
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
            deleteButton.Location = new Point(28, 388);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 48);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete Assigned course";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(28, 304);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(211, 48);
            updateButton.TabIndex = 12;
            updateButton.Text = "Edit Assigned course\r\n";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
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
            addButton.Text = "Add Assigned course";
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
            label5.Location = new Point(78, 628);
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
            label8.Location = new Point(478, 21);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 7;
            label8.Text = "Welcome to Faculty Course Management Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFacultyCourses
            // 
            dataGridViewFacultyCourses.BackgroundColor = Color.SteelBlue;
            dataGridViewFacultyCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFacultyCourses.Location = new Point(350, 489);
            dataGridViewFacultyCourses.Name = "dataGridViewFacultyCourses";
            dataGridViewFacultyCourses.Size = new Size(499, 150);
            dataGridViewFacultyCourses.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(semestercomboBox);
            groupBox2.Controls.Add(coursecomboBox);
            groupBox2.Controls.Add(facultycomboBox);
            groupBox2.Location = new Point(350, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 259);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 165);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 17;
            label3.Text = "Select semester:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 16;
            label2.Text = "Select course:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 15;
            label1.Text = "Select faculty memeber:";
            // 
            // semestercomboBox
            // 
            semestercomboBox.FormattingEnabled = true;
            semestercomboBox.Location = new Point(25, 200);
            semestercomboBox.Name = "semestercomboBox";
            semestercomboBox.Size = new Size(288, 23);
            semestercomboBox.TabIndex = 14;
            // 
            // coursecomboBox
            // 
            coursecomboBox.FormattingEnabled = true;
            coursecomboBox.Location = new Point(25, 132);
            coursecomboBox.Name = "coursecomboBox";
            coursecomboBox.Size = new Size(288, 23);
            coursecomboBox.TabIndex = 1;
            // 
            // facultycomboBox
            // 
            facultycomboBox.FormattingEnabled = true;
            facultycomboBox.Location = new Point(25, 59);
            facultycomboBox.Name = "facultycomboBox";
            facultycomboBox.Size = new Size(288, 23);
            facultycomboBox.TabIndex = 0;
            // 
            // facultycourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox2);
            Controls.Add(dataGridViewFacultyCourses);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "facultycourse";
            Text = "facultycourse";
            Load += facultycourse_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacultyCourses).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button clearButton;
        private Button deleteButton;
        private Button updateButton;
        private Button addButton;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label8;
        private DataGridView dataGridViewFacultyCourses;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox semestercomboBox;
        private ComboBox coursecomboBox;
        private ComboBox facultycomboBox;
    }
}