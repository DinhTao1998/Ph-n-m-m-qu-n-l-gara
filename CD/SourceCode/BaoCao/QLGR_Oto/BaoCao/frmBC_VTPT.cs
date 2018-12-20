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
    public partial class frmBC_VTPT : Form
    {
        public frmBC_VTPT()
        {
            InitializeComponent();
        }

        private void frmBC_VTPT_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);

            cboThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void LoadDL()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LOAD_DGV_BCVTPT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", Convert.ToInt32(cboThang.Text));
            cmd.Parameters.AddWithValue("@NAM", Convert.ToInt32(txtNam.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new System.Data.DataTable();
            da.Fill(db.dt);
            dgvBC_VTPT.DataSource = db.dt;
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thoát màn hình báo cáo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
