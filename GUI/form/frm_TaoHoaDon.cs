using System;
using System.Windows.Forms;
namespace doanwf.form
{

    public partial class frm_TaoHoaDon : Form
    {
        //hdbanhangDTO hdbDTO = new hdbanhangDTO();
        //cthdbanhangDTO cthdbhDTO = new cthdbanhangDTO();
        //khachhangDTO khDTO = new khachhangDTO();
        //taohoadonBUS thdBUS = new taohoadonBUS();
        public frm_TaoHoaDon()
        {
            InitializeComponent();
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon chitiethoadon = new frm_ChiTietHoaDon();
            chitiethoadon.Show();
        }

        private void btn_LamMoiHD_Click(object sender, EventArgs e)
        {
            txt_MaHD.Text = string.Empty;
            txt_TenKHTrongTaoHoaDon.Text = string.Empty;
            txt_SDTKHTrongTaoHoaDon.Text = string.Empty;
            dtp_ThoiGianMua.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_DiaChiKHTrongTaoHoaDon.Text = string.Empty;
            txt_TienKhachDua.Text = string.Empty;
            txt_TenSanPham.Text = string.Empty;
            txt_SoLuongMua.Text = string.Empty;
            cbo_MaSp.Text = string.Empty;
        }

        private void frm_TaoHoaDon_Load(object sender, EventArgs e)
        {
            //txt_MaHD.Text = thdBUS.LayMaHD();
            //cbo_MaSp.DataSource = thdBUS.LayDSSanPham();
            //cbo_MaSp.DisplayMember = "masp";
            //cbo_MaSp.ValueMember = "masp";

        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            //hdbDTO.mahd = int.Parse(txt_MaHD.Text);
            //hdbDTO.manv = cbo_NhanVienXuLy.Text;
            //hdbDTO.ngayban = DateTime.Parse(dtp_ThoiGianMua.Value.ToString("dd/MM/yyyy"));
            //hdbDTO.makh = int.Parse(thdBUS.LayMaKH());

            //khDTO.makh = int.Parse(thdBUS.LayMaKH());
            //khDTO.dienthoai = txt_SDTKHTrongTaoHoaDon.Text;
            //khDTO.hoten = txt_TenKHTrongTaoHoaDon.Text;
            //khDTO.diachi = txt_DiaChiKHTrongTaoHoaDon.Text;

            //cthdbhDTO.mahd = int.Parse(txt_MaHD.Text);
            //cthdbhDTO.masp = int.Parse(cbo_MaSp.Text);
            //cthdbhDTO.soluong = int.Parse(txt_SoLuongMua.Text);

        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {

        }



        private void cbo_MaSp_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbo_MaSp.SelectedItem != null)
            //{
            //    DataRowView selectedDataRowView = (DataRowView)cbo_MaSp.SelectedItem;
            //    int masp = Convert.ToInt32(selectedDataRowView["masp"]);
            //    string tensp = thdBUS.LayTenSP(masp);
            //    txt_TenSanPham.Text = tensp;
            //}
        }


    }
}