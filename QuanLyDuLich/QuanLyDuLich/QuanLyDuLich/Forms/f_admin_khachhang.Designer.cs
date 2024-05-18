namespace QuanLyDuLich.Forms
{
    partial class f_admin_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin_khachhang));
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            dataGridView_DSKH = new DataGridView();
            groupBox4 = new GroupBox();
            label1 = new Label();
            radio_KH_Nu = new RadioButton();
            radio_KH_Nam = new RadioButton();
            btn_KH_LamMoi = new Button();
            dtp_KH_NgaySinh = new DateTimePicker();
            label23 = new Label();
            textBox_DiaChiKH = new TextBox();
            textBox_SDTKH = new TextBox();
            textBox_HoTenKH = new TextBox();
            textBox_MaKH = new TextBox();
            btn_KH_Xoa = new Button();
            btn_KH_Sua = new Button();
            btn_KH_Them = new Button();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label39 = new Label();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSKH).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(groupBox4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1348, 721);
            panel6.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView_DSKH);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(500, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 721);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // dataGridView_DSKH
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView_DSKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_DSKH.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_DSKH.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSKH.Dock = DockStyle.Fill;
            dataGridView_DSKH.Location = new Point(3, 23);
            dataGridView_DSKH.Name = "dataGridView_DSKH";
            dataGridView_DSKH.RowHeadersWidth = 51;
            dataGridView_DSKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSKH.Size = new Size(842, 695);
            dataGridView_DSKH.TabIndex = 0;
            dataGridView_DSKH.CellClick += dataGridView_DSKH_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(radio_KH_Nu);
            groupBox4.Controls.Add(radio_KH_Nam);
            groupBox4.Controls.Add(btn_KH_LamMoi);
            groupBox4.Controls.Add(dtp_KH_NgaySinh);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(textBox_DiaChiKH);
            groupBox4.Controls.Add(textBox_SDTKH);
            groupBox4.Controls.Add(textBox_HoTenKH);
            groupBox4.Controls.Add(textBox_MaKH);
            groupBox4.Controls.Add(btn_KH_Xoa);
            groupBox4.Controls.Add(btn_KH_Sua);
            groupBox4.Controls.Add(btn_KH_Them);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(label39);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(500, 721);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 66, 113);
            label1.Location = new Point(139, 34);
            label1.Name = "label1";
            label1.Size = new Size(225, 50);
            label1.TabIndex = 22;
            label1.Text = "Khách hàng";
            // 
            // radio_KH_Nu
            // 
            radio_KH_Nu.AutoSize = true;
            radio_KH_Nu.BackColor = Color.Snow;
            radio_KH_Nu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radio_KH_Nu.Location = new Point(302, 276);
            radio_KH_Nu.Name = "radio_KH_Nu";
            radio_KH_Nu.Size = new Size(62, 32);
            radio_KH_Nu.TabIndex = 21;
            radio_KH_Nu.Text = "Nữ";
            radio_KH_Nu.UseVisualStyleBackColor = false;
            radio_KH_Nu.CheckedChanged += radio_KH_Nu_CheckedChanged;
            // 
            // radio_KH_Nam
            // 
            radio_KH_Nam.AutoSize = true;
            radio_KH_Nam.BackColor = Color.Snow;
            radio_KH_Nam.Checked = true;
            radio_KH_Nam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radio_KH_Nam.Location = new Point(197, 278);
            radio_KH_Nam.Name = "radio_KH_Nam";
            radio_KH_Nam.Size = new Size(78, 32);
            radio_KH_Nam.TabIndex = 20;
            radio_KH_Nam.TabStop = true;
            radio_KH_Nam.Text = "Nam";
            radio_KH_Nam.UseVisualStyleBackColor = false;
            // 
            // btn_KH_LamMoi
            // 
            btn_KH_LamMoi.BackColor = Color.FromArgb(52, 50, 162);
            btn_KH_LamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_KH_LamMoi.ForeColor = Color.White;
            btn_KH_LamMoi.Location = new Point(269, 653);
            btn_KH_LamMoi.Margin = new Padding(3, 4, 3, 4);
            btn_KH_LamMoi.Name = "btn_KH_LamMoi";
            btn_KH_LamMoi.Size = new Size(163, 42);
            btn_KH_LamMoi.TabIndex = 19;
            btn_KH_LamMoi.Text = "Làm mới";
            btn_KH_LamMoi.UseVisualStyleBackColor = false;
            btn_KH_LamMoi.Click += btn_KH_LamMoi_Click;
            // 
            // dtp_KH_NgaySinh
            // 
            dtp_KH_NgaySinh.CustomFormat = "dd-MM-yyyy";
            dtp_KH_NgaySinh.Font = new Font("Segoe UI", 12F);
            dtp_KH_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_KH_NgaySinh.Location = new Point(197, 342);
            dtp_KH_NgaySinh.Name = "dtp_KH_NgaySinh";
            dtp_KH_NgaySinh.Size = new Size(167, 34);
            dtp_KH_NgaySinh.TabIndex = 18;
            dtp_KH_NgaySinh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label23.ForeColor = Color.FromArgb(45, 66, 113);
            label23.Location = new Point(24, 342);
            label23.Name = "label23";
            label23.Size = new Size(114, 28);
            label23.TabIndex = 17;
            label23.Text = "Ngày Sinh:";
            // 
            // textBox_DiaChiKH
            // 
            textBox_DiaChiKH.BackColor = Color.WhiteSmoke;
            textBox_DiaChiKH.Font = new Font("Segoe UI", 12F);
            textBox_DiaChiKH.ForeColor = Color.FromArgb(45, 66, 113);
            textBox_DiaChiKH.Location = new Point(24, 492);
            textBox_DiaChiKH.Multiline = true;
            textBox_DiaChiKH.Name = "textBox_DiaChiKH";
            textBox_DiaChiKH.ScrollBars = ScrollBars.Vertical;
            textBox_DiaChiKH.Size = new Size(459, 63);
            textBox_DiaChiKH.TabIndex = 16;
            // 
            // textBox_SDTKH
            // 
            textBox_SDTKH.BackColor = Color.WhiteSmoke;
            textBox_SDTKH.Font = new Font("Segoe UI", 12F);
            textBox_SDTKH.ForeColor = Color.FromArgb(45, 66, 113);
            textBox_SDTKH.Location = new Point(197, 412);
            textBox_SDTKH.Name = "textBox_SDTKH";
            textBox_SDTKH.Size = new Size(286, 34);
            textBox_SDTKH.TabIndex = 15;
            // 
            // textBox_HoTenKH
            // 
            textBox_HoTenKH.BackColor = Color.WhiteSmoke;
            textBox_HoTenKH.Font = new Font("Segoe UI", 12F);
            textBox_HoTenKH.ForeColor = Color.FromArgb(45, 66, 113);
            textBox_HoTenKH.Location = new Point(24, 216);
            textBox_HoTenKH.Name = "textBox_HoTenKH";
            textBox_HoTenKH.Size = new Size(459, 34);
            textBox_HoTenKH.TabIndex = 12;
            // 
            // textBox_MaKH
            // 
            textBox_MaKH.BackColor = Color.WhiteSmoke;
            textBox_MaKH.Enabled = false;
            textBox_MaKH.Font = new Font("Segoe UI", 12F);
            textBox_MaKH.ForeColor = Color.FromArgb(45, 66, 113);
            textBox_MaKH.Location = new Point(197, 114);
            textBox_MaKH.Name = "textBox_MaKH";
            textBox_MaKH.Size = new Size(286, 34);
            textBox_MaKH.TabIndex = 11;
            // 
            // btn_KH_Xoa
            // 
            btn_KH_Xoa.BackColor = Color.FromArgb(52, 50, 162);
            btn_KH_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_KH_Xoa.ForeColor = Color.White;
            btn_KH_Xoa.Location = new Point(269, 578);
            btn_KH_Xoa.Margin = new Padding(3, 4, 3, 4);
            btn_KH_Xoa.Name = "btn_KH_Xoa";
            btn_KH_Xoa.Size = new Size(163, 42);
            btn_KH_Xoa.TabIndex = 10;
            btn_KH_Xoa.Text = "Xóa";
            btn_KH_Xoa.UseVisualStyleBackColor = false;
            btn_KH_Xoa.Click += btn_KH_Xoa_Click;
            // 
            // btn_KH_Sua
            // 
            btn_KH_Sua.BackColor = Color.FromArgb(52, 50, 162);
            btn_KH_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_KH_Sua.ForeColor = Color.White;
            btn_KH_Sua.Location = new Point(53, 653);
            btn_KH_Sua.Margin = new Padding(3, 4, 3, 4);
            btn_KH_Sua.Name = "btn_KH_Sua";
            btn_KH_Sua.Size = new Size(163, 42);
            btn_KH_Sua.TabIndex = 9;
            btn_KH_Sua.Text = "Sửa ";
            btn_KH_Sua.UseVisualStyleBackColor = false;
            btn_KH_Sua.Click += btn_KH_Sua_Click;
            // 
            // btn_KH_Them
            // 
            btn_KH_Them.BackColor = Color.FromArgb(52, 50, 162);
            btn_KH_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_KH_Them.ForeColor = Color.White;
            btn_KH_Them.Location = new Point(53, 578);
            btn_KH_Them.Margin = new Padding(3, 4, 3, 4);
            btn_KH_Them.Name = "btn_KH_Them";
            btn_KH_Them.Size = new Size(163, 42);
            btn_KH_Them.TabIndex = 8;
            btn_KH_Them.Text = "Thêm";
            btn_KH_Them.UseVisualStyleBackColor = false;
            btn_KH_Them.Click += btn_KH_Them_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label24.ForeColor = Color.FromArgb(45, 66, 113);
            label24.Location = new Point(24, 461);
            label24.Name = "label24";
            label24.Size = new Size(85, 28);
            label24.TabIndex = 7;
            label24.Text = "Địa Chỉ:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label25.ForeColor = Color.FromArgb(45, 66, 113);
            label25.Location = new Point(24, 412);
            label25.Name = "label25";
            label25.Size = new Size(149, 28);
            label25.TabIndex = 6;
            label25.Text = "Số Điện Thoại:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label26.ForeColor = Color.FromArgb(45, 66, 113);
            label26.Location = new Point(24, 280);
            label26.Name = "label26";
            label26.Size = new Size(104, 28);
            label26.TabIndex = 5;
            label26.Text = "Giới Tính:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label27.ForeColor = Color.FromArgb(45, 66, 113);
            label27.Location = new Point(24, 171);
            label27.Name = "label27";
            label27.Size = new Size(111, 28);
            label27.TabIndex = 4;
            label27.Text = "Họ Và Tên:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label39.ForeColor = Color.FromArgb(45, 66, 113);
            label39.Location = new Point(24, 114);
            label39.Name = "label39";
            label39.Size = new Size(167, 28);
            label39.TabIndex = 3;
            label39.Text = "Mã Khách Hàng:";
            // 
            // f_admin_khachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_admin_khachhang";
            Text = "Quản lý khách hàng";
            Load += f_admin_khachhang_Load;
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSKH).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private GroupBox groupBox4;
        private RadioButton radio_KH_Nu;
        private RadioButton radio_KH_Nam;
        private Button btn_KH_LamMoi;
        private DateTimePicker dtp_KH_NgaySinh;
        private Label label23;
        private TextBox textBox_DiaChiKH;
        private TextBox textBox_SDTKH;
        private TextBox textBox_HoTenKH;
        private TextBox textBox_MaKH;
        private Button btn_KH_Xoa;
        private Button btn_KH_Sua;
        private Button btn_KH_Them;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label39;
        private DataGridView dataGridView_DSKH;
        private GroupBox groupBox1;
        private Label label1;
    }
}