using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using GUI.GUI_HocSinh;
using GUI.GUI_Admin;

namespace GUI.GUI_GiaoVien
{
    public partial class FGiaoVien : Form
    {
        private String maGiaoVien;
        public FGiaoVien(String maGiaoVien)
        {
            InitializeComponent();
            this.maGiaoVien = maGiaoVien;
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable table = BUS_GiaoVien.Instance.hienThiThongTinGV(maGiaoVien);
            txtMaGV.Text = table.Rows[0]["MaGV"].ToString();
            txtTenGV.Text = table.Rows[0]["TenGV"].ToString();
            txtDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            txtSoDT.Text = table.Rows[0]["SoDT"].ToString();
            txtEmail.Text = table.Rows[0]["Email"].ToString();
        }
        private void mnuQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FQuanLyHocSinh(maGiaoVien).Show();
        }

        private void mnuQuanLyKetQuaHocTap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FQuanLyKetQuaHocTap(maGiaoVien).Show();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FDoiMatKhau(maGiaoVien).ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không? ", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                FDangNhap.Instance.Show();
            }
        }

        private void FGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
