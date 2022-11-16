using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> LaySanPham()
        {
            return SanPhamDAO.LaySanPham();
        }
        public static List<SanPhamDTO> TimSanPham(string tukhoa)
        {
            return SanPhamDAO.LaySanPham(tukhoa);
        }
        public static bool ThemSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.ThemSanPham(sp);
        }
        public static bool XoaSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.XoaSanPam(sp);
        }
        public static bool CapNhatSanPham(SanPhamDTO sp)
        {
            return SanPhamDAO.CapNhatSanPham(sp);
        }
        public static int SLSanPham()
        {
            return SanPhamDAO.DemSLSanPham();
        }
        public static bool KiemTraMaSP(string ma)
        {
            return SanPhamDAO.KiemTraMaSP(ma);
        } 
    }
}
