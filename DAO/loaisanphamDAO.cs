using doanwf.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace doanwf.DAO
{
    internal class loaisanphamDAO : DataProvider
    {
        public DataTable getAllLoaiSanPham()
        {
            DataTable dt = new DataTable();
            string sql = "select * from loaisanpham";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            return dt;

        }
        public bool insertLoaiSanPham(loaisanphamDTO loaisanpham)
        {
            string sql = "insert into loaisanpham(ten) values(@ten)";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("@ten", loaisanpham.ten);

            try
            {
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public bool update(loaisanphamDTO loaisanpham)
        {
            string sql = "update loaisanpham set ten=@ten where maloaisp=@maloaisp";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("@ten", loaisanpham.ten);
            cm.Parameters.AddWithValue("@ten", loaisanpham.maloaisp);


            try
            {
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public bool delete(int masp)
        {
            string sql = "delete from loaisanpham where ten=@ten";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("@ten", masp);

            try
            {
                conn.Open();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

    }
}
