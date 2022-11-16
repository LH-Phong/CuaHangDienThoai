using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        string sMaSP;
        string sTenSP;
        string sPhanLoai;
        string sHSX;
        string sKhuyenMai;

        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public string SPhanLoai { get => sPhanLoai; set => sPhanLoai = value; }
        public string SHSX { get => sHSX; set => sHSX = value; }
        public string SKhuyenMai { get => sKhuyenMai; set => sKhuyenMai = value; }
    }
}
