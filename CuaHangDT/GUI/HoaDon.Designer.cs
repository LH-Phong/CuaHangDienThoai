
namespace GUI
{
    partial class HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grDSHD = new System.Windows.Forms.GroupBox();
            this.dtgDSHD = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.pnChiTietHD = new System.Windows.Forms.Panel();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgChiTietHD = new System.Windows.Forms.DataGridView();
            this.grSanPham = new System.Windows.Forms.GroupBox();
            this.txtSLSP = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtCauHinh = new System.Windows.Forms.TextBox();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.cboTuyChon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgDSSP = new System.Windows.Forms.DataGridView();
            this.pnNut = new System.Windows.Forms.Panel();
            this.btnLuu = new GUI.CusTom_Button();
            this.btnDanhSach = new GUI.CusTom_Button();
            this.btnDong = new GUI.CusTom_Button();
            this.btnIn = new GUI.CusTom_Button();
            this.btnThemHD = new GUI.CusTom_Button();
            this.pnThongTinKH = new System.Windows.Forms.Panel();
            this.txtSDT_KH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.Label();
            this.btnTim = new GUI.CusTom_Button();
            this.panel1.SuspendLayout();
            this.grDSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHD)).BeginInit();
            this.pnChiTietHD.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHD)).BeginInit();
            this.grSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSP)).BeginInit();
            this.pnNut.SuspendLayout();
            this.pnThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grDSHD);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 174);
            this.panel1.TabIndex = 0;
            // 
            // grDSHD
            // 
            this.grDSHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDSHD.Controls.Add(this.dtgDSHD);
            this.grDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSHD.Location = new System.Drawing.Point(3, 2);
            this.grDSHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDSHD.Name = "grDSHD";
            this.grDSHD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDSHD.Size = new System.Drawing.Size(772, 167);
            this.grDSHD.TabIndex = 0;
            this.grDSHD.TabStop = false;
            this.grDSHD.Text = "Danh sách hóa đơn";
            // 
            // dtgDSHD
            // 
            this.dtgDSHD.AllowUserToAddRows = false;
            this.dtgDSHD.AllowUserToDeleteRows = false;
            this.dtgDSHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDSHD.Location = new System.Drawing.Point(3, 25);
            this.dtgDSHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDSHD.Name = "dtgDSHD";
            this.dtgDSHD.ReadOnly = true;
            this.dtgDSHD.RowHeadersWidth = 51;
            this.dtgDSHD.RowTemplate.Height = 24;
            this.dtgDSHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSHD.Size = new System.Drawing.Size(766, 140);
            this.dtgDSHD.TabIndex = 0;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(517, 9);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(511, 28);
            this.txtTim.TabIndex = 33;
            // 
            // pnChiTietHD
            // 
            this.pnChiTietHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnChiTietHD.Controls.Add(this.btnXoaTatCa);
            this.pnChiTietHD.Controls.Add(this.btnXoa);
            this.pnChiTietHD.Controls.Add(this.txtThanhTien);
            this.pnChiTietHD.Controls.Add(this.label3);
            this.pnChiTietHD.Controls.Add(this.label7);
            this.pnChiTietHD.Controls.Add(this.panel5);
            this.pnChiTietHD.Controls.Add(this.grSanPham);
            this.pnChiTietHD.Location = new System.Drawing.Point(12, 287);
            this.pnChiTietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnChiTietHD.Name = "pnChiTietHD";
            this.pnChiTietHD.Size = new System.Drawing.Size(1125, 323);
            this.pnChiTietHD.TabIndex = 35;
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCa.Location = new System.Drawing.Point(993, 267);
            this.btnXoaTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(124, 46);
            this.btnXoaTatCa.TabIndex = 16;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(872, 267);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 46);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(907, 282);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(21, 20);
            this.txtThanhTien.TabIndex = 15;
            this.txtThanhTien.Text = "--";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi tiết hóa đơn";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(805, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thành Tiền:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dtgChiTietHD);
            this.panel5.Location = new System.Drawing.Point(809, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 212);
            this.panel5.TabIndex = 1;
            // 
            // dtgChiTietHD
            // 
            this.dtgChiTietHD.AllowUserToAddRows = false;
            this.dtgChiTietHD.AllowUserToDeleteRows = false;
            this.dtgChiTietHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgChiTietHD.Location = new System.Drawing.Point(0, 0);
            this.dtgChiTietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgChiTietHD.Name = "dtgChiTietHD";
            this.dtgChiTietHD.ReadOnly = true;
            this.dtgChiTietHD.RowHeadersWidth = 51;
            this.dtgChiTietHD.RowTemplate.Height = 24;
            this.dtgChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChiTietHD.Size = new System.Drawing.Size(309, 212);
            this.dtgChiTietHD.TabIndex = 1;
            this.dtgChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChiTietHD_CellClick);
            // 
            // grSanPham
            // 
            this.grSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grSanPham.Controls.Add(this.txtSLSP);
            this.grSanPham.Controls.Add(this.numSoLuong);
            this.grSanPham.Controls.Add(this.label5);
            this.grSanPham.Controls.Add(this.btnThemSP);
            this.grSanPham.Controls.Add(this.txtCauHinh);
            this.grSanPham.Controls.Add(this.picSP);
            this.grSanPham.Controls.Add(this.cboTuyChon);
            this.grSanPham.Controls.Add(this.label4);
            this.grSanPham.Controls.Add(this.txtGia);
            this.grSanPham.Controls.Add(this.label2);
            this.grSanPham.Controls.Add(this.txtTenSP);
            this.grSanPham.Controls.Add(this.label1);
            this.grSanPham.Controls.Add(this.btnTimSP);
            this.grSanPham.Controls.Add(this.txtTimSP);
            this.grSanPham.Controls.Add(this.panel4);
            this.grSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSanPham.Location = new System.Drawing.Point(3, 2);
            this.grSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSanPham.Name = "grSanPham";
            this.grSanPham.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grSanPham.Size = new System.Drawing.Size(796, 319);
            this.grSanPham.TabIndex = 0;
            this.grSanPham.TabStop = false;
            this.grSanPham.Text = "Danh sách sản phẩm";
            // 
            // txtSLSP
            // 
            this.txtSLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSLSP.AutoSize = true;
            this.txtSLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLSP.ForeColor = System.Drawing.Color.Blue;
            this.txtSLSP.Location = new System.Drawing.Point(219, 272);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.Size = new System.Drawing.Size(48, 20);
            this.txtSLSP.TabIndex = 14;
            this.txtSLSP.Text = "Còn:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(93, 270);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 27);
            this.numSoLuong.TabIndex = 13;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng:";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(503, 65);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(273, 34);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm vào hóa đơn";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click_1);
            // 
            // txtCauHinh
            // 
            this.txtCauHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCauHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHinh.Location = new System.Drawing.Point(535, 134);
            this.txtCauHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCauHinh.Multiline = true;
            this.txtCauHinh.Name = "txtCauHinh";
            this.txtCauHinh.Size = new System.Drawing.Size(255, 181);
            this.txtCauHinh.TabIndex = 10;
            // 
            // picSP
            // 
            this.picSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSP.Location = new System.Drawing.Point(595, -18);
            this.picSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(139, 148);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 9;
            this.picSP.TabStop = false;
            // 
            // cboTuyChon
            // 
            this.cboTuyChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuyChon.FormattingEnabled = true;
            this.cboTuyChon.Location = new System.Drawing.Point(94, 195);
            this.cboTuyChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTuyChon.Name = "cboTuyChon";
            this.cboTuyChon.Size = new System.Drawing.Size(143, 28);
            this.cboTuyChon.TabIndex = 8;
            this.cboTuyChon.SelectedValueChanged += new System.EventHandler(this.cboTuyChon_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tùy chọn:";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.AutoSize = true;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(54, 235);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(21, 20);
            this.txtGia.TabIndex = 6;
            this.txtGia.Text = "--";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenSP.AutoSize = true;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(144, 163);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(21, 20);
            this.txtTenSP.TabIndex = 4;
            this.txtTenSP.Text = "--";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(701, 21);
            this.btnTimSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(75, 30);
            this.btnTimSP.TabIndex = 2;
            this.btnTimSP.Text = "Tìm";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // txtTimSP
            // 
            this.txtTimSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimSP.Location = new System.Drawing.Point(503, 21);
            this.txtTimSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(192, 27);
            this.txtTimSP.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.dtgDSSP);
            this.panel4.Location = new System.Drawing.Point(5, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 97);
            this.panel4.TabIndex = 0;
            // 
            // dtgDSSP
            // 
            this.dtgDSSP.AllowUserToAddRows = false;
            this.dtgDSSP.AllowUserToDeleteRows = false;
            this.dtgDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgDSSP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSSP.Location = new System.Drawing.Point(0, 0);
            this.dtgDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDSSP.Name = "dtgDSSP";
            this.dtgDSSP.ReadOnly = true;
            this.dtgDSSP.RowHeadersWidth = 51;
            this.dtgDSSP.RowTemplate.Height = 24;
            this.dtgDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSSP.Size = new System.Drawing.Size(489, 97);
            this.dtgDSSP.TabIndex = 1;
            this.dtgDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSSP_CellClick);
            // 
            // pnNut
            // 
            this.pnNut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNut.Controls.Add(this.btnLuu);
            this.pnNut.Controls.Add(this.btnDanhSach);
            this.pnNut.Controls.Add(this.btnDong);
            this.pnNut.Controls.Add(this.btnIn);
            this.pnNut.Controls.Add(this.btnThemHD);
            this.pnNut.Location = new System.Drawing.Point(12, 235);
            this.pnNut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnNut.Name = "pnNut";
            this.pnNut.Size = new System.Drawing.Size(1125, 46);
            this.pnNut.TabIndex = 36;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 2;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::GUI.Properties.Resources.save_24px;
            this.btnLuu.Location = new System.Drawing.Point(265, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 39);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDanhSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSach.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDanhSach.BorderRadius = 20;
            this.btnDanhSach.BorderSize = 2;
            this.btnDanhSach.FlatAppearance.BorderSize = 0;
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.Black;
            this.btnDanhSach.Image = global::GUI.Properties.Resources.list2_24px;
            this.btnDanhSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDanhSach.Location = new System.Drawing.Point(415, 5);
            this.btnDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(288, 39);
            this.btnDanhSach.TabIndex = 39;
            this.btnDanhSach.Text = "Danh sách hóa đơn";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSach.TextColor = System.Drawing.Color.Black;
            this.btnDanhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDong.BackColor = System.Drawing.Color.IndianRed;
            this.btnDong.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnDong.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDong.BorderRadius = 20;
            this.btnDong.BorderSize = 2;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = global::GUI.Properties.Resources.exit_24px;
            this.btnDong.Location = new System.Drawing.Point(1006, 5);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 39);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.TextColor = System.Drawing.Color.Black;
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIn.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIn.BorderRadius = 20;
            this.btnIn.BorderSize = 2;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Image = global::GUI.Properties.Resources.print_24px;
            this.btnIn.Location = new System.Drawing.Point(744, 5);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(221, 39);
            this.btnIn.TabIndex = 38;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.TextColor = System.Drawing.Color.Black;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemHD.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemHD.BorderRadius = 20;
            this.btnThemHD.BorderSize = 2;
            this.btnThemHD.FlatAppearance.BorderSize = 0;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.Black;
            this.btnThemHD.Image = global::GUI.Properties.Resources.add_24px;
            this.btnThemHD.Location = new System.Drawing.Point(3, 5);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(221, 39);
            this.btnThemHD.TabIndex = 37;
            this.btnThemHD.Text = "Tạo hóa đơn mới";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.TextColor = System.Drawing.Color.Black;
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // pnThongTinKH
            // 
            this.pnThongTinKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongTinKH.Controls.Add(this.txtSDT_KH);
            this.pnThongTinKH.Controls.Add(this.txtTenKH);
            this.pnThongTinKH.Controls.Add(this.label9);
            this.pnThongTinKH.Controls.Add(this.label8);
            this.pnThongTinKH.Controls.Add(this.txtMaHD);
            this.pnThongTinKH.Location = new System.Drawing.Point(793, 55);
            this.pnThongTinKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThongTinKH.Name = "pnThongTinKH";
            this.pnThongTinKH.Size = new System.Drawing.Size(336, 174);
            this.pnThongTinKH.TabIndex = 37;
            // 
            // txtSDT_KH
            // 
            this.txtSDT_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT_KH.Location = new System.Drawing.Point(29, 134);
            this.txtSDT_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT_KH.Name = "txtSDT_KH";
            this.txtSDT_KH.Size = new System.Drawing.Size(285, 24);
            this.txtSDT_KH.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(29, 76);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(285, 24);
            this.txtTenKH.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số điện thoại: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên khách hàng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.AutoSize = true;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaHD.Location = new System.Drawing.Point(3, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(26, 25);
            this.txtMaHD.TabIndex = 0;
            this.txtMaHD.Text = "--";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.BackgroundColor = System.Drawing.Color.White;
            this.btnTim.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.BorderRadius = 20;
            this.btnTim.BorderSize = 2;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Image = global::GUI.Properties.Resources.search_24px;
            this.btnTim.Location = new System.Drawing.Point(1035, 4);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 39);
            this.btnTim.TabIndex = 34;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.TextColor = System.Drawing.Color.Black;
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1149, 623);
            this.Controls.Add(this.pnThongTinKH);
            this.Controls.Add(this.pnNut);
            this.Controls.Add(this.pnChiTietHD);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.grDSHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHD)).EndInit();
            this.pnChiTietHD.ResumeLayout(false);
            this.pnChiTietHD.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHD)).EndInit();
            this.grSanPham.ResumeLayout(false);
            this.grSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSP)).EndInit();
            this.pnNut.ResumeLayout(false);
            this.pnThongTinKH.ResumeLayout(false);
            this.pnThongTinKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CusTom_Button btnDong;
        private System.Windows.Forms.GroupBox grDSHD;
        private System.Windows.Forms.DataGridView dtgDSHD;
        private CusTom_Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel pnChiTietHD;
        private System.Windows.Forms.Panel pnNut;
        private System.Windows.Forms.Label txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgChiTietHD;
        private System.Windows.Forms.GroupBox grSanPham;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtCauHinh;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.ComboBox cboTuyChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgDSSP;
        private CusTom_Button btnIn;
        private CusTom_Button btnThemHD;
        private System.Windows.Forms.Panel pnThongTinKH;
        private System.Windows.Forms.TextBox txtSDT_KH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtMaHD;
        private CusTom_Button btnDanhSach;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXoa;
        private CusTom_Button btnLuu;
        private System.Windows.Forms.Label txtSLSP;
    }
}