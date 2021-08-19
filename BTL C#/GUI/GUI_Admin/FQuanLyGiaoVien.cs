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
namespace GUI.GUI_Admin
{
    public partial class FQuanLyGiaoVien : Form
    {
        public FQuanLyGiaoVien()
        {
            InitializeComponent();
        }
        private void xoaTrang()
        {
            txtMaGiaoVien.Clear();
            txtTenGiaoVien.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
        }

        private void FQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachGiaoVien.DataSource = BUS_GiaoVien.Instance.layDanhSachGiaoVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String maGV = txtMaGiaoVien.Text;
                String tenGV = txtTenGiaoVien.Text;
                String diaChi = txtDiaChi.Text;
                String email = txtEmail.Text;
                String soDT = txtSoDienThoai.Text;
                String matKhau = txtMatKhau.Text;
                if (String.IsNullOrEmpty(maGV) || String.IsNullOrEmpty(tenGV) || String.IsNullOrEmpty(diaChi) || String.IsNullOrEmpty(soDT) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(matKhau))
                    throw new Exception("Bạn vui lòng nhập đầy đủ thông tin!");
                DTO_GiaoVien giaoVien = new DTO_GiaoVien(maGV, tenGV, diaChi, soDT, email, matKhau);
                BUS_GiaoVien.Instance.themGiaoVien(giaoVien);
                xoaTrang();
                FQuanLyGiaoVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                    MessageBox.Show("Mã giáo viên đã tồn tại,không thể thêm!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaGiaoVien_TextChanged(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = txtMaGiaoVien.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachGiaoVien.SelectedRows.Count == 0)
                    throw new Exception("Vui lòng chọn dòng cần sửa");
                else
                {
                    String maGV = txtMaGiaoVien.Text;
                    String tenGV = txtTenGiaoVien.Text;
                    String diaChi = txtDiaChi.Text;
                    String email = txtEmail.Text;
                    String soDT = txtSoDienThoai.Text;
                    String matKhau = txtMatKhau.Text;
                    if (String.IsNullOrEmpty(maGV) || String.IsNullOrEmpty(tenGV) || String.IsNullOrEmpty(diaChi) || String.IsNullOrEmpty(soDT) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(matKhau))
                        throw new Exception("Bạn vui lòng nhập đầy đủ thông tin!");
                    else
                    {
                        if (double.TryParse(soDT, out double kq) == false)
                        {
                            throw new Exception("Điện thoại phải là số!");
                        }
                        else
                        {
                            DTO_GiaoVien giaoVien = new DTO_GiaoVien(maGV, tenGV, diaChi, soDT, email, matKhau);
                            BUS_GiaoVien.Instance.suaThongTinGiaoVien(giaoVien);
                            FQuanLyGiaoVien_Load(sender, e);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachGiaoVien.SelectedRows.Count == 0)
                    throw new Exception("Vui lòng chọn dòng cần xóa");
                else
                {
                    String maGV = txtMaGiaoVien.Text;
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên có mã " + maGV, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        BUS_GiaoVien.Instance.xoaGiaoVien(maGV);
                        xoaTrang();
                        FQuanLyGiaoVien_Load(sender, e);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FAdmin().Show();
        }

        private void dgvDanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            dgvDanhSachGiaoVien.CurrentRow.Selected = true;
            txtMaGiaoVien.Text = dgvDanhSachGiaoVien.Rows[row].Cells[0].Value.ToString();
            txtTenGiaoVien.Text = dgvDanhSachGiaoVien.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSachGiaoVien.Rows[row].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvDanhSachGiaoVien.Rows[row].Cells[3].Value.ToString();
            txtEmail.Text = dgvDanhSachGiaoVien.Rows[row].Cells[4].Value.ToString();
            txtMatKhau.Text = dgvDanhSachGiaoVien.Rows[row].Cells[5].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                String maGV = txtMaGiaoVien.Text;
                if (String.IsNullOrEmpty(maGV))
                    throw new Exception("Vui lòng nhập mã giáo viên cần tìm kiếm!");
                else
                {
                    if (BUS_GiaoVien.Instance.timKiemGiaoVien(maGV).Rows.Count == 0)
                        throw new Exception("Không tìm thấy giáo viên có mã " + maGV);
                    else
                    {
                        dgvDanhSachGiaoVien.DataSource = BUS_GiaoVien.Instance.timKiemGiaoVien(maGV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FQuanLyGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
