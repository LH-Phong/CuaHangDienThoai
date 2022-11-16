using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class TaiKhoanBUS
    {
        public static List<TaiKhoanDTO> LayTaiKhoan()
        {
            return TaiKhoanDAO.LayTaiKhoan();
        }
        public static List<TaiKhoanDTO> TimTaiKhoan(string tukhoa)
        {
            return TaiKhoanDAO.LayTaiKhoan(tukhoa);
        }
        public static TaiKhoanDTO DangNhapTaiKhoan(string tk, string mk)
        {
            return TaiKhoanDAO.DangNhapTaiKhoan(tk, mk);
        }
        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.ThemTaiKhoan(tk);
        }
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.CapNhatTaiKhoan(tk);
        }
        public static bool XoaTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAO.XoaTaiKhoan(tk);
        }

    }
}
