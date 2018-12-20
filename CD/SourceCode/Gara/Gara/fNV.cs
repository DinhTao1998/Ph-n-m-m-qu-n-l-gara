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
    public partial class fNV : Form
    {
        BindingSource DSTK = new BindingSource();
        public fNV()
        {
            InitializeComponent();
            dtgv.DataSource = DSTK;
            LoadTK();
            AddTKBinding();
            LoadHX();
        }

        void LoadTK()
        {
            DSTK.DataSource = TKDAO.Instance.GetListTK();
        }

        void AddTKBinding()
        {
            txtTK.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Tài khoản", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Tên", true, DataSourceUpdateMode.Never));
        }

        void LoadHX()
        {
            cbbCV.DataSource = ChucVuDAO.Instance.GetListCV();
            cbbCV.DisplayMember = "TenChucVu";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TKDAO.Instance.SoSanhTK(txtTK.Text))
            {
                MessageBox.Show("Tên tên đăng nhập đã tồn tại.", "Thông báo");
                return;
            }
            if(txtTK.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo");
                return;
            }
            TKDAO.Instance.ThemNV(txtTK.Text, txtName.Text, (cbbCV.SelectedItem as ChucVu).MaChucVu);
            MessageBox.Show("Thêm nhân viên thành công. Mật khẩu ban đầu là '1' ", "Thông báo");
            LoadTK();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
           
                if (dtgv.SelectedCells.Count > 0)
                {
                    int id = (int)dtgv.SelectedCells[0].OwningRow.Cells["Chức vụ"].Value;

                    ChucVu h = ChucVuDAO.Instance.GetTenChucVu(id);


                    int index = -1;
                    int i = 0;
                    foreach (ChucVu item in cbbCV.Items)
                    {
                        if (item.MaChucVu == h.MaChucVu)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbbCV.SelectedIndex = index;
                }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TKDAO.Instance.ResetMK(txtTK.Text);
            MessageBox.Show("Mật khẩu đã được reset lại thành '1'", "Thông báo");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (TKDAO.Instance.SoSanhTK(txtTK.Text) == false)
            {
                MessageBox.Show("Cập nhật không thành công (Tài khoản trên không tồn tại).", "Thông báo");
                return;
            }
            TKDAO.Instance.UpdateTen(txtName.Text, txtTK.Text);
            TKDAO.Instance.UpdateCV((cbbCV.SelectedItem as ChucVu).MaChucVu, txtTK.Text);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            LoadTK();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTK.Text = null;
            txtName.Text = null;
        }
    }
}
