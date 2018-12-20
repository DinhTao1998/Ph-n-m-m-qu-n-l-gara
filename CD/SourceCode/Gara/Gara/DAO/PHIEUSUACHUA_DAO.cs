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
    public class PHIEUSUACHUA_DAO
    {
        public static void ThemPhieuSuaChua(PHIEUSUACHUA_DTO p)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemPhieuSuaChua", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaXe", SqlDbType.Int);
            cmd.Parameters.Add("@NgaySuaChua", SqlDbType.SmallDateTime);
            cmd.Parameters.Add("@TongPhiSuaChua", SqlDbType.Int);
            cmd.Parameters.Add("@SoTienThu", SqlDbType.Int);
            cmd.Parameters.Add("@Conlai", SqlDbType.Int);
            cmd.Parameters["@NgaySuaChua"].Value = p.NgaySuaChua;
            cmd.Parameters["@TongPhiSuaChua"].Value = p.TongChiPhi;
            cmd.Parameters["@SoTienThu"].Value = p.SoTienThu;
            cmd.Parameters["@ConLai"].Value = p.ConLai;
            cmd.Parameters["@MaXe"].Value = p.MaXe;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
            }
            connection.Close();
        }
        public static DataTable LayMaXe()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from XE", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable LayTienCong(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TienCong", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable LayMaTienCong()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaTienCong,TenTienCong from TienCong", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable LayMaVTPT()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaVTPT,TenVTPT from VTPT", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable LayThongTinVTPT(string dk)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from VTPT", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable GetHieuXe()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select TenHieuXe from HIEUXE", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
