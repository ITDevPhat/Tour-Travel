namespace QuanLyDuLich.Forms
{
    partial class f_admin_nhanvien
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
            GroupBox groupBox5;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin_nhanvien));
            label1 = new Label();
            btn_NV_LamMoi = new Button();
            radio_NV_Nu = new RadioButton();
            radio_NV_Nam = new RadioButton();
            textBox_diachiNV = new TextBox();
            textBox_sdtNV = new TextBox();
            dtp_NV_NgaySinh = new DateTimePicker();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            textBox_hotenNV = new TextBox();
            textBox_maNV = new TextBox();
            label32 = new Label();
            button_xoaNV = new Button();
            label33 = new Label();
            button_suaNV = new Button();
            button_themNV = new Button();
            dataGridView_dsNV = new DataGridView();
            groupBox5 = new GroupBox();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dsNV).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Snow;
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(btn_NV_LamMoi);
            groupBox5.Controls.Add(radio_NV_Nu);
            groupBox5.Controls.Add(radio_NV_Nam);
            groupBox5.Controls.Add(textBox_diachiNV);
            groupBox5.Controls.Add(textBox_sdtNV);
            groupBox5.Controls.Add(dtp_NV_NgaySinh);
            groupBox5.Controls.Add(label28);
            groupBox5.Controls.Add(label29);
            groupBox5.Controls.Add(label30);
            groupBox5.Controls.Add(label31);
            groupBox5.Controls.Add(textBox_hotenNV);
            groupBox5.Controls.Add(textBox_maNV);
            groupBox5.Controls.Add(label32);
            groupBox5.Controls.Add(button_xoaNV);
            groupBox5.Controls.Add(label33);
            groupBox5.Controls.Add(button_suaNV);
            groupBox5.Controls.Add(button_themNV);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(450, 721);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 66, 113);
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(198, 50);
            label1.TabIndex = 9;
            label1.Text = "Nhân viên";
            // 
            // btn_NV_LamMoi
            // 
            btn_NV_LamMoi.BackColor = Color.FromArgb(52, 50, 162);
            btn_NV_LamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_NV_LamMoi.ForeColor = Color.White;
            btn_NV_LamMoi.Location = new Point(263, 654);
            btn_NV_LamMoi.Margin = new Padding(3, 4, 3, 4);
            btn_NV_LamMoi.Name = "btn_NV_LamMoi";
            btn_NV_LamMoi.Size = new Size(157, 39);
            btn_NV_LamMoi.TabIndex = 8;
            btn_NV_LamMoi.Text = "Làm mới";
            btn_NV_LamMoi.UseVisualStyleBackColor = false;
            btn_NV_LamMoi.Click += btn_NV_LamMoi_Click;
            // 
            // radio_NV_Nu
            // 
            radio_NV_Nu.AutoSize = true;
            radio_NV_Nu.Font = new Font("Segoe UI", 12F);
            radio_NV_Nu.Location = new Point(348, 247);
            radio_NV_Nu.Name = "radio_NV_Nu";
            radio_NV_Nu.Size = new Size(60, 32);
            radio_NV_Nu.TabIndex = 7;
            radio_NV_Nu.Text = "Nữ";
            radio_NV_Nu.UseVisualStyleBackColor = true;
            // 
            // radio_NV_Nam
            // 
            radio_NV_Nam.AutoSize = true;
            radio_NV_Nam.Checked = true;
            radio_NV_Nam.Font = new Font("Segoe UI", 12F);
            radio_NV_Nam.Location = new Point(188, 247);
            radio_NV_Nam.Name = "radio_NV_Nam";
            radio_NV_Nam.Size = new Size(75, 32);
            radio_NV_Nam.TabIndex = 6;
            radio_NV_Nam.TabStop = true;
            radio_NV_Nam.Text = "Nam";
            radio_NV_Nam.UseVisualStyleBackColor = true;
            // 
            // textBox_diachiNV
            // 
            textBox_diachiNV.BackColor = Color.White;
            textBox_diachiNV.Font = new Font("Segoe UI", 12F);
            textBox_diachiNV.Location = new Point(17, 465);
            textBox_diachiNV.Multiline = true;
            textBox_diachiNV.Name = "textBox_diachiNV";
            textBox_diachiNV.Size = new Size(427, 101);
            textBox_diachiNV.TabIndex = 3;
            // 
            // textBox_sdtNV
            // 
            textBox_sdtNV.BackColor = Color.White;
            textBox_sdtNV.Font = new Font("Segoe UI", 12F);
            textBox_sdtNV.Location = new Point(184, 375);
            textBox_sdtNV.Name = "textBox_sdtNV";
            textBox_sdtNV.Size = new Size(260, 34);
            textBox_sdtNV.TabIndex = 3;
            // 
            // dtp_NV_NgaySinh
            // 
            dtp_NV_NgaySinh.CustomFormat = "dd-MM-yyyy";
            dtp_NV_NgaySinh.Font = new Font("Segoe UI", 12F);
            dtp_NV_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NV_NgaySinh.Location = new Point(184, 308);
            dtp_NV_NgaySinh.Name = "dtp_NV_NgaySinh";
            dtp_NV_NgaySinh.Size = new Size(224, 34);
            dtp_NV_NgaySinh.TabIndex = 3;
            dtp_NV_NgaySinh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label28.ForeColor = Color.FromArgb(45, 66, 113);
            label28.Location = new Point(17, 434);
            label28.Name = "label28";
            label28.Size = new Size(85, 28);
            label28.TabIndex = 3;
            label28.Text = "Địa Chỉ:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label29.ForeColor = Color.FromArgb(45, 66, 113);
            label29.Location = new Point(17, 378);
            label29.Name = "label29";
            label29.Size = new Size(149, 28);
            label29.TabIndex = 3;
            label29.Text = "Số Điện Thoại:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label30.ForeColor = Color.FromArgb(45, 66, 113);
            label30.Location = new Point(17, 308);
            label30.Name = "label30";
            label30.Size = new Size(114, 28);
            label30.TabIndex = 3;
            label30.Text = "Ngày Sinh:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label31.ForeColor = Color.FromArgb(45, 66, 113);
            label31.Location = new Point(21, 251);
            label31.Name = "label31";
            label31.Size = new Size(104, 28);
            label31.TabIndex = 3;
            label31.Text = "Giới Tính:";
            // 
            // textBox_hotenNV
            // 
            textBox_hotenNV.BackColor = Color.White;
            textBox_hotenNV.Font = new Font("Segoe UI", 12F);
            textBox_hotenNV.Location = new Point(134, 185);
            textBox_hotenNV.Name = "textBox_hotenNV";
            textBox_hotenNV.Size = new Size(310, 34);
            textBox_hotenNV.TabIndex = 3;
            // 
            // textBox_maNV
            // 
            textBox_maNV.BackColor = Color.White;
            textBox_maNV.Enabled = false;
            textBox_maNV.Font = new Font("Segoe UI", 12F);
            textBox_maNV.Location = new Point(184, 126);
            textBox_maNV.Name = "textBox_maNV";
            textBox_maNV.ReadOnly = true;
            textBox_maNV.Size = new Size(260, 34);
            textBox_maNV.TabIndex = 3;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label32.ForeColor = Color.FromArgb(45, 66, 113);
            label32.Location = new Point(17, 191);
            label32.Name = "label32";
            label32.Size = new Size(111, 28);
            label32.TabIndex = 3;
            label32.Text = "Họ Và Tên:";
            // 
            // button_xoaNV
            // 
            button_xoaNV.BackColor = Color.FromArgb(52, 50, 162);
            button_xoaNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_xoaNV.ForeColor = Color.White;
            button_xoaNV.Location = new Point(263, 590);
            button_xoaNV.Margin = new Padding(3, 4, 3, 4);
            button_xoaNV.Name = "button_xoaNV";
            button_xoaNV.Size = new Size(157, 39);
            button_xoaNV.TabIndex = 5;
            button_xoaNV.Text = "Xóa";
            button_xoaNV.UseVisualStyleBackColor = false;
            button_xoaNV.Click += button_xoaNV_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label33.ForeColor = Color.FromArgb(45, 66, 113);
            label33.Location = new Point(17, 132);
            label33.Name = "label33";
            label33.Size = new Size(152, 28);
            label33.TabIndex = 3;
            label33.Text = "Mã Nhân Viên:";
            // 
            // button_suaNV
            // 
            button_suaNV.BackColor = Color.FromArgb(52, 50, 162);
            button_suaNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_suaNV.ForeColor = Color.White;
            button_suaNV.Location = new Point(53, 654);
            button_suaNV.Margin = new Padding(3, 4, 3, 4);
            button_suaNV.Name = "button_suaNV";
            button_suaNV.Size = new Size(157, 39);
            button_suaNV.TabIndex = 4;
            button_suaNV.Text = "Sửa ";
            button_suaNV.UseVisualStyleBackColor = false;
            button_suaNV.Click += button_suaNV_Click;
            // 
            // button_themNV
            // 
            button_themNV.BackColor = Color.FromArgb(52, 50, 162);
            button_themNV.BackgroundImageLayout = ImageLayout.Center;
            button_themNV.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button_themNV.FlatAppearance.BorderSize = 0;
            button_themNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_themNV.ForeColor = Color.White;
            button_themNV.Location = new Point(53, 590);
            button_themNV.Margin = new Padding(3, 4, 3, 4);
            button_themNV.Name = "button_themNV";
            button_themNV.Size = new Size(157, 39);
            button_themNV.TabIndex = 3;
            button_themNV.Text = "Thêm";
            button_themNV.UseVisualStyleBackColor = false;
            button_themNV.Click += button_themNV_Click;
            // 
            // dataGridView_dsNV
            // 
            dataGridView_dsNV.AllowUserToAddRows = false;
            dataGridView_dsNV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView_dsNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_dsNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_dsNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView_dsNV.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.MistyRose;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_dsNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_dsNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_dsNV.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_dsNV.Dock = DockStyle.Fill;
            dataGridView_dsNV.GridColor = SystemColors.HotTrack;
            dataGridView_dsNV.Location = new Point(450, 0);
            dataGridView_dsNV.Name = "dataGridView_dsNV";
            dataGridView_dsNV.RowHeadersWidth = 51;
            dataGridView_dsNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_dsNV.Size = new Size(898, 721);
            dataGridView_dsNV.TabIndex = 6;
            dataGridView_dsNV.CellClick += dataGridView_dsNV_CellClick;
            // 
            // f_admin_nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 721);
            Controls.Add(dataGridView_dsNV);
            Controls.Add(groupBox5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_admin_nhanvien";
            Text = "Quản lý nhân viên";
            Load += f_admin_nhanvien_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dsNV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_dsNV;
        private Button btn_NV_LamMoi;
        private RadioButton radio_NV_Nu;
        private RadioButton radio_NV_Nam;
        private TextBox textBox_diachiNV;
        private TextBox textBox_sdtNV;
        private DateTimePicker dtp_NV_NgaySinh;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox textBox_hotenNV;
        private TextBox textBox_maNV;
        private Label label32;
        private Button button_xoaNV;
        private Label label33;
        private Button button_suaNV;
        private Button button_themNV;
        private Label label1;
    }
}