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
    public partial class fCapNhatVTPT : Form
    {
        public fCapNhatVTPT()
        {
            InitializeComponent();
            comboBox1.DataSource = VTPTDAO.Instance.GetVTPT();
            comboBox1.DisplayMember = "TenVTPT";
            comboBox1.ValueMember = "MaVTPT";
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập đúng Đơn giá mới!", "Thông báo");
                return;
            }
            string a = comboBox1.Text;

            VTPTDAO.Instance.CapNhatDonGia(Int32.Parse(textBox1.Text),a);

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }
    }
}
