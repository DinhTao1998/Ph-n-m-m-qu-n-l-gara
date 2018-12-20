using Gara.DAO;
using Gara.DTO;
using System;
using System.Text.RegularExpressions;
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

    public partial class FormLapPhieuThu : Form
    {
        public FormLapPhieuThu()
        {
            InitializeComponent();
            cbbMaXe.DataSource = XeDAO.Instance.GetListXe();
            cbbMaXe.DisplayMember = "Mã xe";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMaXe(cbbMaXe);
          
        }

        void LoadMaXe(ComboBox cb)
        {
            cb.DataSource = XeDAO.Instance.GetListXe();
            cb.DisplayMember = "Mã xe";
            cb.ValueMember = "Mã xe";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbbMaXe.Text = "";
            txtBienSo.Text = "";
            txtTenChuXe.Text = "";
            txtTienDua.Text = "0";
            txtTienThu.Text = "0";
            txtTienThoi.Text = "0";
            txtNoCu.Text = "0";
            txtNoConLai.Text = "0";
            dtpNgayThuTien.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTienThoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn thoát Màn hình lập phiếu thu tiền không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(lenh==DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Sự kiện thay đổi giá trị của txtTienDua
        private void txtTienDua_TextChanged(object sender, EventArgs e)
        {

            if (txtTienDua.Text != "" && IsNumber(txtTienDua.Text))
            {                
                int tienno = int.Parse(txtNoCu.Text);
                int tiendua = int.Parse(txtTienDua.Text);
                int tienthu = int.Parse(txtTienThu.Text);

                int tienthoi = tiendua - tienthu;
                txtTienThoi.Text = tienthoi.ToString();

                int noconlai = tienno - tienthu;
                txtNoConLai.Text = noconlai.ToString();
            }           
        }

        //Hàm kiểm tra giá trị có phải là số hay không
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        //Sự kiện thay đổi giá trị của txtTienThu
        private void txtTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThu.Text != ""&& IsNumber(txtTienThu.Text))
            {
                int tienno = int.Parse(txtNoCu.Text);
                int tiendua = int.Parse(txtTienDua.Text);
                int tienthu = int.Parse(txtTienThu.Text);
                if (tienthu > tienno)
                {
                    MessageBox.Show("Số tiền thu vượt quá số tiền nợ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTienThu.Text = "0";
                }
                else
                {
                    if(tiendua < tienthu)
                    {
                        int tienthoi = 0;
                        txtTienThoi.Text = tienthoi.ToString();
                    }
                    else
                    {
                        int tienthoi = tiendua - tienthu;
                        txtTienThoi.Text = tienthoi.ToString();

                        int noconlai = tienno - tienthu;
                        txtNoConLai.Text = noconlai.ToString();             
                  
                    }
                }
            }
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            int mx = Convert.ToInt32(cbbMaXe.SelectedValue);
            DateTime ntt = dtpNgayThuTien.Value.Date;
            if (IsNumber(txtTienThu.Text) && txtTienThu.Text != "" && txtTienDua.Text != "" && IsNumber(txtTienDua.Text))
            {
                int stt = Convert.ToInt32(txtTienThu.Text);

                int tienno = Convert.ToInt32(txtNoCu.Text);
                int tienthu = Convert.ToInt32(txtTienThu.Text);
                if (tienthu > tienno)
                {
                    MessageBox.Show("Số tiền thu lớn hơn số tiền nợ, vui lòng nhập lại!", "Thông báo");
                    return;
                }
                if (dtpNgayThuTien.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày tiếp nhận chưa hợp lệ!", "Thông báo");
                    return;
                }
                PhieuThuDAO.ThemPhieuThu(mx,dtpNgayThuTien.Text,stt);
            }
            else
            {
                MessageBox.Show("Tiền thu hoặc tiền đưa không hợp lệ, vui lòng nhập lại!", "Thông báo");
            }
        }

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadBienSo(txtBienSo);
            LoadTenChuXe(txtTenChuXe);
            LoadTienNo(txtNoCu);            
        }

        void LoadBienSo(TextBox txt)
        {
            txtBienSo.DataBindings.Clear();
            txtBienSo.DataBindings.Add("Text", cbbMaXe.DataSource, "Biển số");
        }

        void LoadTenChuXe(TextBox txt)
        {
            txtTenChuXe.DataBindings.Clear();
            txtTenChuXe.DataBindings.Add("Text", cbbMaXe.DataSource, "Tên chủ xe");
        }

        void LoadTienNo(TextBox txt)
        {
            txtNoCu.DataBindings.Clear();
            txtNoCu.DataBindings.Add("Text", cbbMaXe.DataSource, "Tiền nợ");
        }

        private void txtNoConLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
