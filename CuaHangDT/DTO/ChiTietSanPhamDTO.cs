using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSanPhamDTO
    {
        string sMaSP;
        string sTuyChon;
        int iSoLuong;
        string sGia;
        string sCauHinh;
        string sHinhAnh;
        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string STuyChon { get => sTuyChon; set => sTuyChon = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public string SGia { get => sGia; set => sGia = value; }
        public string SCauHinh { get => sCauHinh; set => sCauHinh = value; }
        public string SHinhAnh { get => sHinhAnh; set => sHinhAnh = value; }
    }
}
