using Gara.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara.DAO
{
    public class TKDAO
    {
        private static TKDAO instance;

        public static TKDAO Instance
        {
            get { if (instance == null) instance = new TKDAO(); return instance;}
            private set { instance = value; }
        }

        private TKDAO() { }

        public bool Login(string tk, string mk)
        {
            string query = string.Format("SELECT * FROM dbo.NGUOIDUNG WHERE TenDangNhap = N'{0}' AND MatKhau = N'{1}' ",tk,mk);

            DataTable kq = DataProvider.Instance.ExecuteQuery(query);

            return kq.Rows.Count > 0;
        }

        public TK  GetTaiKhoan(string TenDangNhap)
        {
            string query = string.Format("SELECT * FROM dbo.NGUOIDUNG WHERE TenDangNhap = N'{0}'", TenDangNhap);

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in table.Rows)
            {
                return new TK(item);
            }
            return null;
        }

        public DataTable GetListTK()
        {
            string query = "SELECT TenDangNhap AS [Tài khoản],TenHienThi AS [Tên],MaChucVu as [Chức vụ] FROM NGUOIDUNG";
            DataTable kq = new DataTable();
            kq = DataProvider.Instance.ExecuteQuery(query);
            return kq;
        }

        public void UpdateTen(string ht,string dn)
        {
            string query = string.Format("update NGUOIDUNG SET TenHienThi = N'{0}' where TenDangNhap = N'{1}'", ht, dn);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateMK(string mk, string dn)
        {
            string query = string.Format("update NGUOIDUNG SET MatKhau = N'{0}' where TenDangNhap = N'{1}'", mk, dn);
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public void UpdateCV(int cv,string dn)
        {
            string query = string.Format("update NGUOIDUNG SET MaChucVu = {0} where TenDangNhap = N'{1}'", cv, dn);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void ResetMK(string dn)
        {
            string query = string.Format("update NGUOIDUNG SET MatKhau = '1' where TenDangNhap = N'{0}'",dn);
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public void ThemNV(string tk,string ht,int mcv)
        {
            string query = string.Format("INSERT NGUOIDUNG VALUES ('{0}','1',N'{1}',{2})", tk, ht, mcv);
            DataProvider.Instance.ExecuteNonQuery(query);
        }


        public bool SoSanhTK(string tk)
        {
            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '{0}' ", tk);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
