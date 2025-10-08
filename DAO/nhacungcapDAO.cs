using doanwf.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace doanwf.DAO
{
    class nhacungcapDAO : DataProvider
    {
        public DataTable GetData()
        {
            string strquery = "select * from nhacungcap";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strquery, conn);
            da.Fill(dt);
            return dt;
        }


        public bool InsertData(nhacungcapDTO ncc)
        {
            string strquery = "INSERT INTO nhacungcap(ten,website,email,dienthoai,diachi) " +
                "values(@ten,@website,@email,@dienthoai,@diachi)";
            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@ten", ncc.ten);
            cm.Parameters.AddWithValue("@website", ncc.website);
            cm.Parameters.AddWithValue("@email", ncc.email);
            cm.Parameters.AddWithValue("@dienthoai", ncc.dienthoai);
            cm.Parameters.AddWithValue("@diachi", ncc.diachi);
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
        public bool UpdateData(nhacungcapDTO ncc)
        {
            string strquery = "UPDATE nhacungcap SET " +
                              "ten = @ten, " +
                              "website = @website, " +
                              "email = @email, " +
                              "dienthoai = @dienthoai, " +
                              "diachi = @diachi " +
                              "where mancc = @mancc";

            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@mancc", ncc.mancc);
            cm.Parameters.AddWithValue("@ten", ncc.ten);
            cm.Parameters.AddWithValue("@website", ncc.website);
            cm.Parameters.AddWithValue("@email", ncc.email);
            cm.Parameters.AddWithValue("@dienthoai", ncc.dienthoai);
            cm.Parameters.AddWithValue("@diachi", ncc.diachi);
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

        public bool DeleteData(int mancc)
        {
            string strquery = "DELETE FROM nhacungcap WHERE mancc = @mancc";
            SqlCommand cm = new SqlCommand(strquery, conn);
            cm.Parameters.AddWithValue("@mancc", mancc);
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
        public string layMaNccMax()
        {
            string sql = "select max(mancc)+1 from nhacungcap";
            DataProvider dp = new DataProvider();
            SqlCommand cm = new SqlCommand(sql, conn);
            conn.Open();
            object firstValue = cm.ExecuteScalar();
            conn.Close();
            return firstValue.ToString();
        }
        public bool SearchExist(int mancc)
        {
            string strquery = string.Format("select makh from nhacungcap where mancc = {0}", mancc);
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
                if ((int)tmp == mancc)
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
