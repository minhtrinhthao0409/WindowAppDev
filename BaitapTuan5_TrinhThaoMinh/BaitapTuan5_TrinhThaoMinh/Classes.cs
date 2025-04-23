using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTuan5_TrinhThaoMinh
{
    
    public class Khoa
    {
        public string TenKhoa { get; set; }
        public List<Lop> DsLop { get; set; } = new List<Lop>();
    }

    public class Lop
    {
        public string TenLop { get; set; }
        public List<SinhVien> DsSinhVien { get; set; } = new List<SinhVien>();
    }

    public class SinhVien
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
    }
}
