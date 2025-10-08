namespace doanwf.DTO
{
    class cthdbanhangDTO
    {
        public int mahd { get; set; }
        public int masp { get; set; }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public float thanhtien { get; set; }


        public cthdbanhangDTO()
        {
            mahd = 0;
            masp = 0;
            soluong = 0;
            dongia = 0;
            thanhtien = 0;
        }
    }
}
