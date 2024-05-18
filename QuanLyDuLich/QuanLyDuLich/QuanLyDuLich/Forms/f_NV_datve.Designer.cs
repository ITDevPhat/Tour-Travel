namespace QuanLyDuLich.Forms
{
    partial class f_NV_datve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_NV_datve));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            dgv_NV_DanhSachTour = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            panel2 = new Panel();
            btn_DatVe = new Button();
            txtBox_DatVe_SoTien = new TextBox();
            txtBox_DatVe_TenTour = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NV_DanhSachTour).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 591);
            panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_NV_DanhSachTour);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1337, 543);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dgv_NV_DanhSachTour
            // 
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_NV_DanhSachTour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_NV_DanhSachTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NV_DanhSachTour.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_NV_DanhSachTour.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_NV_DanhSachTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_NV_DanhSachTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_NV_DanhSachTour.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_NV_DanhSachTour.Dock = DockStyle.Fill;
            dgv_NV_DanhSachTour.Location = new Point(3, 23);
            dgv_NV_DanhSachTour.Name = "dgv_NV_DanhSachTour";
            dgv_NV_DanhSachTour.ReadOnly = true;
            dgv_NV_DanhSachTour.RowHeadersWidth = 51;
            dgv_NV_DanhSachTour.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NV_DanhSachTour.Size = new Size(1331, 517);
            dgv_NV_DanhSachTour.TabIndex = 0;
            dgv_NV_DanhSachTour.CellClick += dgv_NV_DanhSachTour_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1337, 48);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 66, 113);
            label2.Location = new Point(553, 0);
            label2.Name = "label2";
            label2.Size = new Size(293, 50);
            label2.TabIndex = 1;
            label2.Text = "Danh Sách Tour";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_DatVe);
            panel2.Controls.Add(txtBox_DatVe_SoTien);
            panel2.Controls.Add(txtBox_DatVe_TenTour);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 591);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 100);
            panel2.TabIndex = 5;
            // 
            // btn_DatVe
            // 
            btn_DatVe.BackColor = Color.FromArgb(52, 50, 162);
            btn_DatVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_DatVe.ForeColor = Color.White;
            btn_DatVe.Location = new Point(1166, 11);
            btn_DatVe.Name = "btn_DatVe";
            btn_DatVe.Size = new Size(127, 57);
            btn_DatVe.TabIndex = 2;
            btn_DatVe.Text = "Đặt vé";
            btn_DatVe.UseVisualStyleBackColor = false;
            btn_DatVe.Click += btn_DatVe_Click;
            // 
            // txtBox_DatVe_SoTien
            // 
            txtBox_DatVe_SoTien.BackColor = Color.Snow;
            txtBox_DatVe_SoTien.Enabled = false;
            txtBox_DatVe_SoTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtBox_DatVe_SoTien.ForeColor = Color.FromArgb(224, 22, 0);
            txtBox_DatVe_SoTien.Location = new Point(921, 28);
            txtBox_DatVe_SoTien.Name = "txtBox_DatVe_SoTien";
            txtBox_DatVe_SoTien.Size = new Size(169, 36);
            txtBox_DatVe_SoTien.TabIndex = 1;
            // 
            // txtBox_DatVe_TenTour
            // 
            txtBox_DatVe_TenTour.BackColor = Color.Snow;
            txtBox_DatVe_TenTour.Enabled = false;
            txtBox_DatVe_TenTour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox_DatVe_TenTour.ForeColor = Color.FromArgb(45, 66, 113);
            txtBox_DatVe_TenTour.Location = new Point(26, 22);
            txtBox_DatVe_TenTour.Multiline = true;
            txtBox_DatVe_TenTour.Name = "txtBox_DatVe_TenTour";
            txtBox_DatVe_TenTour.Size = new Size(841, 57);
            txtBox_DatVe_TenTour.TabIndex = 0;
            // 
            // f_NV_datve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1337, 691);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "f_NV_datve";
            Text = "Đặt vé";
            Load += f_NV_datve_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_NV_DanhSachTour).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dgv_NV_DanhSachTour;
        private Panel panel2;
        private Button btn_DatVe;
        private TextBox txtBox_DatVe_SoTien;
        private TextBox txtBox_DatVe_TenTour;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}