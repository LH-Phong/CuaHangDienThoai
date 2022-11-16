using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDonDTO> LayHoaDon()
        {
            return HoaDonDAO.LayHoaDon();
        }
        public static List<HoaDonDTO> LayHoaDon(string tukhoa)
        {
            return HoaDonDAO.LayHoaDon(tukhoa);
        }
        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAO.ThemHoaDon(hd);
        }
        public static bool XoaHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAO.XoaHoaDon(hd);
        }
        public static bool CapNhatHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAO.CapNhatHoaDon(hd);
        }
        public static bool CapNhatTinhTrangn(string ma, string tt)
        {
            return HoaDonDAO.CapNhatHoaDon(ma,tt);
        }
        public static int DemHDTrongNGay(DateTime s)
        {
            return HoaDonDAO.DemHDTrongNgay(s);
        }
        public static string TongTienTrongNgay(DateTime d)
        {
            return HoaDonDAO.TongTienTrongNgay(d);
        }
        public static List<HoaDonDTO> LayHoaDonTheoNgay(string s, string f)
        {
            return HoaDonDAO.LayHoaDonTheoNgay(s, f);
        }
        public static HoaDonRP HDRP(string tukhoa)
        {
            return HoaDonDAO.HDRP(tukhoa);
        }
    }
}
