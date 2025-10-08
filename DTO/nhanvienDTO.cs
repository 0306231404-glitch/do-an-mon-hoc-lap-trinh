using System;

namespace doanwf.DTO
{
    class nhanvienDTO
    {
        //lay get set du lieu va khoi tao mac dinh.
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public string hoten { get; set; }
        public string email { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }
        public string chucvu { get; set; }
        //public string avatar { get; set; }

        public nhanvienDTO()
        {
            tendangnhap = string.Empty;
            matkhau = string.Empty;
            hoten = string.Empty;
            email = string.Empty;
            diachi = string.Empty;
            dienthoai = string.Empty;
            ngaysinh = DateTime.Now;
            gioitinh = true;
            chucvu = string.Empty;
        }
    }
}
