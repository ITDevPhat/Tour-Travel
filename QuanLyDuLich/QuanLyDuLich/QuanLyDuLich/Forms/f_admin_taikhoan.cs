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
    public partial class f_admin_taikhoan : Form
    {
        public string NguoiDungHienTai = "";
        public f_admin_taikhoan(string username)
        {
            InitializeComponent();

            NguoiDungHienTai = username;    
        }

        public void LoadTaiKhoan()
        {
            btn_TaiKhoan_Them.Enabled = true;
            txtbox_TaiKhoan_MaNhanVien.Text = "";
            txtbox_TaiKhoan_TenNhanVien.Text = "";

            txtbox_TaiKhoan_tendangnhap.Text = "";

            txtbox_TaiKhoan_MatKhau.Text = "";

            radio_TaiKhoan_NhanVien.Checked = true;

            radio_TaiKhoan_Admin.Checked = false;


            dgv_TaiKhoan_DSNhanVien.DataSource = NhanVienDAO.Instance.HienThiDanhSachNhanVien();


            dgv_TaiKhoan_DSNhanVien.Columns[2].Visible = false;
            dgv_TaiKhoan_DSNhanVien.Columns[3].Visible = false;
            dgv_TaiKhoan_DSNhanVien.Columns[4].Visible = false;
            dgv_TaiKhoan_DSNhanVien.Columns[5].Visible = false;

            dgv_TaiKhoan_DSTaiKhoan.DataSource = TaiKhoanDAO.Instance.HienThiDanhSachTaiKhoan();
        }


        private void dgv_TaiKhoan_DSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_TaiKhoan_DSNhanVien.Rows[rowIndex];

                txtbox_TaiKhoan_MaNhanVien.Text = row.Cells["Mã nhân viên"].Value.ToString().Trim();
                txtbox_TaiKhoan_TenNhanVien.Text = row.Cells["Họ và tên"].Value.ToString().Trim();

                if (row.Cells["Mã nhân viên"].Value.ToString().Trim() == "NV1" && NguoiDungHienTai != "admin")
                {
                    MessageBox.Show("Không thể chỉnh sửa người dùng này", "Không đủ quyền hạn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void btn_TaiKhoan_Them_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtbox_TaiKhoan_tendangnhap.Text.Trim();
            string matkhau = txtbox_TaiKhoan_MatKhau.Text.Trim();


            int loai = 0;
            if (radio_TaiKhoan_Admin.Checked)
                loai = 1;
            string manhanvien = txtbox_TaiKhoan_MaNhanVien.Text.Trim();
            TaiKhoan tk = new TaiKhoan(tendangnhap, matkhau, loai, manhanvien);

            try
            {
                TaiKhoanDAO.Instance.ThemTaiKhoanMoi(tk);
                MessageBox.Show("Thêm tài khoản thành công", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_TaiKhoan_LamMoi_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        public string TK_tendangnhaphientai = "";
        public string TK_NV_ID = "";
        private void btn_TaiKhoan_Sua_Click(object sender, EventArgs e)
        {

            string tendangnhap = txtbox_TaiKhoan_tendangnhap.Text.Trim();
            string matkhau = txtbox_TaiKhoan_MatKhau.Text.Trim();
            int loai = 0;
            if (radio_TaiKhoan_Admin.Checked)
                loai = 1;
            string manhanvien = txtbox_TaiKhoan_MaNhanVien.Text.Trim();
            TaiKhoan tk = new TaiKhoan(tendangnhap, matkhau, loai, manhanvien);

            try
            {

                TaiKhoanDAO.Instance.SuaTaiKhoan(tk, TK_tendangnhaphientai);
                MessageBox.Show("Sửa tài khoản thành công", "Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi Sửa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_TaiKhoan_DSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_TaiKhoan_Them.Enabled = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_TaiKhoan_DSTaiKhoan.Rows[rowIndex];

                string queryTenDangnhap = row.Cells["Tên đăng nhập"].Value.ToString().Trim();

                if (queryTenDangnhap == "admin")
                {
                    MessageBox.Show("Không có quyền truy cập người quản trị này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    LoadTaiKhoan();
                    return;
                }


                DataTable data = TaiKhoanDAO.Instance.LayThongTinTuTenDangNhap(queryTenDangnhap);

                txtbox_TaiKhoan_tendangnhap.Text = data.Rows[0][0].ToString();
                TK_tendangnhaphientai = data.Rows[0][0].ToString();


                txtbox_TaiKhoan_MatKhau.Text = data.Rows[0][1].ToString();



                int loai = Convert.ToInt32(data.Rows[0][2]);
                radio_TaiKhoan_NhanVien.Checked = false;
                radio_TaiKhoan_Admin.Checked = false;

                if (loai == 1)
                {
                    radio_TaiKhoan_Admin.Checked = true;
                }
                else
                {
                    radio_TaiKhoan_NhanVien.Checked = true;
                }

                txtbox_TaiKhoan_MaNhanVien.Text = data.Rows[0][3].ToString();
                TK_NV_ID = data.Rows[0][3].ToString();

                string tenNV = row.Cells[3].Value.ToString().Trim();
                txtbox_TaiKhoan_TenNhanVien.Text = tenNV;



            }
        }

        private void btn_TaiKhoan_Xoa_Click(object sender, EventArgs e)
        {
            if (TK_tendangnhaphientai != "admin")
            {
                TaiKhoanDAO.Instance.XoaTaiKhoan(TK_tendangnhaphientai, TK_NV_ID);
                MessageBox.Show("Xóa tài khoản thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaiKhoan();
                return;
            }
        }

        private void f_admin_taikhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }
    }
}
