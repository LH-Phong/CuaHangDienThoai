
namespace GUI
{
    partial class DS_HoaDon
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
            this.dtgDsHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTimNgay = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new GUI.CusTom_Button();
            this.cusTom_Button2 = new GUI.CusTom_Button();
            this.cusTom_Button1 = new GUI.CusTom_Button();
            this.btnLuuTT = new GUI.CusTom_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDsHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgDsHoaDon);
            this.panel1.Location = new System.Drawing.Point(11, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 258);
            this.panel1.TabIndex = 0;
            // 
            // dtgDsHoaDon
            // 
            this.dtgDsHoaDon.AllowUserToAddRows = false;
            this.dtgDsHoaDon.AllowUserToDeleteRows = false;
            this.dtgDsHoaDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDsHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDsHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtgDsHoaDon.Name = "dtgDsHoaDon";
            this.dtgDsHoaDon.ReadOnly = true;
            this.dtgDsHoaDon.RowHeadersWidth = 51;
            this.dtgDsHoaDon.RowTemplate.Height = 24;
            this.dtgDsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDsHoaDon.Size = new System.Drawing.Size(1106, 258);
            this.dtgDsHoaDon.TabIndex = 0;
            this.dtgDsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDsHoaDon_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.cusTom_Button2);
            this.panel2.Controls.Add(this.cusTom_Button1);
            this.panel2.Controls.Add(this.btnLuuTT);
            this.panel2.Location = new System.Drawing.Point(865, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 248);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtTenKH);
            this.panel3.Controls.Add(this.txtNguoiLap);
            this.panel3.Controls.Add(this.txtTrangThai);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.txtNgayLap);
            this.panel3.Controls.Add(this.txtMaHD);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 248);
            this.panel3.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(574, 145);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(26, 25);
            this.txtSDT.TabIndex = 13;
            this.txtSDT.Text = "--";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoSize = true;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(602, 79);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(26, 25);
            this.txtTenKH.TabIndex = 12;
            this.txtTenKH.Text = "--";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.AutoSize = true;
            this.txtNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiLap.Location = new System.Drawing.Point(542, 13);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(26, 25);
            this.txtNguoiLap.TabIndex = 11;
            this.txtNguoiLap.Text = "--";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.AutoSize = true;
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.txtTrangThai.Location = new System.Drawing.Point(117, 211);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(26, 25);
            this.txtTrangThai.TabIndex = 10;
            this.txtTrangThai.Text = "--";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(111, 145);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(26, 25);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.Text = "--";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.AutoSize = true;
            this.txtNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(111, 79);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(26, 25);
            this.txtNgayLap.TabIndex = 8;
            this.txtNgayLap.Text = "--";
            // 
            // txtMaHD
            // 
            this.txtMaHD.AutoSize = true;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Red;
            this.txtMaHD.Location = new System.Drawing.Point(133, 13);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(26, 25);
            this.txtMaHD.TabIndex = 7;
            this.txtMaHD.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.btnTimNgay);
            this.panel4.Controls.Add(this.txtTim);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Location = new System.Drawing.Point(17, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 52);
            this.panel4.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(194, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 34);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(986, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 32);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTimNgay
            // 
            this.btnTimNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNgay.Location = new System.Drawing.Point(370, 9);
            this.btnTimNgay.Name = "btnTimNgay";
            this.btnTimNgay.Size = new System.Drawing.Size(145, 32);
            this.btnTimNgay.TabIndex = 2;
            this.btnTimNgay.Text = "Tìm theo ngày";
            this.btnTimNgay.UseVisualStyleBackColor = true;
            this.btnTimNgay.Click += new System.EventHandler(this.btnTimNgay_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(566, 8);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(414, 34);
            this.txtTim.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXem.BorderRadius = 20;
            this.btnXem.BorderSize = 2;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Image = global::GUI.Properties.Resources.search_24px;
            this.btnXem.Location = new System.Drawing.Point(0, 75);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(249, 43);
            this.btnXem.TabIndex = 30;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.TextColor = System.Drawing.Color.Black;
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cusTom_Button2
            // 
            this.cusTom_Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cusTom_Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cusTom_Button2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.cusTom_Button2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cusTom_Button2.BorderRadius = 20;
            this.cusTom_Button2.BorderSize = 2;
            this.cusTom_Button2.FlatAppearance.BorderSize = 0;
            this.cusTom_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusTom_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTom_Button2.ForeColor = System.Drawing.Color.Black;
            this.cusTom_Button2.Image = global::GUI.Properties.Resources.exit_24px;
            this.cusTom_Button2.Location = new System.Drawing.Point(3, 191);
            this.cusTom_Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cusTom_Button2.Name = "cusTom_Button2";
            this.cusTom_Button2.Size = new System.Drawing.Size(249, 43);
            this.cusTom_Button2.TabIndex = 29;
            this.cusTom_Button2.Text = "Thoát";
            this.cusTom_Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cusTom_Button2.TextColor = System.Drawing.Color.Black;
            this.cusTom_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cusTom_Button2.UseVisualStyleBackColor = false;
            this.cusTom_Button2.Click += new System.EventHandler(this.cusTom_Button2_Click);
            // 
            // cusTom_Button1
            // 
            this.cusTom_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cusTom_Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cusTom_Button1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.cusTom_Button1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cusTom_Button1.BorderRadius = 20;
            this.cusTom_Button1.BorderSize = 2;
            this.cusTom_Button1.FlatAppearance.BorderSize = 0;
            this.cusTom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusTom_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTom_Button1.ForeColor = System.Drawing.Color.Black;
            this.cusTom_Button1.Image = global::GUI.Properties.Resources.Trash_26px;
            this.cusTom_Button1.Location = new System.Drawing.Point(0, 133);
            this.cusTom_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cusTom_Button1.Name = "cusTom_Button1";
            this.cusTom_Button1.Size = new System.Drawing.Size(249, 43);
            this.cusTom_Button1.TabIndex = 28;
            this.cusTom_Button1.Text = "Xóa bỏ";
            this.cusTom_Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cusTom_Button1.TextColor = System.Drawing.Color.Black;
            this.cusTom_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cusTom_Button1.UseVisualStyleBackColor = false;
            this.cusTom_Button1.Click += new System.EventHandler(this.cusTom_Button1_Click);
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuTT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuTT.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuTT.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuuTT.BorderRadius = 20;
            this.btnLuuTT.BorderSize = 2;
            this.btnLuuTT.FlatAppearance.BorderSize = 0;
            this.btnLuuTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTT.ForeColor = System.Drawing.Color.Black;
            this.btnLuuTT.Image = global::GUI.Properties.Resources.Check_Circle_24px;
            this.btnLuuTT.Location = new System.Drawing.Point(0, 13);
            this.btnLuuTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(252, 47);
            this.btnLuuTT.TabIndex = 27;
            this.btnLuuTT.Text = "Đánh dấu hoàn thành";
            this.btnLuuTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuTT.TextColor = System.Drawing.Color.Black;
            this.btnLuuTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuTT.UseVisualStyleBackColor = false;
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // DS_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 580);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DS_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.DS_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDsHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgDsHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTimNgay;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label txtTenKH;
        private System.Windows.Forms.Label txtNguoiLap;
        private System.Windows.Forms.Label txtTrangThai;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label txtNgayLap;
        private System.Windows.Forms.Label txtMaHD;
        private CusTom_Button btnLuuTT;
        private CusTom_Button cusTom_Button2;
        private CusTom_Button cusTom_Button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private CusTom_Button btnXem;
    }
}