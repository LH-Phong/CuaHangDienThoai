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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            txtSoHD.Text = HoaDonBUS.DemHDTrongNGay(DateTime.Today).ToString();
            txtSoTien.Text= HoaDonBUS.TongTienTrongNgay(DateTime.Today);
        }
    }
}
