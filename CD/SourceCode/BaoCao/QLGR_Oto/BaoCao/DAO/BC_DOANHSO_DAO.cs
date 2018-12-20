using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCao.DTO;

namespace BaoCao.DAO
{
    class BC_DOANHSO_DAO
    {
        public static string GetMaBaoCao(int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETBAOCAODOANHSO");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", thang);
            cmd.Parameters.AddWithValue("@NAM", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void ThemBaoCao(BC_DOANHSO baoCao)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMBCDS");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MABC", baoCao.MaBaoCaoDoanhSo);
            cmd.Parameters.AddWithValue("@THANG", baoCao.Thang);
            cmd.Parameters.AddWithValue("@NAM", baoCao.Nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MABCDS from BAOCAODOANHSO order by MABCDS desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
    }
}
