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
    public partial class FQuanLyLop : Form
    {
        public FQuanLyLop()
        {
            InitializeComponent();
        }

        private void FQuanLyLop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = BUS_Lop.Instance.hienThi();
            DataTable table = BUS_Lop.Instance.hienThiGV();
            cbbMaGV.DataSource = table;
            cbbMaGV.DisplayMember = "MaGV";
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[d].Cells[0].Value.ToString();
            cbbMaGV.Text = dgvLop.Rows[d].Cells[1].Value.ToString();
            lbSiSo.Text = dgvLop.Rows[d].Cells[2].Value.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FAdmin().ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = "";
            string maGV = "";
            int SiSo = 0;
            try
            {
                maGV = cbbMaGV.Text;
                maLop = txtMaLop.Text;
                
                if(maGV != "" && maLop != "")
                {
                    DTO_Lop lop = new DTO_Lop(maLop, maGV, SiSo);
                   
                        if (BUS_Lop.Instance.them(lop))
                        {
                            dgvLop.DataSource = BUS_Lop.Instance.hienThi();
                            MessageBox.Show("Thêm thành công", "Thêm");
                       }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Báo Lỗi");
                }
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains(" duplicate key "))
                {
                    MessageBox.Show("Bạn ko được nhập trùng mã lớp", "Báo Lỗi");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }    
               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                string maGV = cbbMaGV.Text;
                string maLop = txtMaLop.Text;
                int Siso = int.Parse(lbSiSo.Text);
                if (maGV != "" && maLop != "")
                {
                    DTO_Lop lop = new DTO_Lop(maLop, maGV, Siso);
                    if (MessageBox.Show("Bạn muốn sửa Lớp : " + maLop, "Sửa Lớp", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (BUS_Lop.Instance.sua(lop, maLop))
                        {
                            dgvLop.DataSource = BUS_Lop.Instance.hienThi();
                            MessageBox.Show("Sửa thành công", "Sửa");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Báo Lỗi");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains(" duplicate key "))
                {
                    MessageBox.Show("Bạn ko được nhập trùng mã lớp", "Báo Lỗi");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FQuanLyLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
