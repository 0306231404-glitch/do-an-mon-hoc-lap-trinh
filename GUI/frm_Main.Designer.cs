namespace doanwf
{
    partial class frm_Main
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
            this.palBar = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoatMain = new System.Windows.Forms.Button();
            this.palMainPrimary = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_tennhanvien = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.palBar.SuspendLayout();
            this.palMainPrimary.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // palBar
            // 
            this.palBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palBar.Controls.Add(this.lblChucVu);
            this.palBar.Controls.Add(this.label1);
            this.palBar.Controls.Add(this.btnThoatMain);
            this.palBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.palBar.Location = new System.Drawing.Point(0, 0);
            this.palBar.Name = "palBar";
            this.palBar.Size = new System.Drawing.Size(1118, 62);
            this.palBar.TabIndex = 0;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(348, 32);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(0, 16);
            this.lblChucVu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức Vụ:";
            // 
            // btnThoatMain
            // 
            this.btnThoatMain.Location = new System.Drawing.Point(1174, 11);
            this.btnThoatMain.Name = "btnThoatMain";
            this.btnThoatMain.Size = new System.Drawing.Size(75, 37);
            this.btnThoatMain.TabIndex = 0;
            this.btnThoatMain.Text = "Thoát";
            this.btnThoatMain.UseVisualStyleBackColor = true;
            this.btnThoatMain.Click += new System.EventHandler(this.btnThoatMain_Click);
            // 
            // palMainPrimary
            // 
            this.palMainPrimary.Controls.Add(this.statusStrip1);
            this.palMainPrimary.Controls.Add(this.label2);
            this.palMainPrimary.Controls.Add(this.btnTaoHoaDon);
            this.palMainPrimary.Controls.Add(this.btnQuanLy);
            this.palMainPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMainPrimary.Location = new System.Drawing.Point(0, 62);
            this.palMainPrimary.Name = "palMainPrimary";
            this.palMainPrimary.Size = new System.Drawing.Size(1118, 669);
            this.palMainPrimary.TabIndex = 1;
            this.palMainPrimary.Paint += new System.Windows.Forms.PaintEventHandler(this.palMainPrimary_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_tennhanvien,
            this.toolStripStatusLabel3,
            this.tss_DateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1118, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss_tennhanvien
            // 
            this.tss_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tss_tennhanvien.Name = "tss_tennhanvien";
            this.tss_tennhanvien.Size = new System.Drawing.Size(48, 20);
            this.tss_tennhanvien.Text = "name";
            this.tss_tennhanvien.Click += new System.EventHandler(this.tss_tennhanvien_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(1016, 20);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // tss_DateTime
            // 
            this.tss_DateTime.Name = "tss_DateTime";
            this.tss_DateTime.Size = new System.Drawing.Size(39, 20);
            this.tss_DateTime.Text = "time";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quản Lý Bán Hàng";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHoaDon.Location = new System.Drawing.Point(693, 261);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(188, 147);
            this.btnTaoHoaDon.TabIndex = 1;
            this.btnTaoHoaDon.Text = "Tạo Hoá Đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLy.Location = new System.Drawing.Point(237, 261);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(172, 147);
            this.btnQuanLy.TabIndex = 2;
            this.btnQuanLy.Text = "Quản Lý";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.palMainPrimary);
            this.Controls.Add(this.palBar);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.palBar.ResumeLayout(false);
            this.palBar.PerformLayout();
            this.palMainPrimary.ResumeLayout(false);
            this.palMainPrimary.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palBar;
        private System.Windows.Forms.Button btnThoatMain;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel palMainPrimary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_tennhanvien;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tss_DateTime;
    }
}