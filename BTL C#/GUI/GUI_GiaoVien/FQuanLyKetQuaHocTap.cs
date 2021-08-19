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

namespace GUI.GUI_GiaoVien
{
    public partial class FQuanLyKetQuaHocTap : Form
    {
        private string maGV;
        public FQuanLyKetQuaHocTap(string maGV)
        {
            InitializeComponent();
            this.maGV = maGV;
        }

        private void FQuanLyKetQuaHocTap_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = BUS_KetQua.Instance.hienthi(maGV);
            DataTable table = BUS_KetQua.Instance.hienThiHocSinhCuaGV(maGV);
            cbbMaHS.DataSource = table;
            cbbMaHS.DisplayMember = "TenHS";
            cbbMaHS.ValueMember = "MaHS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FGiaoVien(maGV).ShowDialog();
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d > -1)
            {
                txtNamHoc.Text = dgvKetQua.Rows[d].Cells[0].Value.ToString();
                if ((bool)dgvKetQua.Rows[d].Cells[2].Value == true)
                {
                    rbKy1.Checked = true;
                }
                else
                {
                    rbKy2.Checked = true;
                }
                cbbMaHS.Text = dgvKetQua.Rows[d].Cells[1].Value.ToString();
                txtToan.Text = dgvKetQua.Rows[d].Cells[3].Value.ToString();
                txtVatLy.Text = dgvKetQua.Rows[d].Cells[4].Value.ToString();
                txtHoa.Text = dgvKetQua.Rows[d].Cells[5].Value.ToString();
                txtVan.Text = dgvKetQua.Rows[d].Cells[6].Value.ToString();
                txtAnh.Text = dgvKetQua.Rows[d].Cells[7].Value.ToString();
                txtLichSu.Text = dgvKetQua.Rows[d].Cells[8].Value.ToString();
                txtDiaLy.Text = dgvKetQua.Rows[d].Cells[9].Value.ToString();
                txtGDCD.Text = dgvKetQua.Rows[d].Cells[10].Value.ToString();
                txtTheDuc.Text = dgvKetQua.Rows[d].Cells[11].Value.ToString();
                txtCongNghe.Text = dgvKetQua.Rows[d].Cells[12].Value.ToString();
                txtSinhHoc.Text = dgvKetQua.Rows[d].Cells[13].Value.ToString();
                txtHanhKiem.Text = dgvKetQua.Rows[d].Cells[14].Value.ToString();
                txtNhanXet.Text = dgvKetQua.Rows[d].Cells[15].Value.ToString();
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int namHoc = 0;
            string maHS = "";
            float toan = 0;
            float ly = 0;
            float hoa = 0;
            float van = 0;
            float anh = 0;
            float su = 0;
            float dia = 0;
            float cd = 0;
            float theduc = 0;
            float congnghe = 0;
            float sinh = 0;
            string hanhkiem = "";
            string nhanxet = "";
            try
            {
                namHoc = int.Parse(txtNamHoc.Text);
                maHS = cbbMaHS.Text;
                bool kyHoc = true;
                if(rbKy1.Checked)
                {
                    kyHoc = true;
                }
                else
                {
                    kyHoc = false;
                }
                string hk = "";
                 if(kyHoc == true)
                {
                    hk = "1";
                }
                 else
                {
                    hk = "2";
                }
                toan = float.Parse(txtToan.Text);
                ly = float.Parse(txtVatLy.Text);
                hoa = float.Parse(txtHoa.Text);
                van = float.Parse(txtVan.Text);
                anh = float.Parse(txtAnh.Text);
                su = float.Parse(txtLichSu.Text);
                dia = float.Parse(txtDiaLy.Text);
                cd = float.Parse(txtGDCD.Text);
                theduc = float.Parse(txtTheDuc.Text);
                congnghe = float.Parse(txtCongNghe.Text);
                sinh = float.Parse(txtSinhHoc.Text);
                hanhkiem = txtHanhKiem.Text;
                nhanxet = txtNhanXet.Text;
                if(namHoc != 0 && maHS != "" && hanhkiem != "" && nhanxet != "" && toan > 0 && ly >0 && hoa > 0 && van > 0 && anh > 0 && su > 0 && dia > 0 && cd > 0 && 
                    theduc > 0 && congnghe > 0 && sinh > 0 )
                {
                    DTO_KetQua kq = new DTO_KetQua(namHoc, maHS, kyHoc, toan, ly, hoa, van, anh, su, dia, cd, theduc, congnghe, sinh, hanhkiem, nhanxet);
                    if (MessageBox.Show("Bạn muốn thêm kết quả cho học sinh: " + maHS + " trong Năm Học: " + namHoc + "Vào kỳ: " + hk, "Question?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (BUS_KetQua.Instance.them(kq))
                        {
                            MessageBox.Show("Thêm thành công", "Thêm");
                            dgvKetQua.DataSource = BUS_KetQua.Instance.hienthi(maGV);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Báo Lỗi");
                }
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains(" duplicate key "))
                {
                    MessageBox.Show("Bạn không đk nhập trùng khóa chính", "Lỗi");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int namHoc = 0;
            string maHS = "";
            float toan = 0;
            float ly = 0;
            float hoa = 0;
            float van = 0;
            float anh = 0;
            float su = 0;
            float dia = 0;
            float cd = 0;
            float theduc = 0;
            float congnghe = 0;
            float sinh = 0;
            string hanhkiem = "";
            string nhanxet = "";
            try
            {
                namHoc = int.Parse(txtNamHoc.Text);
                maHS = cbbMaHS.Text;
                bool kyHoc = true;
                if (rbKy1.Checked)
                {
                    kyHoc = true;
                }
                else
                {
                    kyHoc = false;
                }
                string hk = "";
                if (kyHoc == true)
                {
                    hk = "1";
                }
                else
                {
                    hk = "2";
                }
                toan = float.Parse(txtToan.Text);
                ly = float.Parse(txtVatLy.Text);
                hoa = float.Parse(txtHoa.Text);
                van = float.Parse(txtVan.Text);
                anh = float.Parse(txtAnh.Text);
                su = float.Parse(txtLichSu.Text);
                dia = float.Parse(txtDiaLy.Text);
                cd = float.Parse(txtGDCD.Text);
                theduc = float.Parse(txtTheDuc.Text);
                congnghe = float.Parse(txtCongNghe.Text);
                sinh = float.Parse(txtSinhHoc.Text);
                hanhkiem = txtHanhKiem.Text;
                nhanxet = txtNhanXet.Text;
                if (namHoc != 0 && maHS != "" && hanhkiem != "" && nhanxet != "" && toan > 0 && ly > 0 && hoa > 0 && van > 0 && anh > 0 && su > 0 && dia > 0 && cd > 0 &&
                    theduc > 0 && congnghe > 0 && sinh > 0)
                {
                    DTO_KetQua kq = new DTO_KetQua(namHoc, maHS, kyHoc, toan, ly, hoa, van, anh, su, dia, cd, theduc, congnghe, sinh, hanhkiem, nhanxet);
                    if (MessageBox.Show("Bạn muốn Sửa kết quả cho học sinh: " + maHS + " trong Năm Học: " + namHoc + "Vào kỳ: " + hk, "Question?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (BUS_KetQua.Instance.sua(kq))
                        {
                            MessageBox.Show("Sửa thành công", "Sửa");
                            dgvKetQua.DataSource = BUS_KetQua.Instance.hienthi(maGV);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Báo Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInExcel_Click(object sender, EventArgs e)
        {
            BUS_GiaoVien.Instance.Export2Excel(dgvKetQua);
        }

        private void FQuanLyKetQuaHocTap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
