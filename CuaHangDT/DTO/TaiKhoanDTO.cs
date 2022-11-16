using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        string sTenDangNhap;
        string sMatKhau;
        string sNguoiDung;
        string sQuyenHan;
        string sHinhAnh;

        public string STenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public string SNguoiDung { get => sNguoiDung; set => sNguoiDung = value; }
        public string SQuyenHan { get => sQuyenHan; set => sQuyenHan = value; }
        public string SHinhAnh { get => sHinhAnh; set => sHinhAnh = value; }
    }
}
