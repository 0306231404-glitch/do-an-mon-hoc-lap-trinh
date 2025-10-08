using System;

namespace doanwf.DTO
{
    class sanphamDTO
    {
        public int masp { get; set; }
        public string tensp { get; set; }
        public int maloaisp { get; set; }
        public int soluong { get; set; }
        public string mota { get; set; }
        public float dongia { get; set; }
        public int tinhtrang { get; set; }
        public string xuatxu { get; set; }
        public string chatlieu { get; set; }
        public string mausac { get; set; }
        public string img { get; set; }


        public DateTime ngaytao { get; set; }

        public sanphamDTO()
        {
            masp = 0;
            tensp = string.Empty;
            maloaisp = 0;
            soluong = 0;
            mota = string.Empty;
            dongia = 0;
            ngaytao = DateTime.Now;
        }
    }
}
