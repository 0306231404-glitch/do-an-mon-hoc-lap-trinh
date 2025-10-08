namespace doanwf.form.quanly
{
    partial class frm_ThongKe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnXuatALLExel = new System.Windows.Forms.Button();
            this.btnXemChiTietDonHang = new System.Windows.Forms.Button();
            this.txtTiemKiemTK = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1021, 251);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HĐ";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày mua";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã NV";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng hoá đơn (VNĐ)";
            this.columnHeader6.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefesh);
            this.groupBox1.Controls.Add(this.btnXuatALLExel);
            this.groupBox1.Controls.Add(this.btnXemChiTietDonHang);
            this.groupBox1.Controls.Add(this.txtTiemKiemTK);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các hoá đơn tại cửa hàng";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(701, 275);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(83, 30);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            // 
            // btnXuatALLExel
            // 
            this.btnXuatALLExel.Location = new System.Drawing.Point(562, 275);
            this.btnXuatALLExel.Name = "btnXuatALLExel";
            this.btnXuatALLExel.Size = new System.Drawing.Size(133, 30);
            this.btnXuatALLExel.TabIndex = 2;
            this.btnXuatALLExel.Text = "Xuất All Ra Excel";
            this.btnXuatALLExel.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTietDonHang
            // 
            this.btnXemChiTietDonHang.Location = new System.Drawing.Point(388, 275);
            this.btnXemChiTietDonHang.Name = "btnXemChiTietDonHang";
            this.btnXemChiTietDonHang.Size = new System.Drawing.Size(148, 30);
            this.btnXemChiTietDonHang.TabIndex = 2;
            this.btnXemChiTietDonHang.Text = "Xem chi tiết đơn hàng";
            this.btnXemChiTietDonHang.UseVisualStyleBackColor = true;
            // 
            // txtTiemKiemTK
            // 
            this.txtTiemKiemTK.Location = new System.Drawing.Point(0, 275);
            this.txtTiemKiemTK.Multiline = true;
            this.txtTiemKiemTK.Name = "txtTiemKiemTK";
            this.txtTiemKiemTK.Size = new System.Drawing.Size(371, 30);
            this.txtTiemKiemTK.TabIndex = 1;
            this.txtTiemKiemTK.Text = "Tiềm kiếm";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 504);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1045, 551);
            this.MinimumSize = new System.Drawing.Size(1045, 551);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnXuatALLExel;
        private System.Windows.Forms.Button btnXemChiTietDonHang;
        private System.Windows.Forms.TextBox txtTiemKiemTK;
    }
}