namespace Gara
{
    partial class fTK_1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPasswords = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbPasswords);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu để hoàn tất cập nhật:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbPasswords
            // 
            this.txbPasswords.Location = new System.Drawing.Point(198, 22);
            this.txbPasswords.Name = "txbPasswords";
            this.txbPasswords.Size = new System.Drawing.Size(189, 20);
            this.txbPasswords.TabIndex = 1;
            this.txbPasswords.UseSystemPasswordChar = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.bttExit);
            this.groupBox4.Controls.Add(this.bttLogin);
            this.groupBox4.Location = new System.Drawing.Point(12, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 56);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quên mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bttExit
            // 
            this.bttExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttExit.Location = new System.Drawing.Point(280, 19);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(107, 23);
            this.bttExit.TabIndex = 3;
            this.bttExit.Text = "Hủy bỏ";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(6, 19);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(106, 23);
            this.bttLogin.TabIndex = 0;
            this.bttLogin.Text = "Xác nhận";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Lưu ý: Tên hiển thị trên trang chủ sẽ được thay đổi kể từ lần đăng nhập tiếp the" +
    "o)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fTK_1
            // 
            this.AcceptButton = this.bttLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.bttExit;
            this.ClientSize = new System.Drawing.Size(419, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "fTK_1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận mật khẩu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbPasswords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Label label2;
    }
}