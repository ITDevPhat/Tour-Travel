using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    public class TaiKhoan
    {
        private string tendangnhap;
        private string matkhau;
        private int loainguoidung;
        private string maNV;


        public TaiKhoan(string user, string pass, int type, string manv) 
        { 
            this.Tendangnhap = user;
            this.Matkhau = pass;
            this.Loainguoidung = type;
            this.MaNV = manv;
        }

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Loainguoidung { get => loainguoidung; set => loainguoidung = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
