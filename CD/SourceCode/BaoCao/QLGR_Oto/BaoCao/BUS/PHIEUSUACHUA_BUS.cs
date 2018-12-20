using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao.DAO;
using BaoCao.DTO;
using System.Data;

namespace BaoCao.BUS
{
    class PHIEUSUACHUA_BUS
    {
        public static void ThemPhieuSuaChua(PHIEUSUACHUA psc)
        {
            PHIEUSUACHUA_DAO.ThemPhieuSuaChua(psc);

            string maHieuXe = XE_DAO.GetMaHieuXe(psc.MaXe.ToString());
            string maBCDS = BC_DOANHSO_BUS.GetMaBC(psc.NgaySuaChua.Month, psc.NgaySuaChua.Year);

            if (maBCDS == "")
            {
                maBCDS = BC_DOANHSO_BUS.AutoMABC();
      
                BC_DOANHSO baoCao = new BC_DOANHSO();
                baoCao.MaBaoCaoDoanhSo = maBCDS;
                baoCao.Thang = psc.NgaySuaChua.Month;
                baoCao.Nam = psc.NgaySuaChua.Year;

                BC_DOANHSO_BUS.ThemBC(baoCao);
            }

            CT_BC_DOANHSO chiTiet = new CT_BC_DOANHSO();
            chiTiet.MaBCDS = maBCDS;
            chiTiet.MaCTBC = CT_BC_DOANHSO_BUS.GetMaCTBC(maBCDS, maHieuXe);

            if (chiTiet.MaCTBC == "")
            {
                chiTiet.MaCTBC = CT_BC_DOANHSO_BUS.AutoMACTBC();
                chiTiet.MaHieuXe = maHieuXe;
                CT_BC_DOANHSO_BUS.ThemCTBC(chiTiet);
            }

            CT_BC_DOANHSO_BUS.CapNhatSoLuotSua(chiTiet);

            string maBCT = BC_TONVTPT_BUS.GetMaBCT(psc.NgaySuaChua.Month, psc.NgaySuaChua.Year);
            if (maBCT == "")
            {
                maBCT = BC_TONVTPT_BUS.AutoMABCT();

                BC_TONVTPT BCT = new BC_TONVTPT();
                BCT.MaBCT = maBCT;
                BCT.Thang = psc.NgaySuaChua.Month;
                BCT.Nam = psc.NgaySuaChua.Year;

                BC_TONVTPT_BUS.ThemBC(BCT);
            }
        }
    }
}
