using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaoCao.DAO;
using BaoCao.DTO;
using System.Data;

namespace BaoCao.BUS
{
    class CT_BC_VTPT_BUS
    {
        public static string getMaCTBCT(string maBCT, string maPT) //Lấy mã bc ct tồn theo mã bc tồn và vtpt
        {
            return CT_BC_VTPT_DAO.getMaChiTietBCT(maBCT, maPT);
        }

        public static void themChiTietBaoCao(CT_BC_VTPT chitiet)
        {
            CT_BC_VTPT_DAO.themChiTietBCT(chitiet);
        }

        public static void capNhatTonCuoi(CT_BC_VTPT chitiet)
        {
            CT_BC_VTPT_DAO.CapNhatTonCuoi(chitiet);
        }

        public static void capNhatPhatSinh(CT_BC_VTPT chitiet)
        {
            CT_BC_VTPT_DAO.CapNhatPhatSinh(chitiet);
        }

        public static string AutoMaCTBCT()
        {
            string id = CT_BC_VTPT_DAO.GetLastID().Trim();
            if (id == "")
            {
                return "CTBCT_00001";
            }
            int nextID = int.Parse(id.Remove(0, "CTBCT_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "CTBCT_" + id;
        }
    }
}
