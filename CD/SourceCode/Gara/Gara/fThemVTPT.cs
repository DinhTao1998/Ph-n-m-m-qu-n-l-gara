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
    public partial class fThemVTPT : Form
    {
        public fThemVTPT()
        {
            InitializeComponent();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if(txtName.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập đúng tên VTPT!", "Thông báo");
                return;
            }

            if(numGia.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập đúng Đơn giá!", "Thông báo");
                return;
            }

            if (VTPTDAO.Instance.ThemVTPT(txtName.Text,0,Int32.Parse(numGia.Value.ToString())))
            {
                MessageBox.Show("Thêm thành công VTPT mới!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm VTPT mới!", "Thông báo");
            }
        }

        private void bttExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
