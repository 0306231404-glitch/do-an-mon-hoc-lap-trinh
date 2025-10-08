using doanwf.BUS;
using doanwf.DTO;
using System;
using System.Windows.Forms;

namespace doanwf.form.quanly
{
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }
        nhacungcapBUS nccbus = new nhacungcapBUS();
        private string luuMaNCCMax;
        private string luuMaNCCTruocKhiSua;

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenNCC.Text))
            {
                MessageBox.Show("Hãy nhập tên nhà cung cấp");
                return;
            }
            if (string.IsNullOrEmpty(txt_DiaChiNCC.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ nhà cung cấp");
                return;
            }
            if (string.IsNullOrEmpty(txt_EmailNCC.Text))
            {
                MessageBox.Show("Hãy nhập email nhà cung cấp");
                return;
            }
            if (txt_SDTNCC.Text.Length > 0 && txt_SDTNCC.Text.Length != 10 || nccbus.KiemTraSoDienThoai(txt_SDTNCC.Text))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ");
                return;
            }
            nhacungcapDTO themncc = new nhacungcapDTO();
            themncc.mancc = int.Parse(txt_MaNCC.Text);
            themncc.ten = txt_TenNCC.Text;
            themncc.website = txt_WebsiteNCC.Text;
            themncc.email = txt_EmailNCC.Text;
            themncc.dienthoai = txt_SDTNCC.Text;
            themncc.diachi = txt_DiaChiNCC.Text;

            if (nccbus.ThemMoiNCC(themncc))
            {
                MessageBox.Show("Thêm mới nhà cung cấp thành công!");
                dgv_DanhSachNCC.DataSource = nccbus.LayDSNCC();
                txt_MaNCC.Text = nccbus.MaNCCMax();
                luuMaNCCMax = nccbus.MaNCCMax();
            }
            else
            {
                MessageBox.Show("Thêm mới nhà cung cấp thất bại!");
            }
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenNCC.Text))
            {
                MessageBox.Show("Hãy nhập tên nhà cung cấp");
                return;
            }
            if (string.IsNullOrEmpty(txt_DiaChiNCC.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ nhà cung cấp");
                return;
            }
            if (string.IsNullOrEmpty(txt_EmailNCC.Text))
            {
                MessageBox.Show("Hãy nhập email nhà cung cấp");
                return;
            }
            if (txt_SDTNCC.Text.Length > 0 && txt_SDTNCC.Text.Length != 10 || nccbus.KiemTraSoDienThoai(txt_SDTNCC.Text))
            {
                MessageBox.Show("Số điện thoại của bạn không hợp lệ");
                return;
            }
            if (nccbus.KiemTraNCCTonTai(int.Parse(txt_MaNCC.Text)))
            {
                MessageBox.Show("Không nên sửa lại mã khách hàng");
                txt_MaNCC.Text = luuMaNCCTruocKhiSua;
                return;
            }
            nhacungcapDTO suancc = new nhacungcapDTO();
            suancc.mancc = int.Parse(txt_MaNCC.Text);
            suancc.ten = txt_TenNCC.Text;
            suancc.website = txt_WebsiteNCC.Text;
            suancc.email = txt_EmailNCC.Text;
            suancc.dienthoai = txt_SDTNCC.Text;
            suancc.diachi = txt_DiaChiNCC.Text;
            if (nccbus.CapNhatNCC(suancc))
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                dgv_DanhSachNCC.DataSource = nccbus.LayDSNCC();

            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại!");
            }
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text))
            {
                MessageBox.Show("Phải nhập mã khách hàng để xoá!");
                return;
            }

            if (nccbus.XoaNCC(int.Parse(txt_MaNCC.Text)))
            {
                MessageBox.Show("Xoá thành công!");
                dgv_DanhSachNCC.DataSource = nccbus.LayDSNCC();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!");
            }
        }

        private void btn_ResetNCC_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Text = luuMaNCCMax;
            txt_TenNCC.Text = string.Empty;
            txt_WebsiteNCC.Text = string.Empty;
            txt_EmailNCC.Text = string.Empty;
            txt_SDTNCC.Text = string.Empty;
            txt_DiaChiNCC.Text = string.Empty;
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgv_DanhSachNCC.DataSource = nccbus.LayDSNCC();

            txt_MaNCC.Text = nccbus.MaNCCMax();
            luuMaNCCMax = nccbus.MaNCCMax();

        }

        private void dgv_DanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachNCC.Rows[e.RowIndex];
                txt_MaNCC.Text = row.Cells[0].Value.ToString();
                txt_TenNCC.Text = row.Cells[1].Value.ToString();
                txt_WebsiteNCC.Text = row.Cells[2].Value.ToString();
                txt_EmailNCC.Text = row.Cells[3].Value.ToString();
                txt_SDTNCC.Text = row.Cells[4].Value.ToString();
                txt_DiaChiNCC.Text = row.Cells[5].Value.ToString();
                luuMaNCCTruocKhiSua = txt_MaNCC.Text;

            }
        }
    }
}
