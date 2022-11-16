using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string sMaNV;
        string sTenNV;
        string sGioiTinh;
        DateTime dNgaySinh;
        string sSDT;
        string sDiaChi;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        
    }
}
