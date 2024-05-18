using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class ChiTietDAO
    {
        private static ChiTietDAO instance;

        public static ChiTietDAO Instance
        {
            get { if (instance == null) instance = new ChiTietDAO(); return instance; }
            private set { instance = value; }
        }

        public ChiTietDAO() { }


        public void ThemChiTietTour (string idTour, string idDichVu)
        {
            string query = "EXEC Proc_ThemChiTietTour @idTour , @idDichVu";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idTour, idDichVu });
        }
        public void XoaChiTietTour(string idTour, string idDichVu)
        {
            string query = "EXEC Proc_XoaChiTietTour @idTour , @idDichVu";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idTour, idDichVu });
        }



        public DataTable HienThiDanhSachChiTiet ()
        {
            string query = "select TOUR_ID AS N'Mã tour', DV_ID AS N'Mã dịch vụ' from CHITIETTOUR ORDER BY TOUR_ID DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;  
        }
    }
}
