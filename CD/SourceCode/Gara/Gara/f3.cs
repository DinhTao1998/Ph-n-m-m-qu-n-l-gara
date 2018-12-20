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
    public partial class f3 : Form
    {
        //BindingSource DSXe = new BindingSource();

        public f3()
        {
            InitializeComponent();
            //dtgvXe.DataSource = DSXe;
            //LoadXe();
            //AddXeBindding();
            LoadHieuXe(cbbHieuXe);
            
        }

        public object DataProvide { get; private set; }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f3_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        //void LoadXe()
        //{
        //    DSXe.DataSource = XeDAO.Instance.GetListXe();
        //}

        //void AddXeBindding()
        //{
        //    txbBienSo.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Biển số",true,DataSourceUpdateMode.Never));
        //    txbChuXe.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Tên chủ xe", true, DataSourceUpdateMode.Never));
        //    txbMaXe.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Mã xe", true, DataSourceUpdateMode.Never));
        //    numNoDau.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Tiền nợ", true, DataSourceUpdateMode.Never));
        //    dtpNgay.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Ngày tiếp nhận", true, DataSourceUpdateMode.Never));
        //    txbDienThoai.DataBindings.Add(new Binding("Text", dtgvXe.DataSource, "Điện thoại", true, DataSourceUpdateMode.Never));
        //}

        void LoadHieuXe(ComboBox cb)
        {
            cb.DataSource = HieuXeDAO.Instance.GetListHieuXe();
            cb.DisplayMember = "TenHieuXe";
            cb.SelectedIndex = -1;
        }

        private void dtgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void txbMaXe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvXe.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvXe.SelectedCells[0].OwningRow.Cells["Mã hiệu xe"].Value;

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
            }
            catch { }
            try
            {
                DataTable dt = new DataTable();
                dt = XeDAO.Instance.GetXeByMaXe(Int32.Parse(txbMaXe.Text));
                dtgvXe.DataSource = dt;
            }
            catch { }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dtgvXe.RowCount < 1)
            {
                MessageBox.Show("Vui lòng xác định xe cần xem thông tin!!!", "Thông báo");
                return;
            }
            string MaXe;
                MaXe = dtgvXe.Rows[0].Cells[0].Value.ToString();
            try
            {
                MaXe = dtgvXe.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch { }
            DataTable XeChon = XeDAO.Instance.GetXeByMaXe(Int32.Parse(MaXe));
            Xe XeDangChon = null;
            foreach (DataRow item in XeChon.Rows)
            {
                XeDangChon = new Xe(item);
            }
            fXeInf f = new fXeInf(XeDangChon);
            this.Close();
            f.Show();
        }

        private void bttExit_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chức năng Tra cứu xe?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbBienSo_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeByBienSo(txbBienSo.Text);
            //dtgvXe.DataSource = dt;
        }

        private void cbbHieuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

            TimKiem();
            //try
            //{
            //    int mhx = (cbbHieuXe.SelectedItem as HieuXe).MaHieuXe;
            //    DataTable dt = new DataTable();
            //    dt = XeDAO.Instance.GetXeByMaHieuXe(mhx);
            //    dtgvXe.DataSource = dt;
            //}
            //catch { }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            dtpNgay.Format = DateTimePickerFormat.Short;
            TimKiem();
            //string ntn = dtpNgay.Text;
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeByNgayTiepNhan(ntn);
            //dtgvXe.DataSource = dt;
        }

        private void txbChuXe_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            //string ntn = txbChuXe.Text;
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeByTenChuXe(ntn);
            //dtgvXe.DataSource = dt;
        }

        private void txbDienThoai_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
            //string ntn = txbDienThoai.Text;
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeBySoDienThoai(ntn);
            //dtgvXe.DataSource = dt;
        }

        private void numNoDau_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
            //int ntn = Int32.Parse(numNoDau.Value.ToString());
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeByNoDau(ntn);
            //dtgvXe.DataSource = dt;
        }

        private void numNoCuoi_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
            //int ntn = Int32.Parse(numNoCuoi.Value.ToString());
            //DataTable dt = new DataTable();
            //dt = XeDAO.Instance.GetXeByNoCuoi(ntn);
            //dtgvXe.DataSource = dt;
        }

        private void TimKiem()
        {
            DataTable kq = new DataTable();
            string mx;
            if (txbMaXe.Text == null)
                mx = "%";
            else
                mx = txbMaXe.Text;


            string bs;
            if (txbBienSo.Text == null)
                bs = "%";
            else
                bs = txbBienSo.Text;

            string mhx;
            if (cbbHieuXe.SelectedIndex == -1)
                mhx = "%";
            else
                mhx = (cbbHieuXe.SelectedItem as HieuXe).MaHieuXe.ToString();

            string tcx;
            if (txbChuXe.Text == null)
                tcx = "%";
            else
                tcx = txbChuXe.Text;

            string dt;
            if (txbDienThoai == null)
                dt = "%";
            else
                dt = txbDienThoai.Text;

            string ntn;
            if (dtpNgay.Text.Length < 4)
            {
                kq = XeDAO.Instance.GetXeByGR2(mx, bs, mhx, tcx, dt,Int32.Parse(numNoDau.Value.ToString()),Int32.Parse(numNoCuoi.Value.ToString()));
                dtgvXe.DataSource = kq;
                return;
            }
            else ntn = dtpNgay.Text;
            
            kq = XeDAO.Instance.GetXeByGR1(mx, bs, mhx, tcx, dt, ntn, Int32.Parse(numNoDau.Value.ToString()), Int32.Parse(numNoCuoi.Value.ToString()));

            dtgvXe.DataSource = kq;
        }

        private void txbMaXe_TextChanged_1(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            f3 f = new f3();
            f.ShowDialog();
        }
    }
}
