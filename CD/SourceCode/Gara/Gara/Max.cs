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
    public partial class Max : Form
    {
        public Max()
        {
            InitializeComponent();
            txtMax.Text = XeDAO.Instance.GetXeToiDa().ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int x;
            if(Int32.TryParse(txtMax.Text,out x) == false)
            {
                MessageBox.Show("Vui lòng nhập chính xác số xe sửa chữa tối đa trong ngày.", "Thông báo");
                return;
            }

            if (Int32.Parse(txtMax.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập chính xác số xe sửa chữa tối đa trong ngày.", "Thông báo");
                return;
            }

            if (XeDAO.Instance.ThayDoiXeToiDa(Int32.Parse(txtMax.Text)))
                MessageBox.Show("Thay đổi số xe sửa chữa tối đa trong ngày thành công.", "Thông báo");
            else
                MessageBox.Show("Có lỗi trong quá trình thay đổi.", "Thông báo");
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMax.Text = XeDAO.Instance.GetXeToiDa().ToString();
        }
    }
}
