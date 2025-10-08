using doanwf.BUS;
using doanwf.DTO;
using System;
using System.Windows.Forms;
namespace doanwf.form.quanly
{
    public partial class frm_NhanVien : Form
    {

        nhanvienBUS nvBUS = new nhanvienBUS();

        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {

            dgv_dsNhanVien.DataSource = nvBUS.LayDSSV();
        }

        private void btn_LoadDS_Click(object sender, EventArgs e)
        {
            dgv_dsNhanVien.DataSource = nvBUS.LayDSSV();
        }
        //bắt buộc có email vì để liên lạc.
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoanNV.Text.Length > 30 || txt_TaiKhoanNV.Text.Length < 1)
            {
                MessageBox.Show("Tài khoản đăng nhập phải lớn 1 và nhỏ hơn 30 kí tự");
                txt_TaiKhoanNV.Focus();
                return;
            }
            else if (txt_MatKhauNV.Text.Length > 32 || txt_MatKhauNV.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải lớn 5 và nhỏ hơn 32 kí tự");
                txt_TaiKhoanNV.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_MatKhauNV.Text)
                || string.IsNullOrEmpty(txt_TaiKhoanNV.Text)
                || string.IsNullOrEmpty(txt_HoTenNV.Text)
                || string.IsNullOrEmpty(txt_ChucVu.Text)
                || string.IsNullOrEmpty(txt_EmailNV.Text))
            {
                txt_MatKhauNV.Focus();
                MessageBox.Show("Không được để trống họ tên, tài khoản đăng nhập, mật khẩu, chức vụ và email");
                return;
            }
            //kiểm tra nếu có nhập thì phải lớn hơn 10 kí tự || kiểm tra sự tồn tại của số điện thoại.
            if (txt_SDTNV.Text.Length > 0 && txt_SDTNV.Text.Length != 10 || nvBUS.KiemTraSoDienThoai(txt_SDTNV.Text))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ");
                return;
            }
            nhanvienDTO nvThem = new nhanvienDTO();
            nvThem.tendangnhap = txt_TaiKhoanNV.Text;
            nvThem.matkhau = txt_MatKhauNV.Text;
            nvThem.hoten = txt_HoTenNV.Text;
            nvThem.email = txt_EmailNV.Text;
            nvThem.diachi = txt_DiaChi.Text;
            nvThem.dienthoai = txt_SDTNV.Text;
            nvThem.ngaysinh = DateTime.Parse(dtp_NgaySinh.Value.ToString("yyyy-MM-dd"));
            nvThem.gioitinh = rad_Nam.Checked ? true : false;
            nvThem.chucvu = txt_ChucVu.Text;
            if (nvBUS.TimKiemTDNTonTai(txt_TaiKhoanNV.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            if (nvBUS.ThemNhanVien(nvThem))
            {
                MessageBox.Show("Thêm thành công!");
                dgv_dsNhanVien.DataSource = nvBUS.LayDSSV();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }
        //Không cho cập nhật lại tên đăng nhập.
        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MatKhauNV.Text) || string.IsNullOrEmpty(txt_HoTenNV.Text))
            {
                txt_MatKhauNV.Focus();
                MessageBox.Show("Không được để trống họ tên, tài khoản đăng nhập và mật khẩu");
                return;
            }
            else if (txt_MatKhauNV.Text.Length > 32 || txt_MatKhauNV.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải lớn 5 và nhỏ hơn 32 kí tự");
                txt_TaiKhoanNV.Focus();
                return;
            }
            nhanvienDTO suaNv = new nhanvienDTO();
            suaNv.tendangnhap = txt_TaiKhoanNV.Text;
            suaNv.matkhau = txt_MatKhauNV.Text;
            suaNv.hoten = txt_HoTenNV.Text;
            suaNv.email = txt_EmailNV.Text;
            suaNv.diachi = txt_DiaChi.Text;
            suaNv.dienthoai = txt_SDTNV.Text;
            suaNv.ngaysinh = DateTime.Parse(dtp_NgaySinh.Value.ToString("yyyy-MM-dd"));
            suaNv.gioitinh = rad_Nam.Checked ? true : false;
            suaNv.chucvu = txt_ChucVu.Text;
            if (nvBUS.CapNhatNhanVien(suaNv))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgv_dsNhanVien.DataSource = nvBUS.LayDSSV();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (nvBUS.XoaNhanVien(txt_TaiKhoanNV.Text))
            {
                MessageBox.Show("Xoá thành công!");
                dgv_dsNhanVien.DataSource = nvBUS.LayDSSV();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btn_ResetNV_Click(object sender, EventArgs e)
        {
            txt_TaiKhoanNV.Text = string.Empty;
            txt_MatKhauNV.Text = string.Empty;
            txt_HoTenNV.Text = string.Empty;
            txt_EmailNV.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_SDTNV.Text = string.Empty;
            dtp_NgaySinh.Text = DateTime.Now.ToString();
            rad_Nam.Checked = true;
            txt_ChucVu.Text = string.Empty;
            txt_TiemKiemNV.Text = string.Empty;
        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TiemKiemNV.Text))
            {
                MessageBox.Show("Hãy nhập tên nhân viên muốn tìm kiếm");
            }
            dgv_dsNhanVien.DataSource = nvBUS.TimKiemNhanVien(txt_TiemKiemNV.Text);
        }

        private void dgv_dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dsNhanVien.Rows[e.RowIndex];
                txt_TaiKhoanNV.Text = row.Cells[0].Value.ToString();
                txt_MatKhauNV.Text = row.Cells[1].Value.ToString();
                txt_HoTenNV.Text = row.Cells[2].Value.ToString();
                txt_EmailNV.Text = row.Cells[3].Value.ToString();
                txt_DiaChi.Text = row.Cells[4].Value.ToString();
                txt_SDTNV.Text = row.Cells[5].Value.ToString();
                dtp_NgaySinh.Text = row.Cells[6].Value.ToString();
                if (row.Cells[7].Value.ToString() == "True")
                {
                    rad_Nam.Checked = true;
                }
                else
                {
                    rad_Nu.Checked = true;
                }
                txt_ChucVu.Text = row.Cells[8].Value.ToString();
            }

        }


    }
}
