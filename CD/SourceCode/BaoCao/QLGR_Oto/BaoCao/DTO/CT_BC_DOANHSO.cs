using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao.DTO
{
    class CT_BC_DOANHSO
    {
        private string _maCTBC;

        public string MaCTBC
        {
            get { return _maCTBC; }
            set { _maCTBC = value; }
        }

        private string _maBCDS;

        public string MaBCDS
        {
            get { return _maBCDS; }
            set { _maBCDS = value; }
        }

        private string _maHieuXe;

        public string MaHieuXe
        {
            get { return _maHieuXe; }
            set { _maHieuXe = value; }
        }

        public CT_BC_DOANHSO() { }
    }
}
