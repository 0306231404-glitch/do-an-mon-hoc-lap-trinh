using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace doanwf.DAO
{
    internal class DataProvider
    {
        static private string strconn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=quan_ly_ban_hang;Integrated Security=True";
        protected SqlConnection conn;/*= new SqlConnection(strconn);*/
        public DataProvider()
        {
            try
            {
                conn = new SqlConnection(strconn);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connected failed:" + e.Message);
            }
        }
        public void openConn()
        {
            conn.Open();
        }
        public void closeConn()
        {
            conn.Close();
        }
        public SqlConnection getConn()
        {
            return conn;
        }



    }
}
