namespace Midproject
{
    partial class Adminhome
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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminhome));
            groupBox1 = new GroupBox();
            label10 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 593);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 7;
            label1.Text = "Consumables\r\n";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(-5, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 714);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(30, 458);
            label10.Name = "label10";
            label10.Size = new Size(194, 31);
            label10.TabIndex = 6;
            label10.Text = "Room Management\r\n";
            label10.Click += label10_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(25, 529);
            label3.Name = "label3";
            label3.Size = new Size(199, 31);
            label3.TabIndex = 2;
            label3.Text = "Project management";
            label3.Click += label3_Click;
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
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(30, 328);
            label4.Name = "label4";
            label4.Size = new Size(197, 31);
            label4.TabIndex = 2;
            label4.Text = "Profile management";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(30, 398);
            label6.Name = "label6";
            label6.Size = new Size(218, 31);
            label6.TabIndex = 3;
            label6.Text = "Semester Management";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(61, 666);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 3;
            label5.Text = "Log off";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 263);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 1;
            label2.Text = "Course management";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.SteelBlue;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(466, 61);
            label7.Name = "label7";
            label7.Size = new Size(351, 57);
            label7.TabIndex = 6;
            label7.Text = "Welcome to Administrative Staff Panel\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adminhome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 704);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            MinimizeBox = false;
            Name = "Adminhome";
            Load += Adminhome_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label10;
    }
}