using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_KetQua
    {
        private static BUS_KetQua instance;

        public static BUS_KetQua Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KetQua();
                }
                return instance;
            }
        }
        public List<DTO_KetQua> hienthi(string maGV)
        {
            List<DTO_KetQua> list = new List<DTO_KetQua>();
            string query = " select NamHoc, KetQua.MaHS, Ky, Toan, Ly, Hoa, Van, Anh, Lichsu, DiaLy, GDCD, TheDuc, CongNghe, SinhHoc, HanhKiem, NhanXetGV from KetQua inner join HocSinh on HocSinh.MaHS = KetQua.MaHS inner join Lop on HocSinh.MaLop = Lop.MaLop inner join GiaoVien on GiaoVien.MaGV = Lop.MaGV where GiaoVien.MaGV = @MaGV ";
            object[] para = new object[] { maGV};
            DataTable table = dataProvider.Instance.EXcuteQuery(query, para);
            foreach(DataRow dataRow in table.Rows)
            {
                int namHoc = int.Parse(dataRow["NamHoc"].ToString());
                string maHS = dataRow["MaHS"].ToString();
                bool ky = (bool)(dataRow["Ky"]);
                float toan = float.Parse(dataRow["Toan"].ToString());
                float ly = float.Parse(dataRow["Ly"].ToString());
                float hoa = float.Parse(dataRow["Hoa"].ToString());
                float van = float.Parse(dataRow["Van"].ToString());
                float anh = float.Parse(dataRow["Anh"].ToString());
                float lichsu = float.Parse(dataRow["Lichsu"].ToString());
                float dialy = float.Parse(dataRow["DiaLy"].ToString());
                float gdcd = float.Parse(dataRow["GDCD"].ToString());
                float theDuc = float.Parse(dataRow["TheDuc"].ToString());
                float congnghe = float.Parse(dataRow["CongNghe"].ToString());
                float sinhHoc = float.Parse(dataRow["SinhHoc"].ToString());
                string hanhKiem =dataRow["HanhKiem"].ToString();
                string nhanxet = dataRow["NhanXetGV"].ToString();
                DTO_KetQua ketQua = new DTO_KetQua(namHoc, maHS, ky, toan, ly, hoa, van, anh, lichsu, dialy, gdcd, theDuc, congnghe, sinhHoc, hanhKiem, nhanxet);
                list.Add(ketQua);
            }
            return list;
        }
        public bool them(DTO_KetQua ketqua)
        {
            string query = "insert into KetQua values( @NamHoc , @MaHS , @Ky , @Toan , @Ly , @Hoa , @Van , @Anh , @Su , @Dia , @GDCD , @TheDuc , @CongNghe , @Sinh , @HanhKiem , @NX )";
            object[] para = new object[] {ketqua.NamHoc, ketqua.MaHS, ketqua.KyHoc, ketqua.Toan, ketqua.Ly, ketqua.Hoa, ketqua.Van
            , ketqua.Anh, ketqua.LichSu, ketqua.DiaLy, ketqua.GiaoDucCD, ketqua.TheDuc, ketqua.CongNghe, ketqua.SinhHoc, ketqua.HanhKiem, ketqua.NhanXetGV};
            if(dataProvider.Instance.EXcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable hienThiHocSinhCuaGV(string maGV)
        {
            DataTable table = new DataTable();
            string query = "select MaHS from HocSinh inner join Lop on Lop.MaLop = HocSinh.MaLop inner join GiaoVien on Lop.MaGV = GiaoVien.MaGV where GiaoVien.MaGV = @MaGV ";
            object[] para = new object[] {maGV };
            table = dataProvider.Instance.EXcuteQuery(query, para);
            return table;
        }
        public bool sua(DTO_KetQua ketqua)
        {
            string query = "update KetQua set Toan = @Toan , Ly = @Ly , Hoa = @Hoa ,Van = @Van ,Anh = @Anh ,Lichsu = @Su ,Dialy = @Dia ,GDCD = @GDCD ,TheDuc = @TheDuc ,CongNghe = @CongNghe ,SinhHoc = @Sinh ,HanhKiem = @HanhKiem ,NhanXetGV = @NX where NamHoc = @NamHoc and MaHS = @MaHS and Ky = @Ky ";
            object[] para = new object[] {ketqua.Toan, ketqua.Ly, ketqua.Hoa, ketqua.Van
            , ketqua.Anh, ketqua.LichSu, ketqua.DiaLy, ketqua.GiaoDucCD, ketqua.TheDuc, ketqua.CongNghe, ketqua.SinhHoc, ketqua.HanhKiem, ketqua.NhanXetGV, ketqua.NamHoc, ketqua.MaHS, ketqua.KyHoc};
            if (dataProvider.Instance.EXcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable layKetQua(String maHocSinh,int namHoc,bool kyHoc)
        {
            string query = "select * from KetQua where MaHS = @maHocSinh And NamHoc = @namHoc And Ky = @kyHoc ";
            object[] para = { maHocSinh, namHoc, kyHoc };
            return dataProvider.Instance.EXcuteQuery(query, para);
        }
    }
}
