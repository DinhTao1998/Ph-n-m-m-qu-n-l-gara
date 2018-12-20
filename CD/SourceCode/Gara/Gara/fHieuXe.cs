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
    public partial class fHieuXe : Form
    {
        BindingSource DSHX = new BindingSource();
        public fHieuXe()
        {
            InitializeComponent();
            LoadHieuXe();
            dtgv.DataSource = DSHX;
            ADDHXBD();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadHieuXe()
        {
            DSHX.DataSource = HieuXeDAO.Instance.GetTableHX();
        }

        void ADDHXBD()
        {
            txtMa.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txtQG.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Quốc gia", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.Never));
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtMa.Text = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtMa.Text = null;
            txtName.Text = null;
            txtQG.Text = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên hiệu xe!", "Thông báo");
                return;
            }
            if (HieuXeDAO.Instance.SoSanhHieuXe(txtName.Text))
            {
                MessageBox.Show("Hiệu xe đã có trong danh sách.", "Thông báo");
                return;
            }
            HieuXeDAO.Instance.ThemHX(txtName.Text, txtQG.Text);
            MessageBox.Show("Thêm hiệu xe thành công.", "Thông báo");
            LoadHieuXe();
        }
    }
}
