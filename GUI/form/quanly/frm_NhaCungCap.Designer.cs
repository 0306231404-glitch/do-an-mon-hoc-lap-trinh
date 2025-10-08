namespace doanwf.form.quanly
{
    partial class frm_NhaCungCap
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
            this.grp_QuanLiNhaCungCap = new System.Windows.Forms.GroupBox();
            this.btn_ResetNCC = new System.Windows.Forms.Button();
            this.btn_XoaNCC = new System.Windows.Forms.Button();
            this.btn_SuaNCC = new System.Windows.Forms.Button();
            this.btn_ThemNCC = new System.Windows.Forms.Button();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.txt_WebsiteNCC = new System.Windows.Forms.TextBox();
            this.txt_DiaChiNCC = new System.Windows.Forms.TextBox();
            this.txt_EmailNCC = new System.Windows.Forms.TextBox();
            this.txt_SDTNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_DSNhaCungCap = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachNCC = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_QuanLiNhaCungCap.SuspendLayout();
            this.grp_DSNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_QuanLiNhaCungCap
            // 
            this.grp_QuanLiNhaCungCap.Controls.Add(this.btn_ResetNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.btn_XoaNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.btn_SuaNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.btn_ThemNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_TenNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_MaNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_WebsiteNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_DiaChiNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_EmailNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.txt_SDTNCC);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label4);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label2);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label7);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label5);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label3);
            this.grp_QuanLiNhaCungCap.Controls.Add(this.label1);
            this.grp_QuanLiNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_QuanLiNhaCungCap.ForeColor = System.Drawing.Color.Black;
            this.grp_QuanLiNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.grp_QuanLiNhaCungCap.Name = "grp_QuanLiNhaCungCap";
            this.grp_QuanLiNhaCungCap.Size = new System.Drawing.Size(1027, 175);
            this.grp_QuanLiNhaCungCap.TabIndex = 6;
            this.grp_QuanLiNhaCungCap.TabStop = false;
            this.grp_QuanLiNhaCungCap.Text = "Quản lí nhà cung cấp";
            // 
            // btn_ResetNCC
            // 
            this.btn_ResetNCC.Location = new System.Drawing.Point(798, 130);
            this.btn_ResetNCC.Name = "btn_ResetNCC";
            this.btn_ResetNCC.Size = new System.Drawing.Size(75, 23);
            this.btn_ResetNCC.TabIndex = 8;
            this.btn_ResetNCC.Text = "Reset";
            this.btn_ResetNCC.UseVisualStyleBackColor = true;
            this.btn_ResetNCC.Click += new System.EventHandler(this.btn_ResetNCC_Click);
            // 
            // btn_XoaNCC
            // 
            this.btn_XoaNCC.Location = new System.Drawing.Point(798, 101);
            this.btn_XoaNCC.Name = "btn_XoaNCC";
            this.btn_XoaNCC.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaNCC.TabIndex = 7;
            this.btn_XoaNCC.Text = "Xoá";
            this.btn_XoaNCC.UseVisualStyleBackColor = true;
            this.btn_XoaNCC.Click += new System.EventHandler(this.btn_XoaNCC_Click);
            // 
            // btn_SuaNCC
            // 
            this.btn_SuaNCC.Location = new System.Drawing.Point(798, 72);
            this.btn_SuaNCC.Name = "btn_SuaNCC";
            this.btn_SuaNCC.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaNCC.TabIndex = 6;
            this.btn_SuaNCC.Text = "Sửa";
            this.btn_SuaNCC.UseVisualStyleBackColor = true;
            this.btn_SuaNCC.Click += new System.EventHandler(this.btn_SuaNCC_Click);
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.Location = new System.Drawing.Point(798, 43);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNCC.TabIndex = 5;
            this.btn_ThemNCC.Text = "Thêm";
            this.btn_ThemNCC.UseVisualStyleBackColor = true;
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(163, 74);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(166, 22);
            this.txt_TenNCC.TabIndex = 0;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(45, 75);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(100, 22);
            this.txt_MaNCC.TabIndex = 9;
            // 
            // txt_WebsiteNCC
            // 
            this.txt_WebsiteNCC.Location = new System.Drawing.Point(364, 136);
            this.txt_WebsiteNCC.Name = "txt_WebsiteNCC";
            this.txt_WebsiteNCC.Size = new System.Drawing.Size(220, 22);
            this.txt_WebsiteNCC.TabIndex = 4;
            // 
            // txt_DiaChiNCC
            // 
            this.txt_DiaChiNCC.Location = new System.Drawing.Point(45, 136);
            this.txt_DiaChiNCC.Name = "txt_DiaChiNCC";
            this.txt_DiaChiNCC.Size = new System.Drawing.Size(284, 22);
            this.txt_DiaChiNCC.TabIndex = 3;
            // 
            // txt_EmailNCC
            // 
            this.txt_EmailNCC.Location = new System.Drawing.Point(538, 75);
            this.txt_EmailNCC.Name = "txt_EmailNCC";
            this.txt_EmailNCC.Size = new System.Drawing.Size(163, 22);
            this.txt_EmailNCC.TabIndex = 2;
            // 
            // txt_SDTNCC
            // 
            this.txt_SDTNCC.Location = new System.Drawing.Point(364, 75);
            this.txt_SDTNCC.Name = "txt_SDTNCC";
            this.txt_SDTNCC.Size = new System.Drawing.Size(150, 22);
            this.txt_SDTNCC.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
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
            this.label3.Location = new System.Drawing.Point(160, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NCC";
            // 
            // grp_DSNhaCungCap
            // 
            this.grp_DSNhaCungCap.Controls.Add(this.dgv_DanhSachNCC);
            this.grp_DSNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_DSNhaCungCap.Location = new System.Drawing.Point(0, 175);
            this.grp_DSNhaCungCap.Name = "grp_DSNhaCungCap";
            this.grp_DSNhaCungCap.Size = new System.Drawing.Size(1027, 329);
            this.grp_DSNhaCungCap.TabIndex = 7;
            this.grp_DSNhaCungCap.TabStop = false;
            this.grp_DSNhaCungCap.Text = "Danh sách nhà cung cấp";
            // 
            // dgv_DanhSachNCC
            // 
            this.dgv_DanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.ten,
            this.website,
            this.email,
            this.dienthoai,
            this.diachi});
            this.dgv_DanhSachNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachNCC.Location = new System.Drawing.Point(3, 18);
            this.dgv_DanhSachNCC.Name = "dgv_DanhSachNCC";
            this.dgv_DanhSachNCC.RowHeadersWidth = 51;
            this.dgv_DanhSachNCC.RowTemplate.Height = 24;
            this.dgv_DanhSachNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachNCC.Size = new System.Drawing.Size(1021, 308);
            this.dgv_DanhSachNCC.TabIndex = 0;
            this.dgv_DanhSachNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNCC_CellClick);
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.MinimumWidth = 6;
            this.mancc.Name = "mancc";
            this.mancc.Width = 125;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên Nhà Cung Cấp";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 200;
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "Website";
            this.website.MinimumWidth = 6;
            this.website.Name = "website";
            this.website.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện Thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Width = 150;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 150;
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 504);
            this.Controls.Add(this.grp_DSNhaCungCap);
            this.Controls.Add(this.grp_QuanLiNhaCungCap);
            this.MaximumSize = new System.Drawing.Size(1045, 551);
            this.MinimumSize = new System.Drawing.Size(1045, 551);
            this.Name = "frm_NhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frm_NhaCungCap_Load);
            this.grp_QuanLiNhaCungCap.ResumeLayout(false);
            this.grp_QuanLiNhaCungCap.PerformLayout();
            this.grp_DSNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_QuanLiNhaCungCap;
        private System.Windows.Forms.Button btn_ResetNCC;
        private System.Windows.Forms.Button btn_XoaNCC;
        private System.Windows.Forms.Button btn_SuaNCC;
        private System.Windows.Forms.Button btn_ThemNCC;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.TextBox txt_WebsiteNCC;
        private System.Windows.Forms.TextBox txt_DiaChiNCC;
        private System.Windows.Forms.TextBox txt_EmailNCC;
        private System.Windows.Forms.TextBox txt_SDTNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_DSNhaCungCap;
        private System.Windows.Forms.DataGridView dgv_DanhSachNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}