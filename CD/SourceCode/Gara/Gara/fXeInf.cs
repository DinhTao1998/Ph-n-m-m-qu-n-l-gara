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
    public partial class fXeInf : Form
    {
        private Xe xeDangChon;

        public Xe XeDangChon
        {
            get
            {
                return xeDangChon;
            }

            set
            {
                xeDangChon = value;
            }
        }

        public fXeInf(Xe x)
        {
            this.XeDangChon = x;
            InitializeComponent();
            LoadHieuXe();
            ShowXeInf();
        }

        
        void LoadHieuXe()
        {
            List<HieuXe> list = new List<HieuXe> { };
            list = HieuXeDAO.Instance.GetListHieuXe();
            cbbHieuXe.DataSource = list;
            cbbHieuXe.DisplayMember = "TenHieuXe";



            int id = XeDangChon.MaHieuXe;

            HieuXe h = HieuXeDAO.Instance.GetHieuXeByMaHieuXe(id);


            int index = -1;
            int i = 0;
            foreach (HieuXe item in cbbHieuXe.Items)
            {
                if (item.MaHieuXe == h.MaHieuXe)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbbHieuXe.SelectedIndex = index;
        }

        void ShowXeInf()
        {
            txtBienSo.Text = XeDangChon.BienSo;
            txtMaXe.Text = XeDangChon.MaXe.ToString();
            txtChuXe.Text = XeDangChon.TenChuXe;
            txtDiaChi.Text = XeDangChon.DiaChi;
            txtDienThoai.Text = XeDangChon.DienThoai;
            txtTienNo.Text = XeDangChon.TienNo.ToString();
            dtpNgay.Text = XeDangChon.NgayTiepNhan;
            txbEmail.Text = XeDangChon.Email;
            string query = string.Format("SELECT MaPhieuThu AS [Mã], NgayThuTien AS [Ngày], SoTienThu as [Số tiền thu] FROM PHIEUTHU WHERE MaXe = N'{0}'", XeDangChon.MaXe);
            dtgvXe.DataSource = DataProvider.Instance.ExecuteQuery(query);
            string query2 = string.Format("SELECT MaPhieuSC as [Mã], NgaySuaChua as [Ngày], SoTienThu as [Số tiền thu]  FROM PHIEUSUACHUA WHERE MaXe = N'{0}'", XeDangChon.MaXe);
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int MaXe = XeDangChon.MaXe;
            int MaHieuXe = (cbbHieuXe.SelectedItem as HieuXe).MaHieuXe;
            string NgayTiepNhan = dtpNgay.Text;
            string ChuXe = txtChuXe.Text;
            string DiaChi = txtDiaChi.Text;
            string DienThoai = txtDienThoai.Text;
            string Email = txbEmail.Text;
            if(dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày tiếp nhận không hợp lệ!", "Thông báo");
                return;
            }
            if (XeDAO.Instance.SuaXe(MaXe, MaHieuXe, NgayTiepNhan, ChuXe, DiaChi, DienThoai, Email))
            {
                MessageBox.Show("Cập nhật thông tin xe thành công", "Thông báo");

            }
            else
                MessageBox.Show("Cập nhật thông tin xe KHÔNG thành công", "Thông báo");


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fXeInf_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 f = new f3();
            f.Show();
        }

        private void dtgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
