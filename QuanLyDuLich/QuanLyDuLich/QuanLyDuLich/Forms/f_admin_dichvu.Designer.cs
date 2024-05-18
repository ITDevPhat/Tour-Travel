namespace QuanLyDuLich.Forms
{
    partial class f_admin_dichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin_dichvu));
            panel11 = new Panel();
            label11 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel13 = new Panel();
            txtbox_MaDV = new TextBox();
            label13 = new Label();
            panel15 = new Panel();
            txtbox_DiaDiemDV = new TextBox();
            label15 = new Label();
            panel16 = new Panel();
            cb_PhuongTienDV = new ComboBox();
            label16 = new Label();
            panel18 = new Panel();
            btn_LamMoi = new Button();
            btn_XoaDV = new Button();
            btn_SuaDV = new Button();
            btn_ThemDV = new Button();
            panel17 = new Panel();
            txtbox_MoTaDV = new TextBox();
            label17 = new Label();
            panel14 = new Panel();
            txtbox_TenDV = new TextBox();
            label14 = new Label();
            panel10 = new Panel();
            panel2 = new Panel();
            panel12 = new Panel();
            label12 = new Label();
            dgv_DanhSachDichVu = new DataGridView();
            panel11.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel18.SuspendLayout();
            panel17.SuspendLayout();
            panel14.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).BeginInit();
            SuspendLayout();
            // 
            // panel11
            // 
            panel11.Controls.Add(label11);
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(585, 67);
            panel11.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(45, 66, 113);
            label11.Location = new Point(130, 11);
            label11.Name = "label11";
            label11.Size = new Size(266, 41);
            label11.TabIndex = 0;
            label11.Text = "Thông tin dịch vụ";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 846);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel15);
            panel3.Controls.Add(panel16);
            panel3.Controls.Add(panel18);
            panel3.Controls.Add(panel17);
            panel3.Controls.Add(panel14);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(582, 846);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel13
            // 
            panel13.AutoSize = true;
            panel13.Controls.Add(txtbox_MaDV);
            panel13.Controls.Add(label13);
            panel13.Location = new Point(0, 73);
            panel13.Name = "panel13";
            panel13.Size = new Size(582, 67);
            panel13.TabIndex = 4;
            // 
            // txtbox_MaDV
            // 
            txtbox_MaDV.BackColor = Color.WhiteSmoke;
            txtbox_MaDV.Enabled = false;
            txtbox_MaDV.Font = new Font("Segoe UI", 12F);
            txtbox_MaDV.ForeColor = Color.Black;
            txtbox_MaDV.Location = new Point(147, 20);
            txtbox_MaDV.Name = "txtbox_MaDV";
            txtbox_MaDV.ReadOnly = true;
            txtbox_MaDV.Size = new Size(326, 34);
            txtbox_MaDV.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(45, 66, 113);
            label13.Location = new Point(19, 23);
            label13.Name = "label13";
            label13.Size = new Size(122, 28);
            label13.TabIndex = 0;
            label13.Text = "Mã dịch vụ:";
            // 
            // panel15
            // 
            panel15.AutoSize = true;
            panel15.Controls.Add(txtbox_DiaDiemDV);
            panel15.Controls.Add(label15);
            panel15.Location = new Point(0, 294);
            panel15.Name = "panel15";
            panel15.Size = new Size(585, 67);
            panel15.TabIndex = 6;
            // 
            // txtbox_DiaDiemDV
            // 
            txtbox_DiaDiemDV.BackColor = Color.WhiteSmoke;
            txtbox_DiaDiemDV.Font = new Font("Segoe UI", 12F);
            txtbox_DiaDiemDV.Location = new Point(135, 9);
            txtbox_DiaDiemDV.Multiline = true;
            txtbox_DiaDiemDV.Name = "txtbox_DiaDiemDV";
            txtbox_DiaDiemDV.Size = new Size(326, 35);
            txtbox_DiaDiemDV.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(45, 66, 113);
            label15.Location = new Point(19, 12);
            label15.Name = "label15";
            label15.Size = new Size(98, 28);
            label15.TabIndex = 0;
            label15.Text = "Địa điểm";
            // 
            // panel16
            // 
            panel16.AutoSize = true;
            panel16.Controls.Add(cb_PhuongTienDV);
            panel16.Controls.Add(label16);
            panel16.Location = new Point(0, 367);
            panel16.Name = "panel16";
            panel16.Size = new Size(585, 67);
            panel16.TabIndex = 5;
            // 
            // cb_PhuongTienDV
            // 
            cb_PhuongTienDV.BackColor = Color.WhiteSmoke;
            cb_PhuongTienDV.Font = new Font("Segoe UI", 12F);
            cb_PhuongTienDV.FormattingEnabled = true;
            cb_PhuongTienDV.Items.AddRange(new object[] { "Máy bay", "Xe du lịch", "Du thuyền" });
            cb_PhuongTienDV.Location = new Point(186, 19);
            cb_PhuongTienDV.Name = "cb_PhuongTienDV";
            cb_PhuongTienDV.Size = new Size(276, 36);
            cb_PhuongTienDV.TabIndex = 2;
            cb_PhuongTienDV.Text = "Máy bay";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(45, 66, 113);
            label16.Location = new Point(19, 23);
            label16.Name = "label16";
            label16.Size = new Size(134, 28);
            label16.TabIndex = 0;
            label16.Text = "Phương tiện:";
            // 
            // panel18
            // 
            panel18.AutoSize = true;
            panel18.Controls.Add(btn_LamMoi);
            panel18.Controls.Add(btn_XoaDV);
            panel18.Controls.Add(btn_SuaDV);
            panel18.Controls.Add(btn_ThemDV);
            panel18.Location = new Point(0, 717);
            panel18.Name = "panel18";
            panel18.Size = new Size(585, 117);
            panel18.TabIndex = 7;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.BackColor = Color.FromArgb(52, 50, 162);
            btn_LamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_LamMoi.ForeColor = Color.White;
            btn_LamMoi.Location = new Point(343, 20);
            btn_LamMoi.Margin = new Padding(3, 4, 3, 4);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(117, 40);
            btn_LamMoi.TabIndex = 8;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = false;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // btn_XoaDV
            // 
            btn_XoaDV.BackColor = Color.FromArgb(52, 50, 162);
            btn_XoaDV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_XoaDV.ForeColor = Color.White;
            btn_XoaDV.Location = new Point(235, 20);
            btn_XoaDV.Margin = new Padding(3, 4, 3, 4);
            btn_XoaDV.Name = "btn_XoaDV";
            btn_XoaDV.Size = new Size(93, 40);
            btn_XoaDV.TabIndex = 7;
            btn_XoaDV.Text = "Xóa";
            btn_XoaDV.UseVisualStyleBackColor = false;
            btn_XoaDV.Click += btn_XoaDV_Click;
            // 
            // btn_SuaDV
            // 
            btn_SuaDV.BackColor = Color.FromArgb(52, 50, 162);
            btn_SuaDV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_SuaDV.ForeColor = Color.White;
            btn_SuaDV.Location = new Point(127, 20);
            btn_SuaDV.Margin = new Padding(3, 4, 3, 4);
            btn_SuaDV.Name = "btn_SuaDV";
            btn_SuaDV.Size = new Size(93, 40);
            btn_SuaDV.TabIndex = 6;
            btn_SuaDV.Text = "Sửa";
            btn_SuaDV.UseVisualStyleBackColor = false;
            btn_SuaDV.Click += btn_SuaDV_Click;
            // 
            // btn_ThemDV
            // 
            btn_ThemDV.BackColor = Color.FromArgb(52, 50, 162);
            btn_ThemDV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ThemDV.ForeColor = Color.White;
            btn_ThemDV.Location = new Point(19, 20);
            btn_ThemDV.Margin = new Padding(3, 4, 3, 4);
            btn_ThemDV.Name = "btn_ThemDV";
            btn_ThemDV.Size = new Size(93, 40);
            btn_ThemDV.TabIndex = 5;
            btn_ThemDV.Text = "Thêm";
            btn_ThemDV.UseVisualStyleBackColor = false;
            btn_ThemDV.Click += btn_ThemDV_Click;
            // 
            // panel17
            // 
            panel17.AutoSize = true;
            panel17.Controls.Add(txtbox_MoTaDV);
            panel17.Controls.Add(label17);
            panel17.Location = new Point(0, 456);
            panel17.Name = "panel17";
            panel17.Size = new Size(585, 246);
            panel17.TabIndex = 7;
            // 
            // txtbox_MoTaDV
            // 
            txtbox_MoTaDV.BackColor = Color.WhiteSmoke;
            txtbox_MoTaDV.Font = new Font("Segoe UI", 12F);
            txtbox_MoTaDV.Location = new Point(17, 44);
            txtbox_MoTaDV.Multiline = true;
            txtbox_MoTaDV.Name = "txtbox_MoTaDV";
            txtbox_MoTaDV.ScrollBars = ScrollBars.Vertical;
            txtbox_MoTaDV.Size = new Size(443, 199);
            txtbox_MoTaDV.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(45, 66, 113);
            label17.Location = new Point(19, 12);
            label17.Name = "label17";
            label17.Size = new Size(68, 28);
            label17.TabIndex = 0;
            label17.Text = "Mô tả";
            // 
            // panel14
            // 
            panel14.AutoSize = true;
            panel14.Controls.Add(txtbox_TenDV);
            panel14.Controls.Add(label14);
            panel14.Location = new Point(0, 171);
            panel14.Name = "panel14";
            panel14.Size = new Size(585, 117);
            panel14.TabIndex = 5;
            // 
            // txtbox_TenDV
            // 
            txtbox_TenDV.BackColor = Color.WhiteSmoke;
            txtbox_TenDV.Font = new Font("Segoe UI", 12F);
            txtbox_TenDV.Location = new Point(16, 46);
            txtbox_TenDV.Multiline = true;
            txtbox_TenDV.Name = "txtbox_TenDV";
            txtbox_TenDV.Size = new Size(454, 62);
            txtbox_TenDV.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(45, 66, 113);
            label14.Location = new Point(19, 12);
            label14.Name = "label14";
            label14.Size = new Size(125, 28);
            label14.TabIndex = 0;
            label14.Text = "Tên dịch vụ:";
            // 
            // panel10
            // 
            panel10.Controls.Add(panel2);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(582, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(888, 846);
            panel10.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(dgv_DanhSachDichVu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 846);
            panel2.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Controls.Add(label12);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(888, 52);
            panel12.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(45, 66, 113);
            label12.Location = new Point(349, 9);
            label12.Name = "label12";
            label12.Size = new Size(271, 41);
            label12.TabIndex = 0;
            label12.Text = "Danh sách dịch vụ";
            label12.Click += label12_Click;
            // 
            // dgv_DanhSachDichVu
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_DanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_DanhSachDichVu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_DanhSachDichVu.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_DanhSachDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachDichVu.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_DanhSachDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_DanhSachDichVu.Dock = DockStyle.Fill;
            dgv_DanhSachDichVu.Location = new Point(0, 0);
            dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            dgv_DanhSachDichVu.ReadOnly = true;
            dgv_DanhSachDichVu.RowHeadersWidth = 51;
            dgv_DanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DanhSachDichVu.Size = new Size(888, 846);
            dgv_DanhSachDichVu.TabIndex = 0;
            dgv_DanhSachDichVu.CellClick += dgv_DanhSachDichVu_CellClick;
            dgv_DanhSachDichVu.CellContentClick += dgv_DanhSachDichVu_CellContentClick;
            // 
            // f_admin_dichvu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1470, 846);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_admin_dichvu";
            Text = "Quản lý dịch vụ";
            Load += f_admin_dichvu_Load;
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel18.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel11;
        private Label label11;
        private Panel panel1;
        private Panel panel18;
        private Button btn_LamMoi;
        private Button btn_XoaDV;
        private Button btn_SuaDV;
        private Button btn_ThemDV;
        private Panel panel17;
        private TextBox txtbox_MoTaDV;
        private Label label17;
        private Panel panel15;
        private TextBox txtbox_DiaDiemDV;
        private Label label15;
        private Panel panel16;
        private ComboBox cb_PhuongTienDV;
        private Label label16;
        private Panel panel14;
        private TextBox txtbox_TenDV;
        private Label label14;
        private Panel panel13;
        private TextBox txtbox_MaDV;
        private Label label13;
        private Panel panel10;
        private DataGridView dgv_DanhSachDichVu;
        private Panel panel12;
        private Label label12;
        private Panel panel2;
        private Panel panel3;
    }
}