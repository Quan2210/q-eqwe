using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.GUI_Admin;
using GUI.GUI_HocSinh;
using GUI.GUI_GiaoVien;
using BUS;
namespace GUI
{
    public partial class FDangNhap : Form
    {
        private static FDangNhap instance;

        public static FDangNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FDangNhap();
                }
                return instance;
            }
        }

        private FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPass.Text.Equals("admin"))
            {
                FAdmin admin = new FAdmin();
                admin.Show();
                this.Hide();
            }
            else if (BUS_GiaoVien.Instance.checkTaiKhoanGiaoVien(txtUsername.Text, txtPass.Text))
            {
                FGiaoVien giaoVien = new FGiaoVien(txtUsername.Text);
                giaoVien.Show();
                this.Hide();
            }
            else if (BUS_HocSinh.Instance.checkTaiKhoanHocSinh(txtUsername.Text, txtPass.Text))
            {
                FThongTinHocSinh hocSinh = new FThongTinHocSinh(txtUsername.Text);
                hocSinh.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK);


        }
    }
}
