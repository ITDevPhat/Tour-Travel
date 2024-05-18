namespace QuanLyDuLich.Forms
{
    partial class f_admin_Ve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin_Ve));
            dgv_Ve_DoanhThu = new DataGridView();
            label51 = new Label();
            label50 = new Label();
            txtbox_VE_TongVe = new TextBox();
            txtbox_VE_TongTien = new TextBox();
            dtp_Ve_DoanhThuNam = new DateTimePicker();
            dtp_Ve_DoanhThuThang = new DateTimePicker();
            label49 = new Label();
            label48 = new Label();
            label47 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Ve_DoanhThu).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Ve_DoanhThu
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_Ve_DoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Ve_DoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Ve_DoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_Ve_DoanhThu.BackgroundColor = Color.Azure;
            dgv_Ve_DoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Ve_DoanhThu.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Ve_DoanhThu.Dock = DockStyle.Fill;
            dgv_Ve_DoanhThu.Location = new Point(3, 23);
            dgv_Ve_DoanhThu.Name = "dgv_Ve_DoanhThu";
            dgv_Ve_DoanhThu.RowHeadersWidth = 51;
            dgv_Ve_DoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Ve_DoanhThu.Size = new Size(1342, 492);
            dgv_Ve_DoanhThu.TabIndex = 20;
            dgv_Ve_DoanhThu.CellContentClick += dgv_Ve_DoanhThu_CellContentClick;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label51.ForeColor = Color.FromArgb(45, 66, 113);
            label51.Location = new Point(728, 41);
            label51.Name = "label51";
            label51.Size = new Size(202, 28);
            label51.TabIndex = 19;
            label51.Text = "Tổng tiền vé đã bán";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label50.ForeColor = Color.FromArgb(45, 66, 113);
            label50.Location = new Point(36, 39);
            label50.Name = "label50";
            label50.Size = new Size(186, 28);
            label50.TabIndex = 18;
            label50.Text = "Tổng số vé đã bán";
            // 
            // txtbox_VE_TongVe
            // 
            txtbox_VE_TongVe.BackColor = Color.Snow;
            txtbox_VE_TongVe.BorderStyle = BorderStyle.None;
            txtbox_VE_TongVe.Enabled = false;
            txtbox_VE_TongVe.Font = new Font("Segoe UI", 12F);
            txtbox_VE_TongVe.ForeColor = Color.FromArgb(45, 66, 113);
            txtbox_VE_TongVe.Location = new Point(251, 40);
            txtbox_VE_TongVe.Name = "txtbox_VE_TongVe";
            txtbox_VE_TongVe.ReadOnly = true;
            txtbox_VE_TongVe.Size = new Size(353, 27);
            txtbox_VE_TongVe.TabIndex = 17;
            // 
            // txtbox_VE_TongTien
            // 
            txtbox_VE_TongTien.BackColor = Color.Snow;
            txtbox_VE_TongTien.BorderStyle = BorderStyle.None;
            txtbox_VE_TongTien.Enabled = false;
            txtbox_VE_TongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtbox_VE_TongTien.ForeColor = Color.FromArgb(224, 22, 0);
            txtbox_VE_TongTien.Location = new Point(952, 40);
            txtbox_VE_TongTien.Name = "txtbox_VE_TongTien";
            txtbox_VE_TongTien.ReadOnly = true;
            txtbox_VE_TongTien.Size = new Size(395, 29);
            txtbox_VE_TongTien.TabIndex = 16;
            // 
            // dtp_Ve_DoanhThuNam
            // 
            dtp_Ve_DoanhThuNam.CustomFormat = "yyyy";
            dtp_Ve_DoanhThuNam.Font = new Font("Segoe UI", 12F);
            dtp_Ve_DoanhThuNam.Format = DateTimePickerFormat.Custom;
            dtp_Ve_DoanhThuNam.Location = new Point(1095, 73);
            dtp_Ve_DoanhThuNam.Name = "dtp_Ve_DoanhThuNam";
            dtp_Ve_DoanhThuNam.Size = new Size(218, 34);
            dtp_Ve_DoanhThuNam.TabIndex = 15;
            dtp_Ve_DoanhThuNam.ValueChanged += dtp_Ve_DoanhThuNam_ValueChanged;
            // 
            // dtp_Ve_DoanhThuThang
            // 
            dtp_Ve_DoanhThuThang.CustomFormat = "MM-yyyy";
            dtp_Ve_DoanhThuThang.Font = new Font("Segoe UI", 12F);
            dtp_Ve_DoanhThuThang.Format = DateTimePickerFormat.Custom;
            dtp_Ve_DoanhThuThang.Location = new Point(302, 70);
            dtp_Ve_DoanhThuThang.Name = "dtp_Ve_DoanhThuThang";
            dtp_Ve_DoanhThuThang.Size = new Size(203, 34);
            dtp_Ve_DoanhThuThang.TabIndex = 14;
            dtp_Ve_DoanhThuThang.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            dtp_Ve_DoanhThuThang.ValueChanged += dtp_Ve_DoanhThuThang_ValueChanged;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label49.ForeColor = Color.FromArgb(45, 66, 113);
            label49.Location = new Point(868, 73);
            label49.Name = "label49";
            label49.Size = new Size(208, 28);
            label49.TabIndex = 13;
            label49.Text = "Doanh thu theo năm";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label48.ForeColor = Color.FromArgb(45, 66, 113);
            label48.Location = new Point(53, 68);
            label48.Name = "label48";
            label48.Size = new Size(222, 28);
            label48.TabIndex = 12;
            label48.Text = "Doanh thu theo tháng";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label47.ForeColor = Color.FromArgb(45, 66, 113);
            label47.Location = new Point(551, 9);
            label47.Name = "label47";
            label47.Size = new Size(348, 50);
            label47.TabIndex = 11;
            label47.Text = "Báo cáo doanh thu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_Ve_DoanhThuNam);
            groupBox1.Controls.Add(dtp_Ve_DoanhThuThang);
            groupBox1.Controls.Add(label49);
            groupBox1.Controls.Add(label48);
            groupBox1.Controls.Add(label47);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1348, 113);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label51);
            groupBox2.Controls.Add(label50);
            groupBox2.Controls.Add(txtbox_VE_TongVe);
            groupBox2.Controls.Add(txtbox_VE_TongTien);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 631);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1348, 90);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_Ve_DoanhThu);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1348, 518);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            // 
            // f_admin_Ve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1348, 721);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_admin_Ve";
            Text = "Quản Lý Vé";
            Load += f_admin_Ve_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Ve_DoanhThu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Ve_DoanhThu;
        private Label label51;
        private Label label50;
        private TextBox txtbox_VE_TongVe;
        private TextBox txtbox_VE_TongTien;
        private DateTimePicker dtp_Ve_DoanhThuNam;
        private DateTimePicker dtp_Ve_DoanhThuThang;
        private Label label49;
        private Label label48;
        private Label label47;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}