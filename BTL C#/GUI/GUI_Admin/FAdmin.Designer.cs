
namespace GUI.GUI_Admin
{
    partial class FAdmin
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLyGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyGiaoVien,
            this.mnuQuanLyHocSinh,
            this.mnuQuanLyLop,
            this.mnuDangXuat});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(800, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuQuanLyGiaoVien
            // 
            this.mnuQuanLyGiaoVien.Name = "mnuQuanLyGiaoVien";
            this.mnuQuanLyGiaoVien.Size = new System.Drawing.Size(138, 24);
            this.mnuQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.mnuQuanLyGiaoVien.Click += new System.EventHandler(this.mnuQuanLyGiaoVien_Click);
            // 
            // mnuQuanLyHocSinh
            // 
            this.mnuQuanLyHocSinh.Name = "mnuQuanLyHocSinh";
            this.mnuQuanLyHocSinh.Size = new System.Drawing.Size(131, 24);
            this.mnuQuanLyHocSinh.Text = "Quản lý học sinh";
            this.mnuQuanLyHocSinh.Click += new System.EventHandler(this.mnuQuanLyHocSinh_Click);
            // 
            // mnuQuanLyLop
            // 
            this.mnuQuanLyLop.Name = "mnuQuanLyLop";
            this.mnuQuanLyLop.Size = new System.Drawing.Size(99, 24);
            this.mnuQuanLyLop.Text = "Quản lý lớp";
            this.mnuQuanLyLop.Click += new System.EventHandler(this.mnuQuanLyLop_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(91, 24);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAdmin_FormClosed);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyLop;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
    }
}