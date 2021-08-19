using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
using System.Windows.Forms;
using Microsoft.Office.Core;
using ms = Microsoft.Office.Interop.Excel;

namespace BUS
{
    public class BUS_GiaoVien
    {
        private static BUS_GiaoVien instance;

        public static BUS_GiaoVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_GiaoVien();
                }
                return instance;
            }
        }
        public Boolean checkTaiKhoanGiaoVien(String username, String pass)
        {
            String query = "SELECT * FROM GiaoVien WHERE MaGV = @magv and MatKhau = @matkhau";
            object[] para = new object[] { username, pass };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            if (table.Rows.Count != 0) return true;
            else return false;
        }
        public DataTable layDanhSachGiaoVien()
        {
            String query = "select * from GiaoVien";
            object[] para = { };
            DataTable table =dataProvider.Instance.EXcuteQuery(query,para);
            return table;
        }
        public void themGiaoVien(DTO_GiaoVien giaoVien)
        {
            String query = "Insert into GiaoVien values ( @maGV , @tenGV , @diaChi , @soDT , @email , @matKhau )";
            object[] para = { giaoVien.MaGV, giaoVien.TenGV, giaoVien.DiaChi, giaoVien.SoDT, giaoVien.Email, giaoVien.MatKhau };
            dataProvider.Instance.EXcuteNonQuery(query, para);
        }
        public void xoaGiaoVien(String maGV)
        {
            String query = "Delete from GiaoVien where MaGV = @maGV";
            object[] para = { maGV };
            dataProvider.Instance.EXcuteNonQuery(query, para);
        }
        public void suaThongTinGiaoVien(DTO_GiaoVien giaoVien)
        {
            String query = "Update GiaoVien set TenGV= @tenGV ,DiaChi= @diaChi , SoDT= @soDT ,Email= @email ,MatKhau= @matKhau where MaGV= @maGV ";
            object[] para = { giaoVien.TenGV, giaoVien.DiaChi, giaoVien.SoDT, giaoVien.Email, giaoVien.MatKhau, giaoVien.MaGV };
            dataProvider.Instance.EXcuteNonQuery(query, para);
        }
        public DataTable timKiemGiaoVien(String maGV)
        {
            String query = "select * from GiaoVien where MaGv= @maGV";
            object[] para = { maGV };
            return dataProvider.Instance.EXcuteQuery(query, para);
        }
        public DataTable hienThiThongTinGV(string maGV)
        {
            DataTable table = new DataTable();
            string query = "select * from GiaoVien where MaGV = @MaGV ";
            object[] para = new object[] { maGV};
            table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public DataTable matKhauCu(string MaGV)
        {
            DataTable table = new DataTable();
            string query = "select MatKhau from GiaoVien where MaGV = @MaGV ";
            object[] para = new object[] {MaGV };
            table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public bool updateMatKhau(string matkhaumoi, string MaGV)
        {
            string query = "update GiaoVien set MatKhau = @MaKhau where MaGV = @MaGV ";
            object[] para = new object[] {matkhaumoi, MaGV };
            if(dataProvider.Instance.EXcuteNonQuery(query, para)>0)
            {
                return true;
            }
            return false;
        }
        public void Export2Excel(DataGridView dgr)
        {
            try
            {

                 ms.Application exa = new ms.Application();
                 ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
                 ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
                 exa.Visible = true;
                 for (int i = 0; i < dgr.Columns.Count; ++i)
                 {
                     ws.Cells[1, i + 1] = dgr.Columns[i].HeaderText;
                 }
                 ms.Range ran = ws.get_Range("a1", "z1");

                 for (int i = 0; i < dgr.Rows.Count; ++i)
                 {
                     for (int j = 0; j < dgr.Columns.Count; ++j)
                     {
                        if(dgr.Rows[i].Cells[j].Value.ToString() == "True")
                        {
                            ws.Cells[i + 2, j + 1] = "1";
                        }
                        else if (dgr.Rows[i].Cells[j].Value.ToString() == "False")
                        {
                            ws.Cells[i + 2, j + 1] = "2";
                        }
                        else
                        {
                            ws.Cells[i + 2, j + 1] = dgr.Rows[i].Cells[j].Value.ToString();
                        }
                     }
                 }
                 ws.Columns.AutoFit();
                if (ws != null)
                {
                    if (ws.UsedRange != null)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}