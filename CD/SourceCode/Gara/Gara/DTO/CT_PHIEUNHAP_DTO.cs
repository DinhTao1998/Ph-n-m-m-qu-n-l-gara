using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class CT_PHIEUNHAP_DTO
    {
        private int _maPhieuNhap;
        private int _maVTPT;
        private int _donGia;
        private int _soLuong;
        private int _thanhTien;
        public CT_PHIEUNHAP_DTO (int mavtpt, int dongia, int soluong, int thanhtien)
        {
            MaVTPT = mavtpt;
            DonGia = dongia;
            SoLuong = soluong;
            ThanhTien = thanhtien;
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

        public int MaVTPT
        {
            get
            {
                return _maVTPT;
            }

            set
            {
                _maVTPT = value;
            }
        }

        public int DonGia
        {
            get
            {
                return _donGia;
            }

            set
            {
                _donGia = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public int ThanhTien
        {
            get
            {
                return _thanhTien;
            }

            set
            {
                _thanhTien = value;
            }
        }
    }
}
