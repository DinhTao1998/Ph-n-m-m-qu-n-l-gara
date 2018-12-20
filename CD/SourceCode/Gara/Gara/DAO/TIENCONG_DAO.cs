using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara.DTO;
namespace Gara.DAO
{
    public class TIENCONG_DAO
    {
        public static DataTable LietKeTienCong()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            SqlCommand cmd = new SqlCommand("LietKeTienCong", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static void ThemTienCong(TIENCONG_DTO tc)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("ThemTienCong", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenTienCong", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TienCong", SqlDbType.Int);
            cmd.Parameters["@TenTienCong"].Value = tc.TenTienCong;
            cmd.Parameters["@TienCong"].Value = tc.TienCong;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            connection.Close();
        }
        public static void CapNhatTienCong(TIENCONG_DTO tc)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = KetNoi.Instance.conn;
            connection.Open();
            SqlCommand cmd = new SqlCommand("SuaTienCong", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTienCong", SqlDbType.Int);
            cmd.Parameters.Add("@TenTienCong", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TienCong", SqlDbType.Int);
            cmd.Parameters["@TenTienCong"].Value = tc.TenTienCong;
            cmd.Parameters["@TienCong"].Value = tc.TienCong;
            cmd.Parameters["@MaTienCong"].Value = tc.MaTienCong;
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            connection.Close();
        }
    }
}
