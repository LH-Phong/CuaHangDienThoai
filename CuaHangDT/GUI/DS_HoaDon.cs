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
    public partial class DS_HoaDon : Form
    {
        HoaDonDTO hd = new HoaDonDTO();
        public DS_HoaDon()
        {
            InitializeComponent();
        }
        
        private void dtgDsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgDsHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = r.Cells["SMaHD"].Value.ToString();
                //txtNgayLap.Text= r.Cells["SNgayLap"].Value.ToString();
                //txtNguoiLap.Text= r.Cells["SMaNV"].Value.ToString();
                txtTenKH.Text= r.Cells["STenKH"].Value.ToString(); 
                txtSDT.Text= r.Cells["SSDT"].Value.ToString();
                txtTongTien.Text= r.Cells["SThanhTien"].Value.ToString();
                txtTrangThai.Text= r.Cells["STinhTrang"].Value.ToString();
                dateTimePicker1.Text = r.Cells["SNgayLap"].Value.ToString();
                dateTimePicker2.Text = r.Cells["SNgayLap"].Value.ToString();
                txtNgayLap.Text = dateTimePicker1.Text;

                hd.SMaHD= r.Cells["SMaHD"].Value.ToString();
                hd.STenKH = r.Cells["STenKH"].Value.ToString();
                hd.STinhTrang = r.Cells["STinhTrang"].Value.ToString();

                NhanVienDTO nv = NhanVienBUS.NhanVienDangNhap(r.Cells["SMaNV"].Value.ToString());
                txtNguoiLap.Text = nv.STenNV;
            }
        }
        public void HienThiHoaDon()
        {
            List<HoaDonDTO> lstHoaDon = HoaDonBUS.LayHoaDon();
            dtgDsHoaDon.DataSource = lstHoaDon;
            if (lstHoaDon != null)
            {
                dtgDsHoaDon.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dtgDsHoaDon.Columns["SNgayLap"].HeaderText = "Ngày lập";
                dtgDsHoaDon.Columns["SMaNV"].HeaderText = "Người lập";
                dtgDsHoaDon.Columns["STenKH"].HeaderText = "Tên khách hàng";
                dtgDsHoaDon.Columns["SSDT"].HeaderText = "Số điện thoại";
                dtgDsHoaDon.Columns["SThanhTien"].HeaderText = "Tổng tiền";
                dtgDsHoaDon.Columns["STinhTrang"].HeaderText = "Trạng thái";
                dtgDsHoaDon.Columns["STenKH"].Width = 180;
            }
        }

        private void DS_HoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            HoaDonBUS.CapNhatTinhTrangn(txtMaHD.Text, "Đã hoàn thành");
            DS_HoaDon_Load(sender, e);
        }

        private void cusTom_Button1_Click(object sender, EventArgs e)
        {
            hd.SMaHD = txtMaHD.Text;
            if (txtTongTien.Text == "0")
            {
                HoaDonBUS.XoaHoaDon(hd);
                HienThiHoaDon();
                return;
            }
            if (hd.STinhTrang != "Đang thực hiện" || hd.STenKH !="")
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDonBUS.XoaHoaDon(hd);
            DS_HoaDon_Load(sender, e);
        }

        private void cusTom_Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
                DS_HoaDon_Load(sender, e);
            List<HoaDonDTO> lstHoaDon = HoaDonBUS.LayHoaDon(txtTim.Text);
            dtgDsHoaDon.DataSource = lstHoaDon;
            if (lstHoaDon != null)
            {
                dtgDsHoaDon.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dtgDsHoaDon.Columns["SNgayLap"].HeaderText = "Ngày lập";
                dtgDsHoaDon.Columns["SMaNV"].HeaderText = "Người lập";
                dtgDsHoaDon.Columns["STenKH"].HeaderText = "Tên khách hàng";
                dtgDsHoaDon.Columns["SSDT"].HeaderText = "Số điện thoại";
                dtgDsHoaDon.Columns["SThanhTien"].HeaderText = "Tổng tiền";
                dtgDsHoaDon.Columns["STinhTrang"].HeaderText = "Trạng thái";
                dtgDsHoaDon.Columns["STenKH"].Width = 180;
            }
        }

        private void btnTimNgay_Click(object sender, EventArgs e)
        {
            string batdau = dateTimePicker1.Value.ToString();
            string ketthuc = dateTimePicker2.Value.ToString(); 
            List<HoaDonDTO> lstHoaDon = HoaDonBUS.LayHoaDonTheoNgay(batdau, ketthuc);
            dtgDsHoaDon.DataSource = lstHoaDon;
            if (lstHoaDon != null)
            {
                dtgDsHoaDon.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dtgDsHoaDon.Columns["SNgayLap"].HeaderText = "Ngày lập";
                dtgDsHoaDon.Columns["SMaNV"].HeaderText = "Người lập";
                dtgDsHoaDon.Columns["STenKH"].HeaderText = "Tên khách hàng";
                dtgDsHoaDon.Columns["SSDT"].HeaderText = "Số điện thoại";
                dtgDsHoaDon.Columns["SThanhTien"].HeaderText = "Tổng tiền";
                dtgDsHoaDon.Columns["STinhTrang"].HeaderText = "Trạng thái";
                dtgDsHoaDon.Columns["STenKH"].Width = 180;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon CTHD = new ChiTietHoaDon(txtMaHD.Text);
            CTHD.Show();
        }
    }
}
