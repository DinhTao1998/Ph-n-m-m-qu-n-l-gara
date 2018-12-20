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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Thoát màn hình báo cáo?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
