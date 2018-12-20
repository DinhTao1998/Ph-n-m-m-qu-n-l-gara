using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao
{
    public partial class frmNhapVTPT : Form
    {
        TextBox txtSoLuong;

        public frmNhapVTPT(TextBox _txtSL)
        {
            InitializeComponent();
            txtSoLuong = _txtSL;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text);
            soLuong += int.Parse(txtSL.Text);
            txtSoLuong.Text = soLuong.ToString();
            MessageBox.Show("Nhập thành công!", "Thông báo");
            this.Close();
        }
    }
}
