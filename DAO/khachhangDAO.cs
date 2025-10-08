using doanwf.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
namespace doanwf.DAO
{
    class khachhangDAO : DataProvider
    {
        public DataTable GetData()
        {
            string strquery = "select * from khachhang";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strquery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool InsertData(khachhangDTO kh)
        {
            string strquery = "INSERT INTO khachhang(hoten,diachi,dienthoai,ngaysinh,gioitinh) " +
                "values(@hoten,@diachi,@dienthoai ,@ngaysinh,@gioitinh)";
            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@hoten", kh.hoten);
            cm.Parameters.AddWithValue("@diachi", kh.diachi);
            cm.Parameters.AddWithValue("@dienthoai", kh.dienthoai);
            cm.Parameters.AddWithValue("@ngaysinh", kh.ngaysinh);
            cm.Parameters.AddWithValue("@gioitinh", kh.gioitinh);
            try
            {
                if (cm.Connection.State == ConnectionState.Open)
                {
                    cm.Connection.Close();
                }
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                if (cm.Connection.State == ConnectionState.Open)
                {
                    cm.Connection.Close();
                }
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;

        }

        public bool UpdateData(khachhangDTO kh)
        {
            string strquery = "UPDATE khachhang SET " +
                              "hoten = @hoten, " +
                              "diachi = @diachi, " +
                              "dienthoai = @dienthoai, " +
                              "ngaysinh = @ngaysinh, " +
                              "gioitinh = @gioitinh " +
                              "where makh = @makh";

            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@makh", kh.makh);
            cm.Parameters.AddWithValue("@hoten", kh.hoten);
            cm.Parameters.AddWithValue("@diachi", kh.diachi);
            cm.Parameters.AddWithValue("@dienthoai", kh.dienthoai);
            cm.Parameters.AddWithValue("@ngaysinh", kh.ngaysinh);
            cm.Parameters.AddWithValue("@gioitinh", kh.gioitinh);
            try
            {
                if (cm.Connection.State == ConnectionState.Open)
                {
                    cm.Connection.Close();
                }
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool DeleteData(int makh)
        {
            string strquery = "DELETE FROM khachhang WHERE makh = @makh";
            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@makh", makh);
            try
            {
                if (cm.Connection.State == ConnectionState.Open)
                {
                    cm.Connection.Close();
                }
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable SearchKH(string hoten)
        {
            DataTable dt = new DataTable();
            string strquery = string.Format("select * from khachhang where hoten like '%{0}%'", hoten);
            SqlDataAdapter da = new SqlDataAdapter(strquery, conn);
            da.Fill(dt);
            return dt;
        }
        public string layMaKHMax()
        {
            string sql = "select max(makh)+1 from khachhang";
            DataProvider dp = new DataProvider();
            SqlCommand cm = new SqlCommand(sql, conn);
            conn.Open();
            object firstValue = cm.ExecuteScalar();
            conn.Close();
            return firstValue.ToString();
        }
        //tìm kiếm xem mã khách hàng đã tồn tại hay chưa.
        public bool SearchExist(int makh)
        {
            string strquery = string.Format("select makh from khachhang where makh = {0}", makh);
            SqlCommand cm = new SqlCommand(strquery, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                object tmp = cm.ExecuteScalar();
                if (tmp == null)
                {
                    return false;
                }
                else
                if ((int)tmp == makh)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //kiểm tra xem số điện thoại đó có lẫn kí tự nào hay không.
        public bool kiemTraSoDienThoai(string sodienthoai)
        {
            if (string.IsNullOrEmpty(sodienthoai))
            {
                return false;
            }
            foreach (char tmp in sodienthoai)
            {
                if (char.IsLetter(tmp))
                {
                    return true;
                }
            }
            return false;
        }
    }
}



