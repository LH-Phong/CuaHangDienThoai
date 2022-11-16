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
    public partial class LichSu : Form
    {
        public LichSu()
        {
            InitializeComponent();
        }
        
        private void LichSu_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public void hienThi()
        {
            List<LichSuDTO> lst = LichSuBUS.LayLichSu();
            dataGridView1.DataSource = lst;
            if(lst != null)
            {
                dataGridView1.Columns["STenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns["DThoiGian"].HeaderText = "Thời gian";
                dataGridView1.Columns["STenNguoiDung"].HeaderText = "Tên người dùng";
                dataGridView1.Columns["SQuyenHan"].HeaderText = "Quyền hạn";
                dataGridView1.Columns["DThoiGian"].Width = 150;
                dataGridView1.Columns["STenDangNhap"].Width = 120;
                dataGridView1.Columns["STenNguoiDung"].Width = 140;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string batdau = dateTimePicker1.Value.ToString();
            string ketthuc = dateTimePicker2.Value.ToString();
            List<LichSuDTO> lst = LichSuBUS.LayLichSu(batdau,ketthuc);
            dataGridView1.DataSource = lst;
            if (lst != null)
            {
                dataGridView1.Columns["STenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns["DThoiGian"].HeaderText = "Thời gian";
                dataGridView1.Columns["STenNguoiDung"].HeaderText = "Tên người dùng";
                dataGridView1.Columns["SQuyenHan"].HeaderText = "Quyền hạn";
                dataGridView1.Columns["DThoiGian"].Width = 150;
                dataGridView1.Columns["STenDangNhap"].Width = 120;
                dataGridView1.Columns["STenNguoiDung"].Width = 140;
            }
        }
    }
}
