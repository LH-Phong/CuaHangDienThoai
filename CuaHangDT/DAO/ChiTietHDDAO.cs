using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class ChiTietHDDAO
    {
        static SqlConnection conn;
        public static List<ChiTietHDDTO> LayThongTin()
        {
            string sql = "select* from ChiTietHD";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHDDTO> lstCTHD = new List<ChiTietHDDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHDDTO ct = new ChiTietHDDTO();
                ct.SMaHD = dt.Rows[i]["MaHD"].ToString();
                ct.SMaSP = dt.Rows[i]["MaSP"].ToString();
                ct.STenSP = dt.Rows[i]["TenSP"].ToString();
                ct.SGia= dt.Rows[i]["Gia"].ToString();
                ct.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
               
                lstCTHD.Add(ct);
            }
            conn.Close();
            return lstCTHD;
        }
        public static List<ChiTietHDDTO> LayThongTin(string tukhoa)
        {
            string sql = string.Format("select* from ChiTietHD where MaHD like N'%{0}%' " +
                "OR TenSP like N'%{0}%' OR MaSP like N'%{0}%'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHDDTO> lstCTHD = new List<ChiTietHDDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHDDTO ct = new ChiTietHDDTO();
                ct.SMaHD = dt.Rows[i]["MaHD"].ToString();
                ct.SMaSP = dt.Rows[i]["MaSP"].ToString();
                ct.STenSP = dt.Rows[i]["TenSP"].ToString();
                ct.SGia = dt.Rows[i]["Gia"].ToString();
                ct.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());

                lstCTHD.Add(ct);
            }
            conn.Close();
            return lstCTHD;
        }
        public static bool Them(ChiTietHDDTO ct)
        {
            string sql = string.Format(@"insert into ChiTietHD values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')",
            ct.SMaHD,ct.SMaSP,ct.STenSP,ct.SGia,ct.ISoLuong);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool Xoa(ChiTietHDDTO ct)
        {
            string sql = string.Format(@"delete from ChiTietHD where MaHD=N'{0}' and MaSP=N'{1}'",ct.SMaHD, ct.SMaSP);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaTatCa(ChiTietHDDTO ct)
        {
            string sql = string.Format(@"delete from ChiTietHD where MaHD=N'{0}'", ct.SMaHD);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static List<ChiTietRP> CTRP(string tukhoa)
        {
            string sql = string.Format(@"select TenSP,Gia,SoLuong from ChiTietHD where MaHD = '{0}'", tukhoa);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietRP> lst = new List<ChiTietRP>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietRP ct = new ChiTietRP();
                ct.STenSP = dt.Rows[i]["TenSP"].ToString();
                ct.SGia = dt.Rows[i]["Gia"].ToString();
                ct.ISoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                lst.Add(ct);
            }
            conn.Close();
            return lst;
        }
    }
}
