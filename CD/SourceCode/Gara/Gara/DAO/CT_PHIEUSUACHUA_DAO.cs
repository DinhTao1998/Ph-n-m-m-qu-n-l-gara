using Gara.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Gara.DAO
{
    public class CT_PHIEUSUACHUA_DAO 
    {
        public static void ThemCT_PhieuSuaChua(CT_PHIEUSUACHUA_DTO p, PHIEUSUACHUA_DTO q)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemCT_PhieuSC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaXe", SqlDbType.Int);
            cmd.Parameters.Add("@NgaySuaChua", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TongPhiSuaChua", SqlDbType.Int);
            cmd.Parameters.Add("@SoTienThu", SqlDbType.Int);
            cmd.Parameters.Add("@ConLai", SqlDbType.Int);
            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@MaTienCong", SqlDbType.Int);
            cmd.Parameters.Add("@DonGia", SqlDbType.Int);
            cmd.Parameters.Add("@SoLan", SqlDbType.Int);
            cmd.Parameters.Add("@TongTienCong", SqlDbType.Int);
            cmd.Parameters.Add("@ChiPhiVTPT", SqlDbType.Int);
            cmd.Parameters.Add("@TongChiPhi", SqlDbType.Int);
            cmd.Parameters["@NoiDung"].Value = p.NoiDung;
            cmd.Parameters["@MaTienCong"].Value = p.MaTienCong;
            cmd.Parameters["@DonGia"].Value = p.DonGia;
            cmd.Parameters["@SoLan"].Value = p.SoLan;
            cmd.Parameters["@TongTienCong"].Value = p.TongTienCong;
            cmd.Parameters["@ChiPhiVTPT"].Value = p.ChiPhiVTPT;
            cmd.Parameters["@TongChiPhi"].Value = p.TongChiPhi;
            cmd.Parameters["@MaXe"].Value = q.MaXe;
            cmd.Parameters["@NgaySuaChua"].Value = q.NgaySuaChua;
            cmd.Parameters["@TongPhiSuaChua"].Value = q.TongChiPhi;
            cmd.Parameters["@SoTienThu"].Value = q.SoTienThu;
            cmd.Parameters["@ConLai"].Value = q.ConLai;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
    }
}
