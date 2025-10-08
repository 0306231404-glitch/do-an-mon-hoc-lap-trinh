using doanwf.DAO;
using System.Data;

namespace doanwf.BUS
{
    class taohoadonBUS
    {
        taohoadonDAO tdhDAO = new taohoadonDAO();
        public string LayMaKH()
        {
            return tdhDAO.LayMaKh();
        }
        public string LayMaHD()
        {
            return tdhDAO.LayMaHD();
        }
        public string LayTenSP(int masp)
        {
            return tdhDAO.LayTenSanPham(masp);
        }
        public DataTable LayDSSanPham()
        {
            return tdhDAO.LayDSSanPham();
        }
    }
}
