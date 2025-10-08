using System;

namespace doanwf.DTO
{
    class khachhangDTO
    {
        public int makh { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public DateTime ngaysinh { get; set; }
        public bool gioitinh { get; set; }

        public khachhangDTO()
        {
            makh = 0;
            hoten = string.Empty;
            diachi = string.Empty;
            dienthoai = string.Empty;
            ngaysinh = DateTime.Now;
            gioitinh = true;
        }
    }
}
