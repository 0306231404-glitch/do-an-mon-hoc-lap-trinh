using doanwf.DAO;
using doanwf.form;
using doanwf.form.quanly;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace doanwf
{
    public partial class frm_Main : Form
    {
        private DataProvider data;
        public string nhanviendangnhap;
        public frm_Main(string tendangnhap)
        {
            InitializeComponent();
            nhanviendangnhap = tendangnhap;
            LoadChucVu();
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {

            frm_QuanLy quanly = new frm_QuanLy();
            this.Hide();
            quanly.Show();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_TaoHoaDon taohoadon = new frm_TaoHoaDon();
            taohoadon.Show();
        }
        private void LoadChucVu()
        {
            data = new DataProvider();

            SqlConnection conn = data.getConn();

            conn.Open();
            string sql = "SELECT chucvu FROM nhanvien WHERE tendangnhap = @tendangnhap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tendangnhap", nhanviendangnhap);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                lblChucVu.Text = result.ToString();
                if (!result.ToString().Equals("admin"))
                {
                    btnQuanLy.Enabled = false;
                }
                else
                {
                    btnQuanLy.Enabled = true;
                }
            }
            else
            {
                lblChucVu.Text = "Không xác định";
            }



        }
        private void btnThoatMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap dangnhaplai = new frm_DangNhap();
            dangnhaplai.Show();

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tss_tennhanvien_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
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
                                tss_tennhanvien.Text = reader["hoten"].ToString();
                                lblChucVu.Text = reader["ChucVu"].ToString();
                                tss_DateTime.Text = reader["timenow"].ToString();


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
            }
        }

        private void palMainPrimary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
