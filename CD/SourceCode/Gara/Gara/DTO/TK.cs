using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class TK
    {
        public TK(string tk, string ht, int cv, string mk = null)
        {
            this.TenDangNhap = tk;
            this.TenHienThi = ht;
            this.MaChucVu = cv;
            this.MatKhau = mk;
        }

        public TK(DataRow row)
        {
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.TenHienThi = row["TenHienThi"].ToString();
            this.MaChucVu = (int)row["MaChucVu"];
            this.MatKhau = row["MatKhau"].ToString();
        }

        private int maChucVu;


        private string matKhau;


        private string tenHienThi;


        private string tenDangNhap;

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

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return tenHienThi;
            }

            set
            {
                tenHienThi = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }
    }
}
