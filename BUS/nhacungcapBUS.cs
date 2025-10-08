using doanwf.DAO;
using doanwf.DTO;
using System.Data;

namespace doanwf.BUS
{
    class nhacungcapBUS
    {
        nhacungcapDAO nccDAO = new nhacungcapDAO();
        public DataTable LayDSNCC()
        {
            return nccDAO.GetData();
        }
        public bool CapNhatNCC(nhacungcapDTO nccDTO)
        {
            return nccDAO.UpdateData(nccDTO);
        }
        public bool XoaNCC(int makh)
        {
            return nccDAO.DeleteData(makh);
        }
        public bool ThemMoiNCC(nhacungcapDTO nccDTO)
        {
            return nccDAO.InsertData(nccDTO);
        }
        public string MaNCCMax()
        {
            return nccDAO.layMaNccMax();
        }
        public bool KiemTraSoDienThoai(string sodienthoai)
        {
            return nccDAO.kiemTraSoDienThoai(sodienthoai);
        }
        public bool KiemTraNCCTonTai(int mancc)
        {
            return nccDAO.SearchExist(mancc);
        }
    }
}
