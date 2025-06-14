namespace Midproject
{
    partial class Headhome
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
            Label label5;
            Label Workloadassign;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Headhome));
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            label5 = new Label();
            Workloadassign = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(29, 368);
            label5.Name = "label5";
            label5.Size = new Size(197, 31);
            label5.TabIndex = 3;
            label5.Text = "Resourse allocation\r\n";
            label5.Click += label5_Click_1;
            // 
            // Workloadassign
            // 
            Workloadassign.Cursor = Cursors.Hand;
            Workloadassign.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Workloadassign.ForeColor = SystemColors.ButtonFace;
            Workloadassign.Location = new Point(25, 226);
            Workloadassign.Name = "Workloadassign";
            Workloadassign.Size = new Size(197, 31);
            Workloadassign.TabIndex = 5;
            Workloadassign.Text = "Workload Assigment\r\n\r\n";
            Workloadassign.Click += Workloadassign_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Workloadassign);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 694);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 294);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 2;
            label1.Text = "Research supervision\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 172);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(63, 600);
            label7.Name = "label7";
            label7.Size = new Size(106, 31);
            label7.TabIndex = 3;
            label7.Text = "Log off";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(25, 451);
            label9.Name = "label9";
            label9.Size = new Size(199, 31);
            label9.TabIndex = 2;
            label9.Text = "Request Approval\r\n";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(458, 90);
            label8.Name = "label8";
            label8.Size = new Size(351, 57);
            label8.TabIndex = 6;
            label8.Text = "Welcome to Department Head Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(29, 529);
            label2.Name = "label2";
            label2.Size = new Size(199, 31);
            label2.TabIndex = 6;
            label2.Text = "Generate Reports\r\n";
            label2.Click += label2_Click;
            // 
            // Headhome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 696);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "Headhome";
            Load += Headhome_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label2;
    }
}