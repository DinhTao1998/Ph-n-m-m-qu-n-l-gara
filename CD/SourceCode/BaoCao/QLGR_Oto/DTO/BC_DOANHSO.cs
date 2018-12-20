using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BC_DOANHSO
    {
        private string _maBCDS;

        public string MaBaoCaoDoanhSo
        {
            get { return _maBCDS; }
            set { _maBCDS = value; }
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

        private decimal _tongDoanhThu;

        public decimal TongDoanhThu
        {
            get { return _tongDoanhThu; }
            set { _tongDoanhThu = value; }
        }

        public BC_DOANHSO() { }

        public BC_DOANHSO(string maBC, int thang, int nam)
        {
            this.MaBaoCaoDoanhSo = maBC;
            this.Thang = thang;
            this.Nam = nam;
        }
    }
}
