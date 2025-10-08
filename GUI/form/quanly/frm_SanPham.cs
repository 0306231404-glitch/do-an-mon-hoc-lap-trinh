using doanwf.BUS;
using doanwf.DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace doanwf.form.quanly
{
    public partial class frm_SanPham : Form
    {
        static string masp = null;
        sanphamBUS bus = new sanphamBUS();
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = bus.getAllSanPham();

            //đổi tên cột của sản phẩm
            dgv_SanPham.Columns["masp"].HeaderText = "Mã Sản Phẩm";
            dgv_SanPham.Columns["tensp"].HeaderText = "Tên Sản Phẩm";
            dgv_SanPham.Columns["maloaisp"].HeaderText = "Mã Loại";
            dgv_SanPham.Columns["soluong"].HeaderText = "Số Lượng";
            dgv_SanPham.Columns["mota"].HeaderText = "Mô Tả";
            dgv_SanPham.Columns["dongia"].HeaderText = "Đơn Giá";
            dgv_SanPham.Columns["tinhtrang"].HeaderText = "Tình Trạng";
            dgv_SanPham.Columns["ngaytao"].HeaderText = "Ngày Tạo";
            dgv_SanPham.Columns["xuatxu"].HeaderText = "Xuất Xứ";
            dgv_SanPham.Columns["chatlieu"].HeaderText = "Chất Liệu";
            dgv_SanPham.Columns["mausac"].HeaderText = "Màu Sắc";
            dgv_SanPham.Columns["img"].HeaderText = "Hình Ảnh";

            //Xử lí value và display của các cbo sản phẩm
            cbo_LoaiSanPham.DataSource = bus.getMaLoai();
            cbo_LoaiSanPham.DisplayMember = "Name";
            cbo_LoaiSanPham.ValueMember = "maloaisp";//value member dùng để chỉ định tên cột sẽ lấy giá trị
            cbo_LoaiSanPham.DisplayMember="ten";//hiển thị tên loại sản phẩm
            cbo_LoaiSanPham.Text = string.Empty;

            cbo_ChatLieu.DataSource = bus.getChatLieu();
            cbo_ChatLieu.ValueMember = "chatlieu";
            cbo_ChatLieu.Text = string.Empty;

            cbo_MauSac.DataSource = bus.getMauSac();
            cbo_MauSac.ValueMember = "mausac";
            cbo_MauSac.Text = string.Empty;

            cbo_XuatXu.DataSource = bus.getXuatXu();
            cbo_XuatXu.ValueMember = "xuatxu";
            cbo_XuatXu.Text = string.Empty;

            txt_TiemKiemSP.Text="Nhập Tên Sản Phẩm";
            txt_TiemKiemSP.ForeColor=Color.LightGray;

            btn_Them.BackColor=SystemColors.Control;
            btn_Sua.BackColor=SystemColors.Control;
            btn_Xoa.BackColor=SystemColors.Control;
            btn_TimKiem.BackColor=SystemColors.Control;
            btn_UpLoad.BackColor=SystemColors.Control;
            btn_Reset.BackColor=SystemColors.Control;


        }



        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = new DataGridViewRow();
                row = dgv_SanPham.Rows[e.RowIndex];
                //Kiểm tra người dùng có chọn dòng chứa dữ liệu không
                if (row.Cells["masp"].Value is null|| row.Cells["masp"].Value.ToString()=="")
                {
                    masp=null;
                    txt_TenSP.Text=string.Empty;
                    nud_DonGia.Text=string.Empty;
                    txt_MoTa.Text=string.Empty;
                    nud_SoLuong.Text=string.Empty;
                    cbo_ChatLieu.Text=string.Empty;
                    cbo_LoaiSanPham.Text=null;
                    cbo_MauSac.Text=string.Empty;
                    cbo_XuatXu.Text=string.Empty;
                    pic_Anh.Image=null;
                    pic_Anh.ImageLocation=null;


                }

                else
                {
                    masp=row.Cells["masp"].Value.ToString();
                    txt_TenSP.Text = row.Cells["tensp"].Value.ToString();
                    txt_MoTa.Text = row.Cells["mota"].Value.ToString();
                    string maloaisp = row.Cells["maloaisp"].Value.ToString();
                    // Tìm tên loại sản phẩm tương ứng trong ComboBox
                    foreach (DataRowView item in cbo_LoaiSanPham.Items)
                    {
                        if (item["maloaisp"].ToString() == maloaisp)
                        {
                            cbo_LoaiSanPham.Text = item["ten"].ToString();
                            break;
                        }
                    }
                    nud_SoLuong.Text = row.Cells["soluong"].Value.ToString();
                    nud_DonGia.Text = row.Cells["dongia"].Value.ToString();
                    cbo_XuatXu.Text = row.Cells["xuatxu"].Value.ToString();
                    cbo_ChatLieu.Text = row.Cells["chatlieu"].Value.ToString();
                    cbo_MauSac.Text = row.Cells["mausac"].Value.ToString();
                    string imageFileName = Path.GetFileName(row.Cells["img"].Value.ToString());
                    string pathImg = Path.Combine(Application.StartupPath, "Resources", imageFileName);
                    pic_Anh.Image =Image.FromFile(pathImg);
                    pic_Anh.ImageLocation = pathImg;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex.Message);
            }



        }




        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_UpLoad_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;//Đường dẫn gốc của ảnh
                        string fileName = Path.GetFileName(filePath);//lấy tên file của ảnh
                        string resourceFolder = Path.Combine(Application.StartupPath, "Resources");//Đường dẫn thư mục folder của Resource
                        string distinationPath = Path.Combine(resourceFolder, fileName);
                        if (File.Exists(resourceFolder))//nếu có file Resource thì xoá
                        {
                            File.Delete(resourceFolder);
                        }
                        if (!Directory.Exists(resourceFolder))// chưa có thư mục resource thì tạo 
                        {
                            Directory.CreateDirectory(resourceFolder);
                        }
                        //file copy( đường dẫn tuyệt đối của ảnh, đường đẫn tuyệt đối của đích đến,..)
                        File.Copy(filePath, distinationPath, true);// tham số TRUE để ghi đè lại ảnh nếu ảnh đã tồn tại
                        pic_Anh.Image = Image.FromFile(filePath);
                        pic_Anh.ImageLocation = filePath;
                    }
                }
            });

            thread.SetApartmentState(ApartmentState.STA); // Đặt thread ở chế độ STA
            thread.Start();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn Sửa sản phẩm này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl==DialogResult.Yes)
            {
                try
                {
                    if (masp is null)
                    {
                        MessageBox.Show(" Vui chọn dòng có sản phẩm để sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txt_TenSP.Text))
                        {
                            MessageBox.Show("Vui lòng nhập tên sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_TenSP.Focus();
                            return;



                        }
                        else if (string.IsNullOrEmpty(nud_DonGia.Text))
                        {
                            MessageBox.Show("Vui lòng nhập giá sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nud_DonGia.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(nud_SoLuong.Text))
                        {
                            MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nud_SoLuong.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(txt_MoTa.Text))
                        {
                            MessageBox.Show("Vui lòng nhập mô tả sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_MoTa.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(cbo_ChatLieu.Text))
                        {
                            MessageBox.Show("Vui lòng nhập chất liệu sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbo_ChatLieu.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(cbo_LoaiSanPham.Text))
                        {
                            MessageBox.Show("Vui lòng nhập loại sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbo_LoaiSanPham.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(cbo_MauSac.Text))
                        {
                            MessageBox.Show("Vui lòng nhập màu sắc  sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbo_MauSac.Focus();
                            return;

                        }
                        else if (string.IsNullOrEmpty(cbo_XuatXu.Text))
                        {
                            MessageBox.Show("Vui lòng nhập xuất xứ  sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbo_XuatXu.Focus();
                            return;

                        }
                        else
                        {
                            sanphamDTO spDTO = new sanphamDTO();

                            //masp là biến global được tạo để lưu trữ mã sản phẩm khi mình chọn dòng
                            spDTO.masp=int.Parse(masp);
                            spDTO.tensp=txt_TenSP.Text.ToString();
                            spDTO.soluong=int.Parse(nud_SoLuong.Text);
                            if (nud_SoLuong.Value==0)
                            {
                                spDTO.tinhtrang=0;
                            }
                            else
                            {
                                spDTO.tinhtrang=1;

                            }
                            if (cbo_LoaiSanPham.SelectedIndex == -1)
                            {
                                MessageBox.Show("Loại sản phẩm Sai!, vui lòng chọn loại sản phẩm đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                            }
                            else
                            {
                                spDTO.chatlieu=cbo_ChatLieu.Text.ToString();
                                spDTO.xuatxu=cbo_XuatXu.Text.ToString();
                                spDTO.dongia=float.Parse(nud_DonGia.Text);
                                spDTO.mota=txt_MoTa.Text.ToString();
                                spDTO.mausac=cbo_MauSac.Text.ToString();
                                int maloai = cbo_LoaiSanPham.SelectedIndex+1;
                                spDTO.maloaisp=maloai;
                                string imgPath = pic_Anh.ImageLocation;
                                string imgName = Path.GetFileName(imgPath);
                                spDTO.img=imgName;

                                if (bus.update(spDTO))
                                {
                                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgv_SanPham.DataSource=bus.getAllSanPham();
                                    txt_TenSP.Text=string.Empty;
                                    nud_DonGia.Text=string.Empty;
                                    txt_MoTa.Text=string.Empty;
                                    nud_SoLuong.Text=string.Empty;
                                    cbo_ChatLieu.Text=string.Empty;
                                    cbo_LoaiSanPham.Text=null;
                                    cbo_MauSac.Text=string.Empty;
                                    cbo_XuatXu.Text=string.Empty;
                                    pic_Anh.Image=null;
                                }
                                else
                                {
                                    MessageBox.Show("Sửa Thất Bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenSP.Focus();
                    return;



                }
                else if (string.IsNullOrEmpty(nud_DonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nud_DonGia.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(nud_SoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nud_SoLuong.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(txt_MoTa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mô tả sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_MoTa.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(cbo_ChatLieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập chất liệu sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_ChatLieu.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(cbo_LoaiSanPham.Text))
                {
                    MessageBox.Show("Vui lòng nhập loại sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_LoaiSanPham.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(cbo_MauSac.Text))
                {
                    MessageBox.Show("Vui lòng nhập màu sắc  sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_MauSac.Focus();
                    return;

                }
                else if (string.IsNullOrEmpty(cbo_XuatXu.Text))
                {
                    MessageBox.Show("Vui lòng nhập xuất xứ  sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_XuatXu.Focus();
                    return;

                }
                else if (pic_Anh.ImageLocation is null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh  sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_XuatXu.Focus();
                    return;
                }
                else
                {
                    DialogResult dl = MessageBox.Show("Bạn có chắc chắn thêm sản phẩm ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl==DialogResult.Yes)
                    {

                        if (masp is null)
                        {
                            if (nud_SoLuong.Value==0)
                            {
                                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 1!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                            }
                            else
                            {
                                //-1 khong muc nao duoc chon
                                if (cbo_LoaiSanPham.SelectedIndex==-1)
                                {

                                    MessageBox.Show("Loại sản phẩm Sai!, vui lòng chọn loại sản phẩm đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {
                                    sanphamDTO spDTO = new sanphamDTO();
                                    spDTO.tensp=txt_TenSP.Text;
                                    spDTO.soluong=int.Parse(nud_SoLuong.Text);
                                    spDTO.chatlieu=cbo_ChatLieu.Text;
                                    spDTO.xuatxu=cbo_XuatXu.Text;
                                    spDTO.dongia=float.Parse(nud_DonGia.Text);
                                    spDTO.mota=txt_MoTa.Text;
                                    spDTO.mausac=cbo_MauSac.Text;
                                    spDTO.tinhtrang=1;
                                    int maloai = cbo_LoaiSanPham.SelectedIndex+1;
                                    spDTO.maloaisp=maloai;//Lấy gtri cua masp đã lưu trong values member 
                                    string imgPath = pic_Anh.ImageLocation;
                                    string imgName = Path.GetFileName(imgPath);
                                    spDTO.img=imgName;
                                    if (bus.insert(spDTO))
                                    {
                                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgv_SanPham.DataSource=bus.getAllSanPham();
                                        txt_TenSP.Text=string.Empty;
                                        nud_DonGia.Text=string.Empty;
                                        txt_MoTa.Text=string.Empty;
                                        nud_SoLuong.Text=string.Empty;
                                        cbo_ChatLieu.Text=string.Empty;
                                        cbo_LoaiSanPham.Text=null;
                                        cbo_MauSac.Text=string.Empty;
                                        cbo_XuatXu.Text=string.Empty;
                                        pic_Anh.Image=null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Thất Bại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("Sản Phẩm Này Đã Tồn Tại, Vui Lòng Chọn Dòng Mới Để Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }



                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn xoá sản phẩm này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl==DialogResult.Yes)
            {
                try
                {
                    if (masp is null)
                    {
                        MessageBox.Show(" Vui chọn dòng có sản phẩm để Xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bus.delete(int.Parse(masp));
                        dgv_SanPham.DataSource= bus.getAllSanPham();
                        txt_TenSP.Text=string.Empty;
                        nud_DonGia.Text=string.Empty;
                        txt_MoTa.Text=string.Empty;
                        nud_SoLuong.Text=string.Empty;
                        cbo_ChatLieu.Text=string.Empty;
                        cbo_LoaiSanPham.Text=null;
                        cbo_MauSac.Text=string.Empty;
                        cbo_XuatXu.Text=string.Empty;
                        pic_Anh.Image=null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            masp=null;
            txt_TenSP.Text=string.Empty;
            nud_DonGia.Text=string.Empty;
            txt_MoTa.Text=string.Empty;
            nud_SoLuong.Text=string.Empty;
            cbo_ChatLieu.Text=string.Empty;
            cbo_LoaiSanPham.Text=null;
            cbo_MauSac.Text=string.Empty;
            cbo_XuatXu.Text=string.Empty;
            pic_Anh.Image=null;
            dgv_SanPham.DataSource=bus.getAllSanPham();
            btn_Reset.BackColor=SystemColors.Control;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TiemKiemSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TiemKiemSP.Focus();
                return;
            }
            else
            {
                dgv_SanPham.DataSource= bus.search(txt_TiemKiemSP.Text);
                btn_Reset.Focus();
                btn_Reset.BackColor=Color.LightCyan;

            }

        }

        private void dgv_SanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_SanPham.Columns[e.ColumnIndex].Name=="tinhtrang")
            {
                try
                {
                    //nếu chuyển giá trị của e.value thành số thành công thì tinhTrang nhận giatri, trả về true
                    if (e.Value!=null)
                    {
                        if (int.TryParse(e.Value.ToString(), out int tinhTrang))
                        {
                            e.Value = tinhTrang==1 ? "Còn Hàng" : "Hết Hàng";
                            e.FormattingApplied=true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pic_Anh_Click(object sender, EventArgs e)
        {

        }

        private void txt_TiemKiemSP_Enter(object sender, EventArgs e)
        {
            if (txt_TiemKiemSP.Text=="Nhập Tên Sản Phẩm")
            {
                txt_TiemKiemSP.Text="";
                txt_TiemKiemSP.ForeColor=Color.Black;

            }
        }

        private void txt_TiemKiemSP_Leave(object sender, EventArgs e)
        {

            if (txt_TiemKiemSP.Text=="")
            {
                txt_TiemKiemSP.Text="Nhập Tên Sản Phẩm";
                txt_TiemKiemSP.ForeColor=Color.LightGray;

            }
        }
        ///
    }
}
