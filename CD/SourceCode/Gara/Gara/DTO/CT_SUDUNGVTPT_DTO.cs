using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class CT_SUDUNGVTPT_DTO
    {
        private int _maCT_SD;
        private int _maCT;
        private int _maVTPT;
        private int _donGia;
        private int _soLuong;
        private int _thanhTien;
        public CT_SUDUNGVTPT_DTO( int mavtpt, int dongia, int soluong, int thanhtien)
        {
            MaVTPT = mavtpt;
            DonGia = dongia;
            SoLuong = soluong;
            ThanhTien = thanhtien;
        }
        public CT_SUDUNGVTPT_DTO()
        {
        }

        public int MaCT_SD
        {
            get
            {
                return _maCT_SD;
            }

            set
            {
                _maCT_SD = value;
            }
        }

        public int MaCT
        {
            get
            {
                return _maCT;
            }

            set
            {
                _maCT = value;
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
