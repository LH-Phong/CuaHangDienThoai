using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class ChiTietHoaDon : Form
    {
        string mHD="";
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public ChiTietHoaDon(string ma)
        {
            InitializeComponent();
            mHD = ma;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            List<ChiTietHDDTO> lst = ChiTietHDBUS.LayThongTin(mHD);
            dataGridView1.DataSource = lst;
            if (lst != null)
            {
                dataGridView1.Columns["SMaHD"].HeaderText = "Mã hóa đơn";
                dataGridView1.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dataGridView1.Columns["STenSP"].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns["SGia"].HeaderText = "Giá";
                dataGridView1.Columns["iSoLuong"].HeaderText = "Số lượng";

                dataGridView1.Columns["SMaHD"].Width = 130;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1. Rows[e.RowIndex];
                txtMaHD.Text = r.Cells["SMaHD"].Value.ToString();
                txtTenSP.Text = r.Cells["STenSP"].Value.ToString();
                txtMaSP.Text= r.Cells["SMaSP"].Value.ToString(); ;
                txtGia.Text= r.Cells["SGia"].Value.ToString();
                txtSoLuong.Text= r.Cells["iSoLuong"].Value.ToString();
            }
        }
    }
}
