namespace doanwf.DTO
{
    class khohangDTO
    {
        public int makho { get; set; }
        public string tenkho { get; set; }
        public string diachi { get; set; }
        public int masp { get; set; }


        public khohangDTO()
        {
            makho = 0;
            tenkho = string.Empty;
            diachi = string.Empty;
            masp = 0;
        }
    }
}
