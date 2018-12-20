using Gara.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DAO
{
    public class CT_PHIEUNHAP_DAO
    {
        public static void ThemCT_PhieuNhap(CT_PHIEUNHAP_DTO p , PHIEUNHAP_DTO q)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemCT_PhieuNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayNhap", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TongTienNhap", SqlDbType.Int);
            cmd.Parameters.Add("@MaVTPT", SqlDbType.Int);
            cmd.Parameters.Add("@DonGia", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Int);
            cmd.Parameters["@NgayNhap"].Value = q.NgayNhap;
            cmd.Parameters["@TongTienNhap"].Value = q.TongTien;
            cmd.Parameters["@MaVTPT"].Value = p.MaVTPT;
            cmd.Parameters["@DonGia"].Value = p.DonGia;
            cmd.Parameters["@SoLuong"].Value = p.SoLuong;
            cmd.Parameters["@ThanhTien"].Value = p.ThanhTien;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
    }
}
