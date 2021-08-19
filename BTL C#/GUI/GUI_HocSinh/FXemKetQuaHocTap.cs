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
namespace GUI.GUI_HocSinh
{
    public partial class FXemKetQuaHocTap : Form
    {
        String maHocSinh;
        public FXemKetQuaHocTap(String maHocSinh)
        {
            InitializeComponent();
            this.maHocSinh = maHocSinh;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new FThongTinHocSinh(maHocSinh).Show();
        }

        private void FXemKetQuaHocTap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void xoa()
        {
            Label[] labels = { lblKQToan, lblKQVatLy, lblKQHoaHoc, lblKQSinhHoc, lblKQNguVan,
                    lblKQTiengAnh, lblKQTheDuc, lblKQDiaLy, lblKQLichSu, lblKQDiaLy,lblKQGDCD, lblKQCongNghe,lblKQHanhKiem};
            foreach(Label label in labels)
            {
                label.Text="";
            }
            
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                int namHoc = int.Parse(cbbNamHoc.Text); 
                DataTable table = BUS.BUS_KetQua.Instance.layKetQua(maHocSinh,namHoc,rdbKy1.Checked?false:true);
                
                if (table.Rows.Count == 0)
                {
                    xoa();
                    throw new Exception("Không tìm thấy kết quả!!!");
                }
                else
                {
                    lblKQToan.Text = table.Rows[0]["Toan"].ToString();
                    lblKQVatLy.Text = table.Rows[0]["Ly"].ToString();
                    lblKQHoaHoc.Text = table.Rows[0]["Hoa"].ToString();
                    lblKQNguVan.Text = table.Rows[0]["Van"].ToString();
                    lblKQLichSu.Text = table.Rows[0]["LichSu"].ToString();
                    lblKQCongNghe.Text = table.Rows[0]["LichSu"].ToString();
                    lblKQDiaLy.Text = table.Rows[0]["DiaLy"].ToString();
                    lblKQTheDuc.Text = table.Rows[0]["TheDuc"].ToString();
                    lblKQSinhHoc.Text = table.Rows[0]["SinhHoc"].ToString();
                    lblKQTiengAnh.Text = table.Rows[0]["Anh"].ToString();
                    lblKQGDCD.Text = table.Rows[0]["GDCD"].ToString();
                    lblKQHanhKiem.Text = table.Rows[0]["HanhKiem"].ToString();
                }
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("correct format"))
                    MessageBox.Show("Vui lòng chọn năm học!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FXemKetQuaHocTap_Load(object sender, EventArgs e)
        {
            for(int i = 2010; i <= 2030; i++)
            {
                cbbNamHoc.Items.Add(i);
            }
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            new FThongTinHocSinh(maHocSinh).Show();
        }
    }
}
