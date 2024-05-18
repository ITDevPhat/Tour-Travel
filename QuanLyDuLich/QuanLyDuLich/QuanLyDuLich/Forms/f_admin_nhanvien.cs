using QuanLyDuLich.DAO;
using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class f_admin_nhanvien : Form
    {
        public string NV_Ma_HienTai = "";
        public f_admin_nhanvien()
        {
            InitializeComponent();
            LoadLaiTatCaNhanVien();
        }
        public void MaNhanVienMoiNhat()
        {
            textBox_maNV.Text = NhanVienDAO.Instance.MaNhanVienMoiNhat();
        }

        public void LoadDanhSachNhanVien()
        {
            dataGridView_dsNV.DataSource = NhanVienDAO.Instance.HienThiDanhSachNhanVien();
        }

        private void dataGridView_dsNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_themNV.Enabled = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_dsNV.Rows[rowIndex];

                textBox_maNV.Text = row.Cells[0].Value.ToString().Trim();
                textBox_hotenNV.Text = row.Cells[1].Value.ToString().Trim();

                radio_NV_Nu.Checked = false; // Bỏ chọn radio button "Nữ"
                radio_NV_Nam.Checked = false; // Bỏ chọn radio button "Nam"
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    radio_NV_Nam.Checked = true; // Chọn radio button "Nam"
                }
                else
                {
                    radio_NV_Nu.Checked = true; // Chọn radio button "Nữ"
                }
                string dateString = row.Cells[3].Value.ToString();

                DateTime ngaySinh;
                if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    dtp_NV_NgaySinh.Value = ngaySinh;
                }

                textBox_sdtNV.Text = row.Cells[4].Value.ToString().Trim();
                textBox_diachiNV.Text = row.Cells[5].Value.ToString().Trim();

                //Cập nhật mã địa điểm hiện tại
                NV_Ma_HienTai = row.Cells[0].Value.ToString().Trim();
            }
        }

        private void btn_NV_LamMoi_Click(object sender, EventArgs e)
        {
            LoadLaiTatCaNhanVien();
        }

        public void LoadLaiTatCaNhanVien()
        {
            button_themNV.Enabled = true;

            MaNhanVienMoiNhat();
            textBox_hotenNV.Text = "";
            radio_NV_Nam.Checked = true;
            radio_NV_Nu.Checked = false;
            dtp_NV_NgaySinh.Text = System.DateTime.Now.ToString();
            textBox_sdtNV.Text = "";
            textBox_diachiNV.Text = "";


            LoadDanhSachNhanVien();
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Đây là một ví dụ đơn giản, bạn có thể thực hiện kiểm tra phức tạp hơn tùy thuộc vào định dạng số điện thoại yêu cầu
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c)) // Kiểm tra xem tất cả các ký tự có phải là số không
                {
                    return false;
                }
            }
            return true;
        }
        private void button_themNV_Click(object sender, EventArgs e)
        {
            bool flag = true; // Mặc định là thông tin hợp lệ
            if (textBox_maNV.Text == "" || textBox_hotenNV.Text == "" || textBox_sdtNV.Text == "" || textBox_diachiNV.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gioiTinh = "";
            if (radio_NV_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            if (!IsPhoneNumberValid(textBox_sdtNV.Text))
            {
                flag = false;
                MessageBox.Show("Số điện thoại bắt buộc là các chữ số", "Lỗi nhập thông tin số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NhanVien nhanVien = new NhanVien(
                    textBox_maNV.Text.Trim(),
                    textBox_hotenNV.Text.Trim(),
                    gioiTinh,
                    dtp_NV_NgaySinh.Value,
                    textBox_sdtNV.Text,
                    textBox_diachiNV.Text
                                            );
            try
            {
                NhanVienDAO.Instance.ThemNhanVienMoi(nhanVien);
                MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaNhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void button_suaNV_Click(object sender, EventArgs e)
        {
            if (textBox_maNV.Text == "" || textBox_hotenNV.Text == "" || textBox_sdtNV.Text == "" || textBox_diachiNV.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Sửa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gioiTinh = "";
            if (radio_NV_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            NhanVien nhanVien = new NhanVien(
                    textBox_maNV.Text.Trim(),
                    textBox_hotenNV.Text.Trim(),
                    gioiTinh,
                    dtp_NV_NgaySinh.Value,
                    textBox_sdtNV.Text,
                    textBox_diachiNV.Text
                                            );
            try
            {
                NhanVienDAO.Instance.SuaNhanVien(nhanVien);
                MessageBox.Show("Sửa nhân viên thành công", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }

        private void button_xoaNV_Click(object sender, EventArgs e)
        {
            if (dataGridView_dsNV.RowCount <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                NhanVienDAO.Instance.XoaNhanVien(NV_Ma_HienTai);
                if (NV_Ma_HienTai != "NV1")
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadLaiTatCaNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void f_admin_nhanvien_Load(object sender, EventArgs e)
        {
            LoadLaiTatCaNhanVien();
        }
    }
}
