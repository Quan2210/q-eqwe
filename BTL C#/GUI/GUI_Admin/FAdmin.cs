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
                this.Hide();
                FDangNhap.Instance.Show();
            }
        }

        private void mnuQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FQuanLyGiaoVien().Show();
        }

        private void mnuQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQuanLyHocSinh qlHocSinh = new FQuanLyHocSinh("admin");
            qlHocSinh.Show();
        }

        private void mnuQuanLyLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FQuanLyLop().Show();
        }

        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
