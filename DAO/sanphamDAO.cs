using doanwf.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace doanwf.DAO
{
    internal class sanphamDAO : DataProvider
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string sql = "Select* from sanpham";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public DataTable GetMaLoai()
        {
            DataTable dt = new DataTable();
            string sql = "Select maloaisp,ten from loaisanpham";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public DataTable GetMauSac()
        {
            DataTable dt = new DataTable();
            string sql = "select distinct mausac from sanpham";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public DataTable GetXuatXu()
        {
            DataTable dt = new DataTable();
            string sql = "select distinct xuatxu from sanpham";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public DataTable GetChatLieu()
        {
            DataTable dt = new DataTable();
            string sql = "select distinct chatlieu from sanpham";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.Fill(dt);
            return dt;
        }
        public bool Update(sanphamDTO sp)
        {
            string sql = "update sanpham set tensp=@tensp,tinhtrang=@tinhtrang,maloaisp=@maloaisp,soluong=@soluong, mota=@mota,dongia=@dongia,xuatxu=@xuatxu,chatlieu=@chatlieu,mausac=@mausac,img=@img where masp=@masp";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("@tensp", sp.tensp);
            cm.Parameters.AddWithValue("@maloaisp", sp.maloaisp);
            cm.Parameters.AddWithValue("@soluong", sp.soluong);
            cm.Parameters.AddWithValue("@mota", sp.mota);
            cm.Parameters.AddWithValue("@dongia", sp.dongia);
            cm.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
            cm.Parameters.AddWithValue("@chatlieu", sp.chatlieu);
            cm.Parameters.AddWithValue("@mausac", sp.mausac);
            cm.Parameters.AddWithValue("@img", sp.img);
            cm.Parameters.AddWithValue("@masp", sp.masp);
            cm.Parameters.AddWithValue("@tinhtrang", sp.tinhtrang);
            try
            {
                conn.Open();
                int c = cm.ExecuteNonQuery();
                if (c > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;



            }
            finally { conn.Close(); }
            return false;
        }

        public bool Delete(int id)
        {
            string sql = "delete from sanpham where masp=@id";
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                int c = cm.ExecuteNonQuery();
                if (c > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Insert(sanphamDTO sp)
        {
            string sqlQuery = "insert into sanpham(tensp,maloaisp,soluong,mota,dongia,tinhtrang,xuatxu,chatlieu,mausac,img)\r\n" +
                "values(@tensp,@maloaisp,@soluong,@mota,@dongia,@tinhtrang,@xuatxu,@chatlieu,@mausac,@img)";

            SqlCommand cm = new SqlCommand(sqlQuery, conn);
            cm.Parameters.AddWithValue("@tensp", sp.tensp);
            cm.Parameters.AddWithValue("@maloaisp", sp.maloaisp);
            cm.Parameters.AddWithValue("@soluong", sp.soluong);
            cm.Parameters.AddWithValue("@mota", sp.mota);
            cm.Parameters.AddWithValue("@dongia", sp.dongia);
            cm.Parameters.AddWithValue("@tinhtrang", sp.tinhtrang);
            cm.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
            cm.Parameters.AddWithValue("@chatlieu", sp.chatlieu);
            cm.Parameters.AddWithValue("@mausac", sp.mausac);
            cm.Parameters.AddWithValue("@img", sp.img);

            try
            {
                conn.Open();
                int c = cm.ExecuteNonQuery();
                if (c>0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;


        }

        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {

                string sql = string.Format("select * from sanpham where tensp='{0}'", name);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }

    }
}
