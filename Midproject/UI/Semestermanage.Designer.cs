namespace Midproject.UI
{
    partial class Semestermanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semestermanage));
            groupBox1 = new GroupBox();
            clearButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            termComboBox = new ComboBox();
            semesteridTextBox = new TextBox();
            yearTextBox = new TextBox();
            label9 = new Label();
            label7 = new Label();
            semesterDataGridView = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)semesterDataGridView).BeginInit();
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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 673);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            deleteButton.Text = "Delete Existing Semetser";
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
            updateButton.Text = "Edit Existing Semeter";
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
            addButton.Text = "Add new Semester";
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
            label5.Location = new Point(77, 609);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 3;
            label5.Text = "Log off";
            label5.Click += label5_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(termComboBox);
            groupBox2.Controls.Add(semesteridTextBox);
            groupBox2.Controls.Add(yearTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(318, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 209);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // termComboBox
            // 
            termComboBox.ForeColor = SystemColors.WindowFrame;
            termComboBox.FormattingEnabled = true;
            termComboBox.Items.AddRange(new object[] { "Fall", "Spring", "Summer" });
            termComboBox.Location = new Point(26, 148);
            termComboBox.Name = "termComboBox";
            termComboBox.Size = new Size(326, 23);
            termComboBox.TabIndex = 10;
            termComboBox.Text = "Term:";
            // 
            // semesteridTextBox
            // 
            semesteridTextBox.Location = new Point(26, 91);
            semesteridTextBox.Name = "semesteridTextBox";
            semesteridTextBox.PlaceholderText = "Semester_id:";
            semesteridTextBox.Size = new Size(326, 23);
            semesteridTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(26, 36);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year:";
            yearTextBox.Size = new Size(326, 23);
            yearTextBox.TabIndex = 4;
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
            // label7
            // 
            label7.BackColor = Color.SteelBlue;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(479, 24);
            label7.Name = "label7";
            label7.Size = new Size(436, 57);
            label7.TabIndex = 11;
            label7.Text = "Welcome to Semester Management Panel\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // semesterDataGridView
            // 
            semesterDataGridView.AllowUserToAddRows = false;
            semesterDataGridView.AllowUserToDeleteRows = false;
            semesterDataGridView.AllowUserToOrderColumns = true;
            semesterDataGridView.BackgroundColor = Color.SteelBlue;
            semesterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            semesterDataGridView.Location = new Point(722, 444);
            semesterDataGridView.Name = "semesterDataGridView";
            semesterDataGridView.Size = new Size(402, 209);
            semesterDataGridView.TabIndex = 12;
            // 
            // Semestermanage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(semesterDataGridView);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Semestermanage";
            Load += Semestermanage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)semesterDataGridView).EndInit();
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
        private ComboBox termComboBox;
        private TextBox semesteridTextBox;
        private TextBox yearTextBox;
        private Label label9;
        private Label label7;
        private DataGridView semesterDataGridView;
    }
}