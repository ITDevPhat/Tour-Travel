namespace QuanLyDuLich
{
    partial class f_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Login));
            panel2 = new Panel();
            btn_Login_Exit = new Button();
            btn_Login_DangNhap = new Button();
            panel4 = new Panel();
            txtBox_MatKhau = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtBox_TenDangNhap = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_Login_Exit);
            panel2.Controls.Add(btn_Login_DangNhap);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(786, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 754);
            panel2.TabIndex = 1;
            // 
            // btn_Login_Exit
            // 
            btn_Login_Exit.FlatAppearance.BorderSize = 0;
            btn_Login_Exit.Image = Properties.Resources.Exit;
            btn_Login_Exit.Location = new Point(448, 0);
            btn_Login_Exit.Margin = new Padding(3, 4, 3, 4);
            btn_Login_Exit.Name = "btn_Login_Exit";
            btn_Login_Exit.Size = new Size(76, 58);
            btn_Login_Exit.TabIndex = 5;
            btn_Login_Exit.UseVisualStyleBackColor = true;
            btn_Login_Exit.Click += btn_Login_Exit_Click;
            // 
            // btn_Login_DangNhap
            // 
            btn_Login_DangNhap.BackColor = Color.FromArgb(52, 50, 162);
            btn_Login_DangNhap.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login_DangNhap.ForeColor = Color.White;
            btn_Login_DangNhap.Location = new Point(119, 622);
            btn_Login_DangNhap.Margin = new Padding(3, 4, 3, 4);
            btn_Login_DangNhap.Name = "btn_Login_DangNhap";
            btn_Login_DangNhap.Size = new Size(288, 63);
            btn_Login_DangNhap.TabIndex = 4;
            btn_Login_DangNhap.Text = "Đăng nhập";
            btn_Login_DangNhap.UseVisualStyleBackColor = false;
            btn_Login_DangNhap.Click += btn_Login_DangNhap_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtBox_MatKhau);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(17, 500);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(494, 79);
            panel4.TabIndex = 3;
            // 
            // txtBox_MatKhau
            // 
            txtBox_MatKhau.BackColor = Color.Snow;
            txtBox_MatKhau.Font = new Font("Segoe UI", 13.2000008F);
            txtBox_MatKhau.Location = new Point(87, 25);
            txtBox_MatKhau.Margin = new Padding(3, 4, 3, 4);
            txtBox_MatKhau.Name = "txtBox_MatKhau";
            txtBox_MatKhau.PasswordChar = '*';
            txtBox_MatKhau.Size = new Size(358, 37);
            txtBox_MatKhau.TabIndex = 2;
            txtBox_MatKhau.KeyDown += txtBox_MatKhau_KeyDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 20);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(119, 91);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(288, 279);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtBox_TenDangNhap);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(18, 399);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 79);
            panel3.TabIndex = 1;
            // 
            // txtBox_TenDangNhap
            // 
            txtBox_TenDangNhap.BackColor = Color.Snow;
            txtBox_TenDangNhap.Font = new Font("Segoe UI", 13.2000008F);
            txtBox_TenDangNhap.Location = new Point(86, 25);
            txtBox_TenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtBox_TenDangNhap.Name = "txtBox_TenDangNhap";
            txtBox_TenDangNhap.Size = new Size(358, 37);
            txtBox_TenDangNhap.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(15, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 66, 113);
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(363, 50);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng đến với";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources.b5id_x7mt_211025;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(785, 754);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // f_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 754);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "f_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += f_Login_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Login_DangNhap;
        private Panel panel4;
        private TextBox txtBox_MatKhau;
        private PictureBox pictureBox3;
        private TextBox txtBox_TenDangNhap;
        private Button btn_Login_Exit;
        private PictureBox pictureBox4;
    }
}
