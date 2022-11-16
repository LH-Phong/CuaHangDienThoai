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
using System.IO;

namespace GUI
{
    public partial class HangHoa : Form
    {
        #region Biến cục bộ
        string temp = "";
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        OpenFileDialog dlOpen = new OpenFileDialog();
        string msp;
        #endregion
        //-----------------------------------------------------------------------------------
        public HangHoa()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------
        #region Các hoạt động

        private void HangHoa_Load(object sender, EventArgs e)
        {
            kichhoatSP(false);
            kichhoatTT(false);
            HienThiSanPham();
            //HienThiThongTinSP();
        }
        public void kichhoatSP(bool b)
        {
            txtMaSP.Enabled = b;
            txtTenSP.Enabled = b;
            cboPhanLoai.Enabled = b;
            txtHangSanXuat.Enabled = b;
            txtKhuyenMai.Enabled = b;
            btnHuySP.Enabled = b;
            btnLuuSP.Enabled = b;
            btnHuySP.Visible = b;
            btnLuuSP.Visible = b;
            
        }

        public void kichhoatTT(bool b)
        {
            btnChonAnh.Enabled = b;
            txtAnh.Enabled = b;
            btnHuyTT .Enabled = b;
            btnLuuTT.Enabled = b;
            btnHuyTT.Visible = b;
            btnLuuTT.Visible = b;
            //txtTuyChon.Enabled = b;
            radMacDinh.Enabled = b;
            radKhac.Enabled = b;
            txtGia.Enabled = b;
            txtSoLuong.Enabled = b;
            txtCauHinh.Enabled = b;
        }
        public void HienThiSanPham()
        {
            List<SanPhamDTO> lstSanPham = SanPhamBUS.LaySanPham();
            dtgHangHoa.DataSource = lstSanPham;
            if (lstSanPham != null)
            {
                dtgHangHoa.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgHangHoa.Columns["STenSP"].HeaderText = "Tên sản phẩm";
                dtgHangHoa.Columns["SPhanLoai"].HeaderText = "Phân loại";
                dtgHangHoa.Columns["SHSX"].HeaderText = "Hãng sản xuất";
                dtgHangHoa.Columns["SKhuyenMai"].HeaderText = "Khuyến mãi";

                //dtgHangHoa.Columns["SPhanLoai"].Visible = false;
                //dtgHangHoa.Columns["SHSX"].Visible = false;
                dtgHangHoa.Columns["SKhuyenMai"].Visible = false;

                dtgHangHoa.Columns["SHSX"].Width = 150;
                dtgHangHoa.Columns["SMaSP"].Width = 150;
                dtgHangHoa.Columns["STenSP"].Width = 300;
            }
        }
        private void dtgHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgHangHoa.Rows[e.RowIndex];
                txtMaSP.Text= r.Cells["SMaSP"].Value.ToString();
                txtTenSP.Text = r.Cells["STenSP"].Value.ToString();
                cboPhanLoai.SelectedItem = r.Cells["SPhanLoai"].Value.ToString();
                txtHangSanXuat.Text = r.Cells["SHSX"].Value.ToString();
                txtKhuyenMai.Text = r.Cells["SKhuyenMai"].Value.ToString();
            }
            HienThiThongTinSP(txtMaSP.Text);
            msp = txtMaSP.Text;
            txtTongSL.Text="Số lượng: "+ChiTietSanPhamBUS.TongSL(txtMaSP.Text);
        }
        
        public void HienThiThongTinSP()
        {
            List<ChiTietSanPhamDTO> lstThongTin = ChiTietSanPhamBUS.LaySanPham();
            dtgTuyChon.DataSource = lstThongTin;
            if (lstThongTin!= null)
            {
                dtgTuyChon.Columns["SMaSP"].Visible = false;
                dtgTuyChon.Columns["SCauHinh"].Visible = false;
                dtgTuyChon.Columns["SGia"].Visible = false;
                dtgTuyChon.Columns["SHinhAnh"].Visible = false;
                dtgTuyChon.Columns["STuyChon"].HeaderText = "Tùy chọn";
                dtgTuyChon.Columns["ISoLuong"].HeaderText = "Số lượng";

                dtgTuyChon.Columns["STuyChon"].Width = 100;
                dtgTuyChon.Columns["ISoLuong"].Width = 80;
            }
        }

        public void HienThiThongTinSP(string ma)
        {
            List<ChiTietSanPhamDTO> lstThongTin = ChiTietSanPhamBUS.LaySanPham(ma);
            dtgTuyChon.DataSource = lstThongTin;
            if (lstThongTin != null)
            {
                //dtgTuyChon.Columns["SMaSP"].Visible = false;
                dtgTuyChon.Columns["SCauHinh"].Visible = false;
                dtgTuyChon.Columns["SGia"].Visible = false;
                dtgTuyChon.Columns["SHinhAnh"].Visible = false;
                dtgTuyChon.Columns["STuyChon"].HeaderText = "Tùy chọn";
                dtgTuyChon.Columns["ISoLuong"].HeaderText = "Số lượng";
                dtgTuyChon.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgTuyChon.Columns["STuyChon"].Width = 150;
                dtgTuyChon.Columns["ISoLuong"].Width = 150;
                dtgTuyChon.Columns["SMaSP"].Width=150;
            }
        }
        private void dtgTuyChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgTuyChon.Rows[e.RowIndex];
                if (r.Cells["STuyChon"].Value.ToString() == "Mặc định")
                {
                    radMacDinh.Checked = true;
                    txtTuyChon.Visible = false;
                }
                else
                {
                    radKhac.Checked = true;
                    txtTuyChon.Visible = true;
                    txtTuyChon.Text = r.Cells["STuyChon"].Value.ToString();
                }
                txtSoLuong.Text = r.Cells["ISoLuong"].Value.ToString();
                txtGia.Text = r.Cells["SGia"].Value.ToString();
                txtCauHinh.Text = r.Cells["SCauHinh"].Value.ToString();
                txtAnh.Text = r.Cells["SHinhAnh"].Value.ToString();
                if (txtAnh.Text.Trim() != "")
                {
                    try
                    {
                        picHinhAnh.Image = Image.FromFile(path + @"\Images\SanPham\" + txtAnh.Text);
                    }
                    catch
                    {
                        picHinhAnh.Image = Image.FromFile(path + @"\Images\SanPham\Male.png");
                    }
                }
                else
                {
                    picHinhAnh.Image = Image.FromFile(path + @"\Images\SanPham\Male.png");
                }
            }
        }
        private void radMacDinh_Click(object sender, EventArgs e)
        {
            txtTuyChon.Enabled = false;
            txtTuyChon.Visible = false;
        }

        private void radKhac_Click(object sender, EventArgs e)
        {
            txtTuyChon.Enabled = true;
            txtTuyChon.Visible = true;
        }
        #endregion
        //-----------------------------------------------------------------------------------
        #region Các nút chức năng  -- Sản Phẩm --
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            kichhoatSP(true); temp = "add";
            txtMaSP.Text = "SP"+SanPhamBUS.SLSanPham();
            txtTenSP.Text = "";
            cboPhanLoai.SelectedItem ="";
            txtHangSanXuat.Text = "";
            txtKhuyenMai.Text = "";
        }
        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (temp == "add")
            {
                if (txtMaSP.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sản phẩm không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtTenSP.Text.Trim() == "")
                {
                    MessageBox.Show("Tên sản phẩm không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SanPhamBUS.KiemTraMaSP(txtMaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SanPhamDTO sp = new SanPhamDTO();
                sp.SMaSP = txtMaSP.Text;
                sp.STenSP = txtTenSP.Text;
                sp.SPhanLoai = cboPhanLoai.SelectedItem.ToString();
                sp.SHSX = txtHangSanXuat.Text;
                sp.SKhuyenMai = txtKhuyenMai.Text;
                if(SanPhamBUS.ThemSanPham(sp)==false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }
                MessageBox.Show("\tĐã thêm thành công.\nVui lòng bổ sung thêm thông tin chi tiết!");
                HangHoa_Load(sender, e);
            }
            if (temp == "update")
            {
                if (txtTenSP.Text.Trim() == "")
                {
                    MessageBox.Show("Tên sản phẩm không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SanPhamDTO sp = new SanPhamDTO();
                sp.SMaSP = txtMaSP.Text;
                sp.STenSP = txtTenSP.Text;
                sp.SPhanLoai = cboPhanLoai.SelectedItem.ToString();
                sp.SHSX = txtHangSanXuat.Text;
                sp.SKhuyenMai = txtKhuyenMai.Text;
                if (SanPhamBUS.CapNhatSanPham(sp) == false)
                {
                    MessageBox.Show("Không sửa được.");
                    return;
                }
                MessageBox.Show("Đã sửa sản phẩm thành công.");
                HangHoa_Load(sender, e);
            }

        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.SMaSP = txtMaSP.Text;
                if(SanPhamBUS.XoaSanPham(sp)==false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                MessageBox.Show("Đã xóa sản phẩm thành công.");
                HangHoa_Load(sender, e);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            kichhoatSP(true); 
            temp = "update";
            txtMaSP.Enabled = false;
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            kichhoatSP(false);
            temp = "";
            HangHoa_Load(sender, e);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
                HienThiSanPham();
            List<SanPhamDTO> lstSanPham = SanPhamBUS.TimSanPham(txtTim.Text);
            dtgHangHoa.DataSource = lstSanPham;
            if (lstSanPham != null)
            {
                dtgHangHoa.Columns["SMaSP"].HeaderText = "Mã sản phẩm";
                dtgHangHoa.Columns["STenSP"].HeaderText = "Tên sản phẩm";
                dtgHangHoa.Columns["SPhanLoai"].HeaderText = "Phân loại";
                dtgHangHoa.Columns["SHSX"].HeaderText = "Hãng sản xuất";
                dtgHangHoa.Columns["SKhuyenMai"].HeaderText = "Khuyến mãi";

                dtgHangHoa.Columns["SPhanLoai"].Visible = false;
                dtgHangHoa.Columns["SHSX"].Visible = false;
                dtgHangHoa.Columns["SKhuyenMai"].Visible = false;

                dtgHangHoa.Columns["SMaSP"].Width = 80;
                dtgHangHoa.Columns["STenSP"].Width = 300;
            }
        }
        #endregion
        //-----------------------------------------------------------------------------------
        #region Các nút chức năng  -- Chi Tiết Sản Phẩm --

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = path;
            dlgOpen.FilterIndex = 5;
            dlgOpen.Title = "Chọn ảnh ";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = Path.GetFileName(dlgOpen.FileName);
                dlOpen = dlgOpen;
                picHinhAnh.Image = Image.FromFile(dlOpen.FileName);
            }
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            kichhoatTT(true);
            temp = "add";
            txtTuyChon.Text = "";
            txtAnh.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtCauHinh.Text = "";
            picHinhAnh.Image = null;
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (temp == "add")
            {
                if (txtTuyChon.Text.Trim() == "" && radKhac.Checked==true)
                {
                    MessageBox.Show("Tên tùy chọn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtCauHinh.Text.Trim() == "")
                {
                    MessageBox.Show("Thông tin cấu hình không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtGia.Text.Trim() == "" || int.Parse(txtGia.Text)<0)
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSoLuong.Text.Trim() == "" || int.Parse(txtSoLuong.Text) < 0)
                {
                    MessageBox.Show("Số lượng sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
                tt.SMaSP = txtMaSP.Text;
                if (radMacDinh.Checked == true)
                    tt.STuyChon = radMacDinh.Text;
                else
                    tt.STuyChon = txtTuyChon.Text;
                tt.SGia = txtGia.Text;
                tt.ISoLuong =int.Parse(txtSoLuong.Text);
                tt.SCauHinh = txtCauHinh.Text;
                tt.SHinhAnh = txtAnh.Text;
                if (!File.Exists(path + @"\Images\SanPham\" + txtAnh.Text))
                {
                    try
                    {
                        File.Copy(dlOpen.FileName, path + @"\Images\SanPham\" + txtAnh.Text);
                    }
                    catch { }
                }
                if (ChiTietSanPhamBUS.ThemSanPham(tt) == false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }
                MessageBox.Show("Đã thêm thành công!");
            }
            if (temp == "update")
            {
                if (txtTuyChon.Text.Trim() == "" && radKhac.Checked == true)
                {
                    MessageBox.Show("Tên tùy chọn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
                tt.SMaSP = txtMaSP.Text;
                if (radMacDinh.Checked == true)
                    tt.STuyChon = radMacDinh.Text;
                else
                    tt.STuyChon = txtTuyChon.Text;
                tt.SGia = txtGia.Text;
                tt.ISoLuong = int.Parse(txtSoLuong.Text);
                tt.SCauHinh = txtCauHinh.Text;
                tt.SHinhAnh = txtAnh.Text;
                if (!File.Exists(path + @"\Images\SanPham\" + txtAnh.Text))
                {
                    try
                    {
                        File.Copy(dlOpen.FileName, path + @"\Images\SanPham\" + txtAnh.Text);
                    }
                    catch { }
                }
                if (ChiTietSanPhamBUS.CapNhatSanPham(tt) == false)
                {
                    MessageBox.Show("Không sửa được.");
                    return;
                }
                MessageBox.Show("Đã sửa thành công!");
            }
                HienThiThongTinSP(txtMaSP.Text);
            txtTongSL.Text = "Số lượng: " + ChiTietSanPhamBUS.TongSL(msp);
        }
        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa thông tin sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                ChiTietSanPhamDTO tt = new ChiTietSanPhamDTO();
                tt.SMaSP = txtMaSP.Text;
                if (radMacDinh.Checked == true)
                    tt.STuyChon = radMacDinh.Text;
                else
                    tt.STuyChon = txtTuyChon.Text;
                if(ChiTietSanPhamBUS.XoaSanPham(tt)==false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                MessageBox.Show("Đã xóa thành công!");
                HienThiThongTinSP(txtMaSP.Text);
                txtTongSL.Text = "Số lượng: " + ChiTietSanPhamBUS.TongSL(msp);
            }
        }
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            kichhoatTT(true);
            temp = "update";
        }
        private void btnHuyTT_Click(object sender, EventArgs e)
        {
            kichhoatTT(false);
            temp = "";
            HienThiThongTinSP(msp);
        }
        #endregion

        //-----------------------------------------------------------------------------------
        private void cusTom_Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
