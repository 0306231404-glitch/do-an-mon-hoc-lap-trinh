using doanwf.BUS;
using doanwf.DTO;
using System.Data;
using System.Data.SqlClient;

namespace doanwf.DAO
{
    class taohoadonDAO : DataProvider
    {
        hdbanhangDTO hdbDTO = new hdbanhangDTO();
        cthdbanhangDTO cthdbhDTO = new cthdbanhangDTO();
        khachhangDTO khDTO = new khachhangDTO();
        taohoadonBUS thdBUS = new taohoadonBUS();
        public void Insert()
        {
            //string strqueryKH = "INSERT INTO khachhang(hoten,diachi,dienthoai) " +
            //    "values(@hoten,@diachi,@dienthoai)";
            //SqlCommand cm = new SqlCommand(strqueryKH, conn);
            //cm.Parameters.AddWithValue("@hoten", khDTO.hoten);
            //cm.Parameters.AddWithValue("@diachi", khDTO.diachi);
            //cm.Parameters.AddWithValue("@dienthoai", khDTO.dienthoai);

            //string strqueryHDbh = "INSERT INTO hdbanhang(ngayban,manv,makh,tongtien) " +
            //    "values(@hoten,@diachi,@dienthoai)";
            //SqlCommand cm = new SqlCommand(strqueryHDbh, conn);
            //cm.Parameters.AddWithValue("@hoten", hdbDTO.hoten);
            //cm.Parameters.AddWithValue("@diachi", khDTO.diachi);
            //cm.Parameters.AddWithValue("@dienthoai", khDTO.dienthoai);

        }
        public string LayMaKh()
        {
            string sqlquery = "select max(makh)+1 from khachhang";
            SqlCommand cm = new SqlCommand(sqlquery, conn);
            conn.Open();
            object value = cm.ExecuteScalar();
            conn.Close();
            return value.ToString();
        }
        public string LayMaHD()
        {
            string sqlquery = "select max(mahd)+1 from hdbanhang";
            SqlCommand cm = new SqlCommand(sqlquery, conn);
            conn.Open();
            object value = cm.ExecuteScalar();
            conn.Close();
            return value.ToString();
        }
        public string LayTenSanPham(int masp)
        {
            string sqlquery = "select tensp from sanpham where masp = @masp";

            SqlCommand cm = new SqlCommand(sqlquery, conn);
            cm.Parameters.AddWithValue("@masp", masp);
            conn.Open();
            object value = cm.ExecuteScalar();
            conn.Close();
            return value.ToString();
        }
        public DataTable LayDSSanPham()
        {
            DataTable dt = new DataTable();
            string sqlquery = "select * from sanpham";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, conn);
            da.Fill(dt);
            return dt;

        }
        public DataTable GetData()
        {
            string sqlquery = "select hdbanhang.mahd,sanpham.masp,tensp,cthdbanhang.soluong,cthdbanhang.dongia,thanhtien=(cthdbanhang.soluong*cthdbanhang.dongia) from hdbanhang,sanpham,cthdbanhang ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, conn);
            da.Fill(dt);
            return dt;
        }

    }
}
