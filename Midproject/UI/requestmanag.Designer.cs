namespace Midproject
{
    partial class requestmanage
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
            Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestmanage));
            groupBox1 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            requestsGridView = new DataGridView();
            btnRefresh = new Button();
            btnReject = new Button();
            btnApprove = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestsGridView).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(28, 509);
            label6.Name = "label6";
            label6.Size = new Size(197, 31);
            label6.TabIndex = 3;
            label6.Text = "View Request History\r\n\r\n\r\n";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 704);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(25, 431);
            label4.Name = "label4";
            label4.Size = new Size(197, 31);
            label4.TabIndex = 2;
            label4.Text = "Inventary tracking\r\n\r\n";
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
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(28, 357);
            label3.Name = "label3";
            label3.Size = new Size(199, 31);
            label3.TabIndex = 2;
            label3.Text = "Fulfill requests\r\n";
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(28, 291);
            label2.Name = "label2";
            label2.Size = new Size(208, 31);
            label2.TabIndex = 1;
            label2.Text = "Detailed request View";
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 219);
            label1.Name = "label1";
            label1.Size = new Size(199, 31);
            label1.TabIndex = 0;
            label1.Text = "Display Request List";
            // 
            // label8
            // 
            label8.BackColor = Color.SteelBlue;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(458, 20);
            label8.Name = "label8";
            label8.Size = new Size(369, 57);
            label8.TabIndex = 7;
            label8.Text = "Welcome to Request Management Panel\r\n\r\n";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // requestsGridView
            // 
            requestsGridView.BackgroundColor = Color.SteelBlue;
            requestsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsGridView.Location = new Point(319, 186);
            requestsGridView.Name = "requestsGridView";
            requestsGridView.Size = new Size(715, 218);
            requestsGridView.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(767, 457);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 48);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.SteelBlue;
            btnReject.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = SystemColors.ControlLightLight;
            btnReject.Location = new Point(557, 457);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(115, 48);
            btnReject.TabIndex = 12;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.SteelBlue;
            btnApprove.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = SystemColors.ControlLightLight;
            btnApprove.Location = new Point(347, 457);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(115, 48);
            btnApprove.TabIndex = 13;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // requestmanage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 652);
            Controls.Add(btnApprove);
            Controls.Add(btnReject);
            Controls.Add(btnRefresh);
            Controls.Add(requestsGridView);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "requestmanage";
            Load += requestmanage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private DataGridView requestsGridView;
        private Button btnRefresh;
        private Button btnReject;
        private Button btnApprove;
    }
}