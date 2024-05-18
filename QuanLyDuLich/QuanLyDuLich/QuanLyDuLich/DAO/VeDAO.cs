using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class VeDAO
    {
        private static VeDAO instance;

        public static VeDAO Instance
        {
            get { if (instance == null) instance = new VeDAO(); return instance; }
            private set { instance = value; }
        }

        public VeDAO() { }








        

        public string MaVeMoiNhat()
        {
            string kq = "VE1";
            string query = "SELECT TOP 1 VE_ID FROM VE ORDER BY CAST(SUBSTRING(VE_ID, 3, LEN(VE_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string veIdString = data.Rows[0]["VE_ID"].ToString();
                kq = "VE" + (Convert.ToInt32(veIdString.Substring(2)) + 1).ToString();
            }
            return kq;
        }





        public void TaoVe(DTO.Ve ve)
        {
            string query = "EXEC Proc_TaoVe @id , @soLuongMua , @tongTien , @ngayLap , @khachHangId , @tourId , @nhanVienId";

            DataProvider.Instance.ExecuteQuery(query, new object[] { ve.Id, ve.Soluong, ve.Tongtien, ve.Ngaylap, ve.MaKH, ve.MaTour, ve.MaNV });
        }

        public void CapNhatSoLuongTour (string matour, int soluong)
        {
            string query = "EXEC Proc_CapNhatSoLuongTour @matour , @soluong";
            DataProvider.Instance.ExecuteQuery(query, new object[] { matour, soluong});
        }


        public DataTable HienThiVeTheoIDNhanVien (string idNV)
        {
            string query = "select v.VE_ID AS N'Mã vé', TOUR_Ten AS N'Tên tour' ,v.VE_SoLuongMua AS N'Số lượng vé', v.VE_TongTien AS N'Tổng tiền', v.VE_NgayLap AS N'Ngày lập', kh.KH_HoTen AS N'Họ tên khách hàng',  kh.KH_SoDienThoai AS N'Số điện thoại khách hàng', kh.KH_DiaChi AS N'Địa chỉ khách hàng' from ve v, NHANVIEN nv, KHACHHANG kh, TOUR tour Where v.NV_ID = nv.NV_ID  AND v.KH_ID = kh.KH_ID AND v.TOUR_ID = tour.TOUR_ID AND v.NV_ID = @idnhanvien ORDER BY CAST(SUBSTRING(VE_ID, 3, LEN(VE_ID) - 2) AS INT) DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {idNV});

            return dt;
        }

        public void xoaVe(string maVe, string maNV)
        {
            string maKH = "";
            string maTour = "";
            int soluonghuy = 0;

            string query1 = "select KH_ID, TOUR_ID, VE_SoLuongMua from ve where VE_ID = @mave";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1, new object[] {maVe});

            if (data.Rows.Count > 0)
            {
                maKH = data.Rows[0]["KH_ID"].ToString();   
                maTour = data.Rows[0]["TOUR_ID"].ToString();
                soluonghuy = Convert.ToInt32(data.Rows[0]["VE_SoLuongMua"]);
            }

            if (maKH == "" || maTour == "" || maVe == "" || maNV == "")
            {
                MessageBox.Show("Không thể xóa vé này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query2 = "EXEC PROC_XoaVE @idVe , @idNV , @idTour , @idKH , @soluongtra";
            DataProvider.Instance.ExecuteQuery(query2, new object[] {maVe, maNV, maTour, maKH, soluonghuy});

            MessageBox.Show("Xóa vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public DataTable HienThiDoanhThuThang(int thang, int nam)
        {
            string query = "select VE_ID AS N'Mã vé' , VE_SoLuongMua AS N'Số lượng mua' , VE_TongTien AS N'Tổng tiền vé' , VE_NgayLap AS N'Ngày lập vé' , TOUR_Ten AS N'Tên tour' , TOUR_DonGia AS N'Đơn giá tour' , TOUR_TongSoVeTour AS N'Tổng vé còn lại' , NV_Ten AS N'Tên nhân viên' from VE v, Tour t, NHANVIEN nv where v.TOUR_ID = t.TOUR_ID and v.NV_ID = nv.NV_ID AND MONTH(Ve_NgayLap) = @thang  AND YEAR(VE_NgayLap) = @nam";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { thang, nam});

            return data;
        }

        public DataTable HienThiDoanhThuNam(int nam)
        {
            string query = "select VE_ID AS N'Mã vé' , VE_SoLuongMua AS N'Số lượng mua' , VE_TongTien AS N'Tổng tiền vé' , VE_NgayLap AS N'Ngày lập vé' , TOUR_Ten AS N'Tên tour' , TOUR_DonGia AS N'Đơn giá tour' , TOUR_TongSoVeTour AS N'Tổng vé còn lại' , NV_Ten AS N'Tên nhân viên' from VE v, Tour t, NHANVIEN nv where v.TOUR_ID = t.TOUR_ID and v.NV_ID = nv.NV_ID AND YEAR(VE_NgayLap) = @nam";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {nam });

            return data;
        }

    }
}
