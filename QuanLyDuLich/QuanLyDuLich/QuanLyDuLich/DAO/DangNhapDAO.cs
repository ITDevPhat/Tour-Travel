using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;

        public static DangNhapDAO Instance
        {
            get { if (instance == null) { instance = new DangNhapDAO(); } return instance; }
            private set { DangNhapDAO.instance = value; }
        }
        public DangNhapDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "EXEC Proc_DangNhap @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        public bool isAdmin(string userName)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE TK_Loai = 1 AND TK_TenDangNhap = @userName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return result.Rows.Count > 0;
        }


    }
}
