
namespace GUI.GUI_GiaoVien
{
    partial class FGiaoVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLyHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyKetQuaHocTap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyHocSinh,
            this.mnuQuanLyKetQuaHocTap,
            this.mnuDoiMatKhau,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanLyHocSinh
            // 
            this.mnuQuanLyHocSinh.Name = "mnuQuanLyHocSinh";
            this.mnuQuanLyHocSinh.Size = new System.Drawing.Size(131, 24);
            this.mnuQuanLyHocSinh.Text = "Quản lý học sinh";
            this.mnuQuanLyHocSinh.Click += new System.EventHandler(this.mnuQuanLyHocSinh_Click);
            // 
            // mnuQuanLyKetQuaHocTap
            // 
            this.mnuQuanLyKetQuaHocTap.Name = "mnuQuanLyKetQuaHocTap";
            this.mnuQuanLyKetQuaHocTap.Size = new System.Drawing.Size(180, 24);
            this.mnuQuanLyKetQuaHocTap.Text = "Quản lý kết quả học tập";
            this.mnuQuanLyKetQuaHocTap.Click += new System.EventHandler(this.mnuQuanLyKetQuaHocTap_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(112, 24);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(91, 24);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã giáo viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên giáo viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Địa chỉ";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(304, 102);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(132, 22);
            this.txtMaGV.TabIndex = 4;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Location = new System.Drawing.Point(304, 154);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(132, 22);
            this.txtTenGV.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(304, 208);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(132, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Location = new System.Drawing.Point(304, 265);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(132, 22);
            this.txtSoDT.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(304, 325);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 447);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGiaoVien_FormClosed);
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyKetQuaHocTap;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtEmail;
    }
}