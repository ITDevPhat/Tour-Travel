using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        public TaiKhoanDAO() { }


        public DataTable HienThiDanhSachTaiKhoan()
        {
            string query = "SELECT TK_TenDangNhap AS N'Tên đăng nhập', CONCAT('', REPLICATE('*', LEN(TK_MatKhau))) AS N'Mật khẩu', CASE WHEN TK_Loai = 1 THEN N'Người quản trị' ELSE N'Nhân viên' END AS N'Loại', NV_Ten AS N'Tên nhân viên' FROM TAIKHOAN tk JOIN NHANVIEN nv ON tk.NV_ID = nv.NV_ID ORDER BY N'Loại' DESC;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable LayThongTinTuTenDangNhap(string tendangnhap)
        {
            string query = "select * from taikhoan where TK_TenDangNhap = @ten";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap });   

            return data;
        }

        public void ThemTaiKhoanMoi(TaiKhoan tk)
        {
            string query = "EXEC Proc_ThemTaiKhoan @TK_TenDangNhap , @TK_MatKhau , @TK_Loai , @NV_ID";

            DataProvider.Instance.ExecuteQuery(query, new object[] { tk.Tendangnhap, tk.Matkhau, tk.Loainguoidung, tk.MaNV});
        }

        public void SuaTaiKhoan(TaiKhoan tk, string tendangnhaphientai)
        {
            string query = "EXEC Proc_SuaTaiKhoan @TK_TenDangNhapCu , @TK_TenDangNhapMoi , @TK_MatKhau , @TK_Loai , @NV_ID ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhaphientai, tk.Tendangnhap, tk.Matkhau, tk.Loainguoidung, tk.MaNV });
        }
        
        public void XoaTaiKhoan(string tendangnhap, string idNhanVien)
        {
            string query = "EXEC Proc_XoaTaiKhoan @TK_TenDangNhap , @NV_ID";
            DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap, idNhanVien });
        }
    }
}
