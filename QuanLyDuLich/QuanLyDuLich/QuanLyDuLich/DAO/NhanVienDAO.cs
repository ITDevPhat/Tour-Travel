using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public NhanVienDAO() { }


        public DataTable HienThiDanhSachNhanVien()
        {
            string query = "SELECT [NV_ID] AS N'Mã nhân viên', [NV_Ten] AS N'Họ và tên', [NV_GioiTinh] AS N'Giới tính', [NV_NgaySinh] AS N'Ngày sinh', [NV_SoDienThoai] AS N'Số điện thoại', [NV_DiaChi] AS N'Địa chỉ' FROM NHANVIEN ORDER BY CAST(SUBSTRING(NV_ID, 3, LEN(NV_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string MaNhanVienMoiNhat()
        {
            string kq = "NV1";
            string query = "SELECT TOP 1 NV_ID FROM [dbo].[NHANVIEN] ORDER BY CAST(SUBSTRING(NV_ID, 3, LEN(NV_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string NVIdString = data.Rows[0]["NV_ID"].ToString();

                kq = "NV" + (Convert.ToInt32(NVIdString.Substring(2)) + 1).ToString();
            }
            return kq;
        }

        public void ThemNhanVienMoi(NhanVien nv)
        {
            string query = "EXEC Proc_NV_Them @id , @ten , @gioitinh , @NgaySinh , @sdt , @diachi";

            DataProvider.Instance.ExecuteQuery(query, new object[] { nv.Id, nv.Ten, nv.Gioitinh, nv.Ngaysinh, nv.Sodienthoai, nv.Diachi });
        }

        public void SuaNhanVien(NhanVien nv)
        {
            string query = "EXEC Proc_NV_Sua @id , @ten , @gioitinh , @NgaySinh , @sdt , @diachi";
            DataProvider.Instance.ExecuteQuery(query, new object[] { nv.Id, nv.Ten, nv.Gioitinh, nv.Ngaysinh, nv.Sodienthoai, nv.Diachi });
        }

        public void XoaNhanVien(string NV_ID)
        {
            if (NV_ID == "NV1")
            {
                MessageBox.Show("Đây là người dùng quản trị cao nhất của hệ thống, không thể xóa", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra có phải là người quản trị không
            string queryKiemTra = "SELECT nv.NV_ID FROM TAIKHOAN tk JOIN NHANVIEN nv ON tk.NV_ID = nv.NV_ID AND TK_LOAI = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryKiemTra);

            int flag = 0;
            // Kiểm tra bằng foreach
            foreach (DataRow row in dt.Rows)
            {
                string nvId = row["NV_ID"].ToString();
                // So sánh NV_ID nhập vào với giá trị trong cột NV_ID của từng dòng
                if (NV_ID == nvId)
                {
                    flag = 1;
                    break; // Thoát vòng lặp ngay sau khi tìm thấy NV_ID của người quản trị
                }
            }

            if (flag == 1)
            {
                // Hiển thị hộp thoại xác nhận từ người dùng
                DialogResult result = MessageBox.Show("Đây là người dùng quản trị, bạn có chắc muốn xóa chứ?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // Kiểm tra xem người dùng đã xác nhận xóa hay không
                if (result == DialogResult.Cancel)
                {
                    return; // Nếu người dùng chọn hủy bỏ, thoát khỏi phương thức mà không thực hiện xóa
                }
            }



            // Thực hiện xóa nhân viên sau khi đã xác nhận hoặc không phải là người quản trị
            string query = "EXEC Proc_NV_Xoa @id";
            DataProvider.Instance.ExecuteQuery(query, new object[] { NV_ID });
        }


        public string HienThiTenNhanVien(string tendangnhap)
        {
            string tenNhanVien = "";

            // Query để lấy tên nhân viên từ bảng TAIKHOAN và NhanVien
            string query = "SELECT nv.NV_Ten " +
                           "FROM TAIKHOAN tk " +
                           "JOIN NhanVien nv ON tk.NV_ID = nv.NV_ID " +
                           "WHERE tk.TK_TenDangNhap = @tendangnhap";

            // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap });

            // Kiểm tra xem DataTable có hàng không
            if (dt.Rows.Count > 0)
            {
                // Lấy tên nhân viên từ hàng đầu tiên của DataTable
                tenNhanVien = dt.Rows[0]["NV_Ten"].ToString();
            }

            // Trả về tên của nhân viên
            return tenNhanVien;
        }

        public string HienThiMaNhanVienTheoTenDangNhap (string tendangnhap)
        {
            string maNhanVien = "";

            // Query để lấy tên nhân viên từ bảng TAIKHOAN và NhanVien
            string query = "select NV_ID from taikhoan where TK_TenDangNhap = @tendangnhap";

            // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap });

            // Kiểm tra xem DataTable có hàng không
            if (dt.Rows.Count > 0)
            {
                // Lấy tên nhân viên từ hàng đầu tiên của DataTable
                maNhanVien = dt.Rows[0]["NV_ID"].ToString();
            }

            // Trả về tên của nhân viên
            return maNhanVien;
        }
    }
}
