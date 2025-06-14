namespace Midproject.UI
{
    partial class report
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
            generatereport = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(409, 27);
            label8.Name = "label8";
            label8.Size = new Size(173, 43);
            label8.TabIndex = 6;
            label8.Text = "Reports \r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // generatereport
            // 
            generatereport.BackColor = Color.SteelBlue;
            generatereport.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generatereport.ForeColor = SystemColors.ButtonFace;
            generatereport.Location = new Point(133, 185);
            generatereport.Name = "generatereport";
            generatereport.Size = new Size(161, 61);
            generatereport.TabIndex = 7;
            generatereport.Text = "Generate Report";
            generatereport.UseVisualStyleBackColor = false;
            generatereport.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 150);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(133, 96);
            button1.Name = "button1";
            button1.Size = new Size(161, 61);
            button1.TabIndex = 9;
            button1.Text = "Room Allocation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(144, 375);
            button2.Name = "button2";
            button2.Size = new Size(161, 61);
            button2.TabIndex = 10;
            button2.Text = "Admin Roles";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(144, 462);
            button3.Name = "button3";
            button3.Size = new Size(161, 61);
            button3.TabIndex = 11;
            button3.Text = "Generate Report";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.SteelBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(409, 375);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(516, 150);
            dataGridView2.TabIndex = 12;
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 618);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(generatereport);
            Controls.Add(label8);
            Name = "report";
            Text = "report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Button generatereport;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
    }
}