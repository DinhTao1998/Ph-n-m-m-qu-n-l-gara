using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaoCao.DAO;
using BaoCao.DTO;

namespace BaoCao.BUS
{
    class BC_TONVTPT_BUS
    {
        public static void ThemBC(BC_TONVTPT baoCao)
        {

            BC_TONVTPT_DAO.ThemBaoCao(baoCao);
            DataTable dt = VTPT_BUS.ListPhuTung(); //Lấy danh sách VTPT
            foreach (DataRow row in dt.Rows)
            {
                CT_BC_VTPT chiTiet = new CT_BC_VTPT();
                chiTiet.MaCTBC = CT_BC_VTPT_BUS.AutoMaCTBCT(); //Sinh mã bc VTPT
                chiTiet.MaBCT = baoCao.MaBCT;
                chiTiet.MaVTPT = row.ItemArray[0].ToString();
                chiTiet.TonDau = int.Parse(VTPT_BUS.LaySoLuongPhuTung(chiTiet.MaVTPT)); //Lấy số lượng tồn của VTPT
                chiTiet.TonCuoi = chiTiet.TonDau;
                chiTiet.PhatSinh = 0;

                CT_BC_VTPT_BUS.themChiTietBaoCao(chiTiet);
            }
        }

        public static string GetMaBCT(int thang, int nam)
        {
            return BC_TONVTPT_DAO.GetMaBaoCaoTon(thang, nam); //Lấy mã báo cáo tồn theo tháng
        }

        public static string AutoMABCT()
        {
            string id = CT_BC_VTPT_DAO.GetLastID().Trim();
            if (id == "")
            {
                return "BCT_00001";
            }
            int nextID = int.Parse(id.Remove(0, "BCT_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "BCT_" + id;
        }
    }
}
