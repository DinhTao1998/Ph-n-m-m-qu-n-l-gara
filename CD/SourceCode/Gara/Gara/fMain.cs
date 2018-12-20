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
    public partial class fMain : Form
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

        public fMain(TK tk)
        {
            this.TaiKhoanDangNhap = tk;
            InitializeComponent();
            ShowTaiKhoan();
            int m = DateTime.Now.Month;
            int y = DateTime.Now.Year;
            string x = string.Format("THÁNG {0}/{1}", m, y);
            list.DataSource = XeDAO.Instance.ListHome(m);
            lblThang.Text = x;
            if(TaiKhoanDangNhap.MaChucVu != 1)
            {
                ctrlMax.Enabled = false;
                ctrlQLTK.Enabled = false;
                ctrlHX.Enabled = false;
            }
        }

        void ShowTaiKhoan()
        {
            lblTen.Text = TaiKhoanDangNhap.TenHienThi;
            lblChucVu.Text = ChucVuDAO.Instance.GetTenChucVu(TaiKhoanDangNhap.MaChucVu).TenChucVu;
        }

        private void tiếpNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 f = new f1();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            int n = XeDAO.Instance.DemSoXe();
            int m = XeDAO.Instance.GetXeToiDa();
            if(n>m)
            {
                MessageBox.Show("Đã sửa chữa quá lượng xe quy định trong ngày!", "Thông báo");
                return;
            }
            f1 f = new f1();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất phiên làm việc?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3 f = new f3();
            f.Show();
        }

        private void traCứuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f3 f = new f3();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f2 f = new f2();
            f.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 f = new f2();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            f3 f = new f3();
            f.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int n = XeDAO.Instance.DemSoXe();
            int m = XeDAO.Instance.GetXeToiDa();
            if (n > m)
            {
                MessageBox.Show("Đã sửa chữa quá lượng xe quy định trong ngày!", "Thông báo");
                return;
            }
            f2 f = new f2();
            f.Show();
            
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }

        private void thayĐổiLượngXeTốiĐaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Max f = new Max();
            f.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTK f = new fTK(this.TaiKhoanDangNhap);
            f.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNV f = new fNV();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fHieuXe f = new fHieuXe();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmNhapVTPT f = new frmNhapVTPT();
            f.Show();
        }

        private void ctrlHX_Click(object sender, EventArgs e)
        {
            fHieuXe f = new fHieuXe();
            f.Show();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng tham khảo tài liệu hướng dẫn gởi kèm hoặc liên hệ trưởng nhóm xây dựng hệ thống để được trợ giúp!", "Thông báo");
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trưởng nhóm phát triển hệ thống: Phạm Phú Toàn. Điện thoại: 0965352985. Email: 16521260@gm.uit.edu.vn", "Thông tin liên hệ");
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapVTPT f = new frmNhapVTPT();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTienCong f = new FrmTienCong();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLapPhieuThu f = new FormLapPhieuThu();
            f.Show();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLapPhieuThu f = new FormLapPhieuThu();
            f.Show();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemVTPT f = new fThemVTPT();
            f.Show();
        }

        private void cậpNhậtĐơnGiáMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCapNhatVTPT f = new fCapNhatVTPT();
            f.Show(); 
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData.Equals(Keys.Control | Keys.A))
                btnThemXe.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.S))
                button3.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.H))
                button2.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.T))
                button4.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.L))
                button7.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.Q))
                button5.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.N))
                button6.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.B))
                button1.PerformClick();

            return base.ProcessDialogKey(keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBCDS f = new frmBCDS();
            f.Show();
        }

        private void báoCáoTồnVTPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBC_VTPT f = new frmBC_VTPT();
            f.Show();
        }
    }
}
