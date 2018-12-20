using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BaoCao.DTO;

namespace BaoCao.DAO
{
    class PHIEUSUACHUA_DAO
    {
        public static void ThemPhieuSuaChua(PHIEUSUACHUA psc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMPSC");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPSC", psc.MaPhieuSC);
            cmd.Parameters.AddWithValue("@MAXE", psc.MaXe);
            cmd.Parameters.AddWithValue("@NGAYSC", psc.NgaySuaChua);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new System.Data.DataTable();
            da.Fill(db.dt);
        }
    }
}
