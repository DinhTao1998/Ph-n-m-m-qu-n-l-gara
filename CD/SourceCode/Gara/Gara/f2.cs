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
    public partial class f2 : Form
    {
        public f2()
        {
            InitializeComponent();
        }
        //Lấy danh sách mã xe và biển số xe tương ứng trong co sở dữ liệu lên cbbMaXe và txtBienSo
        private void MaXe_Load()
        {
            DataTable dt = new DataTable();
            dt = PHIEUSUACHUA_DAO.LayMaXe();
            cbbMaXe.DataSource = dt;
            cbbMaXe.ValueMember = "MaXe";
            cbbMaXe.DisplayMember = "MaXe";
            txtBienSo.DataBindings.Add("TEXT", cbbMaXe.DataSource, "BienSo");
        }
        //Lấy danh sách tên tiền công và mã tiền công tương ứng trong CSDL vào trong dgvPhieuSuaChua
        private void MaTienCong_Load()
        {
            DataTable dt = new DataTable();
            dt = PHIEUSUACHUA_DAO.LayMaTienCong();
             TenTienCong.DataSource = dt;
            TenTienCong.ValueMember = "MaTienCong";
            TenTienCong.DisplayMember = "TenTienCong";
        }
        //Lấy danh sách vật tư phụ tùng trong CSDL vào dgvCT_SuDungVTPT
        private void MaVTPT_Load()
        {
            DataTable dt = new DataTable();
            dt = PHIEUSUACHUA_DAO.LayMaVTPT();
            TenVTPT.DataSource = dt;
            TenVTPT.ValueMember = "TenVTPT";
            TenVTPT.DisplayMember = "TenVTPT";
        }
        private void Dgv_Load()
        {
            dgvCT_SDVTPT.Rows[0].Cells[0].Value = "1";
            dgvPhieuSuaChua.Rows[0].Cells[0].Value = "1";
        }
        private void dgvCT_load()
        {
            if (dgvPhieuSuaChua.Rows.Count > 1)
                for (int i = 0; i < dgvPhieuSuaChua.Rows.Count; i++)
                    dgvPhieuSuaChua.Rows[i].Cells[0].Value = i + 1;
        }
        private void dgvVTPT_load()
        {
            if (dgvCT_SDVTPT.Rows.Count > 1)
                for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                    dgvCT_SDVTPT.Rows[i].Cells[0].Value = i + 1;
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chức năng Lập phiếu sửa chữa?", "Thông báo", MessageBoxButtons.OKCancel)
               != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void f2_Load(object sender, EventArgs e)
        {
            MaXe_Load();
            MaTienCong_Load();
            MaVTPT_Load();
            Dgv_Load();
            btnSave.Enabled = false;

        }
        //Sự kiện khi thay đổi giá trị trong dgvPhieuSuaChua
        private void dgvPhieuSuaChua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int TongTien = 0;//Tổng phí sửa chữa của phiếu sửa chữa
            for (int i = 0; i < dgvPhieuSuaChua.Rows.Count - 1; i++)
            {
                dgvPhieuSuaChua.Rows[i].Cells[0].Value = i + 1;
                if (dgvPhieuSuaChua.Rows[i].Cells[2].Value != null)
                {
                    //// Lấy Tiền công cho Mã Tiền công tương ứng
                    DataTable dt = new DataTable();
                    dt = PHIEUSUACHUA_DAO.LayTienCong("Where MaTienCong ='" + dgvPhieuSuaChua.Rows[i].Cells[2].Value.ToString() + "'");
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dgvPhieuSuaChua.Rows[i].Cells[2].Value.ToString() == dt.Rows[j]["MaTienCong"].ToString())
                        {
                            dgvPhieuSuaChua.Rows[i].Cells[3].Value = dt.Rows[j]["TienCong"].ToString();
                            break;
                        }
                    }
                    ////
                    int dg = Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[3].Value);
                    int sl = 0;
                    int n = 0;
                    //// Kiểm tra số lượng nhâp vào có phải kí số hay không
                    if (dgvPhieuSuaChua.Rows[i].Cells[4].Value != null)
                    {
                        if (int.TryParse(this.dgvPhieuSuaChua.Rows[i].Cells[4].Value.ToString(), out n))
                            sl = Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[4].Value);
                        else
                        {
                            MessageBox.Show("Số lần phải là ký số");

                        }
                    }
                    int thanhtien = dg * sl;
                    dgvPhieuSuaChua.Rows[i].Cells[5].Value = Convert.ToString(thanhtien);
                    dgvPhieuSuaChua.Rows[i].Cells[7].Value = thanhtien + Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[6].Value);
                    TongTien = TongTien + thanhtien + Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[6].Value);
                }
            }
            txtChiPhiSuaChua.Text = Convert.ToString(TongTien);
        }
        //Sự kiện click vào cells trong dgvPhieuSuaChua
        int ChiMuc;// lấy chỉ mục của cellclick trong dgvPhieuSuaChua
        private void dgvPhieuSuaChua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiMuc = e.RowIndex;
        }
        //Truyền dữ liệu từ dgvCT_SDVTPT sang dgvPhieuSuaChua
        private void LayDuLieu(string dulieu, int row)
        {
            if (dgvPhieuSuaChua.Rows.Count > 1)
            {
                dgvPhieuSuaChua.Rows[row].Cells[6].Value = dulieu;
            }
        }
        //Sự kiện thay đổi giá trị trong Dgv_CTSDVTPT
        private void dgvCT_SDVTPT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int TongTien = 0;// Thành tiền vật tư phụ tùng
            for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
            {
                ////Lấy đơn giá tương ứng với vật tư phụ tùng
                dgvCT_SDVTPT.Rows[i].Cells[0].Value = i + 1;
                DataTable dt = new DataTable();
                dt = PHIEUSUACHUA_DAO.LayThongTinVTPT("Where TenVTPT ='" + dgvCT_SDVTPT.Rows[i].Cells[1].Value.ToString() + "'");
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dgvCT_SDVTPT.Rows[i].Cells[1].Value.ToString() == dt.Rows[j]["TenVTPT"].ToString())
                    {
                        dgvCT_SDVTPT.Rows[i].Cells[2].Value = dt.Rows[j]["DonGia"].ToString();
                        dgvCT_SDVTPT.Rows[i].Cells[5].Value = dt.Rows[j]["MaVTPT"].ToString();
                        break;
                    }
                }
                ////
                int dg = Convert.ToInt32(dgvCT_SDVTPT.Rows[i].Cells[2].Value);
                int sl = 0;
                int n = 0;
                //// Kiểm tra số lượng nhập vào có phải là kí số hay không
                if (dgvCT_SDVTPT.Rows[i].Cells[3].Value != null)
                {
                    if (int.TryParse(this.dgvCT_SDVTPT.Rows[i].Cells[3].Value.ToString(), out n))
                        sl = Convert.ToInt32(dgvCT_SDVTPT.Rows[i].Cells[3].Value);
                    else
                    {
                        if (dgvCT_SDVTPT.Rows[i].Cells[3].Value.ToString() != "")
                            MessageBox.Show("Số lượng phải là ký số");
                    }
                }
                ////
                int thanhtien = dg * sl;
                dgvCT_SDVTPT.Rows[i].Cells[4].Value = Convert.ToString(thanhtien);
                TongTien = TongTien + thanhtien;
            }
            txtTongTienVTPT.Text = Convert.ToString(TongTien);
            LayDuLieu(txtTongTienVTPT.Text, ChiMuc);// Truyền dữ liệu từ dgvCT_SDVTPT sang dgvPhieuSuaChua
        }
        // Sự kiện thay đổi giá trị của txtSoTienThu
        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienThu.Text != null)
            {
                int n = 0;
                if (int.TryParse(this.txtSoTienThu.Text, out n))
                {
                    int ChiPhiSuaChua = int.Parse(txtChiPhiSuaChua.Text);
                    int SoTienThu = int.Parse(txtSoTienThu.Text);
                    //Kiểm tra số tiền thu có bé hơn hoặc bằng Chi Phí sửa chữa hay không
                    if (SoTienThu <= ChiPhiSuaChua)
                    {
                        int ConLai = ChiPhiSuaChua - SoTienThu;
                        txtConLai.Text = Convert.ToString(ConLai);
                    }
                    else
                        MessageBox.Show("Nhập số tiền thu không hợp lệ, số tiền thu phải nhỏ hơn chi phí sửa chữa");
                }
                else
                {
                    if (txtSoTienThu.Text != "")
                        MessageBox.Show("Số tiền phải là ký số");
                }
            }
        }
        // Sự kiện thay đổi giá trị của txtChiPhiSuaChua
        private void txtChiPhiSuaChua_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienThu.Text != "" && dgvPhieuSuaChua.ReadOnly == false)
            {
                int ChiPhiSuaChua = int.Parse(txtChiPhiSuaChua.Text);
                int SoTienThu = int.Parse(txtSoTienThu.Text);
                int ConLai = ChiPhiSuaChua - SoTienThu;
                txtConLai.Text = Convert.ToString(ConLai);
            }
            btnSave.Enabled = true;
        }
        //Sự kiện khi thêm row trong dgvPhieuSuaChua
        DataTable[] dtb = new DataTable[50];// Tạo các table để lưu các record trong dgvCT_SDVTPT 
                                            //  tương ứng với từng record trong dgvPhieuSuaChua
        int dem2 = 0;// chỉ mục của các datatable
        private void dgvPhieuSuaChua_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPhieuSuaChua.Rows[dgvPhieuSuaChua.Rows.Count - 1].Cells[0].Value = e.RowIndex +1;
            //// Lưu các record trong dgvCT_SDVTPT
            if (dgvPhieuSuaChua.Rows.Count > 2)
            {
                if (dgvCT_SDVTPT.Rows.Count > 1)
                {
                    dtb[dem2] = new DataTable();
                    dtb[dem2].Columns.Add("STT", typeof(int));
                    dtb[dem2].Columns.Add("TenVTPT", typeof(string));
                    dtb[dem2].Columns.Add("DonGia", typeof(string));
                    dtb[dem2].Columns.Add("SoLuong", typeof(string));
                    dtb[dem2].Columns.Add("ThanhTien", typeof(string));
                    dtb[dem2].Columns.Add("MaVTPT", typeof(string));
                    for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                    {
                        DataRow row;
                        row = dtb[dem2].NewRow();
                        row["STT"] = i + 1;
                        row["TenVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[1].Value;
                        row["DonGia"] = dgvCT_SDVTPT.Rows[i].Cells[2].Value;
                        row["SoLuong"] = dgvCT_SDVTPT.Rows[i].Cells[3].Value;
                        row["ThanhTien"] = dgvCT_SDVTPT.Rows[i].Cells[4].Value;
                        row["MaVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[5].Value;
                        dtb[dem2].Rows.Add(row);
                    }
                    dem2++;
                }
                else
                {
                    dtb[dem2] = new DataTable();
                    dtb[dem2] = null;
                    dem2++;
                }
            }
            ////
            //// Xóa các record trong dgvCT_SDVTP cũ để thêm mới VTPT cho record trong dgvPhieuSuaChua
            if (dgvPhieuSuaChua.Rows.Count > 1 && dgvCT_SDVTPT.Rows.Count > 1)
            {
                int i = 0;
                int a = dgvCT_SDVTPT.Rows.Count;
                while (i < a - 1)
                {
                    dgvCT_SDVTPT.Rows.Remove(dgvCT_SDVTPT.Rows[0]);
                    i++;
                }
                txtTongTienVTPT.Text = "0";
            }
        }

        // Sự kiện khi doubleclick vào dgvPhieuSuaChua
        int flag = 0;// CHỉ số để nhận biết đã lưu Chi tiết sử dụng vật tu phụ tùng trong dgvCT_SDVTPT
                     // cho record cuối cùng của dgvPhieuSuaChua hay chưa
        private void dgvPhieuSuaChua_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Luư dgvCT_SDVTPT 
            if (dem2 == dgvPhieuSuaChua.Rows.Count - 2 && flag == 0)
            {
                if (dgvCT_SDVTPT.Rows.Count > 1)
                {
                    dtb[dem2] = new DataTable();
                    dtb[dem2].Columns.Add("STT", typeof(int));
                    dtb[dem2].Columns.Add("TenVTPT", typeof(string));
                    dtb[dem2].Columns.Add("DonGia", typeof(string));
                    dtb[dem2].Columns.Add("SoLuong", typeof(string));
                    dtb[dem2].Columns.Add("ThanhTien", typeof(string));
                    dtb[dem2].Columns.Add("MaVTPT", typeof(string));
                    for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                    {
                        DataRow row;
                        row = dtb[dem2].NewRow();
                        row["STT"] = i + 1;
                        row["TenVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[1].Value;
                        row["DonGia"] = dgvCT_SDVTPT.Rows[i].Cells[2].Value;
                        row["SoLuong"] = dgvCT_SDVTPT.Rows[i].Cells[3].Value;
                        row["ThanhTien"] = dgvCT_SDVTPT.Rows[i].Cells[4].Value;
                        row["MaVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[5].Value;
                        dtb[dem2].Rows.Add(row);
                        flag++;
                    }
                }
                else
                {
                    dtb[dem2] = new DataTable();
                    dtb[dem2] = null;
                    flag++;
                }
            }
            //// Xuất Chi tiết sử dụng VTPT tương ứng cho từng record trong dgvPhieuSuaChua
            if (ChiMuc < dgvPhieuSuaChua.Rows.Count-1)
            {
                if (dtb[e.RowIndex] != null)
                {
                    dgvCT_SDVTPT.Columns[0].DataPropertyName = dtb[e.RowIndex].Columns["STT"].ToString();
                    dgvCT_SDVTPT.Columns[1].DataPropertyName = dtb[e.RowIndex].Columns["TenVTPT"].ToString();
                    dgvCT_SDVTPT.Columns[2].DataPropertyName = dtb[e.RowIndex].Columns["DonGia"].ToString();
                    dgvCT_SDVTPT.Columns[3].DataPropertyName = dtb[e.RowIndex].Columns["SoLuong"].ToString();
                    dgvCT_SDVTPT.Columns[4].DataPropertyName = dtb[e.RowIndex].Columns["ThanhTien"].ToString();
                    dgvCT_SDVTPT.Columns[5].DataPropertyName = dtb[e.RowIndex].Columns["MaVTPT"].ToString();
                    dgvCT_SDVTPT.AutoGenerateColumns = false;
                    dgvCT_SDVTPT.DataSource = dtb[e.RowIndex];
                    ////load lại giá trị tương ứng cho txtTongTienVTPT
                    int ChiPhiVTPT = 0;
                    for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                    {
                        ChiPhiVTPT = ChiPhiVTPT + Convert.ToInt32(dgvCT_SDVTPT.Rows[i].Cells[4].Value);
                    }
                    txtTongTienVTPT.Text = Convert.ToString(ChiPhiVTPT);
                    LayDuLieu(txtTongTienVTPT.Text, ChiMuc);
                }
                else
                {
                    dgvCT_SDVTPT.DataSource = null;

                }
            }
        }
        // Sự kiện cho nút thêm mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thêm mới phiếu sửa chữa không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //// Xóa hết record trong dgvPhieuSuaChua
                if (dgvPhieuSuaChua.Rows.Count > 1)
                {
                    while (1 < dgvPhieuSuaChua.Rows.Count)
                    {
                        dgvPhieuSuaChua.Rows.Remove(dgvPhieuSuaChua.Rows[0]);
                    }
                }
                ////
                //// Xóa hết record trong dgvCT_SDVTPT
                if (dgvCT_SDVTPT.Rows.Count > 1)
                {
                    while (1 < dgvCT_SDVTPT.Rows.Count)
                    {
                        dgvCT_SDVTPT.Rows.Remove(dgvCT_SDVTPT.Rows[0]);
                    }
                }
                txtTongTienVTPT.Text = "0";
                txtChiPhiSuaChua.Text = "0";
                txtConLai.Text = "0";
                txtSoTienThu.Text = "0";
                //// xóa dữ liệu trong datatable
                for (int i = 0; i <= dem2; i++)
                {
                    if (dtb[i] != null)
                        dtb[i].Clear();
                }
                dem2 = 0;
                flag = 0;
                btnSave.Enabled = false;
                dgvCT_SDVTPT.ReadOnly = false;
                dgvPhieuSuaChua.ReadOnly = false;
                txtSoTienThu.ReadOnly = false;
                Dgv_Load();
            }
        }
        // Xóa 1 record trong dgvPhieuSuaChua
        private void dgvPhieuSuaChua_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvCT_load();
            int i =0;
            //// Tính lại Tổng thành tiền
            for(int j=0;j<dgvPhieuSuaChua.Rows.Count-1 ;j++)
            {
                i = i + Convert.ToInt32(dgvPhieuSuaChua.Rows[j].Cells[7].Value);
            }
            txtChiPhiSuaChua.Text = Convert.ToString(i);//cập nhật lại Chi Phí sửa chữa
            if(dtb[e.RowIndex]!=null)
            dtb[e.RowIndex].Clear();// Xóa Vật tư phụ tùng của phiếu sửa chữa
            if (ChiMuc != dgvPhieuSuaChua.Rows.Count - 1)
            {
                for(int j = ChiMuc;j<dem2;j++ )
                {
                    dtb[j] = dtb[j + 1];
                }
                //dtb[dem2].Clear();
                dem2 = dem2 - 1;
            }
        }
        //Sử lí khi click nút Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn lưu Phiếu sửa chữa không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                int ChiPhiSuaChua = int.Parse(txtChiPhiSuaChua.Text);
                if (txtSoTienThu.Text.ToString() != "")
                {
                    int SoTienThu = int.Parse(txtSoTienThu.Text);
                    //Kiểm tra số tiền thu có bé hơn hoặc bằng Chi Phí sửa chữa hay không
                    if (SoTienThu <= ChiPhiSuaChua)
                    {
                        //// Lưu Chi tiết sử dụng VTPT cho record cuối cùng trong dgvPhieuSuaChua
                        if (dgvCT_SDVTPT.Rows.Count > 1 && flag == 0)
                        {
                            dtb[dem2] = new DataTable();
                            dtb[dem2].Columns.Add("STT", typeof(int));
                            dtb[dem2].Columns.Add("TenVTPT", typeof(string));
                            dtb[dem2].Columns.Add("DonGia", typeof(string));
                            dtb[dem2].Columns.Add("SoLuong", typeof(string));
                            dtb[dem2].Columns.Add("ThanhTien", typeof(string));
                            dtb[dem2].Columns.Add("MaVTPT", typeof(string));
                            for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                            {
                                DataRow row;
                                row = dtb[dem2].NewRow();
                                row["STT"] = i + 1;
                                row["TenVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[1].Value;
                                row["DonGia"] = dgvCT_SDVTPT.Rows[i].Cells[2].Value;
                                row["SoLuong"] = dgvCT_SDVTPT.Rows[i].Cells[3].Value;
                                row["ThanhTien"] = dgvCT_SDVTPT.Rows[i].Cells[4].Value;
                                row["MaVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[5].Value;
                                dtb[dem2].Rows.Add(row);
                                flag++;
                            }
                        }
                        //// Gán Thông tin phiếu sửa chửa cho đối tượng PhHIEUSUACHUA_DTO
                        PHIEUSUACHUA_DTO PSC = new PHIEUSUACHUA_DTO(Convert.ToInt32(cbbMaXe.Text), dtpNgay.Value.Date,
                                                                    Convert.ToInt32(txtChiPhiSuaChua.Text), Convert.ToInt32(txtSoTienThu.Text),
                                                                    Convert.ToInt32(txtConLai.Text));
                        PHIEUSUACHUA_DAO.ThemPhieuSuaChua(PSC);// Lưu thông tin Phiếu sửa chữa xuống CSDL
                                                               //// Gán vàLưu từng Chi tiết phiếu sửa chữa và danh sách các vật tư phụ tùng tương ứng xuống cơ sở dữ liệu
                        for (int i = 0; i < dgvPhieuSuaChua.Rows.Count - 1; i++)
                        {
                            //Gán Chi tiết phiếu sửa chữa cho đối tượng CT_PHIEUSUACHUA_DTO
                            CT_PHIEUSUACHUA_DTO CT_PSC = new CT_PHIEUSUACHUA_DTO(dgvPhieuSuaChua.Rows[i].Cells[1].Value.ToString(),
                              Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[2].Value), Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[3].Value),
                              Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[4].Value), Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[5].Value),
                              Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[6].Value), Convert.ToInt32(dgvPhieuSuaChua.Rows[i].Cells[7].Value));
                            CT_PHIEUSUACHUA_DAO.ThemCT_PhieuSuaChua(CT_PSC, PSC);// lưu chi tiết phiếu sửa chữa xuống CSDL
                            if (dtb[i] != null)
                            {
                                for (int j = 0; j <= dtb[i].Rows.Count - 1; j++)
                                {
                                    // gán danh sách sử dụng VTPT vào đối tượng CT_SUDUNGVTPT_DTO với CT phiếu sưa chữa tương ứng
                                    CT_SUDUNGVTPT_DTO CT_SDVTPT = new CT_SUDUNGVTPT_DTO(Convert.ToInt32(dtb[i].Rows[j]["MaVTPT"].ToString()),
                                                                                        Convert.ToInt32(dtb[i].Rows[j]["DonGia"].ToString()),
                                                                                        Convert.ToInt32(dtb[i].Rows[j]["SoLuong"].ToString()),
                                                                                        Convert.ToInt32(dtb[i].Rows[j]["ThanhTien"].ToString()));
                                    CT_SUDUNGVTPT_DAO.ThemCT_SUDUNGVTPT(CT_SDVTPT, CT_PSC, PSC);//Lưu danh sách Sử dựng VTPT xuống CSDL
                                }
                            }
                            ///
                        }
                        MessageBox.Show("Bạn đã lưu thành công phiếu sửa chữa");
                        btnSave.Enabled = false;
                        dgvPhieuSuaChua.ReadOnly = true;
                        dgvCT_SDVTPT.ReadOnly = true;
                        txtSoTienThu.ReadOnly = true;
                    }
                    else 
                    MessageBox.Show("Nhập số tiền thu không hợp lệ, số tiền thu phải nhỏ hơn chi phí sửa chữa");
                }
                else
                    MessageBox.Show("Chưa nhập số tiền thu");
            }
        }
        // Xử lí dữ liệu trong dgvCT_SDVTPT khi nhấn nút ENTER
        private void dgvCT_SDVTPT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                if(dgvCT_SDVTPT.Rows.Count >1)
                {
                    // Thêm vật tư phụ tùng cho record trong dgvPhieuSuaChua cellclick
                    if (dtb[ChiMuc] == null)
                    {
                        dtb[ChiMuc] = new DataTable();
                        dtb[ChiMuc].Columns.Add("STT", typeof(int));
                        dtb[ChiMuc].Columns.Add("TenVTPT", typeof(string));
                        dtb[ChiMuc].Columns.Add("DonGia", typeof(string));
                        dtb[ChiMuc].Columns.Add("SoLuong", typeof(string));
                        dtb[ChiMuc].Columns.Add("ThanhTien", typeof(string));
                        dtb[ChiMuc].Columns.Add("MaVTPT", typeof(string));
                        for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                        {
                            DataRow row;
                            row = dtb[ChiMuc].NewRow();
                            row["STT"] = i + 1;
                            row["TenVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[1].Value;
                            row["DonGia"] = dgvCT_SDVTPT.Rows[i].Cells[2].Value;
                            row["SoLuong"] = dgvCT_SDVTPT.Rows[i].Cells[3].Value;
                            row["ThanhTien"] = dgvCT_SDVTPT.Rows[i].Cells[4].Value;
                            row["MaVTPT"] = dgvCT_SDVTPT.Rows[i].Cells[5].Value;
                            dtb[ChiMuc].Rows.Add(row);
                        }
                    }
                }
            }
        }
        //Sử lí khi xóa 1 hàng trong dgvCT_SUDUNGVTPT
        private void dgvCT_SDVTPT_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvVTPT_load();
            //cập nhật lại Thông tin Phiếu sửa chữa và danh sách VTPT sau khi xóa 1 VTPT
            if (flag == 0)
            {
                int ChiPhiVTPT = 0;
                for (int i=0; i<dgvCT_SDVTPT.Rows.Count -1;i++)
                {
                    ChiPhiVTPT = ChiPhiVTPT + Convert.ToInt32(dgvCT_SDVTPT.Rows[i].Cells[4].Value);
                }
                txtTongTienVTPT.Text = Convert.ToString(ChiPhiVTPT);
                LayDuLieu(txtTongTienVTPT.Text, ChiMuc);
            }
            else
            {
                int ChiPhiVTPT = 0;
                for (int i = 0; i < dgvCT_SDVTPT.Rows.Count - 1; i++)
                {
                    ChiPhiVTPT = ChiPhiVTPT + Convert.ToInt32(dgvCT_SDVTPT.Rows[i].Cells[4].Value);
                }
                txtTongTienVTPT.Text = Convert.ToString(ChiPhiVTPT);
                LayDuLieu(txtTongTienVTPT.Text, ChiMuc);
            }
        }
        // Sự kiện khi rê chuột vào nút lưu
        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ctrl + S", btnSave);
        }
        // Sự kiện khi rê chuột vào nút Thêm mới
        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ctrl + N", btnNew);
        }
        // Sựu kiện khi rê chuột vào nút thoát
        private void bttExit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Alt + F4", btnExit);
        }
        // xử lí các phím tắt cho button
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

        private void btnPSC_Click(object sender, EventArgs e)
        {
            f1 f = new f1();
            f.Show();
        }
    }
}
