using QuanLyDuLich.DTO.QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        public KhachHangDAO() { }

        public DataTable HienThiDanhSachKhachHang()
        {
            string query = "SELECT [KH_ID] AS N'Mã khách hàng', [KH_HoTen] AS N'Họ và tên', [KH_GioiTinh] AS N'Giới tính', [KH_NgaySinh] AS N'Ngày sinh', [KH_SoDienThoai] AS N'Số điện thoại', [KH_DiaChi] AS N'Địa chỉ' FROM KHACHHANG ORDER BY CAST(SUBSTRING(KH_ID, 3, LEN(KH_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string MaKhachHangMoiNhat()
        {
            string kq = "KH1";
            string query = "SELECT TOP 1 KH_ID FROM KHACHHANG ORDER BY CAST(SUBSTRING(KH_ID, 3, LEN(KH_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string khIdString = data.Rows[0]["KH_ID"].ToString();
                kq = "KH" + (Convert.ToInt32(khIdString.Substring(2)) + 1).ToString();
            }
            return kq;
        }

        public void ThemKhachHangMoi(KhachHang kh)
        {
            string query = "EXEC Proc_KH_Them @id , @ten , @gioitinh , @NgaySinh , @sdt , @diachi";
            DataProvider.Instance.ExecuteQuery(query, new object[] { kh.Id, kh.HoTen, kh.GioiTinh, kh.NgaySinh, kh.SoDienThoai, kh.DiaChi });
        }

        public void SuaKhachHang(KhachHang kh)
        {
            string query = "EXEC Proc_KH_Sua @id , @ten , @gioitinh , @NgaySinh , @sdt , @diachi";
            DataProvider.Instance.ExecuteQuery(query, new object[] { kh.Id, kh.HoTen, kh.GioiTinh, kh.NgaySinh, kh.SoDienThoai, kh.DiaChi });
        }

        public void XoaKhachHang(string KH_ID)
        {
            string query = "EXEC Proc_KH_Xoa @id";
            DataProvider.Instance.ExecuteQuery(query, new object[] { KH_ID });
        }

    }
}
