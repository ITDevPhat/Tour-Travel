using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    public class Tour
    {
        private string idTour;
        private string tenTour;
        private DateTime ngayKhoiHanh;
        private int soNgay;
        private float donGia;
        private int tongVe;
        private string noiKhoiHanh;


        public Tour(string id, string ten, DateTime ngayKH, int soNgay, float donGia, int tongVe, string noiKH)
        {
            this.IdTour = id;
            this.TenTour = ten;
            this.NgayKhoiHanh = ngayKH;
            this.SoNgay = soNgay;
            this.DonGia = donGia;
            this.TongVe = tongVe;
            this.NoiKhoiHanh= noiKH;
        }

        public string IdTour { get => idTour; set => idTour = value; }
        public string TenTour { get => tenTour; set => tenTour = value; }
        public DateTime NgayKhoiHanh { get => ngayKhoiHanh; set => ngayKhoiHanh = value; }
        public int SoNgay { get => soNgay; set => soNgay = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int TongVe { get => tongVe; set => tongVe = value; }
        public string NoiKhoiHanh { get => noiKhoiHanh; set => noiKhoiHanh = value; }
    }
}
