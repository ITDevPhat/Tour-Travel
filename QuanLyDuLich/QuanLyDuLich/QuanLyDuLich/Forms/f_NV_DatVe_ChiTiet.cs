using QuanLyDuLich.DAO;
using QuanLyDuLich.DTO.QuanLyDuLich.DTO;
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
    public partial class f_NV_DatVe_ChiTiet : Form
    {
        public string tendangnhap;
        public string ID_Tour_HienTai;
        public int tongSoVe;
        public int giaTour;
        public string path = AppDomain.CurrentDomain.BaseDirectory;
        public CultureInfo culture = new CultureInfo("vi-VN");
        public string maKhachHang = "";

        public int tongtien = 0;
        public f_NV_DatVe_ChiTiet(string tendangnhap1, string idtour)
        {
            InitializeComponent();

            tendangnhap = tendangnhap1;
            ID_Tour_HienTai = idtour;
        }

        private void f_NV_DatVe_ChiTiet_Load(object sender, EventArgs e)
        {
            LayThongTinTour();
            LoadTatCa();

        }

        public void LayThongTinTour()
        {
            List<string> list = new List<string>();

            list = TourDAO.Instance.HienThiThongTinTourTheoID(ID_Tour_HienTai);


            txtBox_ChiTietVe_MaTour.Text = ID_Tour_HienTai.ToString(); //list[0]
            txtBox_ChiTietVe_TenTour.Text = list[1];
            txtBox_ChiTietVe_TongVe.Text = list[2];
            txtBox_ChiTietVe_GiaTien.Text = Convert.ToInt32(list[3]).ToString("c", culture);

            tongSoVe = Convert.ToInt32(list[2]);
            giaTour = (int)Convert.ToInt32(list[3]);


            string hinhanh = Path.Combine(path, list[4]);
            if (File.Exists(hinhanh))
                pic_ChiTiet_HinhAnh.Image = new Bitmap(hinhanh);
            else
                pic_ChiTiet_HinhAnh.Image = new Bitmap(Path.Combine(path, "HinhAnhTour", "temp_image.jpg"));
        }

        public void LoadTatCa()
        {
            //mã vé
            txtbox_ChiTietVe_MaVe.Text = VeDAO.Instance.MaVeMoiNhat();

            //Ngày lập vé
            datetimepicker_NgayLapHD.Value = System.DateTime.Now;

            //Hiển thị tên nhân viên
            txtBox_ChitTietVe_TenNhanVien.Text = HienThiTenNhanVien(tendangnhap);

            //load giá tour
            txtBox_ChitTietVe_GiaTour.Text = giaTour.ToString("c", culture);

            txtBox_ChiTietVe_TongTienTour.Text = giaTour.ToString("c", culture);
        }

        public string HienThiTenNhanVien(string tendangnhap)
        {
            string tenNhanVien = NhanVienDAO.Instance.HienThiTenNhanVien(tendangnhap);
            return tenNhanVien;
        }


        public bool KiemTraThongTinKhachHang()
        {
            bool flag = true; // Mặc định là thông tin hợp lệ

            // Kiểm tra xem các trường thông tin bắt buộc có được điền đầy đủ không
            if (string.IsNullOrEmpty(txtBox_ChiTiet_HoTen.Text) ||
                string.IsNullOrEmpty(txtBox_ChiTietVe_SoDienThoai.Text) ||
                string.IsNullOrEmpty(txtBox_ChiTietVe_DiaChi.Text) ||
                dtp_ChiTietVe_NgaySinh.Value == DateTime.MinValue)
            {
                flag = false;
            }

            // Kiểm tra tính hợp lệ của số điện thoại
            if (!IsPhoneNumberValid(txtBox_ChiTietVe_SoDienThoai.Text))
            {
                flag = false;
                MessageBox.Show("Số điện thoại bắt buộc là các chữ số", "Lỗi nhập thông tin số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kiểm tra tính hợp lệ của ngày sinh
            if (dtp_ChiTietVe_NgaySinh.Value > DateTime.Today)
            {
                flag = false;
            }

            return flag;
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

        private void btn_ChiTietVe_DatVe_Click(object sender, EventArgs e)
        {
            //nếu điền đầy đủ thông tin khách hàng
            if (KiemTraThongTinKhachHang())
            {
                string hoten = txtBox_ChiTiet_HoTen.Text;

                string gioitinh = "Nam";
                if (radiobtn_KH_Nu.Checked)
                {
                    gioitinh = "Nữ";
                }
                DateTime ngaysinh = dtp_ChiTietVe_NgaySinh.Value;
                string sdt = txtBox_ChiTietVe_SoDienThoai.Text;
                string diachi = txtBox_ChiTietVe_DiaChi.Text;

                //Lay id moi nhat
                string id = KhachHangDAO.Instance.MaKhachHangMoiNhat();

                //tao khach hang
                KhachHang kh = new KhachHang(id, hoten, gioitinh, ngaysinh, sdt, diachi);

                KhachHangDAO.Instance.ThemKhachHangMoi(kh);

                maKhachHang = id;

            }
            else    //báo lỗi vui lòng điền đầy đủ thông tin khách hàng
                MessageBox.Show("Vui lòng điền đầy đủ thông tin liên lạc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            try
            {
                //Tạo vé 
                string idVe = VeDAO.Instance.MaVeMoiNhat();
                int soluongVe = Convert.ToInt32(numUD_ChiTietVe_SoVe.Value);
                int tongTien = tongtien;
                string maKH = maKhachHang.ToString();
                string maTour = ID_Tour_HienTai;
                string maNV = NhanVienDAO.Instance.HienThiMaNhanVienTheoTenDangNhap(tendangnhap);


                Ve ve = new Ve(idVe, soluongVe, tongTien, System.DateTime.Now, maKH, maTour, maNV);

                VeDAO.Instance.TaoVe(ve);
                VeDAO.Instance.CapNhatSoLuongTour(maTour, soluongVe);
                MessageBox.Show("Tạo vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (Exception ex)
            {
                KhachHangDAO.Instance.XoaKhachHang(maKhachHang);
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void txtBox_ChiTiet_HoTen_TextChanged(object sender, EventArgs e)
        {
            txtBox_ChiTietVe_TenKH.Text = txtBox_ChiTiet_HoTen.Text.Trim();
        }

        private void numUD_ChiTietVe_SoVe_ValueChanged(object sender, EventArgs e)
        {
            if (numUD_ChiTietVe_SoVe.Value > tongSoVe)
            {
                MessageBox.Show("Vượt quá số lượng vé thực tế trong tour", "Thông báo số vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numUD_ChiTietVe_SoVe.Value = tongSoVe;
            }

            if (numUD_ChiTietVe_SoVe.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập lại số vé. Số vé không thể âm hoặc bằng 0", "Thông báo số vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numUD_ChiTietVe_SoVe.Value = 1;
            }

            int tongTienTour = (int)numUD_ChiTietVe_SoVe.Value * (int)giaTour;

            tongtien = tongTienTour;
            txtBox_ChiTietVe_TongTienTour.Text = tongTienTour.ToString("c", culture);
        }

    }
}
