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
    class HieuXeDAO
    {
        private static HieuXeDAO instance;

        internal static HieuXeDAO Instance {
            get { if (instance == null) instance = new HieuXeDAO(); return HieuXeDAO.instance; }
            private set {  instance = value; } }

        private HieuXeDAO() { }

        public List<HieuXe> GetListHieuXe()
        {
            List<HieuXe> list = new List<HieuXe> { };
            string query = "select * from dbo.HieuXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HieuXe h = new HieuXe(item);
                list.Add(h);
            }
            return list;
        }

        public static DataTable GetHieuXe()
        {
            string query = "select * from dbo.HieuXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetTableHX()
        {
            string query = "select MaHieuXe AS [Mã], TenHieuXe AS [Tên], QuocGia AS [Quốc gia] from dbo.HieuXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public HieuXe GetHieuXeByMaHieuXe(int MaHieuXe)
        {
            
            string query = "select * from dbo.HIEUXE where MaHieuXe =" + MaHieuXe;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            HieuXe h = null;
            foreach (DataRow item in data.Rows)
            {
                h = new HieuXe(item);
                return h;
            }
            return h;
        }

        public void ThemHX(string ten,string qg)
        {
            string query = string.Format("insert HIEUXE(TenHieuXe,QuocGia) values (N'{0}',N'{1}')", ten, qg);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool SoSanhHieuXe(string ten)
        {
            string query = string.Format("SELECT * FROM HIEUXE WHERE TenHieuXe = '{0}' ", ten);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
