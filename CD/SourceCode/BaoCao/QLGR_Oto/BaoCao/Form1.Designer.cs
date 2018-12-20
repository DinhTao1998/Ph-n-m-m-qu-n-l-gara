namespace BaoCao
{
    partial class frmBaoCaoDoanhSo
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
            this.grpThoiGian = new System.Windows.Forms.GroupBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblBaoCaoDoanhSo = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.grpBaoCaoDoanhSo = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dgvBCDS = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.TenHieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuotSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThoiGian.SuspendLayout();
            this.grpBaoCaoDoanhSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThoiGian
            // 
            this.grpThoiGian.Controls.Add(this.txtNam);
            this.grpThoiGian.Controls.Add(this.cboThang);
            this.grpThoiGian.Controls.Add(this.lblNam);
            this.grpThoiGian.Controls.Add(this.lblThang);
            this.grpThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThoiGian.Location = new System.Drawing.Point(41, 120);
            this.grpThoiGian.Name = "grpThoiGian";
            this.grpThoiGian.Size = new System.Drawing.Size(526, 148);
            this.grpThoiGian.TabIndex = 0;
            this.grpThoiGian.TabStop = false;
            this.grpThoiGian.Text = "Thời gian";
            this.grpThoiGian.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(303, 69);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(79, 39);
            this.lblNam.TabIndex = 1;
            this.lblNam.Text = "Năm";
            this.lblNam.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(7, 69);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(97, 39);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng";
            this.lblThang.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBaoCaoDoanhSo
            // 
            this.lblBaoCaoDoanhSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaoCaoDoanhSo.AutoSize = true;
            this.lblBaoCaoDoanhSo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoDoanhSo.Location = new System.Drawing.Point(475, 22);
            this.lblBaoCaoDoanhSo.Name = "lblBaoCaoDoanhSo";
            this.lblBaoCaoDoanhSo.Size = new System.Drawing.Size(568, 78);
            this.lblBaoCaoDoanhSo.TabIndex = 1;
            this.lblBaoCaoDoanhSo.Text = "BÁO CÁO DOANH SỐ";
            this.lblBaoCaoDoanhSo.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.Location = new System.Drawing.Point(633, 177);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(247, 63);
            this.btnXuatBaoCao.TabIndex = 2;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // grpBaoCaoDoanhSo
            // 
            this.grpBaoCaoDoanhSo.Controls.Add(this.lblTongDoanhThu);
            this.grpBaoCaoDoanhSo.Controls.Add(this.txtTongDoanhThu);
            this.grpBaoCaoDoanhSo.Controls.Add(this.dgvBCDS);
            this.grpBaoCaoDoanhSo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBaoCaoDoanhSo.Location = new System.Drawing.Point(41, 292);
            this.grpBaoCaoDoanhSo.Name = "grpBaoCaoDoanhSo";
            this.grpBaoCaoDoanhSo.Size = new System.Drawing.Size(1408, 382);
            this.grpBaoCaoDoanhSo.TabIndex = 3;
            this.grpBaoCaoDoanhSo.TabStop = false;
            this.grpBaoCaoDoanhSo.Text = "Báo cáo Doanh số";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(823, 304);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(252, 45);
            this.lblTongDoanhThu.TabIndex = 4;
            this.lblTongDoanhThu.Text = "Tổng doanh thu";
            this.lblTongDoanhThu.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(1105, 304);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(279, 47);
            this.txtTongDoanhThu.TabIndex = 1;
            this.txtTongDoanhThu.TextChanged += new System.EventHandler(this.txtTongDoanhThu_TextChanged);
            // 
            // dgvBCDS
            // 
            this.dgvBCDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHieuXe,
            this.SoLuotSua,
            this.ThanhTien,
            this.TiLe});
            this.dgvBCDS.Location = new System.Drawing.Point(25, 56);
            this.dgvBCDS.Name = "dgvBCDS";
            this.dgvBCDS.RowTemplate.Height = 33;
            this.dgvBCDS.Size = new System.Drawing.Size(1359, 222);
            this.dgvBCDS.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.btnXuatExcel);
            this.groupBox3.Location = new System.Drawing.Point(41, 702);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1408, 114);
            this.groupBox3.TabIndex = 4;
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
            // TenHieuXe
            // 
            this.TenHieuXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHieuXe.DataPropertyName = "TenHieuXe";
            this.TenHieuXe.HeaderText = "Hiệu Xe";
            this.TenHieuXe.Name = "TenHieuXe";
            this.TenHieuXe.ReadOnly = true;
            // 
            // SoLuotSua
            // 
            this.SoLuotSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuotSua.DataPropertyName = "SoLuotSua";
            this.SoLuotSua.HeaderText = "Số Lượt Sửa";
            this.SoLuotSua.Name = "SoLuotSua";
            this.SoLuotSua.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TiLe.DataPropertyName = "TiLe";
            this.TiLe.HeaderText = "Tỉ Lệ";
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // frmBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1488, 846);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBaoCaoDoanhSo);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.lblBaoCaoDoanhSo);
            this.Controls.Add(this.grpThoiGian);
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoDoanhSo";
            this.Text = "Báo cáo Doanh số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThoiGian.ResumeLayout(false);
            this.grpThoiGian.PerformLayout();
            this.grpBaoCaoDoanhSo.ResumeLayout(false);
            this.grpBaoCaoDoanhSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThoiGian;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblBaoCaoDoanhSo;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.GroupBox grpBaoCaoDoanhSo;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvBCDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
    }
}

