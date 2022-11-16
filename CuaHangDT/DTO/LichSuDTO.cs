using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuDTO
    {
        string sTenDangNhap;
        DateTime dThoiGian;
        string sTenNguoiDung;
        string sQuyenHan;

        public string STenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public DateTime DThoiGian { get => dThoiGian; set => dThoiGian = value; }
        public string STenNguoiDung { get => sTenNguoiDung; set => sTenNguoiDung = value; }
        public string SQuyenHan { get => sQuyenHan; set => sQuyenHan = value; }
    }
}
