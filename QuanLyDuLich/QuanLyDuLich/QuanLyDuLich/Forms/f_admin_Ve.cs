using QuanLyDuLich.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class f_admin_Ve : Form
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public f_admin_Ve()
        {
            InitializeComponent();

            LoadDoanhThuVE();
        }
        public void LoadDoanhThuVE()
        {
            dgv_Ve_DoanhThu.DataSource = VeDAO.Instance.HienThiDoanhThuThang(System.DateTime.Now.Month, System.DateTime.Now.Year);

            int tongve = 0;
            long tongtien = 0;

            if (dgv_Ve_DoanhThu.DataSource == null)
            {
                txtbox_VE_TongVe.Text = tongve.ToString();

                txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);
                return;
            }

            foreach (DataGridViewRow row in dgv_Ve_DoanhThu.Rows)
            {
                int soVe = Convert.ToInt32(row.Cells["Số lượng mua"].Value);

                tongve += soVe;

                tongtien += Convert.ToInt64(row.Cells["Tổng tiền vé"].Value);
            }
            txtbox_VE_TongVe.Text = tongve.ToString();

            txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);
        }
        private void dtp_Ve_DoanhThuThang_ValueChanged(object sender, EventArgs e)
        {
            int month = dtp_Ve_DoanhThuThang.Value.Month;
            int year = dtp_Ve_DoanhThuThang.Value.Year;

            dgv_Ve_DoanhThu.DataSource = VeDAO.Instance.HienThiDoanhThuThang(month, year);

            int tongve = 0;
            long tongtien = 0;

            if (dgv_Ve_DoanhThu.DataSource == null)
            {
                txtbox_VE_TongVe.Text = tongve.ToString();

                txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);
                return;
            }

            foreach (DataGridViewRow row in dgv_Ve_DoanhThu.Rows)
            {
                int soVe = Convert.ToInt32(row.Cells["Số lượng mua"].Value);

                tongve += soVe;

                tongtien += Convert.ToInt64(row.Cells["Tổng tiền vé"].Value);
            }
            txtbox_VE_TongVe.Text = tongve.ToString();

            txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);

        }

        private void dtp_Ve_DoanhThuNam_ValueChanged(object sender, EventArgs e)
        {
            int year = dtp_Ve_DoanhThuNam.Value.Year;

            dgv_Ve_DoanhThu.DataSource = VeDAO.Instance.HienThiDoanhThuNam(year);

            int tongve = 0;
            long tongtien = 0;

            if (dgv_Ve_DoanhThu.DataSource == null)
            {
                txtbox_VE_TongVe.Text = tongve.ToString();

                txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);
                return;
            }

            foreach (DataGridViewRow row in dgv_Ve_DoanhThu.Rows)
            {
                int soVe = Convert.ToInt32(row.Cells["Số lượng mua"].Value);

                tongve += soVe;

                tongtien += Convert.ToInt64(row.Cells["Tổng tiền vé"].Value);
            }
            txtbox_VE_TongVe.Text = tongve.ToString();

            txtbox_VE_TongTien.Text = tongtien.ToString("c", culture);
        }

        private void f_admin_Ve_Load(object sender, EventArgs e)
        {
            LoadDoanhThuVE();
        }

        private void dgv_Ve_DoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
