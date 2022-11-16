using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public static List<NhanVienDTO> LayNhanVien()
        {
            return NhanVienDAO.LayNhanVien();
        }
        public static List<NhanVienDTO> TimNhanVien(string tukhoa)
        {
            return NhanVienDAO.LayNhanVien(tukhoa);
        }
        public static NhanVienDTO NhanVienDangNhap(string tukhoa)
        {
            return NhanVienDAO.NhanVienDangNhap(tukhoa) ;
        }
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.ThemNhanVien(nv);
        }
        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.XoaNhanVien(nv);
        }
        public static int SLNhanVien()
        {
            return NhanVienDAO.DemSLNhanVien();
        }
        public static bool CapNhatNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAO.CapNhatNhanVien(nv);
        }
    }
}
