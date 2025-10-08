using System;

namespace doanwf.DTO
{
    class hoadonnhaphangDTO
    {
        public int maHoaDonNhap { get; set; }
        public DateTime ngaynhap { get; set; }
        public string manv { get; set; }
        public int mancc { get; set; }
        public float tongtien { get; set; }

        public hoadonnhaphangDTO()
        {
            maHoaDonNhap = 0;
            ngaynhap = DateTime.Now;
            manv = string.Empty;
            mancc = 0;
            tongtien = 0;
        }
    }
}
