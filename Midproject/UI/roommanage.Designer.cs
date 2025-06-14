namespace Midproject.UI
{
    partial class roommanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roommanage));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            roomtypecomboBox = new ComboBox();
            roomcapacityTextBox = new TextBox();
            roomidTextBox = new TextBox();
            roomNameTextBox = new TextBox();
            label9 = new Label();
            roomsDataGridView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).BeginInit();
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
            groupBox1.Location = new Point(1, 2);
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
            clearButton.Location = new Point(28, 509);
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
            deleteButton.Location = new Point(28, 405);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 48);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete existing Room";
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
            updateButton.Text = "Edit Room info";
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
            addButton.Text = "Add Room";
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
            label5.Location = new Point(63, 605);
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
            label8.Location = new Point(509, 22);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 7;
            label8.Text = "Welcome to Room Management Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(roomtypecomboBox);
            groupBox2.Controls.Add(roomcapacityTextBox);
            groupBox2.Controls.Add(roomidTextBox);
            groupBox2.Controls.Add(roomNameTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(310, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(783, 245);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // roomtypecomboBox
            // 
            roomtypecomboBox.FormattingEnabled = true;
            roomtypecomboBox.Items.AddRange(new object[] { "Classroom", "Lab" });
            roomtypecomboBox.Location = new Point(26, 133);
            roomtypecomboBox.Name = "roomtypecomboBox";
            roomtypecomboBox.Size = new Size(331, 23);
            roomtypecomboBox.TabIndex = 8;
            // 
            // roomcapacityTextBox
            // 
            roomcapacityTextBox.Location = new Point(407, 69);
            roomcapacityTextBox.Name = "roomcapacityTextBox";
            roomcapacityTextBox.PlaceholderText = "Room Capacity:";
            roomcapacityTextBox.Size = new Size(326, 23);
            roomcapacityTextBox.TabIndex = 7;
            // 
            // roomidTextBox
            // 
            roomidTextBox.Location = new Point(407, 169);
            roomidTextBox.Name = "roomidTextBox";
            roomidTextBox.PlaceholderText = "Room_id:";
            roomidTextBox.Size = new Size(326, 23);
            roomidTextBox.TabIndex = 6;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.Location = new Point(26, 36);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.PlaceholderText = "Room Name:";
            roomNameTextBox.Size = new Size(326, 23);
            roomNameTextBox.TabIndex = 4;
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
            // roomsDataGridView
            // 
            roomsDataGridView.AllowUserToAddRows = false;
            roomsDataGridView.AllowUserToDeleteRows = false;
            roomsDataGridView.AllowUserToOrderColumns = true;
            roomsDataGridView.BackgroundColor = Color.SteelBlue;
            roomsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsDataGridView.Location = new Point(310, 488);
            roomsDataGridView.Name = "roomsDataGridView";
            roomsDataGridView.Size = new Size(783, 150);
            roomsDataGridView.TabIndex = 18;
            // 
            // roommanage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(roomsDataGridView);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "roommanage";
            Text = "roommanage";
            Load += roommanage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).EndInit();
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
        private GroupBox groupBox2;
        private ComboBox courseTypeComboBox;
        private TextBox roomidTextBox;
        private TextBox roomNameTextBox;
        private Label label9;
        private DataGridView roomsDataGridView;
        private TextBox roomcapacityTextBox;
        private ComboBox roomtypecomboBox;
    }
}