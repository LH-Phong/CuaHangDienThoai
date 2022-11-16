using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LichSuBUS
    {
        public static List<LichSuDTO> LayLichSu()
        {
            return LichSuDAO.LayLichSu();
        }
        public static List<LichSuDTO> LayLichSu(string bd, string kt)
        {
            return LichSuDAO.LayLichSuTheoNgay(bd,kt);
        }
        public static bool Them(LichSuDTO ls)
        {
            return LichSuDAO.Them(ls);
        }
    }
}
