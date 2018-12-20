using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class CT_BC_VTPT
    {
        private string _maCTBC;
        public string MaCTBC
        {
            get { return _maCTBC; }
            set { _maCTBC = value; }
        }

        private string _maBCT;
        public string MaBCT
        {
            get { return _maBCT; }
            set { _maBCT = value; }
        }

        private string _maVTPT;
        public string MaVTPT
        {
            get { return _maVTPT; }
            set { _maVTPT = value; }
        }

        private int tonDau;
        public int TonDau
        {
            get { return tonDau; }
            set { tonDau = value; }
        }

        private int tonCuoi;
        public int TonCuoi
        {
            get { return tonCuoi; }
            set { tonCuoi = value; }
        }

        private int phatSinh;
        public int PhatSinh
        {
            get { return phatSinh; }
            set { phatSinh = value; }
        }
        public CT_BC_VTPT() { }
    }
}
