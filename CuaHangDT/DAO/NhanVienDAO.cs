using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        static SqlConnection conn;
        public static List<NhanVienDTO> LayNhanVien()
        {
            string sql = "select*from NhanVien";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVienDTO> lstNhanVien= new List<NhanVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = dt.Rows[i]["MaNV"].ToString();
                nv.STenNV = dt.Rows[i]["TenNV"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.DNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SSDT = dt.Rows[i]["SDT"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                lstNhanVien.Add(nv);
            }
            conn.Close();
            return lstNhanVien;
        }

        public static List<NhanVienDTO> LayNhanVien(string tukhoa)
        {
            string sql = string.Format("select* from NhanVien where TenNV like N'%{0}%' " +
                "OR MaNV like N'%{0}%' OR GioiTinh like N'%{0}%'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = dt.Rows[i]["MaNV"].ToString();
                nv.STenNV = dt.Rows[i]["TenNV"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.DNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SSDT = dt.Rows[i]["SDT"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                lstNhanVien.Add(nv);
            }
            conn.Close();
            return lstNhanVien;
        }
        public static NhanVienDTO NhanVienDangNhap(string tukhoa)
        {
            string sql = string.Format("select* from NhanVien where MaNV=N'{0}'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVienDTO nv = new NhanVienDTO();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nv.SMaNV = dt.Rows[i]["MaNV"].ToString();
                nv.STenNV = dt.Rows[i]["TenNV"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.DNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SSDT = dt.Rows[i]["SDT"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
            }
            conn.Close();
            return nv;
        }
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            string sql = string.Format(@"insert into NhanVien values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
             nv.SMaNV,nv.STenNV,nv.SGioiTinh,nv.DNgaySinh,nv.SSDT,nv.SDiaChi);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            string sql = string.Format(@"delete from NhanVien where MaNV=N'{0}'",nv.SMaNV);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }

        public static int DemSLNhanVien()
        {
            string sql = "SELECT COUNT(MaNV)AS 'SL' FROM NhanVien";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int sl = int.Parse(dt.Rows[0]["SL"].ToString())+1;
            return sl;
        }
        public static bool CapNhatNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"update NhanVien set  TenNV=N'{0}', GioiTinh=N'{1}',
                NgaySinh=N'{2}', SDT=N'{3}', DiaChi=N'{4}'  where MaNV=N'{5}'",
               nv.STenNV,nv.SGioiTinh,nv.DNgaySinh,nv.SSDT,nv.SDiaChi,nv.SMaNV);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
    }
}
