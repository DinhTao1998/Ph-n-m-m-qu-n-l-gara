using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaoCao.DAO;
using BaoCao.DTO;

namespace BaoCao.BUS
{
    class BC_DOANHSO_BUS
    {
        public static void ThemBC(BC_DOANHSO baoCao)
        {
            BC_DOANHSO_DAO.ThemBaoCao(baoCao);
            DataTable dt = HIEUXE_BUS.GetMaHieuXe(); //Get list mã hiệu xe
            foreach (DataRow row in dt.Rows)
            {
                CT_BC_DOANHSO chiTiet = new CT_BC_DOANHSO();
                chiTiet.MaCTBC = CT_BC_DOANHSO_BUS.AutoMACTBC();
                chiTiet.MaBCDS = baoCao.MaBaoCaoDoanhSo;
                chiTiet.MaHieuXe = row.ItemArray[0].ToString();

                CT_BC_DOANHSO_BUS.ThemCTBC(chiTiet);
            }
        }

        public static string GetMaBC(int thang, int nam)
        {
            return BC_DOANHSO_DAO.GetMaBaoCao(thang, nam); //Lấy mã BCDS theo tháng
        }

        public static string AutoMABC()
        {
            string id = BC_DOANHSO_DAO.GetLastID().Trim();
            if (id == "")
            {
                return "BCDS_00001";
            }
            int nextID = int.Parse(id.Remove(0, "BCDS_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "BCDS_" + id;
        }
    }
}
