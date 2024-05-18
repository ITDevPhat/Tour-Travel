using QuanLyDuLich.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyDuLich.Forms
{
    public partial class f_nv_quanlyve : Form
    {
        public string tendangnhap = "";
        public string ID_Tour_HienTai = "";
        public int so_ve_HienTai = 0;

        // VE DAT DAT
        public string Ma_Ve_Da_dat;
        //
        public f_nv_quanlyve(string username)
        {
            InitializeComponent();
            tendangnhap = username;
        }

        public void HienThiThongTinNhanVienDaDatVe()
        {
            string maNV = NhanVienDAO.Instance.HienThiMaNhanVienTheoTenDangNhap(tendangnhap);
            dgv_VeDaDat.DataSource = VeDAO.Instance.HienThiVeTheoIDNhanVien(maNV);

        }

        private void dgv_VeDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_VeDaDat.Rows[rowIndex];

                Ma_Ve_Da_dat = row.Cells[0].Value.ToString();
                txtbox_ChiTiet_MaVeCanXoa.Text = Ma_Ve_Da_dat;
                txtBox_ChiTiet_TenTourXoa.Text = row.Cells[1].Value.ToString();
                txtbox_ChiTiet_SoLuongVeHuy.Text = row.Cells[2].Value.ToString();
            }
        }

        private void f_nv_quanlyve_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhanVienDaDatVe();
        }

        private void btn_ChiTiet_XoaVe_Click(object sender, EventArgs e)
        {
            if (Ma_Ve_Da_dat == "")
            {
                MessageBox.Show("Vui lòng chọn Vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maNV = NhanVienDAO.Instance.HienThiMaNhanVienTheoTenDangNhap(tendangnhap);
            try
            {
                VeDAO.Instance.xoaVe(Ma_Ve_Da_dat, maNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi xóa vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HienThiThongTinNhanVienDaDatVe();
                txtbox_ChiTiet_MaVeCanXoa.Text = "";
                txtBox_ChiTiet_TenTourXoa.Text = "";
                txtbox_ChiTiet_SoLuongVeHuy.Text = "";
                
            }
        }
    }
}
