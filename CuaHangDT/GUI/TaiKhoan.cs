using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class TaiKhoan : Form
    {
        #region Biến cục bộ
        OpenFileDialog dlOpen = new OpenFileDialog();
        string anh;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        string temp;
        #endregion

        public TaiKhoan()
        {
            InitializeComponent();
        }

        #region Các hoạt động

        public void HienThiTaiKhoan()
        {
            List<TaiKhoanDTO> lstTaiKhoan = TaiKhoanBUS.LayTaiKhoan();
            dataGridView1.DataSource = lstTaiKhoan;
            if (lstTaiKhoan != null)
            {
                dataGridView1.Columns["STenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns["SMatKhau"].HeaderText = "Mật khẩu";
                dataGridView1.Columns["SNguoiDung"].HeaderText = "Chủ tài khoản";
                dataGridView1.Columns["SQuyenHan"].HeaderText = "Quyền hạn";
                dataGridView1.Columns["SHinhAnh"].HeaderText = "Ảnh đại diện";

                dataGridView1.Columns["STenDangNhap"].Width = 200;
                dataGridView1.Columns["SMatKhau"].Width = 200;
                dataGridView1.Columns["SNguoiDung"].Width = 180;
                dataGridView1.Columns["SQuyenHan"].Width = 190;
                dataGridView1.Columns["SHinhAnh"].Width = 200;
                if (txtAnh.Text.Trim() != "")
                {
                    try
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\" + txtAnh.Text);
                    }
                    catch
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\Male.png");
                    }
                }
                else
                {
                    PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\Male.png");
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTaiKhoan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtTenDangNhap.Text = r.Cells["STenDangNhap"].Value.ToString();
                txtMatKhau.Text= r.Cells["SMatKhau"].Value.ToString();
                txtNguoiDung.Text= r.Cells["SNguoiDung"].Value.ToString();
                if (r.Cells["SQuyenHan"].Value.ToString() == "admin")
                    radAdmin.Checked = true;
                else
                    radUser.Checked = true;
                txtAnh.Text= r.Cells["SHinhAnh"].Value.ToString() ;
                if (txtAnh.Text.Trim() != "")
                {
                    try
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\" + txtAnh.Text);
                    }
                    catch
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\Male.png");
                    }
                }
                else
                {
                    PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\Male.png");
                }
            }
            anh = txtAnh.Text;
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = path;
            dlgOpen.FilterIndex = 5;
            dlgOpen.Title = "Chọn ảnh đại diện";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = Path.GetFileName(dlgOpen.FileName);
                dlOpen = dlgOpen;
                PicAvatar.Image = Image.FromFile(dlOpen.FileName);
            }
        }
        private void kichhoat(Boolean b)
        {
            txtTenDangNhap.Enabled = b;
            txtMatKhau.Enabled = b;
            txtNguoiDung.Enabled = b;
            txtAnh.Enabled = b;
            radAdmin.Enabled = b;
            radUser.Enabled = b;
            btnLuu.Enabled = b;
            btnHuy.Enabled = b;
            btnChonAnh.Enabled = b;
            btnLuu.Visible = b;
            btnHuy.Visible = b;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SMatKhau")
            {
                e.Value = "••••••••••";
            }
        }
        #endregion


        #region Các nút chức năng
        //--------------------------------- Thêm -----------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtNguoiDung.Text = "";
            kichhoat(true);
            temp = "add";
        }
        //--------------------------------- Sửa -----------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            kichhoat(true);
            temp = "update";
            txtTenDangNhap.Enabled = false;
        }
        //--------------------------------- Lưu -----------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (temp == "add")
            {
                if (txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = txtTenDangNhap.Text;
                tk.SMatKhau = txtMatKhau.Text;
                tk.SNguoiDung = txtNguoiDung.Text;
                if (radAdmin.Checked == true)
                    tk.SQuyenHan = "admin";
                else
                    tk.SQuyenHan = "user";
                tk.SHinhAnh = txtAnh.Text;
                if (TaiKhoanBUS.ThemTaiKhoan(tk) == false)
                {
                    MessageBox.Show("Không thêm được!");
                    return;
                }
                //savefile ảnh
                if (!File.Exists(path + @"\Images\AnhTK\" + txtAnh.Text))
                {
                    try
                    {
                        File.Copy(dlOpen.FileName, path + @"\Images\AnhTK\" + txtAnh.Text);
                    }
                    catch { }
                }

                Form1_Load(sender, e);
                MessageBox.Show("Đã thêm thành công!");
            }
            if (temp == "update")
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = txtTenDangNhap.Text;
                tk.SMatKhau = txtMatKhau.Text;
                tk.SNguoiDung = txtNguoiDung.Text;
                if (radAdmin.Checked == true)
                    tk.SQuyenHan = "admin";
                else
                    tk.SQuyenHan = "user";
                tk.SHinhAnh = txtAnh.Text;
                if (TaiKhoanBUS.CapNhatTaiKhoan(tk) == false)
                {
                    MessageBox.Show("Không sửa được!");
                    return;
                }
                //savefile ảnh
                if (!File.Exists(path + @"\Images\AnhTK\" + txtAnh.Text))
                {
                    try
                    {
                        File.Copy(dlOpen.FileName, path + @"\Images\AnhTK\" + txtAnh.Text);
                    }
                    catch { }
                }
                Form1_Load(sender, e);
                MessageBox.Show("Đã sửa thành công!");
            }
            Form1_Load(sender, e);
            kichhoat(false);
        }
        //--------------------------------- Xóa -----------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                // Gán dữ liệu vào kiểu TaiKhoanDTO
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = txtTenDangNhap.Text;

                // Thực hiện xóa (xóa quá trình lương trước khi xóa nhân viên)
                if (TaiKhoanBUS.XoaTaiKhoan(tk) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }

                Form1_Load(sender, e);
                MessageBox.Show("Đã xóa tài khoản.");

            }
        }
        //--------------------------------- Hủy Bỏ -----------------------------------
        private void btnHuy_Click(object sender, EventArgs e)
        {
            kichhoat(false);
            temp = "";
            Form1_Load(sender, e);
        }
        //--------------------------------- Đóng -----------------------------------
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------- Tìm Kiếm -----------------------------------
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                HienThiTaiKhoan();
                return;
            }
            List<TaiKhoanDTO> lstTaiKhoan = TaiKhoanBUS.TimTaiKhoan(txtTim.Text);
            dataGridView1.DataSource = lstTaiKhoan;
            if (lstTaiKhoan != null)
            {
                dataGridView1.Columns["STenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns["SMatKhau"].HeaderText = "Mật khẩu";
                dataGridView1.Columns["SNguoiDung"].HeaderText = "Chủ tài khoản";
                dataGridView1.Columns["SQuyenHan"].HeaderText = "Quyền hạn";
                dataGridView1.Columns["SHinhAnh"].HeaderText = "Ảnh đại diện";
                if (txtAnh.Text.Trim() != "")
                {
                    try
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\" + txtAnh.Text);
                    }
                    catch
                    {
                        PicAvatar.Image = Image.FromFile(path + @"\Images\Male.png");
                    }
                }
                else
                {
                    PicAvatar.Image = Image.FromFile(path + @"\Images\AnhTK\Male.png");
                }

            }
        }
        #endregion


    }
}
