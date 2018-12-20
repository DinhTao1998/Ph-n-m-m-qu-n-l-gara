using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class CT_PHIEUSUACHUA_DTO
    {

        private int _maCTPSC;
        private int _maPhieuSC;
        private string _noiDung;
        private int _maTienCong;
        private int _donGia;
        private int _soLan;
        private int _tongTienCong;
        private int _chiPhiVTPT;
        private int _TongChiPhi;
        public int MaCTPSC
        {
            get
            {
                return _maCTPSC;
            }

            set
            {
                _maCTPSC = value;
            }
        }

        public int MaPhieuSC
        {
            get
            {
                return _maPhieuSC;
            }

            set
            {
                _maPhieuSC = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return _noiDung;
            }

            set
            {
                _noiDung = value;
            }
        }

        public int MaTienCong
        {
            get
            {
                return _maTienCong;
            }

            set
            {
                _maTienCong = value;
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

        public int SoLan
        {
            get
            {
                return _soLan;
            }

            set
            {
                _soLan = value;
            }
        }

        public int TongTienCong
        {
            get
            {
                return _tongTienCong;
            }

            set
            {
                _tongTienCong = value;
            }
        }

        public int ChiPhiVTPT
        {
            get
            {
                return _chiPhiVTPT;
            }

            set
            {
                _chiPhiVTPT = value;
            }
        }

        public int TongChiPhi
        {
            get
            {
                return _TongChiPhi;
            }

            set
            {
                _TongChiPhi = value;
            }
        }

        public CT_PHIEUSUACHUA_DTO(string noidung, int matiencong, int dongia, int solan, int tongtiencong, int chiphivtpt, int tongchiphi)
        {
            NoiDung = noidung;
            MaTienCong = matiencong;
            DonGia = dongia;
            SoLan = solan;
            TongTienCong = tongtiencong;
            ChiPhiVTPT = chiphivtpt;
            TongChiPhi = tongchiphi;
        }
    }
}

