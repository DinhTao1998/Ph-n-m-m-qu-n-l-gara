namespace Gara
{
    partial class FormLapPhieuThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaXe = new System.Windows.Forms.ComboBox();
            this.txtTenChuXe = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoConLai = new System.Windows.Forms.TextBox();
            this.txtNoCu = new System.Windows.Forms.TextBox();
            this.dtpNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienThoi = new System.Windows.Forms.TextBox();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.txtTienDua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonLapPhieuSua = new System.Windows.Forms.Button();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaXe);
            this.groupBox1.Controls.Add(this.txtTenChuXe);
            this.groupBox1.Controls.Add(this.txtBienSo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbMaXe
            // 
            this.cbbMaXe.FormattingEnabled = true;
            this.cbbMaXe.Location = new System.Drawing.Point(84, 22);
            this.cbbMaXe.Name = "cbbMaXe";
            this.cbbMaXe.Size = new System.Drawing.Size(91, 21);
            this.cbbMaXe.TabIndex = 4;
            this.cbbMaXe.SelectedIndexChanged += new System.EventHandler(this.cbMaXe_SelectedIndexChanged);
            // 
            // txtTenChuXe
            // 
            this.txtTenChuXe.Enabled = false;
            this.txtTenChuXe.Location = new System.Drawing.Point(85, 89);
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.Size = new System.Drawing.Size(132, 20);
            this.txtTenChuXe.TabIndex = 5;
            this.txtTenChuXe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Enabled = false;
            this.txtBienSo.Location = new System.Drawing.Point(84, 52);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(91, 20);
            this.txtBienSo.TabIndex = 4;
            this.txtBienSo.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên chủ xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Biển số:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã xe:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNoConLai);
            this.groupBox2.Controls.Add(this.txtNoCu);
            this.groupBox2.Controls.Add(this.dtpNgayThuTien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTienThoi);
            this.groupBox2.Controls.Add(this.txtTienThu);
            this.groupBox2.Controls.Add(this.txtTienDua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(259, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thanh toán";
            // 
            // txtNoConLai
            // 
            this.txtNoConLai.Enabled = false;
            this.txtNoConLai.Location = new System.Drawing.Point(252, 85);
            this.txtNoConLai.Name = "txtNoConLai";
            this.txtNoConLai.Size = new System.Drawing.Size(85, 20);
            this.txtNoConLai.TabIndex = 11;
            this.txtNoConLai.Text = "0";
            this.txtNoConLai.TextChanged += new System.EventHandler(this.txtNoConLai_TextChanged);
            // 
            // txtNoCu
            // 
            this.txtNoCu.Enabled = false;
            this.txtNoCu.Location = new System.Drawing.Point(252, 52);
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.Size = new System.Drawing.Size(85, 20);
            this.txtNoCu.TabIndex = 10;
            this.txtNoCu.Text = "0";
            // 
            // dtpNgayThuTien
            // 
            this.dtpNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThuTien.Location = new System.Drawing.Point(252, 19);
            this.dtpNgayThuTien.Name = "dtpNgayThuTien";
            this.dtpNgayThuTien.Size = new System.Drawing.Size(85, 20);
            this.dtpNgayThuTien.TabIndex = 9;
            this.dtpNgayThuTien.Value = new System.DateTime(2018, 6, 22, 0, 0, 0, 0);
            this.dtpNgayThuTien.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày thu tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nợ cũ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nợ còn lại:";
            // 
            // txtTienThoi
            // 
            this.txtTienThoi.Enabled = false;
            this.txtTienThoi.Location = new System.Drawing.Point(84, 89);
            this.txtTienThoi.Name = "txtTienThoi";
            this.txtTienThoi.Size = new System.Drawing.Size(68, 20);
            this.txtTienThoi.TabIndex = 5;
            this.txtTienThoi.Text = "0";
            this.txtTienThoi.TextChanged += new System.EventHandler(this.textBoxTienThoi_TextChanged);
            // 
            // txtTienThu
            // 
            this.txtTienThu.Location = new System.Drawing.Point(84, 56);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(68, 20);
            this.txtTienThu.TabIndex = 4;
            this.txtTienThu.Text = "0";
            this.txtTienThu.TextChanged += new System.EventHandler(this.txtTienThu_TextChanged);
            // 
            // txtTienDua
            // 
            this.txtTienDua.Location = new System.Drawing.Point(84, 19);
            this.txtTienDua.Name = "txtTienDua";
            this.txtTienDua.Size = new System.Drawing.Size(68, 20);
            this.txtTienDua.TabIndex = 3;
            this.txtTienDua.Text = "0";
            this.txtTienDua.TextChanged += new System.EventHandler(this.txtTienDua_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiền thối:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số tiền thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiền đưa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonThoat);
            this.groupBox3.Controls.Add(this.buttonIn);
            this.groupBox3.Controls.Add(this.buttonLapPhieuSua);
            this.groupBox3.Controls.Add(this.buttonThemMoi);
            this.groupBox3.Controls.Add(this.buttonLuu);
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 39);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.Location = new System.Drawing.Point(511, 10);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(88, 23);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(100, 10);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(88, 23);
            this.buttonIn.TabIndex = 4;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // buttonLapPhieuSua
            // 
            this.buttonLapPhieuSua.Location = new System.Drawing.Point(288, 10);
            this.buttonLapPhieuSua.Name = "buttonLapPhieuSua";
            this.buttonLapPhieuSua.Size = new System.Drawing.Size(88, 23);
            this.buttonLapPhieuSua.TabIndex = 3;
            this.buttonLapPhieuSua.Text = "Lập phiếu sửa chữa";
            this.buttonLapPhieuSua.UseVisualStyleBackColor = true;
            this.buttonLapPhieuSua.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Location = new System.Drawing.Point(194, 10);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(88, 23);
            this.buttonThemMoi.TabIndex = 1;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(6, 10);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(88, 23);
            this.buttonLuu.TabIndex = 0;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(-2, -25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP PHIẾU THU TIỀN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormLapPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(627, 248);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormLapPhieuThu";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu thu tiền";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenChuXe;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayThuTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienThoi;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.TextBox txtTienDua;
        private System.Windows.Forms.TextBox txtNoConLai;
        private System.Windows.Forms.TextBox txtNoCu;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonLapPhieuSua;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ComboBox cbbMaXe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}

