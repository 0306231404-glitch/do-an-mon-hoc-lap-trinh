namespace doanwf.form
{
    partial class frm_TaoHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_ChonSanPham = new System.Windows.Forms.GroupBox();
            this.cbo_MaSp = new System.Windows.Forms.ComboBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.btn_XoaSanPham = new System.Windows.Forms.Button();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoLuongMua = new System.Windows.Forms.TextBox();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_NhanVienXuLy = new System.Windows.Forms.ComboBox();
            this.grp_ThanhToan = new System.Windows.Forms.GroupBox();
            this.txt_TienKhachDua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_ThoiGianMua = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChiKHTrongTaoHoaDon = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.txt_SDTKHTrongTaoHoaDon = new System.Windows.Forms.TextBox();
            this.txt_TenKHTrongTaoHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachSPDaChon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LamMoiHD = new System.Windows.Forms.Button();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_ChonSanPham.SuspendLayout();
            this.grp_ThanhToan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPDaChon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grp_ChonSanPham);
            this.groupBox1.Controls.Add(this.cbo_NhanVienXuLy);
            this.groupBox1.Controls.Add(this.grp_ThanhToan);
            this.groupBox1.Controls.Add(this.dtp_ThoiGianMua);
            this.groupBox1.Controls.Add(this.txt_DiaChiKHTrongTaoHoaDon);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.txt_SDTKHTrongTaoHoaDon);
            this.groupBox1.Controls.Add(this.txt_TenKHTrongTaoHoaDon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // grp_ChonSanPham
            // 
            this.grp_ChonSanPham.Controls.Add(this.cbo_MaSp);
            this.grp_ChonSanPham.Controls.Add(this.txt_TenSanPham);
            this.grp_ChonSanPham.Controls.Add(this.btn_XoaSanPham);
            this.grp_ChonSanPham.Controls.Add(this.btn_ThemSanPham);
            this.grp_ChonSanPham.Controls.Add(this.label8);
            this.grp_ChonSanPham.Controls.Add(this.txt_SoLuongMua);
            this.grp_ChonSanPham.Controls.Add(this.lbl_SanPham);
            this.grp_ChonSanPham.Controls.Add(this.label6);
            this.grp_ChonSanPham.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_ChonSanPham.Location = new System.Drawing.Point(724, 18);
            this.grp_ChonSanPham.Name = "grp_ChonSanPham";
            this.grp_ChonSanPham.Size = new System.Drawing.Size(516, 236);
            this.grp_ChonSanPham.TabIndex = 10;
            this.grp_ChonSanPham.TabStop = false;
            this.grp_ChonSanPham.Text = "Chọn sản phẩm";
            // 
            // cbo_MaSp
            // 
            this.cbo_MaSp.FormattingEnabled = true;
            this.cbo_MaSp.Location = new System.Drawing.Point(13, 59);
            this.cbo_MaSp.Name = "cbo_MaSp";
            this.cbo_MaSp.Size = new System.Drawing.Size(86, 24);
            this.cbo_MaSp.TabIndex = 5;
            this.cbo_MaSp.SelectedValueChanged += new System.EventHandler(this.cbo_MaSp_SelectedValueChanged);
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Location = new System.Drawing.Point(114, 59);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(365, 22);
            this.txt_TenSanPham.TabIndex = 4;
            // 
            // btn_XoaSanPham
            // 
            this.btn_XoaSanPham.Location = new System.Drawing.Point(284, 166);
            this.btn_XoaSanPham.Name = "btn_XoaSanPham";
            this.btn_XoaSanPham.Size = new System.Drawing.Size(119, 42);
            this.btn_XoaSanPham.TabIndex = 1;
            this.btn_XoaSanPham.Text = "Xoá sản phẩm";
            this.btn_XoaSanPham.UseVisualStyleBackColor = true;
            this.btn_XoaSanPham.Click += new System.EventHandler(this.btn_XoaSanPham_Click);
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.Location = new System.Drawing.Point(114, 166);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(128, 42);
            this.btn_ThemSanPham.TabIndex = 1;
            this.btn_ThemSanPham.Text = "Thêm sản phẩm";
            this.btn_ThemSanPham.UseVisualStyleBackColor = true;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng mua";
            // 
            // txt_SoLuongMua
            // 
            this.txt_SoLuongMua.Location = new System.Drawing.Point(13, 120);
            this.txt_SoLuongMua.Multiline = true;
            this.txt_SoLuongMua.Name = "txt_SoLuongMua";
            this.txt_SoLuongMua.Size = new System.Drawing.Size(86, 32);
            this.txt_SoLuongMua.TabIndex = 3;
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Location = new System.Drawing.Point(111, 35);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(69, 16);
            this.lbl_SanPham.TabIndex = 0;
            this.lbl_SanPham.Text = "Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // cbo_NhanVienXuLy
            // 
            this.cbo_NhanVienXuLy.FormattingEnabled = true;
            this.cbo_NhanVienXuLy.Location = new System.Drawing.Point(296, 148);
            this.cbo_NhanVienXuLy.Name = "cbo_NhanVienXuLy";
            this.cbo_NhanVienXuLy.Size = new System.Drawing.Size(121, 24);
            this.cbo_NhanVienXuLy.TabIndex = 9;
            // 
            // grp_ThanhToan
            // 
            this.grp_ThanhToan.Controls.Add(this.txt_TienKhachDua);
            this.grp_ThanhToan.Controls.Add(this.label9);
            this.grp_ThanhToan.Location = new System.Drawing.Point(482, 18);
            this.grp_ThanhToan.Name = "grp_ThanhToan";
            this.grp_ThanhToan.Size = new System.Drawing.Size(236, 230);
            this.grp_ThanhToan.TabIndex = 8;
            this.grp_ThanhToan.TabStop = false;
            this.grp_ThanhToan.Text = "Thanh toán";
            // 
            // txt_TienKhachDua
            // 
            this.txt_TienKhachDua.Location = new System.Drawing.Point(9, 106);
            this.txt_TienKhachDua.Name = "txt_TienKhachDua";
            this.txt_TienKhachDua.Size = new System.Drawing.Size(220, 22);
            this.txt_TienKhachDua.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tiền khách đưa";
            // 
            // dtp_ThoiGianMua
            // 
            this.dtp_ThoiGianMua.Location = new System.Drawing.Point(45, 204);
            this.dtp_ThoiGianMua.Name = "dtp_ThoiGianMua";
            this.dtp_ThoiGianMua.Size = new System.Drawing.Size(366, 22);
            this.dtp_ThoiGianMua.TabIndex = 5;
            // 
            // txt_DiaChiKHTrongTaoHoaDon
            // 
            this.txt_DiaChiKHTrongTaoHoaDon.Location = new System.Drawing.Point(45, 148);
            this.txt_DiaChiKHTrongTaoHoaDon.Name = "txt_DiaChiKHTrongTaoHoaDon";
            this.txt_DiaChiKHTrongTaoHoaDon.Size = new System.Drawing.Size(219, 22);
            this.txt_DiaChiKHTrongTaoHoaDon.TabIndex = 3;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(45, 75);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(100, 22);
            this.txt_MaHD.TabIndex = 3;
            // 
            // txt_SDTKHTrongTaoHoaDon
            // 
            this.txt_SDTKHTrongTaoHoaDon.Location = new System.Drawing.Point(355, 77);
            this.txt_SDTKHTrongTaoHoaDon.Name = "txt_SDTKHTrongTaoHoaDon";
            this.txt_SDTKHTrongTaoHoaDon.Size = new System.Drawing.Size(121, 22);
            this.txt_SDTKHTrongTaoHoaDon.TabIndex = 3;
            // 
            // txt_TenKHTrongTaoHoaDon
            // 
            this.txt_TenKHTrongTaoHoaDon.Location = new System.Drawing.Point(151, 75);
            this.txt_TenKHTrongTaoHoaDon.Name = "txt_TenKHTrongTaoHoaDon";
            this.txt_TenKHTrongTaoHoaDon.Size = new System.Drawing.Size(185, 22);
            this.txt_TenKHTrongTaoHoaDon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã NV Xử lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã HĐ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachSPDaChon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1243, 310);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm đã chọn";
            // 
            // dgv_DanhSachSPDaChon
            // 
            this.dgv_DanhSachSPDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachSPDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSPDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaSP,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgv_DanhSachSPDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachSPDaChon.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_DanhSachSPDaChon.Location = new System.Drawing.Point(3, 18);
            this.dgv_DanhSachSPDaChon.Name = "dgv_DanhSachSPDaChon";
            this.dgv_DanhSachSPDaChon.RowHeadersWidth = 51;
            this.dgv_DanhSachSPDaChon.RowTemplate.Height = 24;
            this.dgv_DanhSachSPDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachSPDaChon.Size = new System.Drawing.Size(1237, 289);
            this.dgv_DanhSachSPDaChon.TabIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LamMoiHD);
            this.panel1.Controls.Add(this.btn_TaoHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 58);
            this.panel1.TabIndex = 8;
            // 
            // btn_LamMoiHD
            // 
            this.btn_LamMoiHD.Location = new System.Drawing.Point(205, 7);
            this.btn_LamMoiHD.Name = "btn_LamMoiHD";
            this.btn_LamMoiHD.Size = new System.Drawing.Size(93, 39);
            this.btn_LamMoiHD.TabIndex = 5;
            this.btn_LamMoiHD.Text = "Làm mới";
            this.btn_LamMoiHD.UseVisualStyleBackColor = true;
            this.btn_LamMoiHD.Click += new System.EventHandler(this.btn_LamMoiHD_Click);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(321, 7);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(138, 39);
            this.btn_TaoHoaDon.TabIndex = 6;
            this.btn_TaoHoaDon.Text = "Tạo hoá đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // frm_TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1261, 678);
            this.MinimumSize = new System.Drawing.Size(1261, 678);
            this.Name = "frm_TaoHoaDon";
            this.Text = "ma";
            this.Load += new System.EventHandler(this.frm_TaoHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_ChonSanPham.ResumeLayout(false);
            this.grp_ChonSanPham.PerformLayout();
            this.grp_ThanhToan.ResumeLayout(false);
            this.grp_ThanhToan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSPDaChon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ThoiGianMua;
        private System.Windows.Forms.TextBox txt_DiaChiKHTrongTaoHoaDon;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.TextBox txt_SDTKHTrongTaoHoaDon;
        private System.Windows.Forms.TextBox txt_TenKHTrongTaoHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_LamMoiHD;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.DataGridView dgv_DanhSachSPDaChon;
        private System.Windows.Forms.GroupBox grp_ChonSanPham;
        private System.Windows.Forms.ComboBox cbo_MaSp;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Button btn_XoaSanPham;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SoLuongMua;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_NhanVienXuLy;
        private System.Windows.Forms.GroupBox grp_ThanhToan;
        private System.Windows.Forms.TextBox txt_TienKhachDua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}