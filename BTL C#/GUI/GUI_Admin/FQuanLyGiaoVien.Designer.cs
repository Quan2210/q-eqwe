
namespace GUI.GUI_Admin
{
    partial class FQuanLyGiaoVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.grbThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbTaiKhoan.SuspendLayout();
            this.grbThongTinCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachGiaoVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbTaiKhoan);
            this.panel1.Controls.Add(this.grbThongTinCaNhan);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 347);
            this.panel1.TabIndex = 0;
            // 
            // grbTaiKhoan
            // 
            this.grbTaiKhoan.Controls.Add(this.txtTenTaiKhoan);
            this.grbTaiKhoan.Controls.Add(this.txtMatKhau);
            this.grbTaiKhoan.Controls.Add(this.lblMatKhau);
            this.grbTaiKhoan.Controls.Add(this.lblTenTK);
            this.grbTaiKhoan.Location = new System.Drawing.Point(45, 231);
            this.grbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoan.Name = "grbTaiKhoan";
            this.grbTaiKhoan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTaiKhoan.Size = new System.Drawing.Size(849, 76);
            this.grbTaiKhoan.TabIndex = 2;
            this.grbTaiKhoan.TabStop = false;
            this.grbTaiKhoan.Text = "Tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(151, 34);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(241, 22);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(547, 33);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(241, 22);
            this.txtMatKhau.TabIndex = 6;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(437, 37);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(70, 17);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(40, 37);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(99, 17);
            this.lblTenTK.TabIndex = 0;
            this.lblTenTK.Text = "Tên tài khoản:";
            // 
            // grbThongTinCaNhan
            // 
            this.grbThongTinCaNhan.Controls.Add(this.txtEmail);
            this.grbThongTinCaNhan.Controls.Add(this.txtSoDienThoai);
            this.grbThongTinCaNhan.Controls.Add(this.txtTenGiaoVien);
            this.grbThongTinCaNhan.Controls.Add(this.txtDiaChi);
            this.grbThongTinCaNhan.Controls.Add(this.txtMaGiaoVien);
            this.grbThongTinCaNhan.Controls.Add(this.lblEmail);
            this.grbThongTinCaNhan.Controls.Add(this.lblSoDT);
            this.grbThongTinCaNhan.Controls.Add(this.lblDiaChi);
            this.grbThongTinCaNhan.Controls.Add(this.lblTenGV);
            this.grbThongTinCaNhan.Controls.Add(this.lblMaGV);
            this.grbThongTinCaNhan.Location = new System.Drawing.Point(45, 59);
            this.grbThongTinCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTinCaNhan.Name = "grbThongTinCaNhan";
            this.grbThongTinCaNhan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThongTinCaNhan.Size = new System.Drawing.Size(845, 167);
            this.grbThongTinCaNhan.TabIndex = 1;
            this.grbThongTinCaNhan.TabStop = false;
            this.grbThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(547, 71);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(241, 22);
            this.txtSoDienThoai.TabIndex = 5;
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Location = new System.Drawing.Point(151, 71);
            this.txtTenGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(241, 22);
            this.txtTenGiaoVien.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(547, 33);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(241, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(151, 33);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(241, 22);
            this.txtMaGiaoVien.TabIndex = 1;
            this.txtMaGiaoVien.TextChanged += new System.EventHandler(this.txtMaGiaoVien_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(437, 76);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(95, 17);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(437, 38);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Location = new System.Drawing.Point(40, 74);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(98, 17);
            this.lblTenGV.TabIndex = 0;
            this.lblTenGV.Text = "Tên giáo viên:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(40, 33);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(92, 17);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã giáo viên:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(396, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ GIÁO VIÊN";
            // 
            // dgvDanhSachGiaoVien
            // 
            this.dgvDanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.DiaChi,
            this.SoDT,
            this.Email,
            this.MatKhau});
            this.dgvDanhSachGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachGiaoVien.Location = new System.Drawing.Point(3, 353);
            this.dgvDanhSachGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachGiaoVien.Name = "dgvDanhSachGiaoVien";
            this.dgvDanhSachGiaoVien.RowHeadersWidth = 51;
            this.dgvDanhSachGiaoVien.Size = new System.Drawing.Size(1027, 277);
            this.dgvDanhSachGiaoVien.TabIndex = 12;
            this.dgvDanhSachGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachGiaoVien_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã giáo viên";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 125;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên giáo viên";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 634);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 67);
            this.panel2.TabIndex = 2;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(866, 14);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(125, 31);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(452, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 31);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(224, 16);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 31);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(666, 15);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 31);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 31);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FQuanLyGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giáo viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FQuanLyGiaoVien_FormClosed);
            this.Load += new System.EventHandler(this.FQuanLyGiaoVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbTaiKhoan.ResumeLayout(false);
            this.grbTaiKhoan.PerformLayout();
            this.grbThongTinCaNhan.ResumeLayout(false);
            this.grbThongTinCaNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTaiKhoan;
        private System.Windows.Forms.GroupBox grbThongTinCaNhan;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaoVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTenGiaoVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.Button btnTimKiem;
    }
}