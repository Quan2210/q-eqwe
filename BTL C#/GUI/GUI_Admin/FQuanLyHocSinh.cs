using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using GUI.GUI_GiaoVien;


namespace GUI.GUI_Admin
{
    public partial class FQuanLyHocSinh : Form
    {
        private String role;
        private int selRow;
        public FQuanLyHocSinh(String s) //s = 'admin' => load toàn bộ học sinh, s = chuỗi mã giáo viên load ra học sinh của lớp đó 
        {
            InitializeComponent();
            this.role = s;
            dtgHocSinh.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void FQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            if (role.Equals("admin"))
            {
                dtgHocSinh.DataSource = BUS_HocSinh.Instance.layDanhSachHocSinh();
                cbbHocSinhLop.DataSource = BUS_HocSinh.Instance.layDanhSachLop();
                cbbHocSinhLop.DisplayMember = "MaLop";
                cbbHocSinhLop.ValueMember = "MaLop";
                
            }
            else
            {
                dtgHocSinh.DataSource = BUS_HocSinh.Instance.layDanhSachHocSinh(role);
                cbbHocSinhLop.DataSource = BUS_HocSinh.Instance.layDanhSachLop(role);
                cbbHocSinhLop.DisplayMember = "MaLop";
                cbbHocSinhLop.ValueMember = "MaLop";
                cbbHocSinhLop.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void dtgHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex  < dtgHocSinh.Rows.Count -1)
            {
                selRow = e.RowIndex;
                

                txtMaHocSinh.Text = dtgHocSinh.Rows[selRow].Cells[0].Value.ToString();
                txtTenHocSinh.Text = dtgHocSinh.Rows[selRow].Cells[1].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dtgHocSinh.Rows[selRow].Cells[2].Value.ToString());
                if (dtgHocSinh.Rows[selRow].Cells[3].Value.Equals(true))
                    rbtNam.Checked = true;
                else
                    rbtNu.Checked = true;
                txtDiaChi.Text = dtgHocSinh.Rows[selRow].Cells[4].Value.ToString();
                txtSoDienThoai.Text = dtgHocSinh.Rows[selRow].Cells[5].Value.ToString();
                txtHoTenBo.Text = dtgHocSinh.Rows[selRow].Cells[6].Value.ToString();
                txtSoDienThoaiBo.Text = dtgHocSinh.Rows[selRow].Cells[7].Value.ToString();
                txtHoTenMe.Text = dtgHocSinh.Rows[selRow].Cells[8].Value.ToString();
                txtSoDienThoaiMe.Text = dtgHocSinh.Rows[selRow].Cells[9].Value.ToString();
                if (dtgHocSinh.Rows[selRow].Cells[10].Value.Equals(true))
                    cbMienGiam.Checked = true;
                else
                    cbMienGiam.Checked = false;
                txtMatKhau.Text = dtgHocSinh.Rows[selRow].Cells[11].Value.ToString();
                cbbHocSinhLop.SelectedValue = dtgHocSinh.Rows[selRow].Cells[12].Value.ToString();
            }
            else
            {
                TextBox[] tbArr = new TextBox[] { txtDiaChi, txtHoTenBo, txtMaHocSinh, txtMatKhau, txtSoDienThoaiBo, txtHoTenMe, txtSoDienThoaiMe, txtTenHocSinh, txtSoDienThoai };

                foreach (TextBox tb in tbArr)
                {
                    tb.Text = "";
                    
                }
            }
        }
        //Chức Năng Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateTextbox())
            {
                try
                {
                    FXacNhanTTHocSinh xacNhan = new FXacNhanTTHocSinh("add", getHocSinhFromTextbox());
                    xacNhan.ShowDialog();
                    FQuanLyHocSinh_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("duplicate key"))
                        MessageBox.Show("Học sinh có mã này đã tồn tại!", "Lưu ý!", MessageBoxButtons.OK);
                    else MessageBox.Show("Lỗi thực thi với CSDL \n Mã lỗi: " + ex.Message, "Lỗi!", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Dữ liệu nhập vào không hợp lệ \n (Không được trống và không được chứa kí tự đặc biệt!)", "Lưu ý!", MessageBoxButtons.OK);

        }

        //Chức năng xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaHocSinh.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh có mã HS: " + txtMaHocSinh.Text, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BUS_HocSinh.Instance.xoaHocSinh(txtMaHocSinh.Text);
                    FQuanLyHocSinh_Load(sender, e);
                }
            }
        }
        //Chức năng sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validateTextbox())
            {
                try
                {
                    FXacNhanTTHocSinh xacNhan = new FXacNhanTTHocSinh("update", getHocSinhFromTextbox());
                    xacNhan.ShowDialog();
                    FQuanLyHocSinh_Load(sender, e);
                }
                catch(SqlException ex)
                {
                    if (ex.Message.Contains("duplicate key"))
                        MessageBox.Show("Học sinh có mã này đã tồn tại!", "Lưu ý!", MessageBoxButtons.OK);
                    else MessageBox.Show("Lỗi thực thi với CSDL \n Mã lỗi: " + ex.ErrorCode, "Lỗi!", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Dữ liệu nhập vào không hợp lệ \n (Không được trống và không được chứa kí tự đặc biệt!)", "Lưu ý!", MessageBoxButtons.OK);

        }

        //Kiểm tra hợp lệ dữ liệu các textbox
        private Boolean validateTextbox()
        {
            TextBox[] tbArr = new TextBox[] { txtDiaChi, txtHoTenBo, txtMaHocSinh, txtMatKhau, txtSoDienThoaiBo, txtHoTenMe, txtSoDienThoaiMe, txtTenHocSinh , txtSoDienThoai};
           
            foreach (TextBox tb in tbArr)
            {
                tb.Text.Trim();
                if(tb.Text == "" || tb.Text.Contains("--"))
                {
                    return false;
                }
            }
            if (!BUS_HocSinh.Instance.checkLop(cbbHocSinhLop.Text))
            {
                return false;
            }
            return true;
            
        }

        //Lấy thông tin ra đối tượng học sinh từ textbox
        private DTO_HocSinh getHocSinhFromTextbox()
        {
            
                return new DTO_HocSinh(txtMaHocSinh.Text, txtTenHocSinh.Text, dtpNgaySinh.Value,
                                        rbtNam.Checked ? true : false, txtDiaChi.Text, txtSoDienThoai.Text,
                                        txtHoTenBo.Text, txtSoDienThoaiBo.Text, txtHoTenMe.Text,
                                        txtSoDienThoaiMe.Text, cbMienGiam.Checked ? true : false,
                                        txtMatKhau.Text, cbbHocSinhLop.SelectedValue.ToString());

            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if(role.Equals("admin"))
            {
                new FAdmin().ShowDialog();
            }
            else
            {
                new FGiaoVien(role).ShowDialog();
            }
        }

        private void FQuanLyHocSinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
