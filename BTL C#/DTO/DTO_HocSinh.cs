using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocSinh
    {
        private string maHS;
        private string tenHS;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private string soDT;
        private string hoTenBo;
        private string soDTBo;
        private string hoTenMe;
        private string soDTMe;
        private bool mienGiam;
        private string matKhau;
        private string maLop;

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public string SoDTBo { get => soDTBo; set => soDTBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public string SoDTMe { get => soDTMe; set => soDTMe = value; }
        public bool MienGiam { get => mienGiam; set => mienGiam = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public DTO_HocSinh(string MaHS, string TenHS, DateTime NgaySinh, bool GioiTinh, string DiaChi, string SoDT,
            string HoTenBo, string SoDTBo, string HoTenMe, string SoDTMe, bool MienGiam, string MatKhau, string MaLop )
        {
            this.MaHS = MaHS;
            this.TenHS = TenHS;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.HoTenBo = HoTenBo;
            this.SoDTBo = SoDTBo;
            this.HoTenMe = HoTenMe;
            this.SoDTMe = SoDTMe;
            this.MatKhau = MatKhau;
            this.MienGiam = MienGiam;
            this.MaLop = MaLop;
        }
    }
}
