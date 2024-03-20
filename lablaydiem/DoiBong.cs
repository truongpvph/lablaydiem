using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lablaydiem
{
    internal class DoiBong
    {
        public int ID { get; set; }
        public string TenDoiBong { get; set; }
        public string QuocGia { get; set; }
        public int NamThanhLap { get; set; }
        public string HuanLuyenVien { get; set; }
        public List<CauThu> DanhSachCauThu { get; set; }
        public bool DangHoatDong { get; set; }
    }
}
