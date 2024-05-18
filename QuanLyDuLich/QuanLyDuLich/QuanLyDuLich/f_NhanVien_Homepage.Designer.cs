namespace QuanLyDuLich
{
    partial class f_NhanVien_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_NhanVien_Homepage));
            btn_home_NV_QuanLyVe = new Button();
            btn_Home_NV_DatVe = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelMenu = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            btn_home_close = new Button();
            btn_home_maximize = new Button();
            btn_home_minimize = new Button();
            panelDesktopPane = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_home_NV_QuanLyVe
            // 
            btn_home_NV_QuanLyVe.Dock = DockStyle.Top;
            btn_home_NV_QuanLyVe.FlatAppearance.BorderSize = 0;
            btn_home_NV_QuanLyVe.FlatStyle = FlatStyle.Flat;
            btn_home_NV_QuanLyVe.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            btn_home_NV_QuanLyVe.ForeColor = Color.White;
            btn_home_NV_QuanLyVe.Image = Properties.Resources.tickets;
            btn_home_NV_QuanLyVe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home_NV_QuanLyVe.Location = new Point(0, 182);
            btn_home_NV_QuanLyVe.Margin = new Padding(4, 3, 4, 3);
            btn_home_NV_QuanLyVe.Name = "btn_home_NV_QuanLyVe";
            btn_home_NV_QuanLyVe.Padding = new Padding(14, 0, 0, 0);
            btn_home_NV_QuanLyVe.Size = new Size(312, 75);
            btn_home_NV_QuanLyVe.TabIndex = 4;
            btn_home_NV_QuanLyVe.Text = "    Quản lý vé";
            btn_home_NV_QuanLyVe.TextAlign = ContentAlignment.MiddleLeft;
            btn_home_NV_QuanLyVe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home_NV_QuanLyVe.UseVisualStyleBackColor = true;
            btn_home_NV_QuanLyVe.Click += btn_home_NV_QuanLyVe_Click;
            // 
            // btn_Home_NV_DatVe
            // 
            btn_Home_NV_DatVe.Dock = DockStyle.Top;
            btn_Home_NV_DatVe.FlatAppearance.BorderSize = 0;
            btn_Home_NV_DatVe.FlatStyle = FlatStyle.Flat;
            btn_Home_NV_DatVe.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            btn_Home_NV_DatVe.ForeColor = Color.White;
            btn_Home_NV_DatVe.Image = (Image)resources.GetObject("btn_Home_NV_DatVe.Image");
            btn_Home_NV_DatVe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Home_NV_DatVe.Location = new Point(0, 107);
            btn_Home_NV_DatVe.Margin = new Padding(4, 3, 4, 3);
            btn_Home_NV_DatVe.Name = "btn_Home_NV_DatVe";
            btn_Home_NV_DatVe.Padding = new Padding(14, 0, 0, 0);
            btn_Home_NV_DatVe.Size = new Size(312, 75);
            btn_Home_NV_DatVe.TabIndex = 1;
            btn_Home_NV_DatVe.Text = "    Đặt vé";
            btn_Home_NV_DatVe.TextAlign = ContentAlignment.MiddleLeft;
            btn_Home_NV_DatVe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Home_NV_DatVe.UseVisualStyleBackColor = true;
            btn_Home_NV_DatVe.Click += btn_Home_NV_DatVe_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Font = new Font("Segoe UI", 13.2000008F);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(312, 107);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(89, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btn_home_NV_QuanLyVe);
            panelMenu.Controls.Add(btn_Home_NV_DatVe);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Segoe UI", 13.2000008F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 896);
            panelMenu.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btn_home_close);
            panelTitleBar.Controls.Add(btn_home_maximize);
            panelTitleBar.Controls.Add(btn_home_minimize);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(312, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1344, 107);
            panelTitleBar.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(618, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 50);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "HOME";
            // 
            // btn_home_close
            // 
            btn_home_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_home_close.FlatAppearance.BorderSize = 0;
            btn_home_close.FlatStyle = FlatStyle.Flat;
            btn_home_close.Image = (Image)resources.GetObject("btn_home_close.Image");
            btn_home_close.Location = new Point(1286, 12);
            btn_home_close.Name = "btn_home_close";
            btn_home_close.Size = new Size(46, 38);
            btn_home_close.TabIndex = 12;
            btn_home_close.UseVisualStyleBackColor = true;
            btn_home_close.Click += btn_home_close_Click;
            // 
            // btn_home_maximize
            // 
            btn_home_maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_home_maximize.FlatAppearance.BorderSize = 0;
            btn_home_maximize.FlatStyle = FlatStyle.Flat;
            btn_home_maximize.Image = (Image)resources.GetObject("btn_home_maximize.Image");
            btn_home_maximize.Location = new Point(1234, 12);
            btn_home_maximize.Name = "btn_home_maximize";
            btn_home_maximize.Size = new Size(46, 38);
            btn_home_maximize.TabIndex = 11;
            btn_home_maximize.UseVisualStyleBackColor = true;
            btn_home_maximize.Click += btn_home_maximize_Click;
            // 
            // btn_home_minimize
            // 
            btn_home_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_home_minimize.FlatAppearance.BorderSize = 0;
            btn_home_minimize.FlatStyle = FlatStyle.Flat;
            btn_home_minimize.Image = Properties.Resources.minus;
            btn_home_minimize.Location = new Point(1182, 13);
            btn_home_minimize.Name = "btn_home_minimize";
            btn_home_minimize.Size = new Size(46, 38);
            btn_home_minimize.TabIndex = 10;
            btn_home_minimize.UseVisualStyleBackColor = true;
            btn_home_minimize.Click += btn_home_minimize_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(groupBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(312, 107);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1344, 789);
            panelDesktopPane.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1344, 789);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 22, 0);
            label3.Location = new Point(488, 262);
            label3.Name = "label3";
            label3.Size = new Size(392, 62);
            label3.TabIndex = 8;
            label3.Text = "Không gian làm việc cho Nhân viên\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(209, 169);
            label4.Name = "label4";
            label4.Size = new Size(951, 46);
            label4.TabIndex = 7;
            label4.Text = "CHÀO MỪNG BẠN ĐẾN VỚI HỆ THỐNG QUẢN LÝ DU LỊCH\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.wavy;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1338, 763);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // f_NhanVien_Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1656, 896);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "f_NhanVien_Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_NhanVien_Homepage";
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_home_NV_QuanLyVe;
        private Button btn_Home_NV_DatVe;
        private Panel panelLogo;
        private PictureBox pictureBox2;
        private Panel panelMenu;
        private Panel panelTitleBar;
        private Button btn_home_close;
        private Button btn_home_maximize;
        private Button btn_home_minimize;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}