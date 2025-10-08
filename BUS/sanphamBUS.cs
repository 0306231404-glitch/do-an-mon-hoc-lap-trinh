using doanwf.DAO;
using doanwf.DTO;
using System.Data;

namespace doanwf.BUS
{
    internal class sanphamBUS
    {
        sanphamDAO sp = new sanphamDAO();
        public DataTable getAllSanPham()
        {
            return sp.GetData();
        }
        public DataTable getMaLoai()
        {
            return sp.GetMaLoai();
        }
//
        public DataTable getMauSac()
        {
            return sp.GetMauSac();

        }
        public DataTable getChatLieu()
        {
            return sp.GetChatLieu();

        }
        public DataTable getXuatXu()
        {
            return sp.GetXuatXu();

        }
        public bool insert(sanphamDTO sanphamDTO)
        {
            return sp.Insert(sanphamDTO);
        }
        public bool update(sanphamDTO sanpham)
        {
            return sp.Update(sanpham);
        }
        public bool delete(int id)
        {

            return (sp.Delete(id));
        }
        public DataTable search(string name)
        {
            return sp.Search(name);
        }

    }
}
