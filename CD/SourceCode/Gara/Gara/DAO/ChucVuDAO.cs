using Gara.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return ChucVuDAO.instance; }
            private set { instance = value; }
        }

        private ChucVuDAO() { }

        public ChucVu GetTenChucVu(int MaCV)
        {
            ChucVu kq = null;
            string query = string.Format("SELECT * from dbo.CHUCVU WHERE MaChucVu = N'{0}'", MaCV);

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                kq = new ChucVu(item);
                return kq;
            }

            return kq;
        }

        public List<ChucVu> GetListCV()
        {
            List<ChucVu> kq = new List<ChucVu> { };
            string query = "SELECT * FROM CHUCVU";
            DataTable kq1 = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in kq1.Rows)
            {
                ChucVu h = new ChucVu(item);
                kq.Add(h);
            }
            return kq;
        }
    }
}
