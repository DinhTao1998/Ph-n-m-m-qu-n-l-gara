using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCao.DTO;

namespace BaoCao.DAO
{
    class CT_BC_DOANHSO_DAO
    {
        public static string GetMaBCDS(string maBCDS, string maHieuXe) 
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETCT_BAOCAODOANHSO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBCDS", maBCDS);
            cmd.Parameters.AddWithValue("@MAHIEUXE", maHieuXe);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void ThemCTBC(CT_BC_DOANHSO chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMCT_BCDS"); 

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABCDS", chiTiet.MaBCDS);
            cmd.Parameters.AddWithValue("@MAHIEUXE", chiTiet.MaHieuXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MACTBC from CT_BCDS order by MACTBC desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void CapNhatSoLuotSua(CT_BC_DOANHSO chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATCT_BCDS");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABCDS", chiTiet.MaBCDS);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatBaoCao(CT_BC_DOANHSO chiTiet, int soTien)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATDOANHTHU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABCDS", chiTiet.MaBCDS);
            cmd.Parameters.AddWithValue("@SOTIEN", soTien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTiLe(CT_BC_DOANHSO chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATTILE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABCDS", chiTiet.MaBCDS);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
