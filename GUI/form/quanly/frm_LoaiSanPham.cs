using doanwf.BUS;
using doanwf.DTO;
using System;
using System.Windows.Forms;

namespace doanwf.GUI.form.quanly
{
    public partial class frm_LoaiSanPham : Form
    {
        static string masp = null;
        loaisanphamBUS bus = new loaisanphamBUS();
        public frm_LoaiSanPham()
        {
            InitializeComponent();
        }

        private void frm_LoaiSanPham_Load(object sender, EventArgs e)
        {

            dgv_LoaiSanPham.DataSource=bus.getAllLoaiSanPham();
            dgv_LoaiSanPham.Columns["ten"].HeaderText="Tên Loại Sản Phẩm";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row=dgv_LoaiSanPham.Rows[e.RowIndex];
            if (e.RowIndex<0)
            {
                return;
            }
            txt_TenLoaiSP.Text=row.Cells["ten"].Value.ToString();
            masp=row.Cells["maloaisp"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (masp==null)
            {
                if (string.IsNullOrEmpty(txt_TenLoaiSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên loại sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenLoaiSP.Focus();
                    return;
                }
                else
                {
                    loaisanphamDTO dTO = new loaisanphamDTO();
                    dTO.ten=txt_TenLoaiSP.Text;
                    try
                    {
                        if (bus.insertLoaiSanPham(dTO))
                        {
                            MessageBox.Show("Thêm Loại Sản Phẩm Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_LoaiSanPham.DataSource=bus.getAllLoaiSanPham();
                            txt_TenLoaiSP.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Đã Có Loại Sản Phẩm Này, Vui lòng nhấn nút Reset hoặc chọn dòng mới để thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //focus vào dòng không chứa dữ liệu

                dgv_LoaiSanPham.CurrentCell = dgv_LoaiSanPham.Rows[dgv_LoaiSanPham.Rows.Count-1].Cells[0]; // Chọn ô đầu tiên của dòng cuối
                dgv_LoaiSanPham.FirstDisplayedScrollingRowIndex = dgv_LoaiSanPham.Rows.Count-1;
                masp=null;
                txt_TenLoaiSP.Text=string.Empty;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_TenLoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenLoaiSP.Focus();
                return;
            }
            else
            {
                loaisanphamDTO dTO = new loaisanphamDTO();
                dTO.ten=txt_TenLoaiSP.Text;
                dTO.maloaisp=int.Parse(masp);
                try
                {
                    if (bus.update(dTO))
                    {
                        MessageBox.Show("Sửa Loại Sản Phẩm Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_LoaiSanPham.DataSource=bus.getAllLoaiSanPham();
                        txt_TenLoaiSP.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (masp==null)
            {
                MessageBox.Show("Vui lòng chọn dòng có dữ liệu để xoá", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv_LoaiSanPham.CurrentCell=dgv_LoaiSanPham.Rows[0].Cells[0];
                dgv_LoaiSanPham.FirstDisplayedCell=dgv_LoaiSanPham.Rows[0].Cells[0];

            }
            else
            {
                try
                {
                    bus.delete(int.Parse(masp));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
