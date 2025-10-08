using doanwf.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
namespace doanwf.DAO
{
    internal class nhanvienDAO : DataProvider
    {

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string strquery = "select * from nhanvien";
            using (SqlDataAdapter da = new SqlDataAdapter(strquery, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public bool UpdateData(nhanvienDTO nv)
        {
            string strquery = "UPDATE nhanvien SET " +
                              "matkhau = @matkhau, " +
                              "hoten = @hoten, " +
                              "email = @email, " +
                              "diachi = @diachi, " +
                              "dienthoai = @dienthoai, " +
                              "ngaysinh = @ngaysinh, " +
                              "gioitinh = @gioitinh, " +
                              "chucvu = @chucvu " +
                              "WHERE tendangnhap = @tendangnhap";

            SqlCommand cm = new SqlCommand(strquery, conn);

            cm.Parameters.AddWithValue("@tendangnhap", nv.tendangnhap);
            cm.Parameters.AddWithValue("@matkhau", nv.matkhau);
            cm.Parameters.AddWithValue("@hoten", nv.hoten);
            cm.Parameters.AddWithValue("@email", nv.email);
            cm.Parameters.AddWithValue("@diachi", nv.diachi);
            cm.Parameters.AddWithValue("@dienthoai", nv.dienthoai);
            cm.Parameters.AddWithValue("@ngaysinh", nv.ngaysinh);
            cm.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
            cm.Parameters.AddWithValue("@chucvu", nv.chucvu);
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
        public bool DeleteData(string tendangnhap)
        {
            string strquery = "DELETE FROM nhanvien WHERE tendangnhap = @tendangnhap";
            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@tendangnhap", tendangnhap);
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

        public DataTable SearchData(string tendangnhap)
        {
            DataTable dt = new DataTable();
            string strquery = string.Format("select * from nhanvien where tendangnhap like '%{0}%'", tendangnhap);
            SqlDataAdapter da = new SqlDataAdapter(strquery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool Search(string tendangnhap)
        {

            string strquery = string.Format("select tendangnhap from nhanvien where tendangnhap = '{0}'", tendangnhap);
            SqlCommand cm = new SqlCommand(strquery, conn);
            try
            {
                if (cm.Connection.State == ConnectionState.Open)
                {
                    cm.Connection.Close();
                }
                conn.Open();
                string tmp = (string)cm.ExecuteScalar();
                if (tmp == null)
                {
                    return false;
                }
                else
                {
                    if (tmp.Equals(tendangnhap))
                    {
                        return true;
                    }
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


        public bool InsertNhanVien(nhanvienDTO nv)
        {
            string strquery = "INSERT INTO nhanvien (tendangnhap, matkhau, hoten, email, diachi, dienthoai, ngaysinh, gioitinh, chucvu) " +
                              "VALUES (@tendangnhap, @matkhau, @hoten, @email, @diachi, @dienthoai, @ngaysinh, @gioitinh, @chucvu)";

            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@tendangnhap", nv.tendangnhap);
            cm.Parameters.AddWithValue("@matkhau", nv.matkhau);
            cm.Parameters.AddWithValue("@hoten", nv.hoten);
            cm.Parameters.AddWithValue("@email", nv.email);
            cm.Parameters.AddWithValue("@diachi", nv.diachi);
            cm.Parameters.AddWithValue("@dienthoai", nv.dienthoai);
            cm.Parameters.AddWithValue("@ngaysinh", nv.ngaysinh);
            cm.Parameters.AddWithValue("@gioitinh", nv.gioitinh);
            cm.Parameters.AddWithValue("@chucvu", nv.chucvu);

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


    }
}
