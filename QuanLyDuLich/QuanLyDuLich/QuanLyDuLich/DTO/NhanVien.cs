using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    public class NhanVien
    {
        private string id;
        private string ten;
        private string gioitinh;
        private DateTime ngaysinh;
        private string sodienthoai;
        private string diachi;

        public NhanVien(string id, string ten, string gioitinh, DateTime ngaysinh, string sodienthoai, string diachi)
        {
            this.Id = id;
            this.Ten = ten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Sodienthoai = sodienthoai;
            this.Diachi = diachi;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
