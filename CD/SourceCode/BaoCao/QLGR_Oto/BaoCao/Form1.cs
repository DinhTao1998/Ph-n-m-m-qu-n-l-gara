using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BaoCao.DAO;

namespace BaoCao
{
    public partial class frmBaoCaoDoanhSo : Form
    {
        public frmBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);

            cboThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void LoadDL_DGV()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LOAD_DGV_BCDS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", Convert.ToInt32(cboThang.Text));
            cmd.Parameters.AddWithValue("@NAM", Convert.ToInt32(txtNam.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new System.Data.DataTable();
            da.Fill(db.dt);
            dgvBCDS.DataSource = db.dt;
        }

        private void LoadDL_TDT()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LOAD_TDT_BCDS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", Convert.ToInt32(cboThang.Text));
            cmd.Parameters.AddWithValue("@NAM", Convert.ToInt32(txtNam.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new System.Data.DataTable();
            da.Fill(db.dt);
            txtTongDoanhThu.DataBindings.Add("Text", db.dt, "TongDoanhThu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thoát màn hình báo cáo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            LoadDL_DGV();
            LoadDL_TDT();
        }

        private void txtTongDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
