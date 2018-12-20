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

    public partial class fTK : Form
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

        public fTK(TK tk)
        {
            this.TaiKhoanDangNhap = tk;
            InitializeComponent();
            txtAcc.Text = tk.TenDangNhap.ToString();
            txtName.Text = tk.TenHienThi.ToString();
            txtChucVu.Text = ChucVuDAO.Instance.GetTenChucVu(TaiKhoanDangNhap.MaChucVu).TenChucVu;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            fTK_1 f = new fTK_1(this.TaiKhoanDangNhap,txtName.Text);
            f.ShowDialog();
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            fDoiMK f = new fDoiMK(this.TaiKhoanDangNhap);
            f.ShowDialog();
        }
    }
}
