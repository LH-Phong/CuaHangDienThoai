using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class ChiTietSanPhamDAO
    {
        static SqlConnection conn;
        
        public static List<ChiTietSanPhamDTO> LayThongTin()
        {
            string sql = "select* from ChiTietSanPham";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietSanPhamDTO> lstThongTin = new List<ChiTietSanPhamDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
                tt.SMaSP = dt.Rows[i]["MaSP"].ToString();
                tt.STuyChon = dt.Rows[i]["TuyChon"].ToString();
                tt.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                tt.SGia = dt.Rows[i]["Gia"].ToString();
                tt.SCauHinh = dt.Rows[i]["CauHinh"].ToString();
                tt.SHinhAnh= dt.Rows[i]["HinhAnh"].ToString();
                lstThongTin.Add(tt);
            }
            conn.Close();
            return lstThongTin;
        }
        public static List<ChiTietSanPhamDTO> LayThongTin(string ma)
        {
            string sql = string.Format("select* from ChiTietSanPham where MaSP like N'%{0}%' ", ma);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietSanPhamDTO> lstThongTin = new List<ChiTietSanPhamDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
                tt.SMaSP = dt.Rows[i]["MaSP"].ToString();
                tt.STuyChon = dt.Rows[i]["TuyChon"].ToString();
                tt.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                tt.SGia = dt.Rows[i]["Gia"].ToString();
                tt.SCauHinh = dt.Rows[i]["CauHinh"].ToString();
                tt.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();
                lstThongTin.Add(tt);
            }
            conn.Close();
            return lstThongTin;
        }
        public static bool ThemThongTin(ChiTietSanPhamDTO tt)
        {
            string sql = string.Format(@"insert into ChiTietSanPham values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
            tt.SMaSP,tt.STuyChon,tt.ISoLuong,tt.SGia,tt.SCauHinh,tt.SHinhAnh);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaThongTin(ChiTietSanPhamDTO tt)
        {
            string sql = string.Format(@"delete from ChiTietSanPham where MaSP=N'{0}' and TuyChon=N'{1}'", tt.SMaSP,tt.STuyChon);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool CapNhatThongTin(ChiTietSanPhamDTO tt)
        {
            string sTruyVan = string.Format(@"update ChiTietSanPham set TuyChon=N'{5}', SoLuong=N'{0}',
               Gia=N'{1}', CauHinh=N'{2}', HinhAnh=N'{3}' where MaSP=N'{4}' and TuyChon=N'{5}'",
               tt.ISoLuong,tt.SGia,tt.SCauHinh,tt.SHinhAnh,tt.SMaSP,tt.STuyChon);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static int TongSL(string ma)
        {
            string sql = string.Format(@"select SUM(SoLuong) as'TongSL' from ChiTietSanPham where MaSP=N'{0}'", ma);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int sl;
            try
            {
                sl= int.Parse(dt.Rows[0]["TongSL"].ToString());
            }
            catch { sl = 0; }
            conn.Close();
            return sl;
        }
        public static string LayGia(string ma,string Chon)
        {
            string sql = string.Format("select * from ChiTietSanPham where MaSP=N'{0}' and TuyChon=N'{1}' ", ma,Chon);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            string gia="0";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gia= dt.Rows[i]["Gia"].ToString(); 
            }
            conn.Close();
            return gia;
        }
        public static int LaySoLuong(string ma, string Chon)
        {
            string sql = string.Format("select * from ChiTietSanPham where MaSP=N'{0}' and TuyChon=N'{1}' ", ma, Chon);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int sl = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sl = int.Parse(dt.Rows[i]["SoLuong"].ToString()); 
            }
            conn.Close();
            return sl;
        }
        public static ChiTietSanPhamDTO Lay1ThongTin(string ma, string chon)
        {
            string sql = string.Format("select * from ChiTietSanPham where MaSP=N'{0}' and TuyChon=N'{1}' ", ma, chon);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tt.SMaSP = dt.Rows[i]["MaSP"].ToString();
                tt.STuyChon = dt.Rows[i]["TuyChon"].ToString();
                tt.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                tt.SGia = dt.Rows[i]["Gia"].ToString();
                tt.SCauHinh = dt.Rows[i]["CauHinh"].ToString();
                tt.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();
            }
            conn.Close();
            return tt;
        }
    }
}
