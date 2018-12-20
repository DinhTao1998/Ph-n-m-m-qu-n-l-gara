using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class XE
    {
        public XE(char mx, string bs, int hx, string ntn, string tcx, string dc, string dt, string em, int tn = 0)
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

        public XE(DataRow row)
        {
            this.MaXe = (char)row["MaXe"];
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

        private char maXe;

        public char MaXe { get => maXe; set => maXe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public int MaHieuXe { get => maHieuXe; set => maHieuXe = value; }
        public string NgayTiepNhan { get => ngayTiepNhan; set => ngayTiepNhan = value; }
        public string TenChuXe { get => tenChuXe; set => tenChuXe = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public int TienNo { get => tienNo; set => tienNo = value; }
    }
}
