using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara.DTO;
namespace Gara.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance { get { if (instance == null) instance = new XeDAO(); return XeDAO.instance; }
            private set { instance = value; }
        }

        private XeDAO() { }

        public bool ThemXe(string BienSo, int HieuXe, string NgayTiepNhan,string ChuXe, string DiaChi, string DienThoai, string Email)
        {
            string query = string.Format("INSERT dbo.XE( BienSo, MaHieuXe, NgayTiepNhan, TenChuXe, DiaChi,DienThoai,Email) VALUES( N'{0}' , {1} , N'{2}' , N'{3}' , N'{4}' , N'{5}' , N'{6}' ) ", BienSo, HieuXe, NgayTiepNhan, ChuXe, DiaChi, DienThoai, Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SoSanhBienSo(string BienSo)
        {
            string query = string.Format("SELECT * FROM XE WHERE BienSo = '{0}' ", BienSo);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public int DemSoXe()
        {
            int n = 0;
            string query = string.Format("SELECT COUNT (*) FROM PHIEUSUACHUA WHERE NgaySuaChua =  ' {0} ' ", DateTime.Now.ToShortDateString());
            DataTable kq = new DataTable();
            kq = DataProvider.Instance.ExecuteQuery(query);
            n = Int32.Parse(kq.Rows[0][0].ToString());
            return n;
        }

        public int GetXeToiDa()
        {
            int n = 0;
            string query = "SELECT GiaTri from THAMSO WHERE TenThamSo = 'SoXeToiDa'";
            DataTable kq = new DataTable();
            kq = DataProvider.Instance.ExecuteQuery(query);
            n = Int32.Parse(kq.Rows[0][0].ToString());
            return n;
        }

        public bool ThayDoiXeToiDa(int x)
        {
            string query = string.Format("update THAMSO set GiaTri = {0} where TenThamSo = 'SoXeToiDa'",x);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaXe(int MaXe, int HieuXe, string NgayTiepNhan, string ChuXe, string DiaChi, string DienThoai, string Email)
        {
            string query = string.Format("UPDATE dbo.XE SET  MaHieuXe =  {1} , NgayTiepNhan  = N'{2}' , TenChuXe =   N'{3}' , DiaChi =  N'{4}' , DienThoai =  N'{5}' ,Email =  N'{6}' WHERE MaXe = {0} ", MaXe, HieuXe, NgayTiepNhan, ChuXe, DiaChi, DienThoai, Email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetListXe()
        {
            DataTable xe = new DataTable();
            string query = "SELECT MaXe as [Mã xe], BienSo as [Biển số], MaHieuXe as [Mã hiệu xe], NgayTiepNhan as [Ngày tiếp nhận], TenChuXe as [Tên chủ xe], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], Email, TienNo as [Tiền nợ] FROM dbo.XE";
            xe = DataProvider.Instance.ExecuteQuery(query);
            return xe;
        }

        public DataTable GetXeByMaXe(int MaXe)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE MaXe = N'{0}' ",MaXe);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByBienSo(string BienSo)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE BienSo LIKE '%'+N'{0}'+'%'", BienSo);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }


        public DataTable GetXeByMaHieuXe(int MaHieuXe)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE MaHieuXe = {0} ", MaHieuXe);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }



        public DataTable GetXeByNgayTiepNhan(string ntn)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE NgayTiepNhan = '{0}' ", ntn);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByTenChuXe(string tcx)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM XE WHERE	[dbo].[GetUnsignString](TenChuXe) LIKE N'%'+[dbo].[GetUnsignString](N'{0}')+N'%'", tcx);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeBySoDienThoai(string tcx)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE DienThoai like '%'+'{0}'+'%' ", tcx);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByNoDau(int tcx)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE TienNo >= {0} ", tcx);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByNoCuoi(int tcx)
        {
            DataTable kq = new DataTable();

            string query = string.Format("SELECT * FROM dbo.XE WHERE TienNo <= {0} ", tcx);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByGR1(string MaXe,string BienSo,string MaHieuXe,string TenChuXe, string DienThoai, string NgayTiepNhan,int NoDau,int NoCuoi)
        {
            DataTable kq = new DataTable();

            string query = string.Format("select MaXe as [Mã xe], BienSo as [Biển số], MaHieuXe as [Mã hiệu xe], NgayTiepNhan as [Ngày tiếp nhận], TenChuXe as [Tên chủ xe], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], Email, TienNo as [Tiền nợ] from xe where MaXe like '%'+'{0}'+'%' and BienSo like '%'+'{1}'+'%' and MaHieuXe like '%'+'{2}'+'%' and [dbo].[GetUnsignString](TenChuXe) LIKE N'%'+[dbo].[GetUnsignString](N'{3}')+N'%'  and DienThoai like '%'+'{4}'+'%' and NgayTiepNhan = '{5}' and TienNo >= {6} and TienNo <= {7}", MaXe, BienSo, MaHieuXe, TenChuXe, DienThoai, NgayTiepNhan,NoDau,NoCuoi);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable GetXeByGR2(string MaXe, string BienSo, string MaHieuXe, string TenChuXe, string DienThoai, int NoDau, int NoCuoi)
        {
            DataTable kq = new DataTable();

            string query = string.Format("select MaXe as [Mã xe], BienSo as [Biển số], MaHieuXe as [Mã hiệu xe], NgayTiepNhan as [Ngày tiếp nhận], TenChuXe as [Tên chủ xe], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], Email, TienNo as [Tiền nợ] from xe where MaXe like '%'+'{0}'+'%' and BienSo like '%'+'{1}'+'%' and MaHieuXe like '%'+'{2}'+'%' and [dbo].[GetUnsignString](TenChuXe) LIKE N'%'+[dbo].[GetUnsignString](N'{3}')+N'%'  and DienThoai like '%'+'{4}'+'%' and TienNo >= {5} and TienNo <= {6}", MaXe, BienSo, MaHieuXe, TenChuXe, DienThoai,NoDau,NoCuoi);

            kq = DataProvider.Instance.ExecuteQuery(query);

            return kq;
        }

        public DataTable ListHome(int m)
        {
            string query = string.Format("select distinct DAY(NgaySuaChua) AS [Ngày], count(MaPhieuSC) AS [Lượt] from PHIEUSUACHUA where MONTH(NgaySuaChua) = {0} GROUP BY DAY(NgaySuaChua)", m);
            DataTable kq = DataProvider.Instance.ExecuteQuery(query);
            return kq;
        }
    }
}
