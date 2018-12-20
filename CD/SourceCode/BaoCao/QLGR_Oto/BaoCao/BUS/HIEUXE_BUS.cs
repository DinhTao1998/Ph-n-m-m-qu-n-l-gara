using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaoCao.DAO;

namespace BaoCao.BUS
{
    class HIEUXE_BUS
    {
        public static DataTable GetMaHieuXe()
        {
            return HIEUXE_DAO.GetMaHieuXe();
        }
    }
}
