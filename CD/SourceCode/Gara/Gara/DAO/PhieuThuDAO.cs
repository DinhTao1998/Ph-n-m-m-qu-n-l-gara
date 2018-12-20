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
    public class PhieuThuDAO
    {
        private static PhieuThuDAO instance;

        public static PhieuThuDAO Instance
        {
            get { if (instance == null) instance = new PhieuThuDAO(); return PhieuThuDAO.instance; }
            private set { instance = value; }
        }

        private PhieuThuDAO() { }

        public static void ThemPhieuThu(int mx,string ntn,int stt)
        {
            SqlConnection conn = new SqlConnection(ConnectionString.conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("PhieuThu_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaXe", SqlDbType.Int);
            cmd.Parameters.Add("@SoTienThu", SqlDbType.Int);
            cmd.Parameters.Add("@NgayThuTien", SqlDbType.SmallDateTime);
            cmd.Parameters["@MaXe"].Value = mx;
            cmd.Parameters["@NgayThuTien"].Value = ntn;
            cmd.Parameters["@SoTienThu"].Value = stt;
            int count = cmd.ExecuteNonQuery();
            if(count > 0)
            {
                MessageBox.Show("Thêm phiếu thu tiền thành công!");
            }
            else
            {
                MessageBox.Show("Thêm phiếu thu tiền thất bại!");
            }
            conn.Close();
        }

    }
}
