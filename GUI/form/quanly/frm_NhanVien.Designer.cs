namespace doanwf.form.quanly
{
    partial class frm_NhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dsNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_LoadDS = new System.Windows.Forms.Button();
            this.btn_ResetNV = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.txt_HoTenNV = new System.Windows.Forms.TextBox();
            this.txt_TiemKiemNV = new System.Windows.Forms.TextBox();
            this.txt_EmailNV = new System.Windows.Forms.TextBox();
            this.txt_ChucVu = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_MatKhauNV = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoanNV = new System.Windows.Forms.TextBox();
            this.txt_SDTNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dsNhanVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 271);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgv_dsNhanVien
            // 
            this.dgv_dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dsNhanVien.Location = new System.Drawing.Point(3, 18);
            this.dgv_dsNhanVien.Name = "dgv_dsNhanVien";
            this.dgv_dsNhanVien.RowHeadersWidth = 51;
            this.dgv_dsNhanVien.RowTemplate.Height = 24;
            this.dgv_dsNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsNhanVien.Size = new System.Drawing.Size(1021, 250);
            this.dgv_dsNhanVien.TabIndex = 18;
            this.dgv_dsNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsNhanVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Nu);
            this.groupBox1.Controls.Add(this.rad_Nam);
            this.groupBox1.Controls.Add(this.dtp_NgaySinh);
            this.groupBox1.Controls.Add(this.btn_LoadDS);
            this.groupBox1.Controls.Add(this.btn_ResetNV);
            this.groupBox1.Controls.Add(this.btn_XoaNV);
            this.groupBox1.Controls.Add(this.btn_SuaNV);
            this.groupBox1.Controls.Add(this.btn_TimKiemNV);
            this.groupBox1.Controls.Add(this.btn_ThemNV);
            this.groupBox1.Controls.Add(this.txt_HoTenNV);
            this.groupBox1.Controls.Add(this.txt_TiemKiemNV);
            this.groupBox1.Controls.Add(this.txt_EmailNV);
            this.groupBox1.Controls.Add(this.txt_ChucVu);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_MatKhauNV);
            this.groupBox1.Controls.Add(this.txt_TaiKhoanNV);
            this.groupBox1.Controls.Add(this.txt_SDTNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 276);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(584, 140);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 9;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Location = new System.Drawing.Point(509, 139);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 8;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(613, 71);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(186, 22);
            this.dtp_NgaySinh.TabIndex = 4;
            // 
            // btn_LoadDS
            // 
            this.btn_LoadDS.Location = new System.Drawing.Point(588, 180);
            this.btn_LoadDS.Name = "btn_LoadDS";
            this.btn_LoadDS.Size = new System.Drawing.Size(99, 28);
            this.btn_LoadDS.TabIndex = 16;
            this.btn_LoadDS.Text = "Load Lại DS";
            this.btn_LoadDS.UseVisualStyleBackColor = true;
            this.btn_LoadDS.Click += new System.EventHandler(this.btn_LoadDS_Click);
            // 
            // btn_ResetNV
            // 
            this.btn_ResetNV.Location = new System.Drawing.Point(832, 158);
            this.btn_ResetNV.Name = "btn_ResetNV";
            this.btn_ResetNV.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetNV.TabIndex = 13;
            this.btn_ResetNV.Text = "Reset";
            this.btn_ResetNV.UseVisualStyleBackColor = true;
            this.btn_ResetNV.Click += new System.EventHandler(this.btn_ResetNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Location = new System.Drawing.Point(832, 129);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaNV.TabIndex = 12;
            this.btn_XoaNV.Text = "Xoá";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Location = new System.Drawing.Point(832, 100);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaNV.TabIndex = 11;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseVisualStyleBackColor = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.Location = new System.Drawing.Point(476, 180);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(97, 28);
            this.btn_TimKiemNV.TabIndex = 15;
            this.btn_TimKiemNV.Text = "Tìm kiếm";
            this.btn_TimKiemNV.UseVisualStyleBackColor = true;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(832, 71);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNV.TabIndex = 10;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // txt_HoTenNV
            // 
            this.txt_HoTenNV.Location = new System.Drawing.Point(45, 75);
            this.txt_HoTenNV.Name = "txt_HoTenNV";
            this.txt_HoTenNV.Size = new System.Drawing.Size(130, 22);
            this.txt_HoTenNV.TabIndex = 0;
            // 
            // txt_TiemKiemNV
            // 
            this.txt_TiemKiemNV.Location = new System.Drawing.Point(230, 180);
            this.txt_TiemKiemNV.Name = "txt_TiemKiemNV";
            this.txt_TiemKiemNV.Size = new System.Drawing.Size(234, 22);
            this.txt_TiemKiemNV.TabIndex = 14;
            // 
            // txt_EmailNV
            // 
            this.txt_EmailNV.Location = new System.Drawing.Point(341, 71);
            this.txt_EmailNV.Name = "txt_EmailNV";
            this.txt_EmailNV.Size = new System.Drawing.Size(130, 22);
            this.txt_EmailNV.TabIndex = 2;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Location = new System.Drawing.Point(45, 138);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(129, 22);
            this.txt_ChucVu.TabIndex = 5;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(485, 71);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(118, 22);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_MatKhauNV
            // 
            this.txt_MatKhauNV.Location = new System.Drawing.Point(355, 135);
            this.txt_MatKhauNV.Name = "txt_MatKhauNV";
            this.txt_MatKhauNV.Size = new System.Drawing.Size(118, 22);
            this.txt_MatKhauNV.TabIndex = 7;
            // 
            // txt_TaiKhoanNV
            // 
            this.txt_TaiKhoanNV.Location = new System.Drawing.Point(196, 135);
            this.txt_TaiKhoanNV.Name = "txt_TaiKhoanNV";
            this.txt_TaiKhoanNV.Size = new System.Drawing.Size(138, 22);
            this.txt_TaiKhoanNV.TabIndex = 6;
            // 
            // txt_SDTNV
            // 
            this.txt_SDTNV.Location = new System.Drawing.Point(190, 73);
            this.txt_SDTNV.Name = "txt_SDTNV";
            this.txt_SDTNV.Size = new System.Drawing.Size(133, 22);
            this.txt_SDTNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tìm kiếm theo tên đăng nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1045, 549);
            this.MinimumSize = new System.Drawing.Size(1045, 549);
            this.Name = "frm_NhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ResetNV;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.TextBox txt_HoTenNV;
        private System.Windows.Forms.TextBox txt_TiemKiemNV;
        private System.Windows.Forms.TextBox txt_EmailNV;
        private System.Windows.Forms.TextBox txt_ChucVu;
        private System.Windows.Forms.TextBox txt_MatKhauNV;
        private System.Windows.Forms.TextBox txt_TaiKhoanNV;
        private System.Windows.Forms.TextBox txt_SDTNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_dsNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_TimKiemNV;
        private System.Windows.Forms.Button btn_LoadDS;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.Label label10;
    }
}