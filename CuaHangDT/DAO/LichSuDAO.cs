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

    public class LichSuDAO
    {
        static SqlConnection conn;

        public static List<LichSuDTO> LayLichSu()
        {
            string sql = "select*from LichSu ORDER BY ThoiGian DESC";
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSuDTO> lstLichSu = new List<LichSuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSuDTO ls = new LichSuDTO();
                ls.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                ls.DThoiGian= DateTime.Parse(dt.Rows[i]["ThoiGian"].ToString());
                ls.STenNguoiDung= dt.Rows[i]["TenNguoiDung"].ToString(); 
                ls.SQuyenHan= dt.Rows[i]["QuyenHan"].ToString();
                lstLichSu.Add(ls);
            }
            conn.Close();
            return lstLichSu;
        }
        public static List<LichSuDTO> LayLichSuTheoNgay(string start, string finish)
        {
            string sql = string.Format(@"select *from LichSu where ThoiGian between '{0}' and '{1}' ORDER BY ThoiGian DESC", start, finish);
            conn = DataProviders.MoKetNoi();
            DataTable dt = DataProviders.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSuDTO> lstLichSu = new List<LichSuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSuDTO ls = new LichSuDTO();

                ls.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                ls.DThoiGian = DateTime.Parse(dt.Rows[i]["ThoiGian"].ToString());
                ls.STenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                ls.SQuyenHan = dt.Rows[i]["QuyenHan"].ToString();
                lstLichSu.Add(ls);
            }
            conn.Close();
            return lstLichSu;
        }
        public static bool Them(LichSuDTO ls)
        {
            string sql = string.Format(@"insert into LichSu values(N'{0}', N'{1}',N'{2}',N'{3}')",
            ls.STenDangNhap,ls.DThoiGian,ls.STenNguoiDung,ls.SQuyenHan);
            conn = DataProviders.MoKetNoi();
            bool kq = DataProviders.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }

    }
}
