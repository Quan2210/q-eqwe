
namespace GUI.GUI_HocSinh
{
    partial class FDoiMatKhau
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapMatKhauCu = new System.Windows.Forms.Label();
            this.lblNhapMatKhauMoi = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhauMoi = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(292, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblNhapMatKhauCu
            // 
            this.lblNhapMatKhauCu.AutoSize = true;
            this.lblNhapMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMatKhauCu.Location = new System.Drawing.Point(39, 72);
            this.lblNhapMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMatKhauCu.Name = "lblNhapMatKhauCu";
            this.lblNhapMatKhauCu.Size = new System.Drawing.Size(127, 17);
            this.lblNhapMatKhauCu.TabIndex = 1;
            this.lblNhapMatKhauCu.Text = "Nhập mật khẩu cũ:";
            // 
            // lblNhapMatKhauMoi
            // 
            this.lblNhapMatKhauMoi.AutoSize = true;
            this.lblNhapMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMatKhauMoi.Location = new System.Drawing.Point(39, 129);
            this.lblNhapMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMatKhauMoi.Name = "lblNhapMatKhauMoi";
            this.lblNhapMatKhauMoi.Size = new System.Drawing.Size(134, 17);
            this.lblNhapMatKhauMoi.TabIndex = 1;
            this.lblNhapMatKhauMoi.Text = "Nhập mật khẩu mới:";
            // 
            // lblXacNhanMatKhauMoi
            // 
            this.lblXacNhanMatKhauMoi.AutoSize = true;
            this.lblXacNhanMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanMatKhauMoi.Location = new System.Drawing.Point(39, 186);
            this.lblXacNhanMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXacNhanMatKhauMoi.Name = "lblXacNhanMatKhauMoi";
            this.lblXacNhanMatKhauMoi.Size = new System.Drawing.Size(160, 17);
            this.lblXacNhanMatKhauMoi.TabIndex = 1;
            this.lblXacNhanMatKhauMoi.Text = "Xác nhận mật khẩu mới:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(146, 235);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(155, 44);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(436, 235);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(155, 44);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(214, 69);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(412, 22);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(214, 129);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(412, 22);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // txtXacNhanMatKhauMoi
            // 
            this.txtXacNhanMatKhauMoi.Location = new System.Drawing.Point(214, 186);
            this.txtXacNhanMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacNhanMatKhauMoi.Name = "txtXacNhanMatKhauMoi";
            this.txtXacNhanMatKhauMoi.Size = new System.Drawing.Size(412, 22);
            this.txtXacNhanMatKhauMoi.TabIndex = 3;
            // 
            // FDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 308);
            this.Controls.Add(this.txtXacNhanMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblXacNhanMatKhauMoi);
            this.Controls.Add(this.lblNhapMatKhauMoi);
            this.Controls.Add(this.lblNhapMatKhauCu);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapMatKhauCu;
        private System.Windows.Forms.Label lblNhapMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhauMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanMatKhauMoi;
    }
}