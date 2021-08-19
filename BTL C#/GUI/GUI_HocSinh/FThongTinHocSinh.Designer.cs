
namespace GUI.GUI_HocSinh
{
    partial class FThongTinHocSinh
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
            this.mnuXemKetQuaHocTap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblHoTenBo = new System.Windows.Forms.Label();
            this.lblHoTenMe = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMienGiam = new System.Windows.Forms.Label();
            this.lblSoDTBo = new System.Windows.Forms.Label();
            this.lblSoDTMe = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemKetQuaHocTap,
            this.mnuDoiMatKhau,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(852, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuXemKetQuaHocTap
            // 
            this.mnuXemKetQuaHocTap.Name = "mnuXemKetQuaHocTap";
            this.mnuXemKetQuaHocTap.Size = new System.Drawing.Size(160, 24);
            this.mnuXemKetQuaHocTap.Text = "Xem kết quả học tập";
            this.mnuXemKetQuaHocTap.Click += new System.EventHandler(this.mnuXemKetQuaHocTap_Click);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã học sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(461, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Miễn giảm học phí:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Họ tên mẹ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số điện thoại bố:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Họ tên bố:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(457, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Số điện thoại mẹ:";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(225, 127);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(54, 17);
            this.lblMaHS.TabIndex = 3;
            this.lblMaHS.Text = "label13";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(368, 78);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(54, 18);
            this.lblTenHS.TabIndex = 3;
            this.lblTenHS.Text = "label13";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(225, 166);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 17);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "label13";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(225, 209);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(54, 17);
            this.lblSoDT.TabIndex = 3;
            this.lblSoDT.Text = "label13";
            // 
            // lblHoTenBo
            // 
            this.lblHoTenBo.AutoSize = true;
            this.lblHoTenBo.Location = new System.Drawing.Point(225, 257);
            this.lblHoTenBo.Name = "lblHoTenBo";
            this.lblHoTenBo.Size = new System.Drawing.Size(54, 17);
            this.lblHoTenBo.TabIndex = 3;
            this.lblHoTenBo.Text = "label13";
            // 
            // lblHoTenMe
            // 
            this.lblHoTenMe.AutoSize = true;
            this.lblHoTenMe.Location = new System.Drawing.Point(225, 306);
            this.lblHoTenMe.Name = "lblHoTenMe";
            this.lblHoTenMe.Size = new System.Drawing.Size(54, 17);
            this.lblHoTenMe.TabIndex = 3;
            this.lblHoTenMe.Text = "label13";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(639, 127);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 17);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "label13";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(639, 166);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(54, 17);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "label13";
            // 
            // lblMienGiam
            // 
            this.lblMienGiam.AutoSize = true;
            this.lblMienGiam.Location = new System.Drawing.Point(639, 209);
            this.lblMienGiam.Name = "lblMienGiam";
            this.lblMienGiam.Size = new System.Drawing.Size(54, 17);
            this.lblMienGiam.TabIndex = 3;
            this.lblMienGiam.Text = "label13";
            // 
            // lblSoDTBo
            // 
            this.lblSoDTBo.AutoSize = true;
            this.lblSoDTBo.Location = new System.Drawing.Point(639, 257);
            this.lblSoDTBo.Name = "lblSoDTBo";
            this.lblSoDTBo.Size = new System.Drawing.Size(54, 17);
            this.lblSoDTBo.TabIndex = 3;
            this.lblSoDTBo.Text = "label13";
            // 
            // lblSoDTMe
            // 
            this.lblSoDTMe.AutoSize = true;
            this.lblSoDTMe.Location = new System.Drawing.Point(639, 306);
            this.lblSoDTMe.Name = "lblSoDTMe";
            this.lblSoDTMe.Size = new System.Drawing.Size(54, 17);
            this.lblSoDTMe.TabIndex = 3;
            this.lblSoDTMe.Text = "label13";
            // 
            // FThongTinHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 452);
            this.Controls.Add(this.lblSoDTMe);
            this.Controls.Add(this.lblHoTenMe);
            this.Controls.Add(this.lblSoDTBo);
            this.Controls.Add(this.lblMienGiam);
            this.Controls.Add(this.lblHoTenBo);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FThongTinHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FThongTinHocSinh_FormClosed);
            this.Load += new System.EventHandler(this.FThongTinHocSinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuXemKetQuaHocTap;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblHoTenBo;
        private System.Windows.Forms.Label lblHoTenMe;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMienGiam;
        private System.Windows.Forms.Label lblSoDTBo;
        private System.Windows.Forms.Label lblSoDTMe;
    }
}