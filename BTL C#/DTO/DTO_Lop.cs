using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string maLop;
        private string maGV;
        private int siSo;

        public string MaLop { get => maLop; set => maLop = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public DTO_Lop(string MaLop, string MaGV, int SiSo)
        {
            this.MaLop = MaLop;
            this.MaGV = MaGV;
            this.SiSo = SiSo;
        }
    }
}
