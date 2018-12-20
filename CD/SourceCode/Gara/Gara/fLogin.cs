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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string tk = txbUser.Text;
            string mk = txbPasswords.Text;
            if(Login(tk,mk))
            {
                txbUser.Text = null;
                txbPasswords.Text = null;
                TK TaiKhoanDangNhap = TKDAO.Instance.GetTaiKhoan(tk);
                fMain f = new fMain(TaiKhoanDangNhap);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }

        bool Login(string tk,string mk)
        {
            return TKDAO.Instance.Login(tk, mk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ Giám đốc để được cấp lại mật khẩu!","Thông báo");
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
