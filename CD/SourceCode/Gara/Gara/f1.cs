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
    public partial class f1 : Form
    {
        public f1()
        {
            InitializeComponent();
        }
        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chức năng Tiếp nhận bảo trì xe?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnPSC_Click(object sender, EventArgs e)
        {
            f2 f = new f2();
            this.Close();
            f.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bs = txtBienSo.Text;
            int hx = (cbbHieuXe.SelectedItem as HieuXe).MaHieuXe;
            string ntn = dtpNgay.Text;
            string cx = txtChuXe.Text;
            string dc = txtDiaChi.Text;
            string dt = txtDienThoai.Text;
            string em = txtEmail.Text;

            if (XeDAO.Instance.SoSanhBienSo(bs))
            {
                MessageBox.Show("Biển số xe trên đã được tiếp nhận trước đó.", "Thông báo");
                return;
            }
            if(bs.Length<8)
            {
                MessageBox.Show("Biển số xe chưa hợp lệ!", "Thông báo");
                return;
            }
            if(dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày tiếp nhận chưa hợp lệ!", "Thông báo");
                return;
            }
            if (XeDAO.Instance.ThemXe(bs,hx,ntn,cx,dc,dt,em))
            {
                MessageBox.Show("Tiếp nhận xe mới thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi tiếp nhận xe mới!", "Thông báo");
            }
        }

        private void f1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garaDataSet.HIEUXE' table. You can move, or remove it, as needed.
            LoadHieuXe(cbbHieuXe);
        }

        void LoadHieuXe(ComboBox cb)
        {
            cb.DataSource = HieuXeDAO.Instance.GetListHieuXe();
            cb.DisplayMember = "TenHieuXe";
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            f3 f = new f3();
            f.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBienSo.Text = null;
            txtChuXe.Text = null;
            txtDiaChi.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            dtpNgay.Value = DateTime.Now;
        }
    }
}
