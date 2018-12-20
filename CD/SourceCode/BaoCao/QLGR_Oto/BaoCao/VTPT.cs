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
    public partial class VTPT : Form
    {
        public VTPT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSL_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtSoLuong.Text);
            frmNhapVTPT form = new frmNhapVTPT(txtSoLuong);
            form.ShowDialog();
            if (btnThayDoi.Enabled)
            {
                DTO.VTPT phuTung = new DTO.VTPT();
                phuTung.MaVTPT = txtMaVTPT.Text;
                phuTung.TenVTPT = txtTenVTPT.Text;
                phuTung.SoLuongTon = int.Parse(txtSoLuong.Text);

                //cap nhat phat sinh
                DateTime today = DateTime.Now;
                string maBCT = BC_TONVTPT_BUS.GetMaBCT(today.Month, today.Year);

                if (maBCT == "")
                {
                    BC_TONVTPT baocao = new BC_TONVTPT();

                    baocao.MaBCT = BC_TONVTPT_BUS.AutoMABCT();
                    maBCT = baocao.MaBCT;
                    baocao.Thang = today.Month;
                    baocao.Nam = today.Year;
                    BC_TONVTPT_BUS.ThemBC(baocao);
                }

                string maCTBCT = CT_BC_VTPT_BUS.getMaCTBCT(maBCT, phuTung.MaVTPT);
                CT_BC_VTPT chitiet = new CT_BC_VTPT();

                chitiet.MaBCT = maBCT;
                chitiet.MaCTBC = maCTBCT;
                chitiet.MaVTPT = phuTung.MaVTPT;
                chitiet.TonCuoi = 0;
                chitiet.PhatSinh = int.Parse(txtSoLuong.Text) - soluong;
                chitiet.TonDau = 0;
                CT_BC_VTPT_BUS.capNhatPhatSinh(chitiet);

                //PHUTUNG_BUS.ThayDoiSoLuongPhuTung(phuTung);
            }
        }
    }
}
