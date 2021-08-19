using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Lop
    {
        private static BUS_Lop instance;

        public static BUS_Lop Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Lop();
                }
                return instance;
            }
        }
        public BUS_Lop() { }
        public List<DTO_Lop> hienThi()
        {
            List<DTO_Lop> list = new List<DTO_Lop>();
            string query = "select * from Lop";
            DataTable table = dataProvider.Instance.EXcuteQuery(query);
            foreach (DataRow datarow in table.Rows)
            {
                string maLop = datarow["MaLop"].ToString();
                string maGV = datarow["MaGV"].ToString();
                int siso = int.Parse(datarow["SiSo"].ToString());
                DTO_Lop lop = new DTO_Lop(maLop, maGV, siso);
                list.Add(lop);
            }
            return list;
        }
        public DataTable hienThiGV()
        {
            string query = "select * from GiaoVien";
            DataTable table = dataProvider.Instance.EXcuteQuery(query);
            return table;
        }
        public bool them(DTO_Lop lop)
        {
            string query = "insert into Lop values ( @MaLop , @maGV , @SiSo )";
            object[] para = new object[] { lop.MaLop, lop.MaGV, lop.SiSo };
            if (dataProvider.Instance.EXcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool sua(DTO_Lop lop, string maLop)
        {
            string query = "update Lop set MaGV = @MaGV where MaLop = @MaLop ";
            object[] para = new object[] { lop.MaGV, maLop };
            if (dataProvider.Instance.EXcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
