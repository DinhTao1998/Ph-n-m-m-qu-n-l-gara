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
using System.Data.SqlClient;
using Gara.DTO;
namespace Gara
{
    public partial class FrmTienCong : Form
    {
        public FrmTienCong()
        {
            InitializeComponent();
        }
        // Sự kiện load dgv_TienCong
        private void dgv_load()
        {
            DataTable dt = new DataTable();
            dt = TIENCONG_DAO.LietKeTienCong();
            dgvTienCong.DataSource = dt;
            for(int i=0;i<dgvTienCong.Rows.Count-1;i++)
            {
                dgvTienCong.Rows[i].Cells[0].Value = i + 1;
            }
        }
        //Load form
        private void FrmTienCong_Load(object sender, EventArgs e)
        {
            dgvTienCong.AutoGenerateColumns = false;
            dgvTienCong.Columns[1].DataPropertyName = "MaTienCong";
            dgvTienCong.Columns[2].DataPropertyName = "TenTienCong";
            dgvTienCong.Columns[3].DataPropertyName = "TienCong";
            dgv_load();
            txtMaTienCong.ReadOnly = true;
            txtTenTienCong.ReadOnly = true;
            txtTienCong.ReadOnly = true;
            btnSave.Enabled = false;
            txtMaTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["MaTienCong"].Value);
            txtTenTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TenTienCong"].Value);
            txtTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TienCong"].Value);
            LoadDataToCollection();
        }
        // Sự kiện khi click vào 1 dòng trong dgv_TienCong
        int ChiMuc;
        private void dgvTienCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["MaTienCong"].Value);
            txtTenTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TenTienCong"].Value);
            txtTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TienCong"].Value);
            ChiMuc = e.RowIndex;
        }
        // Sự kiện nhấn nút thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dgvTienCong.Rows[dgvTienCong.Rows.Count-2].Cells["MaTienCong"].Value) + 1;
            txtMaTienCong.Text = Convert.ToString(ma);
            txtTenTienCong.ReadOnly = false;
            txtTenTienCong.Text = null;
            txtTienCong.ReadOnly = false;
            txtTienCong.Text = null;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        // sự kiện nhấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten;
            int tien;
            if (btnNew.Enabled || btnUpdate.Enabled)
            {
                if (txtTenTienCong.Text.ToString() == "")
                    MessageBox.Show("Chưa nhập tên tiền công");
                else
                    ten = Convert.ToString(txtTenTienCong.Text);
                if (txtTienCong.Text != null)
                {
                    int n = 0;
                    if (int.TryParse(this.txtTienCong.Text, out n))
                    {
                        tien = Convert.ToInt32(txtTienCong.Text);
                        TIENCONG_DTO tc = new TIENCONG_DTO(txtTenTienCong.Text, tien);
                        TIENCONG_DTO tc1 = new TIENCONG_DTO(Convert.ToInt32(txtMaTienCong.Text), txtTenTienCong.Text, tien);
                        if (btnNew.Enabled)
                        {
                            DialogResult dr;
                            dr = MessageBox.Show("Bạn có muốn thêm loại tiền công '" + txtTenTienCong.Text + "' hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                                TIENCONG_DAO.ThemTienCong(tc);
                            dgv_load();
                            dgvTienCong.CurrentCell = dgvTienCong.Rows[dgvTienCong.Rows.Count - 2].Cells[0];
                            dgvTienCong.CurrentRow.Selected = true;
                            txtMaTienCong.Text = Convert.ToString(dgvTienCong.Rows[dgvTienCong.Rows.Count -2].Cells["MaTienCong"].Value);
                            txtTenTienCong.Text = Convert.ToString(dgvTienCong.Rows[dgvTienCong.Rows.Count - 2].Cells["TenTienCong"].Value);
                            txtTienCong.Text = Convert.ToString(dgvTienCong.Rows[dgvTienCong.Rows.Count - 2].Cells["TienCong"].Value);
                        }
                        if (btnUpdate.Enabled)
                        {
                            DialogResult dr;
                            dr = MessageBox.Show("Bạn có muốn cập nhật loại tiền công '" + txtTenTienCong.Text + "' hay không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                                TIENCONG_DAO.CapNhatTienCong(tc1);
                            dgv_load();
                            dgvTienCong.CurrentCell = dgvTienCong.Rows[ChiMuc].Cells[0];
                            dgvTienCong.CurrentRow.Selected = true; 
                            txtMaTienCong.Text = Convert.ToString(dgvTienCong.Rows[ChiMuc].Cells["MaTienCong"].Value);
                            txtTenTienCong.Text = Convert.ToString(dgvTienCong.Rows[ChiMuc].Cells["TenTienCong"].Value);
                            txtTienCong.Text = Convert.ToString(dgvTienCong.Rows[ChiMuc].Cells["TienCong"].Value);
                        }
                    }
                    else
                    {
                        if (txtTienCong.Text.ToString() != "")
                            MessageBox.Show("Số tiền phải là ký số");
                    }
                }
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Enabled = true;
                txtMaTienCong.ReadOnly = true;
                txtTenTienCong.ReadOnly = true;
                txtTienCong.ReadOnly = true;
            }
        }
        //sự kiện thay đổi txtTienCong
        private void txtTienCong_TextChanged(object sender, EventArgs e)
        {
            if(txtTienCong.Text!=null)
            {
                int n = 0;
                if (int.TryParse(this.txtTienCong.Text, out n))
                { }
                else
                {
                    if (txtTienCong.Text.ToString() != "")
                        MessageBox.Show("Số tiền phải là ký số");
                }
            }
        }
        // sự kiện nhấn nút Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            txtMaTienCong.ReadOnly = true;
            txtTenTienCong.ReadOnly = false;
            txtTienCong.ReadOnly = false;
            txtMaTienCong.Text = null;
            txtTenTienCong.Text = null;
            txtTienCong.Text = null;
            //txtMaTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["MaTienCong"].Value);
            //txtTenTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TenTienCong"].Value);
            //txtTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TienCong"].Value);
            LoadDataToCollection();

        }
        // Quay về trạng thái mặc định ban đầu
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            dgv_load();
            txtMaTienCong.ReadOnly = true;
            txtTenTienCong.ReadOnly = true;
            txtTienCong.ReadOnly = true;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            txtMaTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["MaTienCong"].Value);
            txtTenTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TenTienCong"].Value);
            txtTienCong.Text = Convert.ToString(dgvTienCong.CurrentRow.Cells["TienCong"].Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
            if (keyData.Equals(Keys.Control | Keys.B))
                btnBack.PerformClick();
            if (keyData.Equals(Keys.Control | Keys.U))
                btnUpdate.PerformClick();
            return base.ProcessDialogKey(keyData);
        }
        // Chọn nhanh trong txtTenTienCOng
        private void LoadDataToCollection()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            string strConnection =KetNoi.Instance.conn;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            string sql = "Select  TenTienCong from TIENCONG ";
            SqlCommand com = new SqlCommand();

            com.Connection = conn;
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["TenTienCong"].ToString());
                }
            }

            txtTenTienCong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenTienCong.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenTienCong.AutoCompleteCustomSource = auto2;
        }

        private void txtTenTienCong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                for(int i =0; i<dgvTienCong.Rows.Count -1;i++)
                {
                    if(txtTenTienCong.Text == dgvTienCong.Rows[i].Cells["TenTienCong"].Value.ToString())
                    {
                        txtMaTienCong.Text = dgvTienCong.Rows[i].Cells["MaTienCong"].Value.ToString();
                        txtTienCong.Text = dgvTienCong.Rows[i].Cells["TienCong"].Value.ToString();
                        dgvTienCong.CurrentCell = dgvTienCong.Rows[i].Cells["TenTienCong"];
                        dgvTienCong.CurrentRow.Selected = true;
                    }
                }
            }
        }

        private void FrmTienCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chức năng Thay đồi tiền công hay không ?", "Thông báo", MessageBoxButtons.OKCancel)
               != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
