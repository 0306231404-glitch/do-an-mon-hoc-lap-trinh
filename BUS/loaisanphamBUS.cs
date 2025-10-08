using doanwf.DAO;
using doanwf.DTO;
using System.Data;

namespace doanwf.BUS
{
    internal class loaisanphamBUS
    {
        loaisanphamDAO loaisanphamDAO = new loaisanphamDAO();
        public DataTable getAllLoaiSanPham()
        {
            return loaisanphamDAO.getAllLoaiSanPham();
        }
        public bool insertLoaiSanPham(loaisanphamDTO dTO)
        {
            return loaisanphamDAO.insertLoaiSanPham(dTO);
        }
        public bool update(loaisanphamDTO dTO)
        {
            return loaisanphamDAO.update(dTO);

        }
        public bool delete(int masp)
        {
            return loaisanphamDAO.delete(masp);
        }

    }
}
