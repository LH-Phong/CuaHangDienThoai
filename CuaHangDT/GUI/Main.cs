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
    public partial class Main : Form
    {
        #region --------------------- Biến cục bộ ------------------------
        NhanVienDTO nv= new NhanVienDTO();
        TaiKhoanDTO tk = new TaiKhoanDTO();
        DangNhap dn = null;
        bool tinhTrangDN =false;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        private Form activeForm;
        #endregion
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            HienThiDangNhap();
            timer1.Start();
            DangNhap();
            if(tinhTrangDN==true)
                btnTrangChu_Click(sender, e);
        }

        #region --------------------- Các Nút ------------------------

        public void MoFormCon(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MoFormCon(new TrangChu(), sender);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFormCon(new TaiKhoan(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new NhanVien(), sender);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MoFormCon(new HangHoa(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon(new HoaDon(nv), sender);
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            MoFormCon(new LichSu(), sender);
        }
        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon(new DS_HoaDon(), sender);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            txtTenDangNhap.Text = "";
            tinhTrangDN = false;
            picAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\LHP.png");
            HienThiDangNhap();
        }
        private void btnHelps_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Helps.chm");
        }
        #endregion


        #region --------------------- Đăng nhập ------------------------
        public void DangNhap()
        {
            if (dn == null || dn.IsDisposed)
                dn = new DangNhap();
            Lamlai:
                if (dn.ShowDialog() == DialogResult.OK)
                {
                    string tenDN = dn.txtTenDangNhap.Text;
                    string matKhau = dn.txtMatKhau.Text;
                    dn.txtThongBaoDN.Visible = false;
                    if (tenDN == "")
                        {
                            dn.txtTenDangNhap.Focus();
                            goto Lamlai;
                        }
                        else if (matKhau == "")
                        {
                            dn.txtMatKhau.Focus();
                            goto Lamlai;
                        }
                    tk = new TaiKhoanDTO();
                    tk = TaiKhoanBUS.DangNhapTaiKhoan(tenDN,matKhau);
                    if (tk != null)
                    {
                        tinhTrangDN = true;
                        //Lịch sử đăng nhập
                        LichSuDTO ls = new LichSuDTO();
                        ls.STenDangNhap = tk.STenDangNhap;
                        ls.SQuyenHan = tk.SQuyenHan;
                        ls.DThoiGian = DateTime.Now;
                        nv = NhanVienBUS.NhanVienDangNhap(tk.SNguoiDung);
                        ls.STenNguoiDung = nv.STenNV;
                        LichSuBUS.Them(ls);
                }
                else
                    {
                        dn.txtThongBaoDN.Visible = true;
                        goto Lamlai;
                    }
                }
                else
                {
                    tinhTrangDN = false;
                }
            HienThiDangNhap();

        }
        public void HienThiDangNhap()
        {
            btnDangXuat.Visible = false;
            btnTrangChu.Visible = false;
            btnTaiKhoan.Visible = false;
            btnNhanVien.Visible = false;
            btnHoaDon.Visible = false;
            btnSanPham.Visible = false;
            btnDSHoaDon.Visible = false;
            txtTenDangNhap.Visible = false;
            if (tinhTrangDN)
            {
                string Quyen = tk.SQuyenHan;
                //nv = NhanVienBUS.NhanVienDangNhap(tk.SNguoiDung);
                txtTenDangNhap.Text = "Chào, " + tk.STenDangNhap;
                txtNhanVien.Text = "Nhân viên: " + nv.STenNV;
                if (tk== null)
                    Quyen = "";
                else
                    Quyen = tk.SQuyenHan;
                try
                {
                    picAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\" +tk.SHinhAnh);
                }
                catch
                {
                    picAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\LHP.png");
                }
                switch (Quyen)
                {
                    case "admin":
                        btnDangXuat.Visible = true;
                        btnDangNhap.Visible = false;
                        btnDangXuat.Visible = true;
                        btnTrangChu.Visible = true;
                        btnTaiKhoan.Visible = true;
                        btnNhanVien.Visible = true;
                        btnHoaDon.Visible = true;
                        btnSanPham.Visible = true;
                        btnDSHoaDon.Visible = true;
                        btnLichSu.Visible = true;
                        txtTenDangNhap.Visible = true;

                        break;
                    case "user":
                        btnDangXuat.Visible = true;
                        btnDangNhap.Visible = false;
                        btnDangXuat.Visible = true;
                        btnTrangChu.Visible = false;
                        btnTaiKhoan.Visible = false;
                        btnNhanVien.Visible = false;
                        btnHoaDon.Visible = true;
                        btnSanPham.Visible = false;
                        btnDSHoaDon.Visible = true;
                        btnTrangChu.Visible = true;
                        btnDSHoaDon.Visible = true;
                        btnLichSu.Visible = false;
                        txtTenDangNhap.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                btnDangXuat.Visible = false;
                btnDangNhap.Visible = true;
                btnDangXuat.Visible = false;
                btnTrangChu.Visible = false;
                btnTaiKhoan.Visible = false;
                btnNhanVien.Visible = false;
                btnHoaDon.Visible = false;
                btnSanPham.Visible = false;
                btnDSHoaDon.Visible = false;
                btnLichSu.Visible = false;
                btnDSHoaDon.Visible = false;
                txtTenDangNhap.Visible = false;

                txtNhanVien.Text = "Nhân viên: ";
            }
        }


        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        
    }
}
