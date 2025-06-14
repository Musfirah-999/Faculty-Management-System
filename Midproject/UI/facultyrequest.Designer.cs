namespace Midproject.UI
{
    partial class facultyrequest
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
            label8 = new Label();
            groupBox2 = new GroupBox();
            lblFacultyName = new Label();
            label2 = new Label();
            btnSubmitRequest = new Button();
            quantitytextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            comboBoxConsumables = new ComboBox();
            dataGridViewRequests = new DataGridView();
            button1 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(436, 21);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 9;
            label8.Text = "Welcome to Faculty Request Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(lblFacultyName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSubmitRequest);
            groupBox2.Controls.Add(quantitytextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxConsumables);
            groupBox2.Location = new Point(402, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 339);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // lblFacultyName
            // 
            lblFacultyName.AutoSize = true;
            lblFacultyName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFacultyName.ForeColor = SystemColors.ButtonHighlight;
            lblFacultyName.Location = new Point(137, 46);
            lblFacultyName.Name = "lblFacultyName";
            lblFacultyName.Size = new Size(0, 21);
            lblFacultyName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 46);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 20;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.SteelBlue;
            btnSubmitRequest.Cursor = Cursors.Hand;
            btnSubmitRequest.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitRequest.Location = new Point(137, 287);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(149, 46);
            btnSubmitRequest.TabIndex = 19;
            btnSubmitRequest.Text = "Submit";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // quantitytextBox
            // 
            quantitytextBox.Location = new Point(25, 222);
            quantitytextBox.Name = "quantitytextBox";
            quantitytextBox.Size = new Size(285, 23);
            quantitytextBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 176);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 17;
            label3.Text = "Enter Quantity:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 88);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 15;
            label1.Text = "Select Item:";
            // 
            // comboBoxConsumables
            // 
            comboBoxConsumables.FormattingEnabled = true;
            comboBoxConsumables.Location = new Point(25, 131);
            comboBoxConsumables.Name = "comboBoxConsumables";
            comboBoxConsumables.Size = new Size(288, 23);
            comboBoxConsumables.TabIndex = 0;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.BackgroundColor = Color.SteelBlue;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(331, 468);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.Size = new Size(583, 150);
            dataGridViewRequests.TabIndex = 17;
            dataGridViewRequests.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(797, 650);
            button1.Name = "button1";
            button1.Size = new Size(117, 49);
            button1.TabIndex = 18;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // facultyrequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(dataGridViewRequests);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Name = "facultyrequest";
            Text = "facultyrequest";
            Load += facultyrequest_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private GroupBox groupBox2;
        private TextBox quantitytextBox;
        private Label label1;
        private ComboBox comboBoxConsumables;
        private DataGridView dataGridViewRequests;
        private Label label3;
        private Button btnSubmitRequest;
        private Button button1;
        private Label label2;
        private Label lblFacultyName;
    }
}