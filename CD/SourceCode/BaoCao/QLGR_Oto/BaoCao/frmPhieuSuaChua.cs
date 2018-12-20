using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaoCao.DTO;
using BaoCao.BUS;

namespace BaoCao
{
    public partial class frmPhieuSuaChua : Form
    {
        public frmPhieuSuaChua()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //PHIEUSUACHUA psc = new PHIEUSUACHUA(...);
            //PHIEUSUACHUA_BUS.ThemPhieuSuaChua(psc);

            DateTime today = DateTime.Now;
            string maBCT = BC_TONVTPT_BUS.GetMaBCT(today.Month, today.Year);
            string maCTBCT = CT_BC_VTPT_BUS.getMaCTBCT(maBCT, cboPhuTung.Text);
            CT_BC_VTPT chitiet = new CT_BC_VTPT();

            chitiet.MaBCT = maBCT;
            chitiet.MaCTBC = maCTBCT;
            chitiet.MaVTPT = cboPhuTung.Text;
            chitiet.TonCuoi = int.Parse(txtSL.Text);
            chitiet.PhatSinh = 0;
            chitiet.TonDau = 0;
            CT_BC_VTPT_BUS.capNhatTonCuoi(chitiet);
        }
    }
}
