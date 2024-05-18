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

namespace QuanLyDuLich
{
    public partial class f_admin_tour : Form
    {
        public string Tour_Ma_HienTai = "";
        public f_admin_tour()
        {
            InitializeComponent();
        }

        private void f_admin_tour_Load(object sender, EventArgs e)
        {
            LoadDanhSachTour();
            LoadLaiTatCaTour();
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

        private void btn_Tour_Them_Click(object sender, EventArgs e)
        {
            bool flag = true; // Mặc định là thông tin hợp lệ




            if (txtBox_TenTour.Text == "" || numUpDown_SoNgay.Value <= 0 || txtBox_NoiKhoiHanh.Text == "" || txtBox_donGiaTour.Text == "" || numUpDown_TongSoVe.Value <= 0)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Tour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!IsPhoneNumberValid(txtBox_donGiaTour.Text))
            {
                flag = false;
                MessageBox.Show("Bắt buộc là các chữ số", "Lỗi đơn giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string idTour = txtBox_MaTour.Text;
            string tenTour = txtBox_TenTour.Text;
            DateTime ngayKhoiHanh = dtp_NgayKhoiHanh.Value;

            if (ngayKhoiHanh <=  DateTime.Now)
            {
                flag = false;
                MessageBox.Show("Ngày khởi hành phải lớn hơn ngày hiện tại", "Lỗi ngày khởi hành", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int soNgay = (int)numUpDown_SoNgay.Value;
            float donGia = (float)Convert.ToDouble(txtBox_donGiaTour.Text);
            int tongVe = (int)numUpDown_TongSoVe.Value;


            if (soNgay <= 0 || tongVe <= 0)
            {
                flag = false;
                MessageBox.Show("Vui lòng chọn số dương", "Lỗi chữ số ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string noiKhoiHanh = txtBox_NoiKhoiHanh.Text;

            Tour tour = new Tour(idTour, tenTour, ngayKhoiHanh, soNgay, donGia, tongVe, noiKhoiHanh);
            try
            {
                TourDAO.Instance.ThemTourMoi(tour);
                MessageBox.Show("Thêm Tour thành công", "Thêm Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaTour();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã đã tồn tại", "Thêm Tour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadDanhSachTour();
            return;
        }
        public void LoadDanhSachTour()
        {
            dgv_DanhSachTour.DataSource = TourDAO.Instance.HienThiDanhSachTour();
        }
        private void btn_Tour_Sua_Click(object sender, EventArgs e)
        {
            bool flag = true; // Mặc định là thông tin hợp lệ
            if (txtBox_TenTour.Text == "" || numUpDown_SoNgay.Value <= 0 || txtBox_NoiKhoiHanh.Text == "" || txtBox_donGiaTour.Text == "" || numUpDown_TongSoVe.Value <= 0)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Sửa Tour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            string idTour = Tour_Ma_HienTai;
            //

            string tenTour = txtBox_TenTour.Text;
            DateTime ngayKhoiHanh = dtp_NgayKhoiHanh.Value;
            int soNgay = (int)numUpDown_SoNgay.Value;
            float donGia = (float)Convert.ToDouble(txtBox_donGiaTour.Text);
            int tongVe = (int)numUpDown_TongSoVe.Value;
            string noiKhoiHanh = txtBox_NoiKhoiHanh.Text;

            Tour tour = new Tour(idTour, tenTour, ngayKhoiHanh, soNgay, donGia, tongVe, noiKhoiHanh);


            if (!IsPhoneNumberValid(txtBox_donGiaTour.Text))
            {
                flag = false;
                MessageBox.Show("Bắt buộc là các chữ số", "Lỗi đơn giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ngayKhoiHanh <= DateTime.Now)
            {
                flag = false;
                MessageBox.Show("Ngày khởi hành phải lớn hơn ngày hiện tại", "Lỗi ngày khởi hành", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TourDAO.Instance.SuaTour(tour);
                MessageBox.Show("Sửa Tour thành công", "Sửa Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLaiTatCaTour();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Sửa Tour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadDanhSachTour();
            return;
        }

        private void btn_Tour_Xoa_Click(object sender, EventArgs e)
        {
            btn_Tour_Them.Enabled = false;
            if (dgv_DanhSachTour.RowCount <= 1)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Xóa Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                TourDAO.Instance.XoaTatCaHinhAnhTour(Tour_Ma_HienTai);
                pic_HinhAnh_1.Tag = null;
                pic_HinhAnh_1.Image = null;
                pic_HinhAnh_2.Tag = null;
                pic_HinhAnh_2.Image = null;
                pic_HinhAnh_3.Tag = null;
                pic_HinhAnh_3.Image = null;
                pic_HinhAnh_4.Tag = null;
                pic_HinhAnh_4.Image = null;
                //chạy được 
                GC.Collect();

                txtBox_HienThiTenVe.Text = null;
                txtBox_HienThiTienVe.Text = null;

                TourDAO.Instance.XoaTour(Tour_Ma_HienTai);
                MessageBox.Show("Xóa Tour thành công", "Xóa Tour", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Xóa Tour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadLaiTatCaTour();
            return;
        }

        private void btn_Tour_LamMoi_Click(object sender, EventArgs e)
        {
            LoadLaiTatCaTour();
        }

        void LoadLaiTatCaTour()
        {
            btn_Tour_Them.Enabled = true;
            txtBox_MaTour.Text = TourDAO.Instance.MaTourMoiNhat();
            txtBox_TenTour.Text = "";
            dtp_NgayKhoiHanh.Value = System.DateTime.Now;
            numUpDown_SoNgay.Value = 1;
            txtBox_NoiKhoiHanh.Text = "";
            txtBox_donGiaTour.Text = "";
            numUpDown_TongSoVe.Value = 1;
            LoadDanhSachTour();


            pic_HinhAnh_1.Image = null;
            pic_HinhAnh_2.Image = null;
            pic_HinhAnh_3.Image = null;
            pic_HinhAnh_4.Image = null;
            GC.Collect();
        }

        private void dgv_DanhSachTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            btn_Tour_Them.Enabled = false;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachTour.Rows[rowIndex];

                txtBox_MaTour.Text = row.Cells[0].Value.ToString().Trim();
                txtBox_TenTour.Text = row.Cells[1].Value.ToString().Trim();

                string dateString = row.Cells[2].Value.ToString();

                DateTime ngayKhoiHanh;
                if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKhoiHanh))
                {
                    dtp_NgayKhoiHanh.Value = ngayKhoiHanh;
                }


                numUpDown_SoNgay.Value = Convert.ToInt32(row.Cells[3].Value);

                txtBox_donGiaTour.Text = row.Cells[4].Value.ToString().Trim();
                txtBox_NoiKhoiHanh.Text = row.Cells[5].Value.ToString().Trim();


                numUpDown_TongSoVe.Value = Convert.ToInt32(row.Cells[6].Value);

                //Cập nhật mã địa điểm hiện tại
                Tour_Ma_HienTai = row.Cells[0].Value.ToString().Trim();
                txtBox_HienThiTenVe.Text = row.Cells[1].Value.ToString().Trim();


                //CultureInfo culture = new CultureInfo("en-US");
                CultureInfo culture = new CultureInfo("vi-VN");

                decimal donGia;
                if (decimal.TryParse(row.Cells[4].Value.ToString().Trim(), out donGia))
                {
                    txtBox_HienThiTienVe.Text = donGia.ToString("c", culture);
                }

                string duongdan1 = TourDAO.Instance.LoadHinhAnhByIDTour_STT(Tour_Ma_HienTai, 1);
                if (duongdan1 == null)
                {
                    pic_HinhAnh_1.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                    GC.Collect();
                }
                else
                {
                    string fullPath1 = Path.Combine(path, duongdan1);
                    if (File.Exists(fullPath1))
                    {
                        pic_HinhAnh_1.Image = new Bitmap(fullPath1);
                    }
                    else
                    {
                        pic_HinhAnh_1.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                        GC.Collect();
                    }
                }

                string duongdan2 = TourDAO.Instance.LoadHinhAnhByIDTour_STT(Tour_Ma_HienTai, 2);
                if (duongdan2 == null)
                {
                    pic_HinhAnh_2.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                    GC.Collect();
                }
                else
                {
                    string fullPath2 = Path.Combine(path, duongdan2);
                    if (File.Exists(fullPath2))
                    {
                        pic_HinhAnh_2.Image = new Bitmap(fullPath2);
                    }
                    else
                    {
                        pic_HinhAnh_2.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                        GC.Collect();
                    }
                }

                string duongdan3 = TourDAO.Instance.LoadHinhAnhByIDTour_STT(Tour_Ma_HienTai, 3);
                if (duongdan3 == null)
                {
                    pic_HinhAnh_3.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                    GC.Collect();
                }
                else
                {
                    string fullPath3 = Path.Combine(path, duongdan3);
                    if (File.Exists(fullPath3))
                    {
                        pic_HinhAnh_3.Image = new Bitmap(fullPath3);
                    }
                    else
                    {
                        pic_HinhAnh_3.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                        GC.Collect();
                    }
                }

                string duongdan4 = TourDAO.Instance.LoadHinhAnhByIDTour_STT(Tour_Ma_HienTai, 4);
                if (duongdan4 == null)
                {
                    pic_HinhAnh_4.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                    GC.Collect();
                }
                else
                {
                    string fullPath4 = Path.Combine(path, duongdan4);
                    if (File.Exists(fullPath4))
                    {
                        pic_HinhAnh_4.Image = new Bitmap(fullPath4);
                    }
                    else
                    {
                        pic_HinhAnh_4.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
                        GC.Collect();
                    }
                }
            }
        }

        public void LoadHinhAnh(string maTour, int STT, PictureBox pic)
        {
            string duongdan = TourDAO.Instance.LoadHinhAnhByIDTour_STT(maTour, STT);
            if (duongdan == null)
            {
                duongdan = Path.Combine("HinhAnhTour", "temp_image.jpg");
                MessageBox.Show("Lỗi không thể thêm hình ảnh vì không cung cấp đường dẫn", "Lỗi thêm hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string path = AppDomain.CurrentDomain.BaseDirectory;
            //Đã có hình ảnh
            if (pic.Image == null)
            {
                pic.Image = new Bitmap(Path.Combine(path, duongdan));
                return;
            }

            if (pic.Image != null)
            {
                pic.Image.Dispose();
                pic.Image = null;
            }
            if (pic.Tag != null)
            {
                System.IO.File.Delete((string)pic.Tag);
                pic.Tag = null;
            }


            if (pic.Image != null)
            {
                pic.Image = new Bitmap(Path.Combine(path, duongdan));
            }

        }

        private void btn_Tour_HinhAnh_1_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng hình ảnh dịch vụ
            //chỉnh sửa lại 

            pic_HinhAnh_1.Tag = null;
            pic_HinhAnh_1.Image = null;
            //chạy được 
            GC.Collect();

            TourDAO.Instance.ThemHinhAnhTour(Tour_Ma_HienTai, 1);

            LoadHinhAnh(Tour_Ma_HienTai, 1, pic_HinhAnh_1);

            return;
        }

        private void btn_Tour_HinhAnh_2_Click(object sender, EventArgs e)
        {
            pic_HinhAnh_2.Tag = null;
            pic_HinhAnh_2.Image = null;
            //chạy được 
            GC.Collect();

            TourDAO.Instance.ThemHinhAnhTour(Tour_Ma_HienTai, 2);

            LoadHinhAnh(Tour_Ma_HienTai, 2, pic_HinhAnh_2);

            return;
        }

        private void btn_Tour_HinhAnh_3_Click(object sender, EventArgs e)
        {
            pic_HinhAnh_3.Tag = null;
            pic_HinhAnh_3.Image = null;
            //chạy được 
            GC.Collect();

            TourDAO.Instance.ThemHinhAnhTour(Tour_Ma_HienTai, 3);

            LoadHinhAnh(Tour_Ma_HienTai, 3, pic_HinhAnh_3);

            return;
        }

        private void btn_Tour_HinhAnh_4_Click(object sender, EventArgs e)
        {
            pic_HinhAnh_4.Tag = null;
            pic_HinhAnh_4.Image = null;
            //chạy được 
            GC.Collect();

            TourDAO.Instance.ThemHinhAnhTour(Tour_Ma_HienTai, 4);

            LoadHinhAnh(Tour_Ma_HienTai, 4, pic_HinhAnh_4);

            return;
        }

        private void btn_Tour_TimKiem_Click(object sender, EventArgs e)
        {
            string findText = txtBox_TenTour.Text;

            dgv_DanhSachTour.DataSource = TourDAO.Instance.HienThiDanhSachTour(findText);
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
}
