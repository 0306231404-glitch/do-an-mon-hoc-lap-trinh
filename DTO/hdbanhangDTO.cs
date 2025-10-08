using System;

namespace doanwf.DTO
{
    class hdbanhangDTO
    {
        public int mahd { get; set; }
        public DateTime ngayban { get; set; }
        public string manv { get; set; }
        public int makh { get; set; }
        public float tongtien { get; set; }

        public hdbanhangDTO()
        {
            mahd = 0;
            ngayban = DateTime.Now;
            manv = string.Empty;
            makh = 0;
            tongtien = 0;
        }
    }
}
