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
    public class CT_SUDUNGVTPT_DAO
    {
        public static void ThemCT_SUDUNGVTPT(CT_SUDUNGVTPT_DTO p,CT_PHIEUSUACHUA_DTO q, PHIEUSUACHUA_DTO n)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemCT_SuDungVTPT", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaXe", SqlDbType.Int);
            cmd.Parameters.Add("@NgaySuaChua", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TongPhiSuaChua", SqlDbType.Int);
            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@MaTienCong", SqlDbType.Int);
            cmd.Parameters.Add("@TongTienCong", SqlDbType.Int);
            cmd.Parameters.Add("@ChiPhiVTPT", SqlDbType.Int);
            cmd.Parameters.Add("@TongChiPhi", SqlDbType.Int);
            cmd.Parameters.Add("@MaVTPT", SqlDbType.Int);
            cmd.Parameters.Add("@DonGia", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Int);
            cmd.Parameters["@NoiDung"].Value = q.NoiDung;
            cmd.Parameters["@MaTienCong"].Value = q.MaTienCong;
            cmd.Parameters["@TongTienCong"].Value = q.TongTienCong;
            cmd.Parameters["@ChiPhiVTPT"].Value = q.ChiPhiVTPT;
            cmd.Parameters["@TongChiPhi"].Value = q.TongChiPhi;
            cmd.Parameters["@MaXe"].Value = n.MaXe;
            cmd.Parameters["@NgaySuaChua"].Value = n.NgaySuaChua;
            cmd.Parameters["@TongPhiSuaChua"].Value = n.TongChiPhi;
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
