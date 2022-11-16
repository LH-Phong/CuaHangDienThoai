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
using Microsoft.Reporting.WinForms;

namespace GUI.Reports
{
    public partial class InHoaDon : Form
    {
        HoaDonRP hdon;
        List<ChiTietRP> lstChiTiet;
        public InHoaDon()
        {
            InitializeComponent();
        }

        public InHoaDon(HoaDonRP hd, List<ChiTietRP> lst)
        {
            InitializeComponent();
            hdon = hd;
            lstChiTiet = lst;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ChiTietRPBindingSource.DataSource = lstChiTiet;
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("SMaHD", hdon.SMaHD),
                new ReportParameter("STenKH", hdon.STenKH),
                new ReportParameter("STenNV", hdon.STenNV),
                new ReportParameter("SNgayLap", hdon.SNgayLap.ToString("dd/MM/yyyy")),
                new ReportParameter("SThanhTien",  hdon.SThanhTien),
                new ReportParameter("SSDT", hdon.SSDT)
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
