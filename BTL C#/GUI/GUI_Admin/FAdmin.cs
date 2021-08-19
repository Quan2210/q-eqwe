using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_Admin
{
    public partial class FAdmin : Form
    {
        
        public FAdmin()
        {
            InitializeComponent();
          
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không? ", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                FDangNhap.Instance.Show();
            }
        }

        private void mnuQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FQuanLyGiaoVien().Show();
        }

        private void mnuQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FQuanLyHocSinh qlHocSinh = new FQuanLyHocSinh("admin");
            qlHocSinh.ShowDialog();
        }

        private void mnuQuanLyLop_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FQuanLyLop().ShowDialog();
        }

        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
