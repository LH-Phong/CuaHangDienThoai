using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonRP
    {
        string sMaHD;
        DateTime sNgayLap;
        string sTenNV;
        string sTenKH;
        string sSDT;
        string sThanhTien;

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public DateTime SNgayLap { get => sNgayLap; set => sNgayLap = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string SThanhTien { get => sThanhTien; set => sThanhTien = value; }
    }
}
