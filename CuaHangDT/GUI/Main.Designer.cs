
namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnHelps = new GUI.CusTom_Button();
            this.txtNhanVien = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.txtTenDangNhap = new System.Windows.Forms.Label();
            this.btnDSHoaDon = new GUI.CusTom_Button();
            this.btnDangNhap = new GUI.CusTom_Button();
            this.btnDangXuat = new GUI.CusTom_Button();
            this.btnHoaDon = new GUI.CusTom_Button();
            this.btnSanPham = new GUI.CusTom_Button();
            this.btnNhanVien = new GUI.CusTom_Button();
            this.btnTaiKhoan = new GUI.CusTom_Button();
            this.btnTrangChu = new GUI.CusTom_Button();
            this.pnPic = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnLichSu = new GUI.CusTom_Button();
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.Gainsboro;
            this.pnMain.BackgroundImage = global::GUI.Properties.Resources.Picture2;
            this.pnMain.Location = new System.Drawing.Point(283, 210);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(832, 486);
            this.pnMain.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTop.BackgroundImage = global::GUI.Properties.Resources.Picture1_2;
            this.pnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTop.Controls.Add(this.btnHelps);
            this.pnTop.Controls.Add(this.txtNhanVien);
            this.pnTop.Controls.Add(this.txtTime);
            this.pnTop.Location = new System.Drawing.Point(283, 12);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(832, 194);
            this.pnTop.TabIndex = 1;
            // 
            // btnHelps
            // 
            this.btnHelps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelps.BackColor = System.Drawing.Color.Azure;
            this.btnHelps.BackgroundColor = System.Drawing.Color.Azure;
            this.btnHelps.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnHelps.BorderRadius = 5;
            this.btnHelps.BorderSize = 0;
            this.btnHelps.FlatAppearance.BorderSize = 0;
            this.btnHelps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelps.ForeColor = System.Drawing.Color.Black;
            this.btnHelps.Image = global::GUI.Properties.Resources.help_24px;
            this.btnHelps.Location = new System.Drawing.Point(791, 2);
            this.btnHelps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelps.Name = "btnHelps";
            this.btnHelps.Size = new System.Drawing.Size(38, 41);
            this.btnHelps.TabIndex = 3;
            this.btnHelps.TextColor = System.Drawing.Color.Black;
            this.btnHelps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelps.UseVisualStyleBackColor = false;
            this.btnHelps.Click += new System.EventHandler(this.btnHelps_Click);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.AutoSize = true;
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtNhanVien.Image = global::GUI.Properties.Resources.Picture1;
            this.txtNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNhanVien.Location = new System.Drawing.Point(4, 142);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(141, 29);
            this.txtNhanVien.TabIndex = 1;
            this.txtNhanVien.Text = "Nhân viên: ";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Maroon;
            this.txtTime.Location = new System.Drawing.Point(597, 142);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(136, 29);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "Thời Gian: ";
            // 
            // pnLeft
            // 
            this.pnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnLeft.BackgroundImage = global::GUI.Properties.Resources.Picture2;
            this.pnLeft.Controls.Add(this.btnLichSu);
            this.pnLeft.Controls.Add(this.txtTenDangNhap);
            this.pnLeft.Controls.Add(this.btnDSHoaDon);
            this.pnLeft.Controls.Add(this.btnDangNhap);
            this.pnLeft.Controls.Add(this.btnDangXuat);
            this.pnLeft.Controls.Add(this.btnHoaDon);
            this.pnLeft.Controls.Add(this.btnSanPham);
            this.pnLeft.Controls.Add(this.btnNhanVien);
            this.pnLeft.Controls.Add(this.btnTaiKhoan);
            this.pnLeft.Controls.Add(this.btnTrangChu);
            this.pnLeft.Controls.Add(this.pnPic);
            this.pnLeft.Location = new System.Drawing.Point(12, 12);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(252, 686);
            this.pnLeft.TabIndex = 0;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.AutoSize = true;
            this.txtTenDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(0, 561);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(26, 25);
            this.txtTenDangNhap.TabIndex = 9;
            this.txtTenDangNhap.Text = "--";
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDSHoaDon.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnDSHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDSHoaDon.BackgroundImage")));
            this.btnDSHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDSHoaDon.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnDSHoaDon.BorderRadius = 5;
            this.btnDSHoaDon.BorderSize = 0;
            this.btnDSHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSHoaDon.FlatAppearance.BorderSize = 0;
            this.btnDSHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnDSHoaDon.Image = global::GUI.Properties.Resources.list2_24px;
            this.btnDSHoaDon.Location = new System.Drawing.Point(0, 446);
            this.btnDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(252, 50);
            this.btnDSHoaDon.TabIndex = 8;
            this.btnDSHoaDon.Text = "Danh sách hóa đơn";
            this.btnDSHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSHoaDon.TextColor = System.Drawing.Color.Black;
            this.btnDSHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnDangNhap.BorderRadius = 5;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Image = global::GUI.Properties.Resources.login_24px;
            this.btnDangNhap.Location = new System.Drawing.Point(0, 586);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(252, 50);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.TextColor = System.Drawing.Color.Black;
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDangXuat.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnDangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.BackgroundImage")));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnDangXuat.BorderRadius = 5;
            this.btnDangXuat.BorderSize = 0;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = global::GUI.Properties.Resources.Logout_24px;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 636);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(252, 50);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextColor = System.Drawing.Color.Black;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHoaDon.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.BackgroundImage")));
            this.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoaDon.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnHoaDon.BorderRadius = 5;
            this.btnHoaDon.BorderSize = 0;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = global::GUI.Properties.Resources.receipt_dollar_24px;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 396);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(252, 50);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.TextColor = System.Drawing.Color.Black;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSanPham.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSanPham.BackgroundImage")));
            this.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSanPham.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnSanPham.BorderRadius = 5;
            this.btnSanPham.BorderSize = 0;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham.Image = global::GUI.Properties.Resources.warehouse_24px;
            this.btnSanPham.Location = new System.Drawing.Point(0, 346);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(252, 50);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "Hàng hóa";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSanPham.TextColor = System.Drawing.Color.Black;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNhanVien.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.BackgroundImage")));
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanVien.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnNhanVien.BorderRadius = 5;
            this.btnNhanVien.BorderSize = 0;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = global::GUI.Properties.Resources.staff_24px;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 296);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(252, 50);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.TextColor = System.Drawing.Color.Black;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTaiKhoan.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.BackgroundImage")));
            this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaiKhoan.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnTaiKhoan.BorderRadius = 5;
            this.btnTaiKhoan.BorderSize = 0;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = global::GUI.Properties.Resources.account_24px;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 246);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(252, 50);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.BackgroundImage")));
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnTrangChu.BorderRadius = 5;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = global::GUI.Properties.Resources.home_24px;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 196);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(252, 50);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangChu.TextColor = System.Drawing.Color.Black;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnPic
            // 
            this.pnPic.BackgroundImage = global::GUI.Properties.Resources.Picture2;
            this.pnPic.Controls.Add(this.picAvatar);
            this.pnPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPic.Location = new System.Drawing.Point(0, 0);
            this.pnPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPic.Name = "pnPic";
            this.pnPic.Size = new System.Drawing.Size(252, 196);
            this.pnPic.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAvatar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picAvatar.Image = global::GUI.Properties.Resources.LHP;
            this.picAvatar.Location = new System.Drawing.Point(51, 21);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(149, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLichSu.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnLichSu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLichSu.BackgroundImage")));
            this.btnLichSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichSu.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnLichSu.BorderRadius = 5;
            this.btnLichSu.BorderSize = 0;
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.ForeColor = System.Drawing.Color.Black;
            this.btnLichSu.Image = global::GUI.Properties.Resources.order_history_24px;
            this.btnLichSu.Location = new System.Drawing.Point(0, 496);
            this.btnLichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(252, 50);
            this.btnLichSu.TabIndex = 10;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSu.TextColor = System.Drawing.Color.Black;
            this.btnLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 710);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng điện thoại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private CusTom_Button btnTaiKhoan;
        private CusTom_Button btnTrangChu;
        private System.Windows.Forms.Panel pnPic;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMain;
        private CusTom_Button btnDangNhap;
        private CusTom_Button btnDangXuat;
        private CusTom_Button btnHoaDon;
        private CusTom_Button btnSanPham;
        private CusTom_Button btnNhanVien;
        private CusTom_Button btnDSHoaDon;
        private System.Windows.Forms.Label txtTenDangNhap;
        private System.Windows.Forms.Timer timer1;
        private CusTom_Button btnHelps;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtNhanVien;
        private CusTom_Button btnLichSu;
    }
}