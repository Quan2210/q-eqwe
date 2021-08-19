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
using GUI.GUI_GiaoVien;

namespace GUI.GUI_HocSinh
{
    public partial class FDoiMatKhau : Form
    {
        String ma;
        public FDoiMatKhau(String ma)
        {
            InitializeComponent();
            this.ma = ma;
        }
       private void xoaTrang()
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMatKhauMoi.Clear();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                String matKhauCu = txtMatKhauCu.Text.Trim();
                String matKhauMoi = txtMatKhauMoi.Text.Trim();
                String xacNhan = txtXacNhanMatKhauMoi.Text.Trim();
                if (String.IsNullOrEmpty(matKhauCu) || String.IsNullOrEmpty(matKhauMoi) || String.IsNullOrEmpty(xacNhan))
                {
                    xoaTrang();
                    throw new Exception("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    if (BUS_HocSinh.Instance.checkTaiKhoanHocSinh(ma, matKhauCu))
                    {
                        if (xacNhan.Equals(matKhauMoi) == false)
                        {
                            txtMatKhauMoi.Clear();
                            txtXacNhanMatKhauMoi.Clear();
                            throw new Exception("Mật khẩu không khớp!Vui lòng nhập lại!");
                        }
                        else
                        {
                            BUS_HocSinh.Instance.capNhatMatKhauHS(ma, matKhauMoi);
                            this.Close();
                        }
                    }
                    else if (BUS_GiaoVien.Instance.checkTaiKhoanGiaoVien(ma, matKhauCu))
                    {
                        if (xacNhan.Equals(matKhauMoi) == false)
                        {
                            txtMatKhauMoi.Clear();
                            txtXacNhanMatKhauMoi.Clear();
                            throw new Exception("Mật khẩu không khớp!Vui lòng nhập lại!");
                        }
                        else
                        {
                            BUS_GiaoVien.Instance.updateMatKhau(ma, matKhauMoi);
                            this.Close();
                        }
                    }
                    else
                    {
                        xoaTrang();
                        throw new Exception("Mật khẩu cũ không chính xác!Vui lòng nhập lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
