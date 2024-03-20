using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lablaydiem
{
    internal class CauThu
    {
        public int ID { get; set; }
        public string TenCauThu { get; set; }
        public DateTimePicker NgaySinh { get; set; }
        public string ViTri { get; set; }
        public int SoAo { get; set; }
        public string QuocTich { get; set; }
        public bool CauThuTuDo { get; set; }
    }
}
