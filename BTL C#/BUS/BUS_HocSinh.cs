using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HocSinh
    {
        private static BUS_HocSinh instance;

        public static BUS_HocSinh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HocSinh();
                }
                return instance;
            }
        }

        public Boolean checkTaiKhoanHocSinh(String username, String pass)
        {
            String query = "SELECT * FROM HocSinh WHERE MaHS = @mahs and MatKhau = @matkhau ";
            object[] para = new object[] { username, pass };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            if (table.Rows.Count != 0) return true;
            else return false;
        }
        public DataTable layDanhSachHocSinh()
        {
            String query = "SELECT * FROM HocSinh";
            object[] para = new object[] { };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public DataTable layDanhSachHocSinh(String maGiaoVien)
        {
            String query = "SELECT MaHS, TenHS, NgaySinh, GioiTinh, DiaChi, SoDT, HoTenBo,SoDTBo, HoTenMe, SoDTMe, MienGiam, MatKhau, Lop.MaLop FROM HocSinh INNER JOIN LOP ON HocSinh.MaLop = Lop.MaLop WHERE MaGV = @magv ";
            object[] para = new object[] { maGiaoVien };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }

        //để tạm

        public Boolean checkLop(String maLop)
        {
            String query = "SELECT * FROM Lop WHERE MaLop = @malop";
            object[] para = new object[] { maLop };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            if (table.Rows.Count != 0) return true;
            else return false;
        }
        public DataTable layDanhSachLop()
        {
            String query = "SELECT * FROM LOP";
            object[] para = new object[] { };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public DataTable layDanhSachLop(String maGiaoVien)
        {
            String query = "SELECT * FROM LOP WHERE MAGV = @magv";
            object[] para = new object[] { maGiaoVien };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }

        public void xoaHocSinh(String maHs)
        {
            String queryXoaHocSinh = "DELETE FROM HocSinh WHERE MaHS = @mahs";
            object[] para = new object[] { maHs };
            dataProvider.Instance.EXcuteNonQuery(queryXoaHocSinh, para);

            //Xóa điểm nếu cần
            //String queryDiem = "DELETE FROM Diem WHERE MaHS = @mahs";
            //dataProvider.Instance.EXcuteNonQuery(queryDiem, para);

        }
        public void themHocSinh(DTO_HocSinh hs)
        {
            String insertSQL = "INSERT HocSinh VALUES ( @mahs , @tenhs , @ngsinh , @gt , @dc , @sodt , @htbo , @sdtbo , @htme , @sdtme , @mg , @mk , @ml )";
            object[] para = new object[] { hs.MaHS, hs.TenHS, hs.NgaySinh, hs.GioiTinh,
                                            hs.DiaChi, hs.SoDT, hs.HoTenBo, hs.SoDTBo,
                                            hs.HoTenMe, hs.SoDTMe, hs.MienGiam, hs.MatKhau,
                                            hs.MaLop };
            dataProvider.Instance.EXcuteNonQuery(insertSQL, para);
        }

        public void suaHocSinh(DTO_HocSinh hs)
        {
            String updateSQL = "UPDATE HocSinh SET TenHS = @tenhs , NgaySinh = @ns ,  GioiTinh = @gt , DiaChi = @dc , SoDT = @sodt , HoTenBo = @htbo , SoDTBo = @sdtbo , HoTenMe = @htme , SoDTMe = @sdtme , MienGiam = @mg , MatKhau = @mk , MaLop = @ml WHERE MaHS = @mahs ";
            object[] para = new object[] {  hs.TenHS, hs.NgaySinh, hs.GioiTinh,
                                            hs.DiaChi, hs.SoDT, hs.HoTenBo, hs.SoDTBo,
                                            hs.HoTenMe, hs.SoDTMe, hs.MienGiam, hs.MatKhau,
                                            hs.MaLop , hs.MaHS};
            dataProvider.Instance.EXcuteNonQuery(updateSQL, para);
        }
        public DataTable hienThi(string maHSinh)
        {
            string query = "select * from HocSinh where MaHS = @maHS ";
            object[] para = new object[] { maHSinh };
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public void capNhatMatKhauHS(String maHocSinh,String matKhauMoi)
        {
            String query = "Update HocSinh set MatKhau = @matKhauMoi where MaHS = @maHS";
            object[] para = { matKhauMoi, maHocSinh };
            dataProvider.Instance.EXcuteNonQuery(query, para);
        }
    }
}
