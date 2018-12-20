using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DTO
{
    public class PhieuThuDTO
    {
        private int maPhieuThu;
        private int maXe;
        private DateTime ngayThuTien;
        private int soTienThu;

        public PhieuThuDTO(int maxe, DateTime ngaythutien, int sotienthu)
        {
            MaXe = maxe;
            NgayThuTien = ngayThuTien;
            SoTienThu = sotienthu;
        }

        public int MaPhieuThu
        {
            get
            {
                return maPhieuThu;
            }

            set
            {
                maPhieuThu = value;
            }
        }

        public int MaXe
        {
            get
            {
                return maXe;
            }

            set
            {
                maXe = value;
            }
        }

        public DateTime NgayThuTien
        {
            get
            {
                return ngayThuTien;
            }

            set
            {
                ngayThuTien = value;
            }
        }

        public int SoTienThu
        {
            get
            {
                return soTienThu;
            }

            set
            {
                soTienThu = value;
            }
        }

    }
}
