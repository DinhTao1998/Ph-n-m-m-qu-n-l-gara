using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class ChucVu
    {
        public ChucVu(int m,string t,int ma)
        {
            this.MaChucVu = m;
            this.TenChucVu = t;
            this.MaManHinhChinh = ma;
        }

        public ChucVu(DataRow row)
        {
            this.MaChucVu = (int)row["MaChucVu"];
            this.TenChucVu = row["TenChucVu"].ToString();
            this.MaManHinhChinh = (int)row["MaManHinhChinh"];
        }

        private int maManHinhChinh;
    


        private string tenChucVu;



        private int maChucVu;

        public int MaManHinhChinh
        {
            get
            {
                return maManHinhChinh;
            }

            set
            {
                maManHinhChinh = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return tenChucVu;
            }

            set
            {
                tenChucVu = value;
            }
        }

        public int MaChucVu
        {
            get
            {
                return maChucVu;
            }

            set
            {
                maChucVu = value;
            }
        }
    }
}
