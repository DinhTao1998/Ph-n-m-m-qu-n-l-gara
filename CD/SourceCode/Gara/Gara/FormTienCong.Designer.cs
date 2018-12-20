namespace Gara
{
    partial class FrmTienCong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTienCong = new System.Windows.Forms.TextBox();
            this.lblTienCong = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTenTienCong = new System.Windows.Forms.TextBox();
            this.lbl2TenTienCong = new System.Windows.Forms.Label();
            this.txtMaTienCong = new System.Windows.Forms.TextBox();
            this.lblMaTienCong = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTienCong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienCong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THAY ĐỔI TIỀN CÔNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtTienCong);
            this.groupBox2.Controls.Add(this.lblTienCong);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.txtTenTienCong);
            this.groupBox2.Controls.Add(this.lbl2TenTienCong);
            this.groupBox2.Controls.Add(this.txtMaTienCong);
            this.groupBox2.Controls.Add(this.lblMaTienCong);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tiền công";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 162);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.toolTip1.SetToolTip(this.btnUpdate, "Ctrl + U");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTienCong
            // 
            this.txtTienCong.Location = new System.Drawing.Point(137, 111);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Size = new System.Drawing.Size(100, 20);
            this.txtTienCong.TabIndex = 5;
            this.txtTienCong.Text = "0";
            this.txtTienCong.TextChanged += new System.EventHandler(this.txtTienCong_TextChanged);
            // 
            // lblTienCong
            // 
            this.lblTienCong.AutoSize = true;
            this.lblTienCong.Location = new System.Drawing.Point(44, 114);
            this.lblTienCong.Name = "lblTienCong";
            this.lblTienCong.Size = new System.Drawing.Size(58, 13);
            this.lblTienCong.TabIndex = 4;
            this.lblTienCong.Text = "Tiền công:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(19, 162);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Thêm mới";
            this.toolTip1.SetToolTip(this.btnNew, "Ctrl + N");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTenTienCong
            // 
            this.txtTenTienCong.Location = new System.Drawing.Point(137, 64);
            this.txtTenTienCong.Name = "txtTenTienCong";
            this.txtTenTienCong.Size = new System.Drawing.Size(100, 20);
            this.txtTenTienCong.TabIndex = 3;
            this.txtTenTienCong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenTienCong_KeyDown);
            // 
            // lbl2TenTienCong
            // 
            this.lbl2TenTienCong.AutoSize = true;
            this.lbl2TenTienCong.Location = new System.Drawing.Point(44, 64);
            this.lbl2TenTienCong.Name = "lbl2TenTienCong";
            this.lbl2TenTienCong.Size = new System.Drawing.Size(76, 13);
            this.lbl2TenTienCong.TabIndex = 2;
            this.lbl2TenTienCong.Text = "Tên tiền công:";
            // 
            // txtMaTienCong
            // 
            this.txtMaTienCong.Location = new System.Drawing.Point(137, 21);
            this.txtMaTienCong.Name = "txtMaTienCong";
            this.txtMaTienCong.Size = new System.Drawing.Size(100, 20);
            this.txtMaTienCong.TabIndex = 1;
            // 
            // lblMaTienCong
            // 
            this.lblMaTienCong.AutoSize = true;
            this.lblMaTienCong.Location = new System.Drawing.Point(43, 24);
            this.lblMaTienCong.Name = "lblMaTienCong";
            this.lblMaTienCong.Size = new System.Drawing.Size(77, 13);
            this.lblMaTienCong.TabIndex = 0;
            this.lblMaTienCong.Text = "Mã Tiền Công:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.toolTip1.SetToolTip(this.btnBack, "Ctrl + B");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(652, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btnExit, "Alt + F4");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Tag = "Ctrl + S";
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvTienCong);
            this.groupBox4.Location = new System.Drawing.Point(319, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách tiền công";
            // 
            // dgvTienCong
            // 
            this.dgvTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaTienCong,
            this.TenTienCong,
            this.TienCong});
            this.dgvTienCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTienCong.Location = new System.Drawing.Point(3, 16);
            this.dgvTienCong.Name = "dgvTienCong";
            this.dgvTienCong.Size = new System.Drawing.Size(472, 185);
            this.dgvTienCong.TabIndex = 0;
            this.dgvTienCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienCong_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaTienCong
            // 
            this.MaTienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTienCong.HeaderText = "Mã Tiền Công";
            this.MaTienCong.Name = "MaTienCong";
            this.MaTienCong.ReadOnly = true;
            this.MaTienCong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenTienCong
            // 
            this.TenTienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTienCong.HeaderText = "Tên Tiền Công";
            this.TenTienCong.Name = "TenTienCong";
            this.TenTienCong.ReadOnly = true;
            this.TenTienCong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TienCong
            // 
            this.TienCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienCong.HeaderText = "Tiền Công";
            this.TienCong.Name = "TienCong";
            this.TienCong.ReadOnly = true;
            this.TienCong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmTienCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(809, 335);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmTienCong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi tiền công";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTienCong_FormClosing);
            this.Load += new System.EventHandler(this.FrmTienCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTienCong;
        private System.Windows.Forms.Label lblTienCong;
        private System.Windows.Forms.TextBox txtTenTienCong;
        private System.Windows.Forms.Label lbl2TenTienCong;
        private System.Windows.Forms.TextBox txtMaTienCong;
        private System.Windows.Forms.Label lblMaTienCong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}