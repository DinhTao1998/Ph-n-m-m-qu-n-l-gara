using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCao.DTO;

namespace BaoCao.DAO
{
    class CT_BC_VTPT_DAO
    {
        public static string getMaChiTietBCT(string maBC, string maPT)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETMACTBCT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MABCT", maBC);
            cmd.Parameters.AddWithValue("@MAPT", maPT);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();

            }
            return "";
        }

        public static void themChiTietBCT(CT_BC_VTPT chitiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMCT_BCT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chitiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABC", chitiet.MaBCT);
            cmd.Parameters.AddWithValue("@MAPT", chitiet.MaVTPT);
            cmd.Parameters.AddWithValue("@TONDAU", chitiet.TonDau);
            cmd.Parameters.AddWithValue("@PHATSINH", chitiet.PhatSinh);
            cmd.Parameters.AddWithValue("@TONCUOI", chitiet.TonCuoi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MACTBCT from CT_BC_VTPT order by MACTBCT desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void CapNhatPhatSinh(CT_BC_VTPT chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATPHATSINH");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBCT", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@SL", chiTiet.PhatSinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTonCuoi(CT_BC_VTPT chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATTONCUOI");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SL", chiTiet.TonCuoi);
            cmd.Parameters.AddWithValue("@MACTBCT", chiTiet.MaCTBC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
