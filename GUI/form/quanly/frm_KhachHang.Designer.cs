namespace doanwf.form.quanly
{
    partial class frm_KhachHang
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
            this.grp_QuanliKH = new System.Windows.Forms.GroupBox();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_ResetKhachHang = new System.Windows.Forms.Button();
            this.btn_XoaKhachHang = new System.Windows.Forms.Button();
            this.btn_SuaKhachHang = new System.Windows.Forms.Button();
            this.btn_ThemKhachHang = new System.Windows.Forms.Button();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.txt_TiemKiemKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_DiaChiKH = new System.Windows.Forms.TextBox();
            this.txt_SDTKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_DanhSachKH = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.grp_QuanliKH.SuspendLayout();
            this.grp_DanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_QuanliKH
            // 
            this.grp_QuanliKH.Controls.Add(this.rad_Nu);
            this.grp_QuanliKH.Controls.Add(this.rad_Nam);
            this.grp_QuanliKH.Controls.Add(this.dtp_NgaySinhKH);
            this.grp_QuanliKH.Controls.Add(this.label2);
            this.grp_QuanliKH.Controls.Add(this.btn_Load);
            this.grp_QuanliKH.Controls.Add(this.btn_TimKiem);
            this.grp_QuanliKH.Controls.Add(this.btn_ResetKhachHang);
            this.grp_QuanliKH.Controls.Add(this.btn_XoaKhachHang);
            this.grp_QuanliKH.Controls.Add(this.btn_SuaKhachHang);
            this.grp_QuanliKH.Controls.Add(this.btn_ThemKhachHang);
            this.grp_QuanliKH.Controls.Add(this.txt_HoTenKH);
            this.grp_QuanliKH.Controls.Add(this.txt_TiemKiemKH);
            this.grp_QuanliKH.Controls.Add(this.txt_MaKH);
            this.grp_QuanliKH.Controls.Add(this.txt_DiaChiKH);
            this.grp_QuanliKH.Controls.Add(this.txt_SDTKH);
            this.grp_QuanliKH.Controls.Add(this.label7);
            this.grp_QuanliKH.Controls.Add(this.label5);
            this.grp_QuanliKH.Controls.Add(this.label3);
            this.grp_QuanliKH.Controls.Add(this.label6);
            this.grp_QuanliKH.Controls.Add(this.label4);
            this.grp_QuanliKH.Controls.Add(this.label1);
            this.grp_QuanliKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_QuanliKH.ForeColor = System.Drawing.Color.Black;
            this.grp_QuanliKH.Location = new System.Drawing.Point(0, 0);
            this.grp_QuanliKH.Name = "grp_QuanliKH";
            this.grp_QuanliKH.Size = new System.Drawing.Size(1027, 237);
            this.grp_QuanliKH.TabIndex = 1;
            this.grp_QuanliKH.TabStop = false;
            this.grp_QuanliKH.Text = "Quản lí khách hàng";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(364, 133);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 5;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Location = new System.Drawing.Point(297, 132);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 4;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinhKH
            // 
            this.dtp_NgaySinhKH.Location = new System.Drawing.Point(46, 130);
            this.dtp_NgaySinhKH.Name = "dtp_NgaySinhKH";
            this.dtp_NgaySinhKH.Size = new System.Drawing.Size(200, 22);
            this.dtp_NgaySinhKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(597, 182);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(86, 23);
            this.btn_Load.TabIndex = 12;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(486, 182);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 23);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_ResetKhachHang
            // 
            this.btn_ResetKhachHang.Location = new System.Drawing.Point(833, 130);
            this.btn_ResetKhachHang.Name = "btn_ResetKhachHang";
            this.btn_ResetKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetKhachHang.TabIndex = 9;
            this.btn_ResetKhachHang.Text = "Reset";
            this.btn_ResetKhachHang.UseVisualStyleBackColor = true;
            this.btn_ResetKhachHang.Click += new System.EventHandler(this.btn_ResetKhachHang_Click);
            // 
            // btn_XoaKhachHang
            // 
            this.btn_XoaKhachHang.Location = new System.Drawing.Point(833, 101);
            this.btn_XoaKhachHang.Name = "btn_XoaKhachHang";
            this.btn_XoaKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaKhachHang.TabIndex = 8;
            this.btn_XoaKhachHang.Text = "Xoá";
            this.btn_XoaKhachHang.UseVisualStyleBackColor = true;
            this.btn_XoaKhachHang.Click += new System.EventHandler(this.btn_XoaKhachHang_Click);
            // 
            // btn_SuaKhachHang
            // 
            this.btn_SuaKhachHang.Location = new System.Drawing.Point(833, 72);
            this.btn_SuaKhachHang.Name = "btn_SuaKhachHang";
            this.btn_SuaKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaKhachHang.TabIndex = 7;
            this.btn_SuaKhachHang.Text = "Sửa";
            this.btn_SuaKhachHang.UseVisualStyleBackColor = true;
            this.btn_SuaKhachHang.Click += new System.EventHandler(this.btn_SuaKhachHang_Click);
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(833, 43);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemKhachHang.TabIndex = 6;
            this.btn_ThemKhachHang.Text = "Thêm";
            this.btn_ThemKhachHang.UseVisualStyleBackColor = true;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Location = new System.Drawing.Point(180, 73);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(168, 22);
            this.txt_HoTenKH.TabIndex = 0;
            // 
            // txt_TiemKiemKH
            // 
            this.txt_TiemKiemKH.Location = new System.Drawing.Point(165, 183);
            this.txt_TiemKiemKH.Name = "txt_TiemKiemKH";
            this.txt_TiemKiemKH.Size = new System.Drawing.Size(315, 22);
            this.txt_TiemKiemKH.TabIndex = 10;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(45, 75);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(100, 22);
            this.txt_MaKH.TabIndex = 0;
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.Location = new System.Drawing.Point(538, 75);
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.Size = new System.Drawing.Size(166, 22);
            this.txt_DiaChiKH.TabIndex = 2;
            // 
            // txt_SDTKH
            // 
            this.txt_SDTKH.Location = new System.Drawing.Point(364, 75);
            this.txt_SDTKH.Name = "txt_SDTKH";
            this.txt_SDTKH.Size = new System.Drawing.Size(156, 22);
            this.txt_SDTKH.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã KH";
            // 
            // grp_DanhSachKH
            // 
            this.grp_DanhSachKH.Controls.Add(this.dgv_DanhSachKH);
            this.grp_DanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_DanhSachKH.Location = new System.Drawing.Point(0, 237);
            this.grp_DanhSachKH.Name = "grp_DanhSachKH";
            this.grp_DanhSachKH.Size = new System.Drawing.Size(1027, 267);
            this.grp_DanhSachKH.TabIndex = 7;
            this.grp_DanhSachKH.TabStop = false;
            this.grp_DanhSachKH.Text = "Danh sách khách hàng";
            // 
            // dgv_DanhSachKH
            // 
            this.dgv_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachKH.Location = new System.Drawing.Point(3, 18);
            this.dgv_DanhSachKH.Name = "dgv_DanhSachKH";
            this.dgv_DanhSachKH.RowHeadersWidth = 51;
            this.dgv_DanhSachKH.RowTemplate.Height = 24;
            this.dgv_DanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachKH.Size = new System.Drawing.Size(1021, 246);
            this.dgv_DanhSachKH.TabIndex = 0;
            this.dgv_DanhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKH_CellClick);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 504);
            this.Controls.Add(this.grp_DanhSachKH);
            this.Controls.Add(this.grp_QuanliKH);
            this.MaximumSize = new System.Drawing.Size(1045, 551);
            this.MinimumSize = new System.Drawing.Size(1045, 551);
            this.Name = "frm_KhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.grp_QuanliKH.ResumeLayout(false);
            this.grp_QuanliKH.PerformLayout();
            this.grp_DanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_QuanliKH;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinhKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_ResetKhachHang;
        private System.Windows.Forms.Button btn_XoaKhachHang;
        private System.Windows.Forms.Button btn_SuaKhachHang;
        private System.Windows.Forms.Button btn_ThemKhachHang;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.TextBox txt_TiemKiemKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_DiaChiKH;
        private System.Windows.Forms.TextBox txt_SDTKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_DanhSachKH;
        private System.Windows.Forms.DataGridView dgv_DanhSachKH;
    }
}