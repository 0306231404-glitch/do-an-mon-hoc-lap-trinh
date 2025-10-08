using doanwf.DAO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace doanwf
{
    public partial class frm_DangNhap : Form
    {
        private DataProvider db;
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_HienMatKhau.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {



            if (txt_TenDangNhap.Text.Length < 3)//min:  trên 3 ký tự
            {
                MessageBox.Show("Vui lòng nhập 3 ký tự trở lên.",
                "Cảnh Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;

            }
            else if (txt_TenDangNhap.Text.Length > 20)//max:dưới 32 ký tự
            {
                MessageBox.Show("Vui lòng nhập ít hơn 20 ký tự",
                "Cảnh Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txt_TenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập.",
                    "Cảnh Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            db = new DataProvider();
            SqlConnection conn = db.getConn();
            db.openConn();
            try
            {

                string sql = "SELECT * FROM nhanvien WHERE tendangnhap = @username AND matkhau = @password";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txt_TenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@password", txt_MatKhau.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            this.Hide();
                            frm_Main main = new frm_Main(txt_TenDangNhap.Text);
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại. Tên đăng nhập hoặc mật khẩu không đúng.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            db.closeConn();




        }



        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
