namespace BaoCao
{
    partial class VTPT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbVTPT = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.btnThemSL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVTPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenVTPT = new System.Windows.Forms.TextBox();
            this.btnThayDoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(240, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbVTPT
            // 
            this.lbVTPT.AutoSize = true;
            this.lbVTPT.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVTPT.Location = new System.Drawing.Point(13, 13);
            this.lbVTPT.Name = "lbVTPT";
            this.lbVTPT.Size = new System.Drawing.Size(123, 59);
            this.lbVTPT.TabIndex = 1;
            this.lbVTPT.Text = "VTPT";
            this.lbVTPT.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(313, 368);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(276, 31);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(313, 314);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(135, 39);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "So Luong";
            // 
            // btnThemSL
            // 
            this.btnThemSL.Location = new System.Drawing.Point(619, 350);
            this.btnThemSL.Name = "btnThemSL";
            this.btnThemSL.Size = new System.Drawing.Size(169, 48);
            this.btnThemSL.TabIndex = 5;
            this.btnThemSL.Text = "Them VTPT";
            this.btnThemSL.UseVisualStyleBackColor = true;
            this.btnThemSL.Click += new System.EventHandler(this.btnThemSL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã VTPT";
            // 
            // txtMaVTPT
            // 
            this.txtMaVTPT.Location = new System.Drawing.Point(313, 111);
            this.txtMaVTPT.Name = "txtMaVTPT";
            this.txtMaVTPT.Size = new System.Drawing.Size(276, 31);
            this.txtMaVTPT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên VTPT";
            // 
            // txtTenVTPT
            // 
            this.txtTenVTPT.Location = new System.Drawing.Point(313, 239);
            this.txtTenVTPT.Name = "txtTenVTPT";
            this.txtTenVTPT.Size = new System.Drawing.Size(276, 31);
            this.txtTenVTPT.TabIndex = 8;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(619, 267);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(169, 49);
            this.btnThayDoi.TabIndex = 10;
            this.btnThayDoi.Text = "Luu";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            // 
            // VTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenVTPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaVTPT);
            this.Controls.Add(this.btnThemSL);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbVTPT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VTPT";
            this.Text = "VTPT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbVTPT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Button btnThemSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVTPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenVTPT;
        private System.Windows.Forms.Button btnThayDoi;
    }
}