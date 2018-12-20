using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DAO
{
    class VTPTDAO
    {
        private static VTPTDAO instance;

        internal static VTPTDAO Instance
        {
            get { if (instance == null) instance = new VTPTDAO(); return VTPTDAO.instance; }
            private set { instance = value; }
        
        }

        private VTPTDAO() {}

        public bool ThemVTPT(string t,int sl,int dg)
        {
            string query = string.Format("INSERT VTPT(TenVTPT,SoLuong,DonGia) VALUES (N'{0}',{1},{2})", t, sl,dg);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetVTPT()
        {
            string query = "SELECT * FROM VTPT";
            DataTable KQ = DataProvider.Instance.ExecuteQuery(query);
            return KQ;
        }
        public void CapNhatDonGia(int dg, string ma)
        {
            string query = string.Format("update vtpt set DonGia = {0} where TenVTPT = N'{1}'", dg, ma);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
