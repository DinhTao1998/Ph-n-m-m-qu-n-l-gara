using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class Xe
    {
        public Xe(int mx, string bs, int hx, string ntn, string tcx, string dc,string dt, string em,int tn = 0)
        {
            this.MaXe = mx;
            this.BienSo = bs;
            this.MaHieuXe = hx;
            this.NgayTiepNhan = ntn;
            this.TenChuXe = tcx;
            this.DiaChi = dc;
            this.DienThoai = dt;
            this.Email = em;
            this.TienNo = tn;
        }

        public Xe(DataRow row)
        {
            this.MaXe = (int)row["MaXe"];
            this.BienSo = row["BienSo"].ToString();
            this.MaHieuXe = (int)row["MaHieuXe"];
            this.NgayTiepNhan = row["NgayTiepNhan"].ToString();
            this.TenChuXe = row["TenChuXe"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.Email = row["Email"].ToString();
            this.TienNo = (int)row["TienNo"];
        }
        private int tienNo;

        private string email;

        private string dienThoai;

        private string diaChi;

        private string tenChuXe;

        private string ngayTiepNhan;

        private int maHieuXe;

        private string bienSo;

        private int maXe;

        public int TienNo
        {
            get
            {
                return tienNo;
            }

            set
            {
                tienNo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }

            set
            {
                dienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string TenChuXe
        {
            get
            {
                return tenChuXe;
            }

            set
            {
                tenChuXe = value;
            }
        }

        public string NgayTiepNhan
        {
            get
            {
                return ngayTiepNhan;
            }

            set
            {
                ngayTiepNhan = value;
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

        public string BienSo
        {
            get
            {
                return bienSo;
            }

            set
            {
                bienSo = value;
            }
        }

        public int MaXe
        {
            get
            {
                return maXe;
            }

            set
            {
                maXe = value;
            }
        }
    }
}
