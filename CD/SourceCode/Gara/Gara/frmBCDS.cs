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
    public partial class frmBCDS : Form
    {
        public frmBCDS()
        {
            InitializeComponent();
        }

        private void frmBCDS_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);

            cboThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thoát màn hình báo cáo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = PHIEUSUACHUA_DAO.GetHieuXe();
            //dgvBCDS.DataSource = dt;
            ////for(int i=0; i < dt.Rows.Count - 1; i++)
            ////{
            ////    dgvBCDS.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
            ////}
        }
    }
}
