using QuanLyDuLich.DAO;
using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class f_admin_dichvu : Form
    {
        public string DV_Ma_HienTai = "";

        public f_admin_dichvu()
        {
            InitializeComponent();
        }

        private void f_admin_dichvu_Load(object sender, EventArgs e)
        {
            HienThiTatCaDichVu();
            LoadLaiTatCaDV();
        }
        void LoadLaiTatCaDV()
        {
            btn_ThemDV.Enabled = true;
            txtbox_TenDV.Text = "";
            cb_PhuongTienDV.Text = "Máy bay";
            txtbox_DiaDiemDV.Text = "";
            txtbox_MoTaDV.Text = "";

            txtbox_MaDV.Text = DichVuDAO.Instance.MaDVMoiNhat();
            HienThiTatCaDichVu();

        }
        public void HienThiTatCaDichVu()
        {
            dgv_DanhSachDichVu.DataSource = DichVuDAO.Instance.HienThiDanhSachDichVu();
        }

        private void dgv_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ThemDV.Enabled = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachDichVu.Rows[rowIndex];
                txtbox_MaDV.Text = row.Cells[0].Value.ToString().Trim();
                txtbox_TenDV.Text = row.Cells[1].Value.ToString().Trim();
                cb_PhuongTienDV.Text = row.Cells[2].Value.ToString().Trim();
                txtbox_DiaDiemDV.Text = row.Cells[3].Value.ToString().Trim();
                txtbox_MoTaDV.Text = row.Cells[4].Value.ToString().Trim();

                //Cập nhật mã địa điểm hiện tại
                DV_Ma_HienTai = row.Cells[0].Value.ToString();
            }

        }

        private void btn_ThemDV_Click(object sender, EventArgs e)
        {
            if (txtbox_TenDV.Text == "" || cb_PhuongTienDV.Text == "" || txtbox_DiaDiemDV.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DichVu dichVu = new DichVu(txtbox_MaDV.Text.Trim(), txtbox_TenDV.Text.Trim(), cb_PhuongTienDV.Text.Trim(), txtbox_DiaDiemDV.Text.Trim(), txtbox_MoTaDV.Text.Trim());
            try
            {
                DichVuDAO.Instance.ThemDichVuMoi(dichVu);
                MessageBox.Show("Thêm dịch vụ thành công", "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaDV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Thêm dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void btn_XoaDV_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachDichVu.RowCount <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DichVuDAO.Instance.XoaDichVu(DV_Ma_HienTai.Trim());
                MessageBox.Show("Xóa dịch vụ thành công", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaDV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadLaiTatCaDV();
        }

        private void btn_SuaDV_Click(object sender, EventArgs e)
        {
            if (txtbox_TenDV.Text == "" || cb_PhuongTienDV.Text == "" || txtbox_DiaDiemDV.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Sửa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadLaiTatCaDV();
                return;
            }

            DichVu dichVu = new DichVu(txtbox_MaDV.Text.Trim(), txtbox_TenDV.Text.Trim(), cb_PhuongTienDV.Text.Trim(), txtbox_DiaDiemDV.Text.Trim(), txtbox_MoTaDV.Text.Trim());
            try
            {
                DichVuDAO.Instance.SuaDichVU(dichVu);
                MessageBox.Show("Sửa dịch vụ thành công", "Sửa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaDV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Sửa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DanhSachDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
