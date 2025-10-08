
using doanwf.BUS;
using doanwf.DTO;
using System;
using System.Windows.Forms;

namespace doanwf.form.quanly
{
    public partial class frm_KhachHang : Form
    {
        khachhangBUS khbus = new khachhangBUS();
        private string luuMaKhMax;
        private string luuMaTruocKhiSua;


        public frm_KhachHang()
        {
            InitializeComponent();
        }


        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTenKH.Text))
            {
                MessageBox.Show("Không được để trống họ tên");
                return;
            }
            else if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Mã Khách hàng không thể để trống");
                txt_MaKH.Text = khbus.MaKHMax();
                return;
            }
            //kiểm tra nếu có nhập thì phải lớn hơn 10 kí tự || kiểm tra sự tồn tại của kí tự trong số điện thoại.
            if (txt_SDTKH.Text.Length > 0 && txt_SDTKH.Text.Length != 10 || khbus.KiemTraSoDienThoai(txt_SDTKH.Text))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ");
                return;
            }

            khachhangDTO themkh = new khachhangDTO();
            themkh.makh = int.Parse(txt_MaKH.Text);
            themkh.hoten = txt_HoTenKH.Text;
            themkh.diachi = txt_DiaChiKH.Text;
            themkh.dienthoai = txt_SDTKH.Text;
            themkh.ngaysinh = DateTime.Parse(dtp_NgaySinhKH.Value.ToString("yyyy-MM-dd"));
            themkh.gioitinh = rad_Nam.Checked ? true : false;
            if (khbus.KiemTraKhTonTai(int.Parse(txt_MaKH.Text)))
            {
                MessageBox.Show("Không nên sửa lại mã khách hàng");
                return;
            }
            if (khbus.ThemMoiKH(themkh))
            {
                MessageBox.Show("Thêm mới khách hàng thành công!");
                dgv_DanhSachKH.DataSource = khbus.LayDSKhachHang();
                luuMaKhMax = khbus.MaKHMax();
                txt_MaKH.Text = khbus.MaKHMax();

            }
            else
            {
                MessageBox.Show("Thêm mới khách hàng thất bại!");
            }
        }


        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            dgv_DanhSachKH.DataSource = khbus.LayDSKhachHang();
            txt_MaKH.Text = khbus.MaKHMax();
            luuMaKhMax = khbus.MaKHMax();

        }

        private void btn_SuaKhachHang_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_HoTenKH.Text))
            {
                MessageBox.Show("Không được để trống họ tên");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Mã Khách hàng không thể để trống");
                txt_MaKH.Text = khbus.MaKHMax();
                return;
            }
            if (khbus.KiemTraKhTonTai(int.Parse(txt_MaKH.Text)))
            {
                MessageBox.Show("Không nên sửa lại mã khách hàng");
                txt_MaKH.Text = luuMaTruocKhiSua;
                return;
            }
            khachhangDTO themkh = new khachhangDTO();
            themkh.makh = int.Parse(txt_MaKH.Text);
            themkh.hoten = txt_HoTenKH.Text;
            themkh.diachi = txt_DiaChiKH.Text;
            themkh.dienthoai = txt_SDTKH.Text;
            themkh.ngaysinh = DateTime.Parse(dtp_NgaySinhKH.Value.ToString("yyyy-MM-dd"));
            themkh.gioitinh = rad_Nam.Checked ? true : false;
            if (khbus.CapNhatKH(themkh))
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
                dgv_DanhSachKH.DataSource = khbus.LayDSKhachHang();

            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại!");
            }
        }

        private void btn_XoaKhachHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Phải nhập mã khách hàng để xoá!");
                return;
            }

            if (khbus.XoaKH(int.Parse(txt_MaKH.Text)))
            {
                MessageBox.Show("Xoá thành công!");
                dgv_DanhSachKH.DataSource = khbus.LayDSKhachHang();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btn_ResetKhachHang_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = luuMaKhMax;
            txt_HoTenKH.Text = string.Empty;
            txt_DiaChiKH.Text = string.Empty;
            txt_SDTKH.Text = string.Empty;
            rad_Nam.Checked = true;
            dtp_NgaySinhKH.Text = DateTime.Now.ToString();
            txt_TiemKiemKH.Text = string.Empty;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TiemKiemKH.Text))
            {
                MessageBox.Show("Hãy nhập mã khách hàng tìm kiếm");
                return;
            }
            dgv_DanhSachKH.DataSource = khbus.TimKiemKH(txt_TiemKiemKH.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            dgv_DanhSachKH.DataSource = khbus.LayDSKhachHang();
        }

        private void dgv_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachKH.Rows[e.RowIndex];
                txt_MaKH.Text = row.Cells[0].Value.ToString();
                txt_HoTenKH.Text = row.Cells[1].Value.ToString();
                txt_DiaChiKH.Text = row.Cells[2].Value.ToString();
                txt_SDTKH.Text = row.Cells[3].Value.ToString();
                dtp_NgaySinhKH.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "True")
                {
                    rad_Nam.Checked = true;
                }
                else
                {
                    rad_Nu.Checked = true;
                }
                luuMaTruocKhiSua = txt_MaKH.Text;
            }
        }
    }
}

