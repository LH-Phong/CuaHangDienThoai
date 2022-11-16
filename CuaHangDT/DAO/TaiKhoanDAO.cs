using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class TaiKhoanDAO
    {
        static SqlConnection conn;
        public static TaiKhoanDTO DangNhapTaiKhoan(string tenDN, string matKhau)
        {
            string sTruyVan = string.Format("select * from TaiKhoan where TenDangNhap=N'{0}' and MatKhau=N'{1}'", tenDN, matKhau);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.STenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            tk.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            tk.SNguoiDung = dt.Rows[0]["NguoiDung"].ToString();
            tk.SQuyenHan = dt.Rows[0]["QuyenHan"].ToString();
            tk.SHinhAnh = dt.Rows[0]["HinhAnh"].ToString();

            conn.Close();
            return tk;
        }
        public static List<TaiKhoanDTO> LayTaiKhoan()
        {
            string sql = "select*from TaiKhoan";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                tk.SMatKhau = dt.Rows[i]["MatKhau"].ToString();
                tk.SNguoiDung = dt.Rows[i]["NguoiDung"].ToString();
                tk.SQuyenHan = dt.Rows[i]["QuyenHan"].ToString();
                tk.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();
                lstTaiKhoan.Add(tk);
            }
            conn.Close();
            return lstTaiKhoan;
        }
        public static List<TaiKhoanDTO> LayTaiKhoan(String tukhoa)
        {
            string sql = string.Format("select*from TaiKhoan where TenDangNhap like N'%{0}%'" +
                " OR NguoiDung like N'%{0}%' OR QuyenHan like N'%{0}%'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                tk.SMatKhau = dt.Rows[i]["MatKhau"].ToString();
                tk.SNguoiDung = dt.Rows[i]["NguoiDung"].ToString();
                tk.SQuyenHan = dt.Rows[i]["QuyenHan"].ToString();
                tk.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();
                lstTaiKhoan.Add(tk);
            }
            conn.Close();
            return lstTaiKhoan;
        }
        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            string sql = string.Format(@"insert into TaiKhoan values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')",
              tk.STenDangNhap, tk.SMatKhau, tk.SNguoiDung, tk.SQuyenHan, tk.SHinhAnh);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaTaiKhoan(TaiKhoanDTO tk)
        {
            string sTruyVan = string.Format(@"delete from TaiKhoan where TenDangNhap=N'{0}'", tk.STenDangNhap);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tk)
        {
            string sTruyVan = string.Format(@"update TaiKhoan set  MatKhau=N'{0}', NguoiDung=N'{1}',
                QuyenHan=N'{2}', HinhAnh=N'{3}' where TenDangNhap=N'{4}'",
                tk.SMatKhau, tk.SNguoiDung, tk.SQuyenHan, tk.SHinhAnh,tk.STenDangNhap);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
    }
}
