namespace Gara
{
    partial class f2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.cbbMaXe = new System.Windows.Forms.ComboBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySuaChua = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtChiPhiSuaChua = new System.Windows.Forms.TextBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.lbConLai = new System.Windows.Forms.Label();
            this.lblSoTienThu = new System.Windows.Forms.Label();
            this.lblChiPhiSuaChua = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTienCong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPhieuSuaChua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CT_SudungVTPT = new System.Windows.Forms.GroupBox();
            this.txtTongTienVTPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCT_SDVTPT = new System.Windows.Forms.DataGridView();
            this.STTVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVTPT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGiaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CT_SudungVTPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_SDVTPT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(108, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(200, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThemXe
            // 
            this.btnThemXe.Location = new System.Drawing.Point(290, 19);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(75, 23);
            this.btnThemXe.TabIndex = 5;
            this.btnThemXe.Text = "Thêm xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnPSC_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Controls.Add(this.btnIn);
            this.groupBox4.Controls.Add(this.btnThemXe);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Location = new System.Drawing.Point(15, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(848, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(727, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.bttExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.bttExit_MouseHover);
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Location = new System.Drawing.Point(217, 22);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(45, 13);
            this.lblBienSo.TabIndex = 1;
            this.lblBienSo.Text = "Biển số:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Location = new System.Drawing.Point(54, 24);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(39, 13);
            this.lblMaXe.TabIndex = 0;
            this.lblMaXe.Text = "Mã xe:";
            // 
            // cbbMaXe
            // 
            this.cbbMaXe.FormattingEnabled = true;
            this.cbbMaXe.Location = new System.Drawing.Point(108, 19);
            this.cbbMaXe.Name = "cbbMaXe";
            this.cbbMaXe.Size = new System.Drawing.Size(41, 21);
            this.cbbMaXe.TabIndex = 2;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(299, 19);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.ReadOnly = true;
            this.txtBienSo.Size = new System.Drawing.Size(91, 20);
            this.txtBienSo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgay);
            this.groupBox2.Controls.Add(this.cbbMaXe);
            this.groupBox2.Controls.Add(this.txtBienSo);
            this.groupBox2.Controls.Add(this.lblNgaySuaChua);
            this.groupBox2.Controls.Add(this.lblBienSo);
            this.groupBox2.Controls.Add(this.lblMaXe);
            this.groupBox2.Location = new System.Drawing.Point(15, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu sửa chữa";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(574, 18);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgay.TabIndex = 3;
            // 
            // lblNgaySuaChua
            // 
            this.lblNgaySuaChua.AutoSize = true;
            this.lblNgaySuaChua.Location = new System.Drawing.Point(466, 22);
            this.lblNgaySuaChua.Name = "lblNgaySuaChua";
            this.lblNgaySuaChua.Size = new System.Drawing.Size(82, 13);
            this.lblNgaySuaChua.TabIndex = 2;
            this.lblNgaySuaChua.Text = "Ngày sửa chữa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtConLai);
            this.groupBox3.Controls.Add(this.txtChiPhiSuaChua);
            this.groupBox3.Controls.Add(this.txtSoTienThu);
            this.groupBox3.Controls.Add(this.lbConLai);
            this.groupBox3.Controls.Add(this.lblSoTienThu);
            this.groupBox3.Controls.Add(this.lblChiPhiSuaChua);
            this.groupBox3.Location = new System.Drawing.Point(589, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 172);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtConLai.Location = new System.Drawing.Point(143, 128);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(103, 20);
            this.txtConLai.TabIndex = 4;
            this.txtConLai.Text = "0";
            // 
            // txtChiPhiSuaChua
            // 
            this.txtChiPhiSuaChua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtChiPhiSuaChua.Location = new System.Drawing.Point(143, 39);
            this.txtChiPhiSuaChua.Name = "txtChiPhiSuaChua";
            this.txtChiPhiSuaChua.ReadOnly = true;
            this.txtChiPhiSuaChua.Size = new System.Drawing.Size(103, 20);
            this.txtChiPhiSuaChua.TabIndex = 3;
            this.txtChiPhiSuaChua.Text = "0";
            this.txtChiPhiSuaChua.TextChanged += new System.EventHandler(this.txtChiPhiSuaChua_TextChanged);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(143, 84);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(103, 20);
            this.txtSoTienThu.TabIndex = 1;
            this.txtSoTienThu.Text = "0";
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            // 
            // lbConLai
            // 
            this.lbConLai.AutoSize = true;
            this.lbConLai.Location = new System.Drawing.Point(35, 131);
            this.lbConLai.Name = "lbConLai";
            this.lbConLai.Size = new System.Drawing.Size(42, 13);
            this.lbConLai.TabIndex = 2;
            this.lbConLai.Text = "Còn lại:";
            // 
            // lblSoTienThu
            // 
            this.lblSoTienThu.AutoSize = true;
            this.lblSoTienThu.Location = new System.Drawing.Point(35, 84);
            this.lblSoTienThu.Name = "lblSoTienThu";
            this.lblSoTienThu.Size = new System.Drawing.Size(61, 13);
            this.lblSoTienThu.TabIndex = 1;
            this.lblSoTienThu.Text = "Số tiền thu:";
            // 
            // lblChiPhiSuaChua
            // 
            this.lblChiPhiSuaChua.AutoSize = true;
            this.lblChiPhiSuaChua.Location = new System.Drawing.Point(35, 42);
            this.lblChiPhiSuaChua.Name = "lblChiPhiSuaChua";
            this.lblChiPhiSuaChua.Size = new System.Drawing.Size(91, 13);
            this.lblChiPhiSuaChua.TabIndex = 0;
            this.lblChiPhiSuaChua.Text = "Chi phí sửa chữa:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPhieuSuaChua);
            this.groupBox5.Location = new System.Drawing.Point(16, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(847, 165);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu sửa chữa";
            // 
            // dgvPhieuSuaChua
            // 
            this.dgvPhieuSuaChua.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NoiDung,
            this.TenTienCong,
            this.DonGia,
            this.SoLan,
            this.ThanhTienCong,
            this.ThanhTienVTPT,
            this.TongThanhTien});
            this.dgvPhieuSuaChua.Location = new System.Drawing.Point(6, 17);
            this.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua";
            this.dgvPhieuSuaChua.Size = new System.Drawing.Size(835, 142);
            this.dgvPhieuSuaChua.TabIndex = 0;
            this.dgvPhieuSuaChua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuSuaChua_CellClick);
            this.dgvPhieuSuaChua.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuSuaChua_CellDoubleClick);
            this.dgvPhieuSuaChua.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuSuaChua_CellValueChanged);
            this.dgvPhieuSuaChua.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPhieuSuaChua_RowsAdded);
            this.dgvPhieuSuaChua.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPhieuSuaChua_RowsRemoved);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.Name = "NoiDung";
            // 
            // TenTienCong
            // 
            this.TenTienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTienCong.HeaderText = "Tên tiền công";
            this.TenTienCong.Name = "TenTienCong";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLan
            // 
            this.SoLan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLan.FillWeight = 60F;
            this.SoLan.HeaderText = "Số lần";
            this.SoLan.Name = "SoLan";
            // 
            // ThanhTienCong
            // 
            this.ThanhTienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTienCong.HeaderText = "Thành tiền công";
            this.ThanhTienCong.Name = "ThanhTienCong";
            this.ThanhTienCong.ReadOnly = true;
            // 
            // ThanhTienVTPT
            // 
            this.ThanhTienVTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTienVTPT.HeaderText = "Thành tiền VTPT";
            this.ThanhTienVTPT.Name = "ThanhTienVTPT";
            this.ThanhTienVTPT.ReadOnly = true;
            // 
            // TongThanhTien
            // 
            this.TongThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongThanhTien.HeaderText = "Tổng thành tiền";
            this.TongThanhTien.Name = "TongThanhTien";
            this.TongThanhTien.ReadOnly = true;
            // 
            // lblPhieuSuaChua
            // 
            this.lblPhieuSuaChua.AutoSize = true;
            this.lblPhieuSuaChua.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuSuaChua.ForeColor = System.Drawing.Color.White;
            this.lblPhieuSuaChua.Location = new System.Drawing.Point(260, 27);
            this.lblPhieuSuaChua.Name = "lblPhieuSuaChua";
            this.lblPhieuSuaChua.Size = new System.Drawing.Size(326, 32);
            this.lblPhieuSuaChua.TabIndex = 0;
            this.lblPhieuSuaChua.Text = "LẬP PHIẾU SỬA CHỮA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.lblPhieuSuaChua);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-2, -18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // CT_SudungVTPT
            // 
            this.CT_SudungVTPT.Controls.Add(this.txtTongTienVTPT);
            this.CT_SudungVTPT.Controls.Add(this.label2);
            this.CT_SudungVTPT.Controls.Add(this.dgvCT_SDVTPT);
            this.CT_SudungVTPT.Location = new System.Drawing.Point(15, 295);
            this.CT_SudungVTPT.Name = "CT_SudungVTPT";
            this.CT_SudungVTPT.Size = new System.Drawing.Size(568, 172);
            this.CT_SudungVTPT.TabIndex = 6;
            this.CT_SudungVTPT.TabStop = false;
            this.CT_SudungVTPT.Text = "Chi tiết sử dụng vật tư phụ tùng";
            // 
            // txtTongTienVTPT
            // 
            this.txtTongTienVTPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTongTienVTPT.Location = new System.Drawing.Point(445, 146);
            this.txtTongTienVTPT.Name = "txtTongTienVTPT";
            this.txtTongTienVTPT.ReadOnly = true;
            this.txtTongTienVTPT.Size = new System.Drawing.Size(103, 20);
            this.txtTongTienVTPT.TabIndex = 5;
            this.txtTongTienVTPT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thành tiền VTPT";
            // 
            // dgvCT_SDVTPT
            // 
            this.dgvCT_SDVTPT.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCT_SDVTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_SDVTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTVTPT,
            this.TenVTPT,
            this.DonGiaVTPT,
            this.SoLuong,
            this.ThanhTien,
            this.MaVTPT});
            this.dgvCT_SDVTPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCT_SDVTPT.Location = new System.Drawing.Point(3, 16);
            this.dgvCT_SDVTPT.Name = "dgvCT_SDVTPT";
            this.dgvCT_SDVTPT.Size = new System.Drawing.Size(562, 124);
            this.dgvCT_SDVTPT.TabIndex = 0;
            this.dgvCT_SDVTPT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCT_SDVTPT_CellValueChanged);
            this.dgvCT_SDVTPT.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCT_SDVTPT_RowsRemoved);
            this.dgvCT_SDVTPT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCT_SDVTPT_KeyDown);
            // 
            // STTVTPT
            // 
            this.STTVTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STTVTPT.FillWeight = 50F;
            this.STTVTPT.HeaderText = "STT";
            this.STTVTPT.Name = "STTVTPT";
            this.STTVTPT.ReadOnly = true;
            // 
            // TenVTPT
            // 
            this.TenVTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVTPT.HeaderText = "Vật tư phụ tùng";
            this.TenVTPT.Name = "TenVTPT";
            // 
            // DonGiaVTPT
            // 
            this.DonGiaVTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGiaVTPT.HeaderText = "Đơn giá";
            this.DonGiaVTPT.Name = "DonGiaVTPT";
            this.DonGiaVTPT.ReadOnly = true;
            this.DonGiaVTPT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonGiaVTPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.FillWeight = 60F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // MaVTPT
            // 
            this.MaVTPT.HeaderText = "MaVTPT";
            this.MaVTPT.Name = "MaVTPT";
            this.MaVTPT.ReadOnly = true;
            this.MaVTPT.Visible = false;
            // 
            // f2
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(875, 541);
            this.Controls.Add(this.CT_SudungVTPT);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "f2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu sửa chữa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f2_FormClosing);
            this.Load += new System.EventHandler(this.f2_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CT_SudungVTPT.ResumeLayout(false);
            this.CT_SudungVTPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_SDVTPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.ComboBox cbbMaXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblNgaySuaChua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtChiPhiSuaChua;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.Label lbConLai;
        private System.Windows.Forms.Label lblSoTienThu;
        private System.Windows.Forms.Label lblChiPhiSuaChua;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPhieuSuaChua;
        private System.Windows.Forms.Label lblPhieuSuaChua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CT_SudungVTPT;
        private System.Windows.Forms.TextBox txtTongTienVTPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCT_SDVTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienVTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTVTPT;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenVTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaVTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVTPT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}