using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class HIEUXE
    {
        public HIEUXE(int m, string t, string q)
        {
            this.MaHieuXe = m;
            this.TenHieuXe = t;
            this.QuocGia = q;
        }

        public HIEUXE(DataRow row)
        {
            this.MaHieuXe = (int)row["MaHieuXe"];
            this.TenHieuXe = row["TenHieuXe"].ToString();
            this.QuocGia = row["QuocGia"].ToString();
        }



        private string quocGia;


        private string tenHieuXe;


        private int maHieuXe;

        public int MaHieuXe { get => maHieuXe; set => maHieuXe = value; }
        public string TenHieuXe { get => tenHieuXe; set => tenHieuXe = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
    }
}
