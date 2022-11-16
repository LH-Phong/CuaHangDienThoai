using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   
    public class SanPhamDAO
    {
        static SqlConnection conn;

        public static List<SanPhamDTO> LaySanPham()
        {
            string sql = "select* from SanPham";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPhamDTO sp= new SanPhamDTO();
                sp.SMaSP = dt.Rows[i]["MaSP"].ToString();
                sp.STenSP= dt.Rows[i]["TenSP"].ToString();
                sp.SPhanLoai= dt.Rows[i]["PhanLoai"].ToString();
                sp.SHSX= dt.Rows[i]["HangSanXuat"].ToString();
                sp.SKhuyenMai= dt.Rows[i]["KhuyenMai"].ToString();
                lstSanPham.Add(sp);
            }
            conn.Close();
            return lstSanPham;
        }
        public static List<SanPhamDTO> LaySanPham(string TuKhoa)
        {
            string sql = string.Format("select* from SanPham where MaSP like N'%{0}%' " +
                "OR TenSP like N'%{0}%' OR HangSanXuat like N'%{0}%' OR PhanLoai like N'%{0}%'", TuKhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.SMaSP = dt.Rows[i]["MaSP"].ToString();
                sp.STenSP = dt.Rows[i]["TenSP"].ToString();
                sp.SPhanLoai = dt.Rows[i]["PhanLoai"].ToString();
                sp.SHSX = dt.Rows[i]["HangSanXuat"].ToString();
                sp.SKhuyenMai = dt.Rows[i]["KhuyenMai"].ToString();
                lstSanPham.Add(sp);
            }
            conn.Close();
            return lstSanPham;
        }

        public static bool ThemSanPham(SanPhamDTO sp)
        {
            string sql = string.Format(@"insert into SanPham values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')",
            sp.SMaSP,sp.STenSP,sp.SPhanLoai,sp.SHSX,sp.SKhuyenMai);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaSanPam(SanPhamDTO sp)
        {
            string sql1 = string.Format(@"delete from ChiTietSanPham where MaSP=N'{0}'", sp.SMaSP);
            string sql2 = string.Format(@"delete from SanPham where MaSP=N'{0}'", sp.SMaSP);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql1, conn);
            kq = DataProviders.TruyVanKhongLayDuLieu(sql2, conn);
            conn.Close();
            return kq;
        }
        public static bool CapNhatSanPham(SanPhamDTO sp)
        {
            string sTruyVan = string.Format(@"update SanPham set  TenSP=N'{0}', PhanLoai=N'{1}',
               HangSanXuat=N'{2}', KhuyenMai=N'{3}' where MaSP=N'{4}'",
               sp.STenSP,sp.SPhanLoai,sp.SHSX,sp.SKhuyenMai,sp.SMaSP);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static int DemSLSanPham()
        {
            string sql = "SELECT COUNT(MaSP)AS 'SL' FROM SanPham";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int sl = int.Parse(dt.Rows[0]["SL"].ToString()) + 1;
            conn.Close();
            return sl;
        }
        public static  bool KiemTraMaSP(string ma)
        {
            string sql = string.Format(@"select * from SanPham where MaSP=N'{0}'", ma);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
    }
}
