using QuanLyDuLich.DAO;
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
    public partial class f_NV_datve : Form
    {
        public string tendangnhap = "";
        public string ID_Tour_HienTai = "";
        public int so_ve_HienTai = 0;

        // VE DAT DAT
        public string Ma_Ve_Da_dat;
        //
        public f_NV_datve(string userName)
        {
            InitializeComponent();
            tendangnhap = userName;
        }


        private void dgv_NV_DanhSachTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_NV_DanhSachTour.Rows[rowIndex];


                txtBox_DatVe_TenTour.Text = row.Cells[1].Value.ToString().Trim();

                //CultureInfo culture = new CultureInfo("en-US");
                CultureInfo culture = new CultureInfo("vi-VN");

                decimal donGia;
                if (decimal.TryParse(row.Cells[4].Value.ToString().Trim(), out donGia))
                {
                    txtBox_DatVe_SoTien.Text = donGia.ToString("c", culture);
                }


                ID_Tour_HienTai = row.Cells[0].Value.ToString().Trim();

                so_ve_HienTai = (int)row.Cells[6].Value;
            }
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (ID_Tour_HienTai == "")
            {
                MessageBox.Show("Vui lòng chọn tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (so_ve_HienTai == 0)
            {
                MessageBox.Show("Tour bạn chọn đã hết vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            f_NV_DatVe_ChiTiet f = new f_NV_DatVe_ChiTiet(tendangnhap, ID_Tour_HienTai);

            f.ShowDialog();

            dgv_NV_DanhSachTour.DataSource = TourDAO.Instance.HienThiDanhSachTour();
        }

        private void f_NV_datve_Load(object sender, EventArgs e)
        {
            dgv_NV_DanhSachTour.DataSource = TourDAO.Instance.HienThiDanhSachTour();
        }
    }
}
