using doanwf.DAO;
using System;
using System.Windows.Forms;

namespace doanwf.form.quanly
{

    public partial class frm_QuanLy : Form
    {
        private DataProvider data;
        public string nhanviendangnhap;
        private Button currentButton;
        private Form activeForm;
        public frm_QuanLy()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    currentButton = (Button)btnSender;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_QuanLy.Controls.Add(childForm);
            this.pnl_QuanLy.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_SanPham(), sender);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_KhachHang(), sender);

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_NhaCungCap(), sender);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_NhanVien(), sender);

        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_KhoHang(), sender);

        }
        private void btn_LoaiSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.quanly.frm_ThongKe(), sender);

        }
        private void btnDanXuatQuanLyBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap dangnhaplai = new frm_DangNhap();
            dangnhaplai.Show();

        }

        private void btnSangTaoHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TaoHoaDon taohoadon = new frm_TaoHoaDon();
            taohoadon.Show();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            /* try
             {
                 data = new DataProvider();
                 using (SqlConnection conn = data.getConn())
                 {
                     conn.Open();
                     string sql = "SELECT *,FORMAT( GETDATE(),'dd/MM/yyyy') 'timenow' FROM nhanvien WHERE tendangnhap = @tendangnhap";
                     using (SqlCommand sqlCommand = new SqlCommand(sql, conn))
                     {
                         sqlCommand.Parameters.AddWithValue("@tendangnhap", nhanviendangnhap);

                         using (SqlDataReader reader = sqlCommand.ExecuteReader())
                         {
                             if (reader.Read())
                             {
                                 tss_Name.Text=reader["hoten"].ToString();
                                 tss_Time.Text=reader["timenow"].ToString();


                             }
                             else
                             {
                                 MessageBox.Show("Không tìm thấy nhân viên!");
                             }
                         }
                     }
                 }


             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/

        }


    }
}
