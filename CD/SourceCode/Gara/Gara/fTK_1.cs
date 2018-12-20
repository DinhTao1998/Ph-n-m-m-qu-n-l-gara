using Gara.DAO;
using Gara.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gara
{
    public partial class fTK_1 : Form
    {

        private TK taiKhoanDangNhap;

        private string TenHienThiMoi;

        public TK TaiKhoanDangNhap
        {
            get
            {
                return taiKhoanDangNhap;
            }

            set
            {
                taiKhoanDangNhap = value;
            }
        }

        public fTK_1(TK tk,string TenMoi)
        {
            this.TenHienThiMoi = TenMoi;
            this.TaiKhoanDangNhap = tk;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
            fTK f = new fTK(this.TaiKhoanDangNhap);
            f.Show();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string tk = this.TaiKhoanDangNhap.TenDangNhap;
            string mk = txbPasswords.Text;
            if (Login(tk, mk))
            {
                TKDAO.Instance.UpdateTen(this.TenHienThiMoi, tk);
                this.TaiKhoanDangNhap.TenHienThi = TenHienThiMoi;
                fTK f = new fTK(this.TaiKhoanDangNhap);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
            }
        }

        bool Login(string tk, string mk)
        {
            return TKDAO.Instance.Login(tk, mk);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
