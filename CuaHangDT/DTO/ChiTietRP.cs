using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietRP
    {
        string sTenSP;
        string sGia;
        int iSoLuong;

        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public string SGia { get => sGia; set => sGia = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
    }
}
