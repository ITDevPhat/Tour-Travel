using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    using System;

    namespace QuanLyDuLich.DTO
    {
        public class KhachHang
        {
            private string id;
            private string hoTen;
            private string gioiTinh;
            private DateTime ngaySinh;
            private string soDienThoai;
            private string diaChi;

            public KhachHang(string id, string hoTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string diaChi)
            {
                this.Id = id;
                this.HoTen = hoTen;
                this.GioiTinh = gioiTinh;
                this.NgaySinh = ngaySinh;
                this.SoDienThoai = soDienThoai;
                this.DiaChi = diaChi;
            }

            public string Id { get => id; set => id = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
            public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
            public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
            public string DiaChi { get => diaChi; set => diaChi = value; }
        }
    }

}
