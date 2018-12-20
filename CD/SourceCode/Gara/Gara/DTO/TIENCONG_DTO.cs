using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class TIENCONG_DTO
    {

        private int _maTienCong;
        private string _tenTienCong;
        private int _tienCong;

        public TIENCONG_DTO(int matiencong, string tentiencong, int tiencong)
        {
            MaTienCong = matiencong;
            TenTienCong = tentiencong;
            TienCong = tiencong;
        }

        public TIENCONG_DTO(string tentiencong, int tiencong)
        {
            TenTienCong = tentiencong;
            TienCong = tiencong;
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

        public string TenTienCong
        {
            get
            {
                return _tenTienCong;
            }

            set
            {
                _tenTienCong = value;
            }
        }

        public int TienCong
        {
            get
            {
                return _tienCong;
            }

            set
            {
                _tienCong = value;
            }
        }
    }
}
