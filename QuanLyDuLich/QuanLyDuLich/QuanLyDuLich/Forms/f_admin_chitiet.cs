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

namespace QuanLyDuLich.Forms
{
    public partial class f_admin_chitiet : Form
    {
        
        public f_admin_chitiet()
        {
            InitializeComponent();
        }

        private void f_admin_chitiet_Load(object sender, EventArgs e)
        {
            LoadChiTiet();
        }
        public void LoadChiTiet()
        {
            dgv_ChiTiet_DanhSachTour.DataSource = TourDAO.Instance.HienThiDanhSachTour();

            // Ẩn các cột có chỉ số 2, 3, 4, 5, 6 trong DataGridView
            dgv_ChiTiet_DanhSachTour.Columns[2].Visible = false;
            dgv_ChiTiet_DanhSachTour.Columns[3].Visible = false;
            dgv_ChiTiet_DanhSachTour.Columns[4].Visible = false;
            dgv_ChiTiet_DanhSachTour.Columns[5].Visible = false;
            dgv_ChiTiet_DanhSachTour.Columns[6].Visible = false;


            dgv_ChiTiet_DanhSachDichVu.DataSource = DichVuDAO.Instance.HienThiDanhSachDichVu();
            dgv_ChiTiet_DanhSachDichVu.Columns[2].Visible = false;
            dgv_ChiTiet_DanhSachDichVu.Columns[3].Visible = false;
            dgv_ChiTiet_DanhSachDichVu.Columns[4].Visible = false;

            dgv_ChiTiet_DanhSachChiTiet.DataSource = ChiTietDAO.Instance.HienThiDanhSachChiTiet();
        }
        public string ChiTiet_MaTour;
        public string ChiTiet_MaDichVu;
        private void dgv_ChiTiet_DanhSachTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChiTiet_DanhSachTour.Rows[rowIndex];
                ChiTiet_MaTour = row.Cells[0].Value.ToString();
            }
        }

        private void dgv_ChiTiet_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChiTiet_DanhSachDichVu.Rows[rowIndex];
                ChiTiet_MaDichVu = row.Cells[0].Value.ToString();
            }
        }

        public string ChiTiet_Xoa_idTour = "";
        public string ChiTiet_Xoa_idDichvu = "";

        private void dgv_ChiTiet_DanhSachChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_ChiTiet_DanhSachChiTiet.Rows[rowIndex];
                ChiTiet_Xoa_idTour = row.Cells[0].Value.ToString();
                ChiTiet_Xoa_idDichvu = row.Cells[1].Value.ToString();
            }
        }

        private void btn_ChiTiet_ThemDichVuVaoChiTiet_Click(object sender, EventArgs e)
        {
            if (ChiTiet_MaTour == null)
            {
                MessageBox.Show("Vui lòng chọn tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ChiTiet_MaDichVu == null)
            {
                MessageBox.Show("Vui lòng chọn Dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                ChiTietDAO.Instance.ThemChiTietTour(ChiTiet_MaTour, ChiTiet_MaDichVu);


                MessageBox.Show("Thêm chi tiết thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ChiTiet_MaDichVu = "";
            }

            dgv_ChiTiet_DanhSachChiTiet.DataSource = ChiTietDAO.Instance.HienThiDanhSachChiTiet();
        }

        private void btn_ChiTiet_XoaDichVuTrongChiTiet_Click(object sender, EventArgs e)
        {
            if (ChiTiet_Xoa_idTour == null || ChiTiet_Xoa_idDichvu == null)
            {
                MessageBox.Show("Vui lòng chọn dòng trong Chi Tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                ChiTietDAO.Instance.XoaChiTietTour(ChiTiet_Xoa_idTour, ChiTiet_Xoa_idDichvu);


                MessageBox.Show("Xoá chi tiết thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ChiTiet_Xoa_idTour = "";
                ChiTiet_Xoa_idDichvu = "";
            }

            dgv_ChiTiet_DanhSachChiTiet.DataSource = ChiTietDAO.Instance.HienThiDanhSachChiTiet();
        }
    }
}
