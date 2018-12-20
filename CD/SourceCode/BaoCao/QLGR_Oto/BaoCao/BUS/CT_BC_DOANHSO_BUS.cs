using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaoCao.DAO;
using BaoCao.DTO;
using System.Data;

namespace BaoCao.BUS
{
    class CT_BC_DOANHSO_BUS
    {
        public static void ThemCTBC(CT_BC_DOANHSO chiTiet)
        {
            CT_BC_DOANHSO_DAO.ThemCTBC(chiTiet); //Thêm ct_bcds mới (MACTBC, MABCDS, MAHX)
        }

        public static string GetMaCTBC(string maBC, string maHieuXe)
        {
            return CT_BC_DOANHSO_DAO.GetMaBCDS(maBC, maHieuXe); //Lấy mã CTBC từ mã BCDS và MaHieuXe
        }

        public static void CapNhatSoLuotSua(CT_BC_DOANHSO chiTiet)
        {
            CT_BC_DOANHSO_DAO.CapNhatSoLuotSua(chiTiet);
        }

        public static string AutoMACTBC()
        {
            string id = CT_BC_DOANHSO_DAO.GetLastID().Trim();
            if (id == "")
            {
                return "CTBC_00001";
            }
            int nextID = int.Parse(id.Remove(0, "CTBC_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "CTBC_" + id;
        }

        public static void CapNhatBaoCao(CT_BC_DOANHSO chiTiet, int soTien)
        {
            CT_BC_DOANHSO_DAO.CapNhatBaoCao(chiTiet, soTien); //Cập nhật tổng doanh thu
            DataTable dt = HIEUXE_BUS.GetMaHieuXe(); //Lấy danh sách mã hiệu xe
            foreach (DataRow row in dt.Rows)
            {
                CT_BC_DOANHSO _chiTiet = new CT_BC_DOANHSO();
                _chiTiet.MaBCDS = chiTiet.MaBCDS;
                _chiTiet.MaHieuXe = row.ItemArray[0].ToString(); 
                _chiTiet.MaCTBC = CT_BC_DOANHSO_DAO.GetMaBCDS(_chiTiet.MaBCDS, _chiTiet.MaHieuXe);
                CT_BC_DOANHSO_DAO.CapNhatTiLe(_chiTiet);
            }
        }
    }
}
