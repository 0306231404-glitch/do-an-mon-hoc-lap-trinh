
using doanwf.DAO;
using doanwf.DTO;
using System.Data;

namespace doanwf.BUS
{
    class khachhangBUS
    {
        khachhangDAO kh = new khachhangDAO();
        public DataTable LayDSKhachHang()
        {
            return kh.GetData();
        }
        public bool CapNhatKH(khachhangDTO khDTO)
        {
            return kh.UpdateData(khDTO);
        }
        public bool XoaKH(int makh)
        {
            return kh.DeleteData(makh);
        }
        public bool ThemMoiKH(khachhangDTO khDTO)
        {
            return kh.InsertData(khDTO);
        }
        public DataTable TimKiemKH(string tenkh)
        {
            return kh.SearchKH(tenkh);
        }
        public string MaKHMax()
        {
            return kh.layMaKHMax();
        }
        public bool KiemTraKhTonTai(int makh)
        {
            return kh.SearchExist(makh);
        }
        public bool KiemTraSoDienThoai(string sodienthoai)
        {
            return kh.kiemTraSoDienThoai(sodienthoai);
        }

    }
}


