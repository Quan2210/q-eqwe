using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KetQua
    {
        private int namHoc;
        private string maHS;
        private bool kyHoc;
        private float toan;
        private float ly;
        private float hoa;
        private float van;
        private float anh;
        private float lichSu;
        private float diaLy;
        private float giaoDucCD;
        private float theDuc;
        private float congNghe;
        private float sinhHoc;
        private string hanhKiem;
        private string nhanXetGV;

        public int NamHoc { get => namHoc; set => namHoc = value; }
        public string MaHS { get => maHS; set => maHS = value; }
        public bool KyHoc { get => kyHoc; set => kyHoc = value; }
        public float Toan { get => toan; set => toan = value; }
        public float Ly { get => ly; set => ly = value; }
        public float Hoa { get => hoa; set => hoa = value; }
        public float Van { get => van; set => van = value; }
        public float Anh { get => anh; set => anh = value; }
        public float LichSu { get => lichSu; set => lichSu = value; }
        public float DiaLy { get => diaLy; set => diaLy = value; }
        public float GiaoDucCD { get => giaoDucCD; set => giaoDucCD = value; }
        public float TheDuc { get => theDuc; set => theDuc = value; }
        public float CongNghe { get => congNghe; set => congNghe = value; }
        public float SinhHoc { get => sinhHoc; set => sinhHoc = value; }
        public string HanhKiem { get => hanhKiem; set => hanhKiem = value; }
        public string NhanXetGV { get => nhanXetGV; set => nhanXetGV = value; }
        public DTO_KetQua(int NamHoc, string MaHS, bool KyHoc, float Toan, float Ly, float Hoa, float Van, float Anh,
            float LichSu, float DiaLy, float GDCD, float TheDuc, float CongNghe, float SinhHoc, string HanhKiem, string NhanXet)
        {
            this.NamHoc = NamHoc;
            this.MaHS = MaHS;
            this.KyHoc = KyHoc;
            this.Toan = Toan;
            this.Ly = Ly;
            this.Hoa = Hoa;
            this.Van = Van;
            this.Anh = Anh;
            this.LichSu = LichSu;
            this.DiaLy = DiaLy;
            this.GiaoDucCD = GDCD;
            this.TheDuc = TheDuc;
            this.CongNghe = CongNghe;
            this.SinhHoc = SinhHoc;
            this.HanhKiem = HanhKiem;
            this.NhanXetGV = NhanXet;
        }
    }
}
