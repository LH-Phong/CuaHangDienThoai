using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        string sMaHD;
        DateTime sNgayLap;
        string sMaNV;
        string sTenKH;
        string sSDT;
        string sThanhTien;
        string sTinhTrang;

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public DateTime SNgayLap { get => sNgayLap; set => sNgayLap = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string SThanhTien { get => sThanhTien; set => sThanhTien = value; }
        public string STinhTrang { get => sTinhTrang; set => sTinhTrang = value; }
        
    }
}
