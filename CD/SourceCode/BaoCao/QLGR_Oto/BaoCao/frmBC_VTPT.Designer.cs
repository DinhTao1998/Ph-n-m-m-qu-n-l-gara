namespace BaoCao
{
    partial class frmBC_VTPT
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
            this.lblBaoCaoDoanhSo = new System.Windows.Forms.Label();
            this.grpThoiGian = new System.Windows.Forms.GroupBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.grpBaoCaoDoanhSo = new System.Windows.Forms.GroupBox();
            this.dgvBC_VTPT = new System.Windows.Forms.DataGridView();
            this.TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.grpThoiGian.SuspendLayout();
            this.grpBaoCaoDoanhSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBC_VTPT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaoCaoDoanhSo
            // 
            this.lblBaoCaoDoanhSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaoCaoDoanhSo.AutoSize = true;
            this.lblBaoCaoDoanhSo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoDoanhSo.Location = new System.Drawing.Point(456, 20);
            this.lblBaoCaoDoanhSo.Name = "lblBaoCaoDoanhSo";
            this.lblBaoCaoDoanhSo.Size = new System.Drawing.Size(542, 78);
            this.lblBaoCaoDoanhSo.TabIndex = 6;
            this.lblBaoCaoDoanhSo.Text = "BÁO CÁO TỒN VTPT";
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.txtNam);
            this.grpThoiGian.Controls.Add(this.cboThang);
            this.grpThoiGian.Controls.Add(this.lblNam);
            this.grpThoiGian.Controls.Add(this.lblThang);
            this.grpThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThoiGian.Location = new System.Drawing.Point(22, 118);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Size = new System.Drawing.Size(526, 148);
            this.grpThoiGian.TabIndex = 5;
            this.grpThoiGian.TabStop = false;
            this.grpThoiGian.Text = "Thời gian";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(388, 66);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(120, 47);
            this.txtNam.TabIndex = 3;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(109, 66);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 47);
            this.cboThang.TabIndex = 2;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(303, 69);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(79, 39);
            this.lblNam.TabIndex = 1;
            this.lblNam.Text = "Năm";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(7, 69);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(97, 39);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng";
            // 
            // grpBaoCaoDoanhSo
            // 
            this.grpBaoCaoDoanhSo.Controls.Add(this.dgvBC_VTPT);
            this.grpBaoCaoDoanhSo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBaoCaoDoanhSo.Location = new System.Drawing.Point(22, 290);
            this.grpBaoCaoDoanhSo.Name = "grpBaoCaoDoanhSo";
            this.grpBaoCaoDoanhSo.Size = new System.Drawing.Size(1408, 382);
            this.grpBaoCaoDoanhSo.TabIndex = 8;
            this.grpBaoCaoDoanhSo.TabStop = false;
            this.grpBaoCaoDoanhSo.Text = "Báo cáo Tồn VTPT";
            // 
            // dgvBC_VTPT
            // 
            this.dgvBC_VTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBC_VTPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenVTPT,
            this.TonDau,
            this.PhatSinh,
            this.TonCuoi});
            this.dgvBC_VTPT.Location = new System.Drawing.Point(39, 58);
            this.dgvBC_VTPT.Name = "dgvBC_VTPT";
            this.dgvBC_VTPT.RowTemplate.Height = 33;
            this.dgvBC_VTPT.Size = new System.Drawing.Size(1335, 298);
            this.dgvBC_VTPT.TabIndex = 0;
            this.dgvBC_VTPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TenVTPT
            // 
            this.TenVTPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVTPT.DataPropertyName = "TenVTPT";
            this.TenVTPT.HeaderText = "Vật Tư Phụ Tùng";
            this.TenVTPT.Name = "TenVTPT";
            this.TenVTPT.ReadOnly = true;
            // 
            // TonDau
            // 
            this.TonDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TonDau.DataPropertyName = "TonDau";
            this.TonDau.HeaderText = "Tồn Đầu";
            this.TonDau.Name = "TonDau";
            this.TonDau.ReadOnly = true;
            // 
            // PhatSinh
            // 
            this.PhatSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhatSinh.DataPropertyName = "PhatSinh";
            this.PhatSinh.HeaderText = "Phát Sinh";
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.ReadOnly = true;
            // 
            // TonCuoi
            // 
            this.TonCuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TonCuoi.DataPropertyName = "TonCuoi";
            this.TonCuoi.HeaderText = "Tồn Cuối";
            this.TonCuoi.Name = "TonCuoi";
            this.TonCuoi.ReadOnly = true;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(614, 175);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(247, 63);
            this.btnXuatBaoCao.TabIndex = 7;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.btnXuatExcel);
            this.groupBox3.Location = new System.Drawing.Point(22, 700);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1408, 114);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1137, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(247, 63);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(322, 30);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(157, 63);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(25, 30);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(247, 63);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // frmBC_VTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1452, 832);
            this.Controls.Add(this.lblBaoCaoDoanhSo);
            this.Controls.Add(this.grpThoiGian);
            this.Controls.Add(this.grpBaoCaoDoanhSo);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "frmBC_VTPT";
            this.Text = "Báo cáo VTPT";
            this.Load += new System.EventHandler(this.frmBC_VTPT_Load);
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.grpBaoCaoDoanhSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBC_VTPT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaoCaoDoanhSo;
        private System.Windows.Forms.GroupBox grpThoiGian;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.GroupBox grpBaoCaoDoanhSo;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridView dgvBC_VTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVTPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;
    }
}