using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    class VTPT
    {
        private int maVTPT;
        private string tenVTPT;
        private int donGia;
        private int soLuongTon;

        
        public VTPT(DataRow row)
        {
            this.MaVTPT = (int)row["MaVTPT"];
            this.TenVTPT = row["TenVTPT"].ToString();
            this.DonGia = (int)row["DonGia"];
            this.SoLuongTon = (int)row["SoLuongTon"];
        }

        public int MaVTPT
        {
            get
            {
                return maVTPT;
            }

            set
            {
                maVTPT = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return soLuongTon;
            }

            set
            {
                soLuongTon = value;
            }
        }

        public string TenVTPT
        {
            get
            {
                return tenVTPT;
            }

            set
            {
                tenVTPT = value;
            }
        }
    }
}
