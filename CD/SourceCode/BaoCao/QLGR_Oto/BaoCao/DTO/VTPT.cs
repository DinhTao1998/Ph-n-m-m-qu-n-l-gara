using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class VTPT
    {
        private string _maVTPT;

        public string MaVTPT
        {
            get { return _maVTPT; }
            set { _maVTPT = value; }
        }

        private string _tenVTPT;

        public string TenVTPT
        {
            get { return _tenVTPT; }
            set { _tenVTPT = value; }
        }

        private int _donGia;

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }


        private int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public VTPT() { }

        public VTPT(System.Data.DataRow row)
        {
            this._maVTPT = row["MaVTPT"].ToString();
            this._tenVTPT = row["TenVTPT"].ToString();
            this._soLuongTon = (int)row["SoLuongTon"];
            this._donGia = (int)row["DonGia"];
        }
    }
}
