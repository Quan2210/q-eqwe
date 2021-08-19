using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        private string maGV;
        private string tenGV;
        private string diaChi;
        private string soDT;
        private string email;
        private string matKhau;

        public DTO_GiaoVien(string maGV, string tenGV, string diaChi, string soDT, string email, string matKhau)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.email = email;
            this.matKhau = matKhau;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        
    }
}
