using QuanLyDuLich.DAO;
using QuanLyDuLich.DTO.QuanLyDuLich.DTO;
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
    public partial class f_admin_khachhang : Form
    {
        public string KH_Ma_HienTai = "";
        public f_admin_khachhang()
        {
            InitializeComponent();
        }

        private void f_admin_khachhang_Load(object sender, EventArgs e)
        {
            LoadLaiTatCaKhachHang();
        }
        public void MaKhachHangMoiNhat()
        {
            textBox_MaKH.Text = KhachHangDAO.Instance.MaKhachHangMoiNhat();
        }

        public void LoadDanhSachKhachHang()
        {
            dataGridView_DSKH.DataSource = KhachHangDAO.Instance.HienThiDanhSachKhachHang();
        }

        private void dataGridView_DSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_KH_Them.Enabled = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_DSKH.Rows[rowIndex];

                textBox_MaKH.Text = row.Cells["Mã khách hàng"].Value.ToString().Trim();
                textBox_HoTenKH.Text = row.Cells["Họ và tên"].Value.ToString().Trim();

                radio_KH_Nu.Checked = false; // Bỏ chọn radio button "Nữ"
                radio_KH_Nam.Checked = false; // Bỏ chọn radio button "Nam"
                if (row.Cells["Giới tính"].Value.ToString() == "Nam")
                {
                    radio_KH_Nam.Checked = true; // Chọn radio button "Nam"
                }
                else
                {
                    radio_KH_Nu.Checked = true; // Chọn radio button "Nữ"
                }

                if (DateTime.TryParse(row.Cells["Ngày sinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dtp_KH_NgaySinh.Value = ngaySinh;
                }

                textBox_SDTKH.Text = row.Cells["Số điện thoại"].Value.ToString().Trim();
                textBox_DiaChiKH.Text = row.Cells["Địa chỉ"].Value.ToString().Trim();

                //Cập nhật mã khách hàng hiện tại
                KH_Ma_HienTai = row.Cells["Mã khách hàng"].Value.ToString().Trim();
            }
        }

        private void btn_KH_LamMoi_Click(object sender, EventArgs e)
        {
            LoadLaiTatCaKhachHang();
        }

        public void LoadLaiTatCaKhachHang()
        {
            btn_KH_Them.Enabled = true;

            MaKhachHangMoiNhat();
            textBox_HoTenKH.Text = "";
            radio_KH_Nam.Checked = true;
            radio_KH_Nu.Checked = false;
            dtp_KH_NgaySinh.Value = DateTime.Now;
            textBox_SDTKH.Text = "";
            textBox_DiaChiKH.Text = "";

            LoadDanhSachKhachHang();
        }

        private void btn_KH_Them_Click(object sender, EventArgs e)
        {
            if (textBox_MaKH.Text == "" || textBox_HoTenKH.Text == "" || textBox_SDTKH.Text == "" || textBox_DiaChiKH.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gioiTinh = "";
            if (radio_KH_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            KhachHang khachHang = new KhachHang(
                    textBox_MaKH.Text.Trim(),
                    textBox_HoTenKH.Text.Trim(),
                    gioiTinh,
                    dtp_KH_NgaySinh.Value,
                    textBox_SDTKH.Text,
                    textBox_DiaChiKH.Text
            );
            try
            {
                KhachHangDAO.Instance.ThemKhachHangMoi(khachHang);
                MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KH_Sua_Click(object sender, EventArgs e)
        {
            if (textBox_MaKH.Text == "" || textBox_HoTenKH.Text == "" || textBox_SDTKH.Text == "" || textBox_DiaChiKH.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Sửa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gioiTinh = radio_KH_Nam.Checked ? "Nam" : "Nữ";

            KhachHang khachHang = new KhachHang(
                    textBox_MaKH.Text.Trim(),
                    textBox_HoTenKH.Text.Trim(),
                    gioiTinh,
                    dtp_KH_NgaySinh.Value,
                    textBox_SDTKH.Text,
                    textBox_DiaChiKH.Text
            );
            try
            {
                KhachHangDAO.Instance.SuaKhachHang(khachHang);
                MessageBox.Show("Sửa khách hàng thành công", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KH_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dữ liệu để xóa
            if (dataGridView_DSKH.RowCount <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Gọi phương thức XoaKhachHang của lớp KhachHangDAO để xóa khách hàng
                KhachHangDAO.Instance.XoaKhachHang(KH_Ma_HienTai);

                MessageBox.Show("Xóa khách hàng thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi xóa thành công, load lại danh sách khách hàng
                LoadLaiTatCaKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_KH_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
