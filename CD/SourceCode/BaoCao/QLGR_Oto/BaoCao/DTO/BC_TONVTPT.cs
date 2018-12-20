using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class BC_TONVTPT
    {
        private string _maBCT;

        public string MaBCT
        {
            get { return _maBCT; }
            set { _maBCT = value; }
        }


        private int _thang;

        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        private int _nam;

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }
        public BC_TONVTPT() { }

        public BC_TONVTPT(string maBC, int thang, int nam)
        {
            this.MaBCT = maBC;
            this.Thang = thang;
            this.Nam = nam;
        }
    }
}
