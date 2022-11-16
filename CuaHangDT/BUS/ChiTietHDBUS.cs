using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietHDBUS
    {
        public static List<ChiTietHDDTO> LayThongTin()
        {
            return ChiTietHDDAO.LayThongTin(); 
        }
        public static List<ChiTietHDDTO> LayThongTin(string tu)
        {
            return ChiTietHDDAO.LayThongTin(tu);
        }
        public static bool Them(ChiTietHDDTO ct)
        {
            return ChiTietHDDAO.Them(ct);
        }
        public static bool Xoa(ChiTietHDDTO ct)
        {
            return ChiTietHDDAO.Xoa(ct);
        }
        public static bool XoaTatCa(ChiTietHDDTO ct)
        {
            return ChiTietHDDAO.XoaTatCa(ct);
        }
        public static List<ChiTietRP> CTRP(string tukhoa)
        {
            return ChiTietHDDAO.CTRP(tukhoa);
        }
    }
}
