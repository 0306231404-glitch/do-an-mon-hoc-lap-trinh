namespace doanwf
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.pnl_DangNhap = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_DangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DangNhap
            // 
            this.pnl_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_DangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_DangNhap.Controls.Add(this.btn_Thoat);
            this.pnl_DangNhap.Controls.Add(this.chk_HienMatKhau);
            this.pnl_DangNhap.Controls.Add(this.btn_DangNhap);
            this.pnl_DangNhap.Controls.Add(this.label2);
            this.pnl_DangNhap.Controls.Add(this.txt_MatKhau);
            this.pnl_DangNhap.Controls.Add(this.txt_TenDangNhap);
            this.pnl_DangNhap.Controls.Add(this.label3);
            this.pnl_DangNhap.Controls.Add(this.label1);
            this.pnl_DangNhap.Location = new System.Drawing.Point(-3, 0);
            this.pnl_DangNhap.Name = "pnl_DangNhap";
            this.pnl_DangNhap.Size = new System.Drawing.Size(557, 326);
            this.pnl_DangNhap.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(317, 201);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(150, 38);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Location = new System.Drawing.Point(157, 148);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(140, 20);
            this.chk_HienMatKhau.TabIndex = 3;
            this.chk_HienMatKhau.Text = "Hiện Thị Mật Khẩu.";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienMatKhau_CheckedChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(101, 201);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(150, 38);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(157, 111);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(310, 22);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(157, 70);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(310, 22);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhâp:";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(546, 318);
            this.Controls.Add(this.pnl_DangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.pnl_DangNhap.ResumeLayout(false);
            this.pnl_DangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DangNhap;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

