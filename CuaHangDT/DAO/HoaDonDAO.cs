using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class HoaDonDAO
    {
        static SqlConnection conn;
        public static List<HoaDonDTO> LayHoaDon()
        {
            string sql = "select* from HoaDon";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHD = dt.Rows[i]["MaHD"].ToString();
                hd.SNgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString(); ;
                hd.STenKH = dt.Rows[i]["TenKH"].ToString(); ;
                hd.SSDT = dt.Rows[i]["SDT"].ToString(); ;
                hd.SThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                hd.STinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }

        public static List<HoaDonDTO> LayHoaDon(string tukhoa)
        {
            string sql = string.Format("select* from HoaDon where MaHD like N'%{0}%' " +
               "OR TenKH like N'%{0}%' OR NgayLap like N'%{0}%' OR TinhTrang like N'%{0}%'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHD = dt.Rows[i]["MaHD"].ToString();
                hd.SNgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString(); ;
                hd.STenKH = dt.Rows[i]["TenKH"].ToString(); ;
                hd.SSDT = dt.Rows[i]["SDT"].ToString(); ;
                hd.SThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                hd.STinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }
        public static List<HoaDonDTO> LayHoaDonTheoNgay(string start, string finish)
        {
            string sql = string.Format(@"select *from HoaDon where NgayLap between '{0}' and '{1}'", start,finish);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHD = dt.Rows[i]["MaHD"].ToString();
                hd.SNgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString(); ;
                hd.STenKH = dt.Rows[i]["TenKH"].ToString(); ;
                hd.SSDT = dt.Rows[i]["SDT"].ToString(); ;
                hd.SThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                hd.STinhTrang = dt.Rows[i]["TinhTrang"].ToString();
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }
        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            string sql = string.Format(@"insert into HoaDon values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')",
            hd.SMaHD,hd.SNgayLap,hd.SMaNV,hd.STenKH,hd.SSDT,hd.SThanhTien,hd.STinhTrang);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaHoaDon(HoaDonDTO hd)
        {
            string sql1 = string.Format(@"delete from ChiTietHD where MaHD=N'{0}'", hd.SMaHD);
            string sql2 = string.Format(@"delete from HoaDon where MaHD=N'{0}'", hd.SMaHD);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql1, conn);
            kq = DataProviders.TruyVanKhongLayDuLieu(sql2, conn);
            conn.Close();
            return kq;
        }
        public static bool CapNhatHoaDon(HoaDonDTO hd)
        {
            string sTruyVan = string.Format(@"update HoaDon set  NgayLap=N'{0}', MaNV=N'{1}',
               TenKH=N'{2}', SDT=N'{3}', ThanhTien=N'{4}' , TinhTrang=N'{5}'  where MaHD=N'{6}'",
              hd.SNgayLap, hd.SMaNV, hd.STenKH, hd.SSDT, hd.SThanhTien, hd.STinhTrang,hd.SMaHD);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static bool CapNhatHoaDon(string ma,string ttrang)
        {
            string sTruyVan = string.Format(@"update HoaDon set TinhTrang=N'{0}'  where MaHD=N'{1}'", ttrang,ma);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static int DemHDTrongNgay(DateTime d)
        {
            string sTruyVan = string.Format(@"SELECT COUNT(NgayLap) as 'SL' FROM HoaDon where NgayLap = N'{0}' and TinhTrang=N'Đã hoàn thành'", d);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            int sl = int.Parse(dt.Rows[0]["SL"].ToString());
            conn.Close();
            return sl;
        }
        public static string TongTienTrongNgay(DateTime d)
        {
            string sTruyVan = string.Format(@"select ThanhTien from HoaDon where NgayLap = N'{0}' and TinhTrang = 'Đã hoàn thành'", d);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return "0";
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SThanhTien = dt.Rows[i]["ThanhTien"].ToString();
                lstHoaDon.Add(hd);
            }
            double tong=0;
            for (int i=0; i< lstHoaDon.Count; i++)
            {
                int tien = int.Parse(lstHoaDon[i].SThanhTien);
                tong = tong + tien;
            }
            conn.Close();
            return tong+"" ;
        }
        public static HoaDonRP HDRP(string tukhoa)
        {
            string sql = string.Format(@"select hd.MaHD,hd.TenKH, hd.NgayLap,hd.SDT,hd.ThanhTien,nv.TenNV  from HoaDon hd, NhanVien nv
            where hd.MaNV = nv.MaNV and hd.MaHD = '{0}'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HoaDonRP hd = new HoaDonRP();
            hd.SMaHD = dt.Rows[0]["MaHD"].ToString();
            hd.STenKH = dt.Rows[0]["TenKH"].ToString();
            hd.STenNV = dt.Rows[0]["TenNV"].ToString();
            hd.SSDT = dt.Rows[0]["SDT"].ToString();
            hd.SThanhTien= dt.Rows[0]["ThanhTien"].ToString();
            hd.SNgayLap = (DateTime)dt.Rows[0]["NgayLap"];
            conn.Close();
            return hd;
        }
    }
}
