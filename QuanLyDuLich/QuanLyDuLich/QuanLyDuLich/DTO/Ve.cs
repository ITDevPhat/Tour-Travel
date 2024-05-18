using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    public class Ve
    {
        private string id;
        private int soluong;
        private int tongtien;
        private DateTime ngaylap;
        private string maKH;
        private string maTour;
        private string maNV;


        public Ve (string id, int soluong, int tongtien, DateTime ngaylap, string makh, string matour, string maNV)
        {
            this.Id = id;
            this.Ngaylap = ngaylap;
            this.Soluong = soluong;
            this.Tongtien = tongtien;
            this.MaKH = makh;
            this.MaTour = matour;
            this.MaNV = maNV;
        }

        public string Id { get => id; set => id = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaTour { get => maTour; set => maTour = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
