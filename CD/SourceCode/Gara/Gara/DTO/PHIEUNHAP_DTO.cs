using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class PHIEUNHAP_DTO
    {
        private int _maPhieuNhap;
        private DateTime _ngayNhap;
        private int _tongTien;
        public PHIEUNHAP_DTO(DateTime ngaynhap, int tongtien)
        {
            NgayNhap = ngaynhap;
            TongTien = tongtien;
        }
        public int MaPhieuNhap
        {
            get
            {
                return _maPhieuNhap;
            }

            set
            {
                _maPhieuNhap = value;
            }
        }

        public DateTime NgayNhap
        {
            get
            {
                return _ngayNhap;
            }

            set
            {
                _ngayNhap = value;
            }
        }

        public int TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
            }
        }
    }
}
