using doanwf.DAO;
using doanwf.DTO;
using System.Data;
namespace doanwf.BUS
{
    class nhanvienBUS
    {
        nhanvienDAO nv = new nhanvienDAO();
        public DataTable LayDSSV()
        {
            return nv.GetData();
        }
        public DataTable TimKiemNhanVien(string manv)
        {
            return nv.SearchData(manv);
        }
        public bool ThemNhanVien(nhanvienDTO nvDTO)
        {
            return nv.InsertNhanVien(nvDTO);
        }
        public bool TimKiemTDNTonTai(string tendangnhap)
        {
            return nv.Search(tendangnhap);
        }
        public bool CapNhatNhanVien(nhanvienDTO nvDTO)
        {
            return nv.UpdateData(nvDTO);
        }
        public bool XoaNhanVien(string manv)
        {
            return nv.DeleteData(manv);
        }
        public bool KiemTraSoDienThoai(string sodienthoai)
        {
            return nv.kiemTraSoDienThoai(sodienthoai);
        }
    }
}
