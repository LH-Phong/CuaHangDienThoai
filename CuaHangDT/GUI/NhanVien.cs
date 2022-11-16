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
    public partial class NhanVien : Form
    {

        #region Biến cục bộ
        string temp="";
        #endregion
        //-----------------------------------------------------------------------------------
        public NhanVien()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------
        #region Các hoạt động
        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            kichhoat(false);
        }

        public void HienThiNhanVien()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayNhanVien();
            dataGridView1.DataSource = lstNhanVien;
            if (lstNhanVien != null)
            {
                dataGridView1.Columns["SMaNV"].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns["STenNV"].HeaderText = "Tên nhân viên";
                dataGridView1.Columns["SGioiTinh"].HeaderText = "Giới tinh";
                dataGridView1.Columns["DNgaySinh"].HeaderText = "Ngày Sinh";
                dataGridView1.Columns["SSDT"].HeaderText = "Số điện thoại";
                dataGridView1.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtMaNV.Text= r.Cells["SMaNV"].Value.ToString();
                txtTenNV.Text= r.Cells["STenNV"].Value.ToString();
                if (r.Cells["SGioiTinh"].Value.ToString()=="Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                dtpNgaySinh.Text = r.Cells["DNgaySinh"].Value.ToString();
                txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
                txtSDT.Text = r.Cells["SSDT"].Value.ToString();
            }
        }

        private void kichhoat(Boolean b)
        {
            txtMaNV.Enabled = b;
            txtTenNV.Enabled = b;
            txtTenNV.Enabled = b;
            radNam.Enabled = b;
            radNu.Enabled = b;
            dtpNgaySinh.Enabled = b;
            txtSDT.Enabled = b;
            txtDiaChi.Enabled = b;
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btnLuu.Visible = b;
            btnHuy.Visible = b;
        }

        #endregion
        //-----------------------------------------------------------------------------------
        #region Các nút chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl = 0;
            sl= NhanVienBUS.SLNhanVien();
            txtMaNV.Text = "NV" + sl;
            txtTenNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.Text = DateTime.Now.ToString();
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            kichhoat(true);
            temp = "add";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(temp=="add")
            {
                if (txtTenNV.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Nhân viên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = txtMaNV.Text;
                nv.STenNV = txtTenNV.Text;
                if (radNam.Checked == true)
                    nv.SGioiTinh = "Nam";
                else
                    nv.SGioiTinh = "Nữ";
                nv.DNgaySinh = dtpNgaySinh.Value;
                nv.SSDT = txtSDT.Text;
                nv.SDiaChi = txtDiaChi.Text;
                if (NhanVienBUS.ThemNhanVien(nv) == false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }
                MessageBox.Show("Đã thêm thành công.");
                NhanVien_Load(sender, e);
            }
            if (temp == "update")
            {
                if (txtTenNV.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Nhân viên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = txtMaNV.Text;
                nv.STenNV = txtTenNV.Text;
                if (radNam.Checked == true)
                    nv.SGioiTinh = "Nam";
                else
                    nv.SGioiTinh = "Nữ";
                nv.DNgaySinh = dtpNgaySinh.Value;
                nv.SSDT = txtSDT.Text;
                nv.SDiaChi = txtDiaChi.Text;
                if (NhanVienBUS.CapNhatNhanVien(nv) == false)
                {
                    MessageBox.Show("Không sửa được.");
                    return;
                }
                MessageBox.Show("Đã sửa thành công.");
                NhanVien_Load(sender, e);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = txtMaNV.Text;
                if(NhanVienBUS.XoaNhanVien(nv)== false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                MessageBox.Show("Đã xóa nhân viên.");
                NhanVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kichhoat(true);
            temp = "update";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            temp = "";
            kichhoat(false);
            NhanVien_Load(sender, e);
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                HienThiNhanVien();
                return;
            }
            else
            {
                List<NhanVienDTO> lstNhanVien = NhanVienBUS.TimNhanVien(txtTim.Text);
                dataGridView1.DataSource = lstNhanVien;
                if (lstNhanVien != null)
                {
                    dataGridView1.Columns["SMaNV"].HeaderText = "Tên đăng nhập";
                    dataGridView1.Columns["STenNV"].HeaderText = "Tên nhân viên";
                    dataGridView1.Columns["SGioiTinh"].HeaderText = "Giới tinh";
                    dataGridView1.Columns["DNgaySinh"].HeaderText = "Ngày Sinh";
                    dataGridView1.Columns["SSDT"].HeaderText = "Số điện thoại";
                    dataGridView1.Columns["SDiaChi"].HeaderText = "Địa chỉ";
                }
            }
        }

        #endregion

        //-----------------------------------------------------------------------------------
    }
}
