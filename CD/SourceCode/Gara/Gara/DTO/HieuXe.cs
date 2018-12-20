using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class HieuXe
    {
        public HieuXe(int m,string t,string q)
        {
            this.MaHieuXe = m;
            this.TenHieuXe = t;
            this.QuocGia = q;
        }

        public HieuXe(DataRow row)
        {
            this.MaHieuXe = (int)row["MaHieuXe"];
            this.TenHieuXe = row["TenHieuXe"].ToString();
            this.QuocGia = row["QuocGia"].ToString();
        }

        

        private string quocGia;


        private string tenHieuXe;


        private int maHieuXe;

        public string QuocGia
        {
            get
            {
                return quocGia;
            }

            set
            {
                quocGia = value;
            }
        }

        public string TenHieuXe
        {
            get
            {
                return tenHieuXe;
            }

            set
            {
                tenHieuXe = value;
            }
        }

        public int MaHieuXe
        {
            get
            {
                return maHieuXe;
            }

            set
            {
                maHieuXe = value;
            }
        }
    }
}
