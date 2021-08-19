using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.GUI_Admin
{
    public partial class FXacNhanTTHocSinh : Form
    {
        String mess;
        DTO_HocSinh hs;
        public FXacNhanTTHocSinh(String mess, DTO_HocSinh hs)
        {
            InitializeComponent();
            this.mess = mess;
            this.hs = hs;
        }

        private void FXacNhanTTHocSinh_Load(object sender, EventArgs e)
        {
            if (mess.Equals("add"))
                lbMessage.Text = "Xác nhận thêm học sinh mới?";
            else if (mess.Equals("update"))
                lbMessage.Text = "Xác nhận sửa thông tin học sinh?";

            lbMaHocSinh.Text = hs.MaHS;
            lbTenHocSinh.Text = hs.TenHS;
            lbNgaySinh.Text = hs.NgaySinh.ToShortDateString();

            if (hs.GioiTinh == true)
                lbGioiTinh.Text = "Nam";
            else
                lbGioiTinh.Text = "Nữ";

            lbDiaChi.Text = hs.DiaChi;
            lbSoDienThoai.Text = hs.SoDT;
            lbHoTenBo.Text = hs.HoTenBo;
            lbSodienThoaiBo.Text = hs.SoDTBo;
            lbHoTenMe.Text = hs.HoTenMe;
            lbSoDienThoaiMe.Text = hs.SoDTMe;
            if (hs.MienGiam == true)
                lbMienGiam.Text = "Thuộc diện miễn giảm học phí";
            else
                lbMienGiam.Text = "Không thuộc diện miễn giảm học phí";

            lbMatKhau.Text = hs.MatKhau;
            lbLop.Text = hs.MaLop;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (mess.Equals("add"))
            {
                BUS_HocSinh.Instance.themHocSinh(hs);
                this.Dispose();
            }
            else if (mess.Equals("update"))
            {
                BUS_HocSinh.Instance.suaHocSinh(hs);
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
