namespace doanwf.DTO
{
    class nhacungcapDTO
    {
        public int mancc { get; set; }
        public string ten { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public string dienthoai { get; set; }
        public string diachi { get; set; }

        public nhacungcapDTO()
        {
            mancc = 0;
            ten = string.Empty;
            website = string.Empty;
            email = string.Empty;
            dienthoai = string.Empty;
            diachi = string.Empty;
        }
    }
}
