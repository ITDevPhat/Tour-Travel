namespace QuanLyDuLich.Forms
{
    partial class f_nv_quanlyve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_nv_quanlyve));
            label5 = new Label();
            txtbox_ChiTiet_SoLuongVeHuy = new TextBox();
            label4 = new Label();
            txtBox_ChiTiet_TenTourXoa = new TextBox();
            label3 = new Label();
            txtbox_ChiTiet_MaVeCanXoa = new TextBox();
            btn_ChiTiet_XoaVe = new Button();
            label1 = new Label();
            dgv_VeDaDat = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_VeDaDat).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Snow;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 66, 113);
            label5.Location = new Point(911, 23);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 17;
            label5.Text = "Số lượng vé hủy";
            // 
            // txtbox_ChiTiet_SoLuongVeHuy
            // 
            txtbox_ChiTiet_SoLuongVeHuy.BackColor = Color.Snow;
            txtbox_ChiTiet_SoLuongVeHuy.Font = new Font("Segoe UI", 12F);
            txtbox_ChiTiet_SoLuongVeHuy.Location = new Point(911, 70);
            txtbox_ChiTiet_SoLuongVeHuy.Name = "txtbox_ChiTiet_SoLuongVeHuy";
            txtbox_ChiTiet_SoLuongVeHuy.Size = new Size(125, 34);
            txtbox_ChiTiet_SoLuongVeHuy.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 66, 113);
            label4.Location = new Point(273, 23);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 15;
            label4.Text = "Tên tour cần hủy";
            // 
            // txtBox_ChiTiet_TenTourXoa
            // 
            txtBox_ChiTiet_TenTourXoa.BackColor = Color.Snow;
            txtBox_ChiTiet_TenTourXoa.BorderStyle = BorderStyle.None;
            txtBox_ChiTiet_TenTourXoa.Font = new Font("Segoe UI", 12F);
            txtBox_ChiTiet_TenTourXoa.Location = new Point(273, 70);
            txtBox_ChiTiet_TenTourXoa.Multiline = true;
            txtBox_ChiTiet_TenTourXoa.Name = "txtBox_ChiTiet_TenTourXoa";
            txtBox_ChiTiet_TenTourXoa.ReadOnly = true;
            txtBox_ChiTiet_TenTourXoa.Size = new Size(552, 70);
            txtBox_ChiTiet_TenTourXoa.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 66, 113);
            label3.Location = new Point(46, 23);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 13;
            label3.Text = "Mã vé cần huỷ";
            // 
            // txtbox_ChiTiet_MaVeCanXoa
            // 
            txtbox_ChiTiet_MaVeCanXoa.BackColor = Color.Snow;
            txtbox_ChiTiet_MaVeCanXoa.BorderStyle = BorderStyle.None;
            txtbox_ChiTiet_MaVeCanXoa.Font = new Font("Segoe UI", 12F);
            txtbox_ChiTiet_MaVeCanXoa.Location = new Point(46, 70);
            txtbox_ChiTiet_MaVeCanXoa.Name = "txtbox_ChiTiet_MaVeCanXoa";
            txtbox_ChiTiet_MaVeCanXoa.ReadOnly = true;
            txtbox_ChiTiet_MaVeCanXoa.Size = new Size(125, 27);
            txtbox_ChiTiet_MaVeCanXoa.TabIndex = 12;
            // 
            // btn_ChiTiet_XoaVe
            // 
            btn_ChiTiet_XoaVe.BackColor = Color.FromArgb(52, 50, 162);
            btn_ChiTiet_XoaVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ChiTiet_XoaVe.ForeColor = Color.White;
            btn_ChiTiet_XoaVe.Location = new Point(1159, 68);
            btn_ChiTiet_XoaVe.Margin = new Padding(3, 4, 3, 4);
            btn_ChiTiet_XoaVe.Name = "btn_ChiTiet_XoaVe";
            btn_ChiTiet_XoaVe.Size = new Size(122, 48);
            btn_ChiTiet_XoaVe.TabIndex = 11;
            btn_ChiTiet_XoaVe.Text = "Xóa vé";
            btn_ChiTiet_XoaVe.UseVisualStyleBackColor = false;
            btn_ChiTiet_XoaVe.Click += btn_ChiTiet_XoaVe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 66, 113);
            label1.Location = new Point(640, 23);
            label1.Name = "label1";
            label1.Size = new Size(185, 50);
            label1.TabIndex = 10;
            label1.Text = "Vé đã đặt";
            // 
            // dgv_VeDaDat
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_VeDaDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_VeDaDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_VeDaDat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_VeDaDat.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_VeDaDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_VeDaDat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_VeDaDat.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_VeDaDat.Dock = DockStyle.Fill;
            dgv_VeDaDat.Location = new Point(3, 23);
            dgv_VeDaDat.Name = "dgv_VeDaDat";
            dgv_VeDaDat.RowHeadersWidth = 51;
            dgv_VeDaDat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_VeDaDat.Size = new Size(1342, 449);
            dgv_VeDaDat.TabIndex = 9;
            dgv_VeDaDat.CellClick += dgv_VeDaDat_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1348, 76);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtbox_ChiTiet_SoLuongVeHuy);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtBox_ChiTiet_TenTourXoa);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtbox_ChiTiet_MaVeCanXoa);
            groupBox2.Controls.Add(btn_ChiTiet_XoaVe);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 551);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1348, 170);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_VeDaDat);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1348, 475);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            // 
            // f_nv_quanlyve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1348, 721);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_nv_quanlyve";
            Text = "Quản lý vé";
            Load += f_nv_quanlyve_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_VeDaDat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private TextBox txtbox_ChiTiet_SoLuongVeHuy;
        private Label label4;
        private TextBox txtBox_ChiTiet_TenTourXoa;
        private Label label3;
        private TextBox txtbox_ChiTiet_MaVeCanXoa;
        private Button btn_ChiTiet_XoaVe;
        private Label label1;
        private DataGridView dgv_VeDaDat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}