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
using DTO;

namespace GUI.GUI_HocSinh
{
    public partial class FThongTinHocSinh : Form
    {
        String maHocSinh;
        public FThongTinHocSinh(String maHocSinh)
        {
            InitializeComponent();
            this.maHocSinh = maHocSinh;
        }

        private void FThongTinHocSinh_Load(object sender, EventArgs e)
        {
           
            DataTable table = BUS_HocSinh.Instance.hienThi(maHocSinh);
            lblTenHS.Text = table.Rows[0]["TenHS"].ToString();
            lblMaHS.Text = table.Rows[0]["MaHS"].ToString();
            lblNgaySinh.Text = table.Rows[0]["NgaySinh"].ToString();
            lblDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            lblSoDTBo.Text = table.Rows[0]["SoDTBo"].ToString();
            lblSoDT.Text = table.Rows[0]["SoDT"].ToString();
            lblSoDTMe.Text = table.Rows[0]["SoDTMe"].ToString();
            lblHoTenMe.Text = table.Rows[0]["HoTenMe"].ToString();
            lblHoTenBo.Text = table.Rows[0]["HoTenBo"].ToString();
            
            if ((bool)table.Rows[0]["GioiTinh"] == true)
            {
                lblGioiTinh.Text = "Nam";
            }
            else
            {
                lblGioiTinh.Text = "Nữ";
            }
            if((bool)table.Rows[0]["MienGiam"] == true)
            {
                lblMienGiam.Text = "Có";
            }
            else
            {
                lblMienGiam.Text = "Không";
            }
        }

        

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FDoiMatKhau(maHocSinh).ShowDialog();
        }

        private void mnuXemKetQuaHocTap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FXemKetQuaHocTap(maHocSinh).Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FDangNhap.Instance.Show();
            }
        }

        private void FThongTinHocSinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
