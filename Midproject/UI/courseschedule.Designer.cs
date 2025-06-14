namespace Midproject.UI
{
    partial class courseschedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseschedule));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            roomcomboBox = new ComboBox();
            daycomboBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            facultycomboBox = new ComboBox();
            scheduleDataGridView = new DataGridView();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).BeginInit();
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
            groupBox1.TabIndex = 8;
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
            deleteButton.Text = "Delete ";
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
            updateButton.Text = "Edit ";
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
            label5.Location = new Point(78, 628);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 3;
            label5.Text = "Log off";
            label5.Click += label5_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(roomcomboBox);
            groupBox2.Controls.Add(daycomboBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(facultycomboBox);
            groupBox2.Location = new Point(410, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 467);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(28, 344);
            label6.Name = "label6";
            label6.Size = new Size(215, 23);
            label6.TabIndex = 27;
            label6.Text = "Select end time:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 259);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 26;
            label2.Text = "Select start time:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(25, 370);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(288, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(2025, 3, 23, 7, 55, 19, 0);
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 106);
            label4.Name = "label4";
            label4.Size = new Size(215, 23);
            label4.TabIndex = 23;
            label4.Text = "Select room:";
            // 
            // roomcomboBox
            // 
            roomcomboBox.FormattingEnabled = true;
            roomcomboBox.Location = new Point(25, 141);
            roomcomboBox.Name = "roomcomboBox";
            roomcomboBox.Size = new Size(288, 23);
            roomcomboBox.TabIndex = 22;
            // 
            // daycomboBox
            // 
            daycomboBox.FormattingEnabled = true;
            daycomboBox.Location = new Point(25, 222);
            daycomboBox.Name = "daycomboBox";
            daycomboBox.Size = new Size(288, 23);
            daycomboBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(28, 186);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 17;
            label3.Text = "Select day:";
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
            // facultycomboBox
            // 
            facultycomboBox.FormattingEnabled = true;
            facultycomboBox.Location = new Point(25, 59);
            facultycomboBox.Name = "facultycomboBox";
            facultycomboBox.Size = new Size(288, 23);
            facultycomboBox.TabIndex = 0;
            // 
            // scheduleDataGridView
            // 
            scheduleDataGridView.BackgroundColor = Color.SteelBlue;
            scheduleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleDataGridView.Location = new Point(386, 610);
            scheduleDataGridView.Name = "scheduleDataGridView";
            scheduleDataGridView.Size = new Size(499, 127);
            scheduleDataGridView.TabIndex = 17;
            scheduleDataGridView.CellContentClick += scheduleDataGridView_CellContentClick;
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(438, 21);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 18;
            label8.Text = "Welcome to Course Schedule Management Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // courseschedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(label8);
            Controls.Add(scheduleDataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "courseschedule";
            Text = "courseschedule";
            Load += courseschedule_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleDataGridView).EndInit();
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
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private ComboBox facultycomboBox;
        private ComboBox daycomboBox;
        private DataGridView scheduleDataGridView;
        private Label label8;
        private Label label4;
        private ComboBox roomcomboBox;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label2;
    }
}