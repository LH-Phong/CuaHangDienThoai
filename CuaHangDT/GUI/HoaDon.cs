using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class HoaDon : Form
    {
        #region Biến cục bộ
        NhanVienDTO nv = new NhanVienDTO();
        ChiTietHDDTO cthd = new ChiTietHDDTO();
        List<ChiTietHDDTO> lstCTHD = new List<ChiTietHDDTO>();
        ChiTietSanPhamDTO ctsp = new ChiTietSanPhamDTO();
        List<ChiTietSanPhamDTO> lstCTSP = new List<ChiTietSanPhamDTO>();
        string maSP;
        string maHD;
        int slKho;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        Double thanhtien = 0;
        #endregion
        public HoaDon()
        {
            InitializeComponent();
        }
        public HoaDon(NhanVienDTO nvien)
        {
            InitializeComponent();
            nv = nvien;
        }
        #region Các hoạt động
        
        private void HoaDon_Load(object sender, EventArgs e)
        {
            kichhoat(false);
            HienThiHoaDon();
            HienThiSanPham();
        }
        public void kichhoat(bool b)
        {
            dtgDSSP.Enabled = b;
            btnLuu.Enabled = b;
            cboTuyChon.Enabled = b;
            numSoLuong.Enabled = b;
            btnTimSP.Enabled = b;
            txtTimSP.Enabled = b;
            btnThemSP.Enabled = b;
            txtTenKH.Enabled = b;
            txtSDT_KH.Enabled = b;
            dtgChiTietHD.Enabled = b;
            btnXoa.Enabled = b;
            btnXoaTatCa.Enabled = b;
        }
        public void HienThiHoaDon()
        {
            List<HoaDonDTO> lstHoaDon = HoaDonBUS.LayHoaDon();
            dtgDSHD.DataSource = lstHoaDon;
            if (lstHoaDon != null)
            {
                dtgDSHD.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dtgDSHD.Columns["SNgayLap"].HeaderText = "Ngày lập";
                dtgDSHD.Columns["SMaNV"].HeaderText = "Người lập";
                dtgDSHD.Columns["STenKH"].HeaderText = "Tên khách hàng";
                dtgDSHD.Columns["SSDT"].HeaderText = "Số điện thoại";
                dtgDSHD.Columns["SThanhTien"].HeaderText = "Tổng tiền";
                dtgDSHD.Columns["STinhTrang"].HeaderText = "Trạng thái";

                dtgDSHD.Columns["SMaNV"].Visible = false;
                //dtgDSHD.Columns["STenKH"].Visible = false;
                //dtgDSHD.Columns["SSDT"].Visible = false;
                //dtgDSHD.Columns["SThanhTien"].Visible = false;
                
                dtgDSHD.Columns["SMaHD"].Width = 160;
                dtgDSHD.Columns["SNgayLap"].Width = 150;
                dtgDSHD.Columns["STenKH"].Width = 200;
                dtgDSHD.Columns["SThanhTien"].Width = 150;
                dtgDSHD.Columns["SSDT"].Width = 150;
                dtgDSHD.Columns["STinhTrang"].Width = 150;
            }
        }
        public void HienThiSanPham()
        {
            List<SanPhamDTO> lstSanPham = SanPhamBUS.LaySanPham();
            dtgDSSP.DataSource = lstSanPham;
            if(lstSanPham != null)
            {
                dtgDSSP.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgDSSP.Columns["STenSP"].HeaderText = "Tên sản phẩm";
                dtgDSSP.Columns["SPhanLoai"].HeaderText = "Phân loại";
                dtgDSSP.Columns["SHSX"].HeaderText = "Hãng sản xuất";
                dtgDSSP.Columns["SKhuyenMai"].HeaderText = "Khuyến mãi";

                dtgDSSP.Columns["SPhanLoai"].Visible = false;
                dtgDSSP.Columns["SHSX"].Visible = false;
                dtgDSSP.Columns["SKhuyenMai"].Visible = false;

                dtgDSSP.Columns["SMaSP"].Width = 80;
                dtgDSSP.Columns["STenSP"].Width = 300;
            }
        }
        public void HienThiChiTietHD()
        {
            List<ChiTietHDDTO> lstChiTiet = ChiTietHDBUS.LayThongTin(maHD);
            dtgChiTietHD.DataSource = lstChiTiet;
            if (lstChiTiet != null)
            {
                dtgChiTietHD.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dtgChiTietHD.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgChiTietHD.Columns["STenSp"].HeaderText = "Tên sản phẩm";
                dtgChiTietHD.Columns["SGia"].HeaderText = "Giá";
                dtgChiTietHD.Columns["ISoLuong"].HeaderText = "Số lượng";
                dtgChiTietHD.Columns["STenSp"].Width = 200;
            }
        }
        private void dtgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboTuyChon.Items.Clear();
            cboTuyChon.Text = "--";
            txtGia.Text = "--";
            txtCauHinh.Text = "";
            picSP.Image = null;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgDSSP.Rows[e.RowIndex];
                //txtMaSP.Text = r.Cells["SMaSP"].Value.ToString();
                txtTenSP.Text = r.Cells["STenSP"].Value.ToString();
                maSP = r.Cells["SMaSP"].Value.ToString();
                lstCTSP = ChiTietSanPhamBUS.LaySanPham(maSP);
                if (lstCTHD != null)
                {
                    for (int i = 0; i < lstCTSP.Count; i++)
                    {
                        cboTuyChon.Items.Add(lstCTSP[i].STuyChon.ToString());
                    }
                }

            }
        }

        private void cboTuyChon_SelectedValueChanged(object sender, EventArgs e)
        {
            ctsp = ChiTietSanPhamBUS.Lay1ThongTin(maSP, cboTuyChon.SelectedItem.ToString());
            if (ctsp != null)
            {
                txtGia.Text = ctsp.SGia.ToString();
                txtCauHinh.Text = ctsp.SCauHinh;
                try
                {
                    picSP.Image = Image.FromFile(path + @"\Images\SanPham\" + ctsp.SHinhAnh);
                }
                catch
                {
                    picSP.Image = Image.FromFile(path + @"\Images\SanPham\Male.png");
                }
                txtSLSP.Text = "Còn: " + ctsp.ISoLuong;
                slKho =ctsp.ISoLuong;
            }
        }
        public static string TaoMa(string keyvalue)
        {
            string key = keyvalue;
            DateTime aDay = DateTime.Now;
            key = key + aDay.Day;
            key = key + aDay.Month;
            key = key + aDay.Year + "_";
            key = key + aDay.Hour;
            key = key + aDay.Minute;
            key = key + aDay.Second;
            return key;
        }
        private void dtgChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgChiTietHD.Rows[e.RowIndex];
                cthd.SMaHD = r.Cells["SMaHD"].Value.ToString();
                cthd.SMaSP = r.Cells["SMaSP"].Value.ToString();
            }
        }
        #endregion

        #region Các nút chức năng
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            DS_HoaDon dshd = new DS_HoaDon();
            dshd.Show();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            kichhoat(true);
            txtMaHD.Text = TaoMa("HD");
            maHD = txtMaHD.Text;
            HoaDonDTO hd = new HoaDonDTO();
            hd.SMaHD = maHD;
            hd.SMaNV = nv.SMaNV;
            hd.SNgayLap = DateTime.Today;
            hd.STinhTrang = "Đang thực hiện";
            HoaDonBUS.ThemHoaDon(hd);
            HienThiHoaDon();
            

        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            if (txtTimSP.Text == "")
                HienThiSanPham();
            List<SanPhamDTO> lstSanPham = SanPhamBUS.TimSanPham(txtTimSP.Text);
            dtgDSSP.DataSource = lstSanPham;
            if (lstSanPham != null)
            {
                dtgDSSP.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgDSSP.Columns["STenSP"].HeaderText = "Tên sản phẩm";
                dtgDSSP.Columns["SPhanLoai"].HeaderText = "Phân loại";
                dtgDSSP.Columns["SHSX"].HeaderText = "Hãng sản xuất";
                dtgDSSP.Columns["SKhuyenMai"].HeaderText = "Khuyến mãi";

                dtgDSSP.Columns["SPhanLoai"].Visible = false;
                dtgDSSP.Columns["SHSX"].Visible = false;
                dtgDSSP.Columns["SKhuyenMai"].Visible = false;

                dtgDSSP.Columns["SMaSP"].Width = 80;
                dtgDSSP.Columns["STenSP"].Width = 300;
            }
        }

        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn muốn thêm sản phẩm này vào hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                if (txtGia.Text != "--")
                {
                    if (numSoLuong.Value > slKho)
                    {
                        MessageBox.Show("Số lượng sản phẩm hiện không đủ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cthd.SMaHD = txtMaHD.Text;
                    cthd.SMaSP = maSP;
                    cthd.STenSP = txtTenSP.Text;
                    cthd.SGia = txtGia.Text;
                    cthd.ISoLuong = int.Parse(numSoLuong.Value.ToString());
                    ChiTietHDBUS.Them(cthd);
                    lstCTHD = ChiTietHDBUS.LayThongTin(cthd.SMaHD);
                    for (int i = 0; i < lstCTHD.Count; i++)
                    {
                        thanhtien = thanhtien + (int.Parse(lstCTHD[i].ISoLuong.ToString()) * int.Parse(lstCTHD[i].SGia));
                    }
                    txtThanhTien.Text = thanhtien + " .VND";
                    HienThiChiTietHD();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn muốn lưu lại hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                if (txtTenKH.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khách hàng không được trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSDT_KH.Text.Trim() == "")
                {
                    MessageBox.Show("Số điện thoại khách hàng không được trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHD = maHD;
                hd.SMaNV = nv.SMaNV;
                hd.SNgayLap = DateTime.Today;
                hd.STinhTrang = "Đang thực hiện";
                hd.STenKH = txtTenKH.Text;
                hd.SSDT = txtSDT_KH.Text;
                hd.SThanhTien = thanhtien.ToString();
                HoaDonBUS.CapNhatHoaDon(hd);
                HienThiHoaDon();
                ctsp.ISoLuong = (int)(ctsp.ISoLuong - numSoLuong.Value);
                ChiTietSanPhamBUS.CapNhatSanPham(ctsp);

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                ChiTietHDBUS.Xoa(cthd);
                HienThiChiTietHD();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa tất cả sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                ChiTietHDBUS.XoaTatCa(cthd);
                HienThiChiTietHD();
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            HoaDonRP hdrp = HoaDonBUS.HDRP(dtgDSHD.CurrentRow.Cells["SMaHD"].Value.ToString());
            List<ChiTietRP> lstRP = ChiTietHDBUS.CTRP(dtgDSHD.CurrentRow.Cells["SMaHD"].Value.ToString());
            new Reports.InHoaDon(hdrp, lstRP).ShowDialog();

        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
