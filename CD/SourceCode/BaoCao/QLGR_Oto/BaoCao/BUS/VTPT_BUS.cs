using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BaoCao.DAO;
using BaoCao.DTO;

namespace BaoCao.BUS
{
    class VTPT_BUS
    {
        public static DataTable ListPhuTung()
        {
            return VTPT_DAO.GetPhuTung();
        }

        public static string LaySoLuongPhuTung(string MaVTPT)
        {
            return VTPT_DAO.LaySoLuongPhuTung(MaVTPT);
        }
    }
}
