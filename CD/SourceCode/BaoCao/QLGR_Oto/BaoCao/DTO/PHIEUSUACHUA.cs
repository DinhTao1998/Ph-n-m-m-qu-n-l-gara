using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class PHIEUSUACHUA
    {
        private int _maPhieuSC;
        private char _maXe;
        private DateTime _ngaySuaChua;
        private int _tongChiPhi;
        private int _soTienThu;
        private int _conLai;

        public PHIEUSUACHUA(char maxe, DateTime ngaysuachua, int tongchiphi, int sotienthu, int conlai)
        {
            MaXe = maxe;
            NgaySuaChua = ngaysuachua;
            TongChiPhi = tongchiphi;
            SoTienThu = sotienthu;
            ConLai = conlai;
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

        public char MaXe
        {
            get
            {
                return _maXe;
            }

            set
            {
                _maXe = value;
            }
        }

        public DateTime NgaySuaChua
        {
            get
            {
                return _ngaySuaChua;
            }

            set
            {
                _ngaySuaChua = value;
            }
        }

        public int TongChiPhi
        {
            get
            {
                return _tongChiPhi;
            }

            set
            {
                _tongChiPhi = value;
            }
        }

        public int SoTienThu
        {
            get
            {
                return _soTienThu;
            }

            set
            {
                _soTienThu = value;
            }
        }

        public int ConLai
        {
            get
            {
                return _conLai;
            }

            set
            {
                _conLai = value;
            }
        }
    }
}
