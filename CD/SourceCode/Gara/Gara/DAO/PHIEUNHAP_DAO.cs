using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara.DTO;
using System.Data.SqlClient;
using System.Data;

namespace Gara.DAO
{
    public class PHIEUNHAP_DAO
    {
        public static void ThemPhieuSuaChua(PHIEUNHAP_DTO p)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemPhieuNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayNhap", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TongTienNhap", SqlDbType.Int);
            cmd.Parameters["@NgayNhap"].Value = p.NgayNhap;
            cmd.Parameters["@TongTienNhap"].Value = p.TongTien;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
    }
}
