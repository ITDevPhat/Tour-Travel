using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }

        public DichVuDAO() { }


        public DataTable HienThiDanhSachDichVu ()
        {
            string query = "SELECT DV_ID AS N'Mã dịch vụ', DV_TEN AS N'Tên dịch vụ', DV_PhuongTien AS N'Phương tiện' , DV_DiaDiem AS N'Địa điểm', DV_MoTa AS N'Mô tả' FROM [dbo].[DICHVU] ORDER BY CAST(SUBSTRING(DV_ID, 3, LEN(DV_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery (query);
            return data;
        }

        public string MaDVMoiNhat()
        {
            string kq = "DV1";
            string query = "SELECT TOP 1 DV_ID FROM [dbo].[DICHVU] ORDER BY CAST(SUBSTRING(DV_ID, 3, LEN(DV_ID) - 2) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                string dvIdString = data.Rows[0]["DV_ID"].ToString();

                kq = "DV" + (Convert.ToInt32(dvIdString.Substring(2)) + 1).ToString();
            }
            return kq;
        }

        public void ThemDichVuMoi (DichVu dv)
        {
            string query = "EXEC Proc_DV_Them @DV_ID , @DV_Ten , @DV_PhuongTien , @DV_DiaDiem , @DV_MoTa";

            DataProvider.Instance.ExecuteQuery (query, new object[] {dv.IdDV, dv.TenDV, dv.PhuongTienDV, dv.DiaDiemDV, dv.MoTaDV});
        }

        public void SuaDichVU (DichVu dv)
        {
            string query = "EXEC Proc_DV_Sua @DV_ID , @DV_Ten , @DV_PhuongTien , @DV_DiaDiem , @DV_MoTa";
            DataProvider.Instance.ExecuteQuery(query, new object[] { dv.IdDV, dv.TenDV, dv.PhuongTienDV, dv.DiaDiemDV, dv.MoTaDV });
        }

        public void XoaDichVu (String DV_ID)
        {
            DataProvider.Instance.ExecuteQuery("EXEC Proc_DV_Xoa @DV_ID", new object[] {DV_ID});
        }

    }
}
