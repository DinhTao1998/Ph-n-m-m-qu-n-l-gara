using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara.DAO;
using Gara.DTO;
namespace Gara
{
    public partial class frmNhapVTPT : Form
    {
        public frmNhapVTPT()
        {
            InitializeComponent();
        }
        //Load mã vật tư phụ tùng từ CSDL lên dgvNhapVTPT
        private void MaVTPT_load()
        {
            DataTable dt = new DataTable();
            dt = PHIEUSUACHUA_DAO.LayMaVTPT();
            MaVTPT.DataSource = dt;
            MaVTPT.ValueMember = "MaVTPT";
            MaVTPT.DisplayMember = "TenVTPT";
        }
        private void dgv_Load()
        {
            if(dgvNhapVTPT.Rows.Count==1)
                dgvNhapVTPT.Rows[0].Cells[0].Value = "1";
            else
            {
                for (int i = 0; i < dgvNhapVTPT.Rows.Count - 1; i++)
                    dgvNhapVTPT.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void frmNhapVTPT_Load(object sender, EventArgs e)
        {
            MaVTPT_load();
            dgv_Load();
            btnSave.Enabled = false;
        }
        // sự kiện thay đổi dữ liệu trong dgvNhapVTPT
        private void dgvNhapVTPT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int TongTien = 0;// Thành tiền vật tư phụ tùng
            for (int i = 0; i < dgvNhapVTPT.Rows.Count - 1; i++)
            {
                dgvNhapVTPT.Rows[i].Cells[0].Value = i + 1;
                ////Lấy đơn giá tương ứng với vật tư phụ tùng
                DataTable dt = new DataTable();
                dt = PHIEUSUACHUA_DAO.LayThongTinVTPT("Where MaVTPT ='" + dgvNhapVTPT.Rows[i].Cells[1].Value.ToString() + "'");
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dgvNhapVTPT.Rows[i].Cells[1].Value.ToString() == dt.Rows[j]["MaVTPT"].ToString())
                    {
                        dgvNhapVTPT.Rows[i].Cells[2].Value = dt.Rows[j]["DonGia"].ToString();
                        break;
                    }
                }
                ////
                int dg = Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[2].Value);
                int sl = 0;
                int n = 0;
                //// Kiểm tra số lượng nhập vào có phải là kí số hay không
                if (dgvNhapVTPT.Rows[i].Cells[3].Value != null)
                {
                    if (int.TryParse(this.dgvNhapVTPT.Rows[i].Cells[3].Value.ToString(), out n))
                        sl = Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[3].Value);
                    else
                    {
                        if (dgvNhapVTPT.Rows[i].Cells[3].Value.ToString() != "")
                            MessageBox.Show("Số lượng phải là ký số");
                    }
                }
                ////
                int thanhtien = dg * sl;
                dgvNhapVTPT.Rows[i].Cells[4].Value = Convert.ToString(thanhtien);
                TongTien = TongTien + thanhtien;
            }
            txtTongTienNhap.Text = Convert.ToString(TongTien);
        }
        // sự kiện xóa 1 hàng trong dgvNhapVTPT
        private void dgvNhapVTPT_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int ChiPhiVTPT = 0;
            // tính lại tổng tiền nhập vtpt
            for (int i = 0; i < dgvNhapVTPT.Rows.Count - 1; i++)
            {
                ChiPhiVTPT = ChiPhiVTPT + Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[4].Value);
            }
            txtTongTienNhap.Text = Convert.ToString(ChiPhiVTPT);// truyền lại cho txtTongTienNhap
            dgv_Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu Phiếu nhập VTPT không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //gán thông tin Phiếu nhập cho đối tượng PHIEUNHAP_DTO
                PHIEUNHAP_DTO pn = new PHIEUNHAP_DTO(dtpNgayNhap.Value.Date, Convert.ToInt32(txtTongTienNhap.Text));
                PHIEUNHAP_DAO.ThemPhieuSuaChua(pn);// lưu phiếu nhập xuống csdl
                for (int i = 0; i < dgvNhapVTPT.Rows.Count - 1; i++)
                {
                    //// gán thông tin chi tiết phiếu nhập cho đối tượng CT_PHIEUNHAP_DTO
                    CT_PHIEUNHAP_DTO ct = new CT_PHIEUNHAP_DTO(Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[1].Value),
                                                               Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[2].Value),
                                                               Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[3].Value),
                                                               Convert.ToInt32(dgvNhapVTPT.Rows[i].Cells[4].Value));
                    CT_PHIEUNHAP_DAO.ThemCT_PhieuNhap(ct, pn);//lưu chi tiết phiếu nhập xuống csdl;
                }
                MessageBox.Show("Thêm thành công");
                dgvNhapVTPT.ReadOnly = true;

            }
        }

        private void txtTongTienNhap_TextChanged(object sender, EventArgs e)
        {
            if(dgvNhapVTPT.ReadOnly == false)
            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn tạo mới Phiếu Nhập VTPT không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                if (dgvNhapVTPT.Rows.Count > 1)
                {
                    while (1 < dgvNhapVTPT.Rows.Count)
                    {
                        dgvNhapVTPT.Rows.Remove(dgvNhapVTPT.Rows[0]);
                    }
                }
                btnSave.Enabled = false;
                dgvNhapVTPT.ReadOnly = false;
            }
        }
        // đóng form
        private void frmNhapVTPT_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đóng Phiếu nhập VTPT hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                this.Close(); ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData.Equals(Keys.Control | Keys.S))
                btnSave.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.N))
                btnNew.PerformClick();
            if (keyData.Equals(Keys.Alt | Keys.F4))
                btnExit.PerformClick();
            return base.ProcessDialogKey(keyData);
        }

        private void frmNhapVTPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chức năng Nhập vật tư phụ tùng?", "Thông báo", MessageBoxButtons.OKCancel)
               != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThemVTPT f = new fThemVTPT();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fCapNhatVTPT f = new fCapNhatVTPT();
            f.Show();
        }
    }
}
