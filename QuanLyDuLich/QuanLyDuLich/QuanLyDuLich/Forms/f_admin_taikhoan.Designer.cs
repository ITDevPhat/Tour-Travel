namespace QuanLyDuLich.Forms
{
    partial class f_admin_taikhoan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin_taikhoan));
            dgv_TaiKhoan_DSTaiKhoan = new DataGridView();
            panel7 = new Panel();
            txtbox_TaiKhoan_MatKhau = new TextBox();
            txtbox_TaiKhoan_tendangnhap = new TextBox();
            radio_TaiKhoan_NhanVien = new RadioButton();
            radio_TaiKhoan_Admin = new RadioButton();
            panel28 = new Panel();
            btn_TaiKhoan_LamMoi = new Button();
            btn_TaiKhoan_Xoa = new Button();
            btn_TaiKhoan_Sua = new Button();
            btn_TaiKhoan_Them = new Button();
            label46 = new Label();
            label45 = new Label();
            label44 = new Label();
            txtbox_TaiKhoan_TenNhanVien = new TextBox();
            label43 = new Label();
            txtbox_TaiKhoan_MaNhanVien = new TextBox();
            label42 = new Label();
            label40 = new Label();
            dgv_TaiKhoan_DSNhanVien = new DataGridView();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan_DSTaiKhoan).BeginInit();
            panel7.SuspendLayout();
            panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan_DSNhanVien).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_TaiKhoan_DSTaiKhoan
            // 
            dgv_TaiKhoan_DSTaiKhoan.AllowUserToAddRows = false;
            dgv_TaiKhoan_DSTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_TaiKhoan_DSTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_TaiKhoan_DSTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TaiKhoan_DSTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_TaiKhoan_DSTaiKhoan.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.MistyRose;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_TaiKhoan_DSTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_TaiKhoan_DSTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_TaiKhoan_DSTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_TaiKhoan_DSTaiKhoan.Dock = DockStyle.Fill;
            dgv_TaiKhoan_DSTaiKhoan.GridColor = SystemColors.HotTrack;
            dgv_TaiKhoan_DSTaiKhoan.Location = new Point(3, 23);
            dgv_TaiKhoan_DSTaiKhoan.Name = "dgv_TaiKhoan_DSTaiKhoan";
            dgv_TaiKhoan_DSTaiKhoan.RowHeadersWidth = 51;
            dgv_TaiKhoan_DSTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TaiKhoan_DSTaiKhoan.Size = new Size(658, 418);
            dgv_TaiKhoan_DSTaiKhoan.TabIndex = 10;
            dgv_TaiKhoan_DSTaiKhoan.CellClick += dgv_TaiKhoan_DSTaiKhoan_CellClick;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtbox_TaiKhoan_MatKhau);
            panel7.Controls.Add(txtbox_TaiKhoan_tendangnhap);
            panel7.Controls.Add(radio_TaiKhoan_NhanVien);
            panel7.Controls.Add(radio_TaiKhoan_Admin);
            panel7.Controls.Add(panel28);
            panel7.Controls.Add(label46);
            panel7.Controls.Add(label45);
            panel7.Controls.Add(label44);
            panel7.Controls.Add(txtbox_TaiKhoan_TenNhanVien);
            panel7.Controls.Add(label43);
            panel7.Controls.Add(txtbox_TaiKhoan_MaNhanVien);
            panel7.Controls.Add(label42);
            panel7.Controls.Add(label40);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(684, 721);
            panel7.TabIndex = 9;
            // 
            // txtbox_TaiKhoan_MatKhau
            // 
            txtbox_TaiKhoan_MatKhau.BackColor = Color.White;
            txtbox_TaiKhoan_MatKhau.Font = new Font("Segoe UI", 12F);
            txtbox_TaiKhoan_MatKhau.Location = new Point(233, 277);
            txtbox_TaiKhoan_MatKhau.Name = "txtbox_TaiKhoan_MatKhau";
            txtbox_TaiKhoan_MatKhau.PasswordChar = '*';
            txtbox_TaiKhoan_MatKhau.Size = new Size(323, 34);
            txtbox_TaiKhoan_MatKhau.TabIndex = 15;
            // 
            // txtbox_TaiKhoan_tendangnhap
            // 
            txtbox_TaiKhoan_tendangnhap.BackColor = Color.White;
            txtbox_TaiKhoan_tendangnhap.Font = new Font("Segoe UI", 12F);
            txtbox_TaiKhoan_tendangnhap.Location = new Point(233, 222);
            txtbox_TaiKhoan_tendangnhap.Name = "txtbox_TaiKhoan_tendangnhap";
            txtbox_TaiKhoan_tendangnhap.Size = new Size(323, 34);
            txtbox_TaiKhoan_tendangnhap.TabIndex = 14;
            // 
            // radio_TaiKhoan_NhanVien
            // 
            radio_TaiKhoan_NhanVien.AutoSize = true;
            radio_TaiKhoan_NhanVien.Checked = true;
            radio_TaiKhoan_NhanVien.Font = new Font("Segoe UI", 12F);
            radio_TaiKhoan_NhanVien.Location = new Point(246, 383);
            radio_TaiKhoan_NhanVien.Name = "radio_TaiKhoan_NhanVien";
            radio_TaiKhoan_NhanVien.Size = new Size(121, 32);
            radio_TaiKhoan_NhanVien.TabIndex = 13;
            radio_TaiKhoan_NhanVien.TabStop = true;
            radio_TaiKhoan_NhanVien.Text = "Nhân viên";
            radio_TaiKhoan_NhanVien.UseVisualStyleBackColor = true;
            // 
            // radio_TaiKhoan_Admin
            // 
            radio_TaiKhoan_Admin.AutoSize = true;
            radio_TaiKhoan_Admin.Font = new Font("Segoe UI", 12F);
            radio_TaiKhoan_Admin.Location = new Point(429, 383);
            radio_TaiKhoan_Admin.Name = "radio_TaiKhoan_Admin";
            radio_TaiKhoan_Admin.Size = new Size(162, 32);
            radio_TaiKhoan_Admin.TabIndex = 12;
            radio_TaiKhoan_Admin.Text = "Người quản trị";
            radio_TaiKhoan_Admin.UseVisualStyleBackColor = true;
            // 
            // panel28
            // 
            panel28.Controls.Add(btn_TaiKhoan_LamMoi);
            panel28.Controls.Add(btn_TaiKhoan_Xoa);
            panel28.Controls.Add(btn_TaiKhoan_Sua);
            panel28.Controls.Add(btn_TaiKhoan_Them);
            panel28.Location = new Point(33, 452);
            panel28.Name = "panel28";
            panel28.Size = new Size(607, 165);
            panel28.TabIndex = 11;
            // 
            // btn_TaiKhoan_LamMoi
            // 
            btn_TaiKhoan_LamMoi.BackColor = Color.FromArgb(52, 50, 162);
            btn_TaiKhoan_LamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_TaiKhoan_LamMoi.ForeColor = Color.White;
            btn_TaiKhoan_LamMoi.Location = new Point(453, 40);
            btn_TaiKhoan_LamMoi.Margin = new Padding(3, 4, 3, 4);
            btn_TaiKhoan_LamMoi.Name = "btn_TaiKhoan_LamMoi";
            btn_TaiKhoan_LamMoi.Size = new Size(117, 42);
            btn_TaiKhoan_LamMoi.TabIndex = 8;
            btn_TaiKhoan_LamMoi.Text = "Làm mới";
            btn_TaiKhoan_LamMoi.UseVisualStyleBackColor = false;
            btn_TaiKhoan_LamMoi.Click += btn_TaiKhoan_LamMoi_Click;
            // 
            // btn_TaiKhoan_Xoa
            // 
            btn_TaiKhoan_Xoa.BackColor = Color.FromArgb(52, 50, 162);
            btn_TaiKhoan_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_TaiKhoan_Xoa.ForeColor = Color.White;
            btn_TaiKhoan_Xoa.Location = new Point(311, 40);
            btn_TaiKhoan_Xoa.Margin = new Padding(3, 4, 3, 4);
            btn_TaiKhoan_Xoa.Name = "btn_TaiKhoan_Xoa";
            btn_TaiKhoan_Xoa.Size = new Size(117, 42);
            btn_TaiKhoan_Xoa.TabIndex = 7;
            btn_TaiKhoan_Xoa.Text = "Xóa";
            btn_TaiKhoan_Xoa.UseVisualStyleBackColor = false;
            btn_TaiKhoan_Xoa.Click += btn_TaiKhoan_Xoa_Click;
            // 
            // btn_TaiKhoan_Sua
            // 
            btn_TaiKhoan_Sua.BackColor = Color.FromArgb(52, 50, 162);
            btn_TaiKhoan_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_TaiKhoan_Sua.ForeColor = Color.White;
            btn_TaiKhoan_Sua.Location = new Point(169, 40);
            btn_TaiKhoan_Sua.Margin = new Padding(3, 4, 3, 4);
            btn_TaiKhoan_Sua.Name = "btn_TaiKhoan_Sua";
            btn_TaiKhoan_Sua.Size = new Size(117, 42);
            btn_TaiKhoan_Sua.TabIndex = 6;
            btn_TaiKhoan_Sua.Text = "Sửa";
            btn_TaiKhoan_Sua.UseVisualStyleBackColor = false;
            btn_TaiKhoan_Sua.Click += btn_TaiKhoan_Sua_Click;
            // 
            // btn_TaiKhoan_Them
            // 
            btn_TaiKhoan_Them.BackColor = Color.FromArgb(52, 50, 162);
            btn_TaiKhoan_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_TaiKhoan_Them.ForeColor = Color.White;
            btn_TaiKhoan_Them.Location = new Point(27, 40);
            btn_TaiKhoan_Them.Margin = new Padding(3, 4, 3, 4);
            btn_TaiKhoan_Them.Name = "btn_TaiKhoan_Them";
            btn_TaiKhoan_Them.Size = new Size(117, 42);
            btn_TaiKhoan_Them.TabIndex = 5;
            btn_TaiKhoan_Them.Text = "Thêm";
            btn_TaiKhoan_Them.UseVisualStyleBackColor = false;
            btn_TaiKhoan_Them.Click += btn_TaiKhoan_Them_Click;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label46.ForeColor = Color.FromArgb(45, 66, 113);
            label46.Location = new Point(75, 385);
            label46.Name = "label46";
            label46.Size = new Size(167, 28);
            label46.TabIndex = 9;
            label46.Text = "Loại người dùng";
            label46.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label45.ForeColor = Color.FromArgb(45, 66, 113);
            label45.Location = new Point(75, 280);
            label45.Name = "label45";
            label45.Size = new Size(102, 28);
            label45.TabIndex = 7;
            label45.Text = "Mật khẩu";
            label45.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label44.ForeColor = Color.FromArgb(45, 66, 113);
            label44.Location = new Point(75, 225);
            label44.Name = "label44";
            label44.Size = new Size(152, 28);
            label44.TabIndex = 5;
            label44.Text = "Tên đăng nhập";
            label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtbox_TaiKhoan_TenNhanVien
            // 
            txtbox_TaiKhoan_TenNhanVien.BackColor = Color.White;
            txtbox_TaiKhoan_TenNhanVien.Font = new Font("Segoe UI", 12F);
            txtbox_TaiKhoan_TenNhanVien.Location = new Point(233, 164);
            txtbox_TaiKhoan_TenNhanVien.Name = "txtbox_TaiKhoan_TenNhanVien";
            txtbox_TaiKhoan_TenNhanVien.Size = new Size(323, 34);
            txtbox_TaiKhoan_TenNhanVien.TabIndex = 4;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label43.ForeColor = Color.FromArgb(45, 66, 113);
            label43.Location = new Point(75, 167);
            label43.Name = "label43";
            label43.Size = new Size(144, 28);
            label43.TabIndex = 3;
            label43.Text = "Tên nhân viên";
            label43.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtbox_TaiKhoan_MaNhanVien
            // 
            txtbox_TaiKhoan_MaNhanVien.BackColor = Color.White;
            txtbox_TaiKhoan_MaNhanVien.Font = new Font("Segoe UI", 12F);
            txtbox_TaiKhoan_MaNhanVien.Location = new Point(233, 109);
            txtbox_TaiKhoan_MaNhanVien.Name = "txtbox_TaiKhoan_MaNhanVien";
            txtbox_TaiKhoan_MaNhanVien.Size = new Size(323, 34);
            txtbox_TaiKhoan_MaNhanVien.TabIndex = 2;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label42.ForeColor = Color.FromArgb(45, 66, 113);
            label42.Location = new Point(75, 112);
            label42.Name = "label42";
            label42.Size = new Size(141, 28);
            label42.TabIndex = 1;
            label42.Text = "Mã nhân viên";
            label42.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label40.ForeColor = Color.FromArgb(45, 66, 113);
            label40.Location = new Point(211, 18);
            label40.Name = "label40";
            label40.Size = new Size(260, 50);
            label40.TabIndex = 0;
            label40.Text = "Tạo tài khoản";
            // 
            // dgv_TaiKhoan_DSNhanVien
            // 
            dgv_TaiKhoan_DSNhanVien.AllowUserToAddRows = false;
            dgv_TaiKhoan_DSNhanVien.AllowUserToDeleteRows = false;
            dgv_TaiKhoan_DSNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_TaiKhoan_DSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TaiKhoan_DSNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_TaiKhoan_DSNhanVien.BackgroundColor = Color.Azure;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Snow;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.SeaShell;
            dataGridViewCellStyle4.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_TaiKhoan_DSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_TaiKhoan_DSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.MistyRose;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_TaiKhoan_DSNhanVien.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_TaiKhoan_DSNhanVien.Dock = DockStyle.Fill;
            dgv_TaiKhoan_DSNhanVien.GridColor = SystemColors.HotTrack;
            dgv_TaiKhoan_DSNhanVien.Location = new Point(3, 23);
            dgv_TaiKhoan_DSNhanVien.Name = "dgv_TaiKhoan_DSNhanVien";
            dgv_TaiKhoan_DSNhanVien.RowHeadersWidth = 51;
            dgv_TaiKhoan_DSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_TaiKhoan_DSNhanVien.Size = new Size(658, 414);
            dgv_TaiKhoan_DSNhanVien.TabIndex = 8;
            dgv_TaiKhoan_DSNhanVien.CellClick += dgv_TaiKhoan_DSNhanVien_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(684, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 721);
            panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_TaiKhoan_DSTaiKhoan);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(664, 444);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_TaiKhoan_DSNhanVien);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 440);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // f_admin_taikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_admin_taikhoan";
            Text = "Quản lý tài khoản";
            Load += f_admin_taikhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan_DSTaiKhoan).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_TaiKhoan_DSNhanVien).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_TaiKhoan_DSTaiKhoan;
        private Panel panel7;
        private TextBox txtbox_TaiKhoan_MatKhau;
        private TextBox txtbox_TaiKhoan_tendangnhap;
        private RadioButton radio_TaiKhoan_NhanVien;
        private RadioButton radio_TaiKhoan_Admin;
        private Panel panel28;
        private Button btn_TaiKhoan_LamMoi;
        private Button btn_TaiKhoan_Xoa;
        private Button btn_TaiKhoan_Sua;
        private Button btn_TaiKhoan_Them;
        private Label label46;
        private Label label45;
        private Label label44;
        private TextBox txtbox_TaiKhoan_TenNhanVien;
        private Label label43;
        private TextBox txtbox_TaiKhoan_MaNhanVien;
        private Label label42;
        private Label label40;
        private DataGridView dgv_TaiKhoan_DSNhanVien;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}