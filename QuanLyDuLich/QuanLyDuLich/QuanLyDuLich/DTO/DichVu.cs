using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.DTO
{
    public class DichVu
    {
        private string idDV;
        private string tenDV;
        private string phuongTienDV;
        private string diaDiemDV;
        private string moTaDV;

        public DichVu(string idDV, string tenDV, string phuongTienDV, string diaDiemDV, string moTaDV) 
        {
            this.IdDV = idDV;
            this.TenDV = tenDV;
            this.PhuongTienDV = phuongTienDV;
            this.DiaDiemDV = diaDiemDV;
            this.MoTaDV = moTaDV;
        }


        public string IdDV { get => idDV; set => idDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string PhuongTienDV { get => phuongTienDV; set => phuongTienDV = value; }
        public string DiaDiemDV { get => diaDiemDV; set => diaDiemDV = value; }
        public string MoTaDV { get => moTaDV; set => moTaDV = value; }
    }
}
