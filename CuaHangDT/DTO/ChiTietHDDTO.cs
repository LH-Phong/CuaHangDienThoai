using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDDTO
    {
        string sMaHD;
        string sMaSP;
        string sTenSP;
        string sGia;
        int iSoLuong;

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public string SGia { get => sGia; set => sGia = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
    }
}
