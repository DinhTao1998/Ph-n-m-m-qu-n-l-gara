using Gara.DTO;
using Gara.DAO;
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
    public partial class fDoiMK : Form
    {

        private TK taiKhoanDangNhap;

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

        public fDoiMK(TK tk)
        {
            this.TaiKhoanDangNhap = tk;
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            if(txtMKMoi.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 3 ký tự!", "Thông báo");
                txtMKMoi.Text = null;
                txtXNMK.Text = null;
                txbPasswords.Text = null;
                return;
            }
            if(txtMKMoi.Text != txtXNMK.Text )
            {
                MessageBox.Show("Nhập lại mật khẩu sai!", "Thông báo");
                txtMKMoi.Text = null;
                txtXNMK.Text = null;
                txbPasswords.Text = null;
                return;
            }
            string tk = this.TaiKhoanDangNhap.TenDangNhap;
            string mk = txbPasswords.Text;
            if (Login(tk, mk))
            {
                TKDAO.Instance.UpdateMK(txtMKMoi.Text, tk);
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
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
    }
}
