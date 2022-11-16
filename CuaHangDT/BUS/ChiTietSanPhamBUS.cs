using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        public static List<ChiTietSanPhamDTO> LaySanPham()
        {
            return ChiTietSanPhamDAO.LayThongTin();
        }
        public static List<ChiTietSanPhamDTO> LaySanPham(string ma)
        {
            return ChiTietSanPhamDAO.LayThongTin(ma);
        }
        public static bool ThemSanPham(ChiTietSanPhamDTO tt)
        {
            return ChiTietSanPhamDAO.ThemThongTin(tt);
        }
        public static bool XoaSanPham(ChiTietSanPhamDTO tt)
        {
            return ChiTietSanPhamDAO.XoaThongTin(tt);
        }
        public static bool CapNhatSanPham(ChiTietSanPhamDTO tt)
        {
            return ChiTietSanPhamDAO.CapNhatThongTin(tt) ;
        }
        public static int TongSL(string ma)
        {
            return ChiTietSanPhamDAO.TongSL(ma);
        }
        public static string LayGia(string ma,string chon)
        {
            return ChiTietSanPhamDAO.LayGia(ma,chon);
        }
        public static ChiTietSanPhamDTO Lay1ThongTin(string ma, string chon)
        {
            return ChiTietSanPhamDAO.Lay1ThongTin(ma, chon);
        }
    }
}
