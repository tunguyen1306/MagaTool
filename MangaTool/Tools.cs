using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MangaTool
{
   public class Tools
    {
        private static SqlConnection _connection;
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DataManga"].ConnectionString;
     
        public static DataSet ExcuteDatasetStore(string storename)
        {
            _connection = new SqlConnection(_connectionString);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandTimeout = 300;
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adap = new SqlDataAdapter(com);
            adap.Fill(ds);
            return ds;
        }
        public static DataSet ExcuteDatasetSql(string sql)
        {
            SqlConnection _connections;
            _connections = new SqlConnection(_connectionString);
          
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(sql, _connections);
            SqlDataAdapter adap = new SqlDataAdapter(com);
            adap.Fill(ds);
            _connections.Close();
            return ds;
        }

        public static int ExcuteNon(string sql)
        {
            _connection = new SqlConnection(_connectionString);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(sql, _connection);
            com.CommandTimeout = 300;
            _connection.Open();
            int ni = com.ExecuteNonQuery();
            _connection.Close();
            return ni ;
        }
        public static DataSet ExcuteDatasetSql(string sql, SqlParameter[] prams)
        {
            _connection = new SqlConnection(_connectionString);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(sql, _connection);
            com.Parameters.AddRange(prams);
            com.CommandTimeout = 300;
            SqlDataAdapter adap = new SqlDataAdapter(com);
            adap.Fill(ds);
            return ds;
        }
        public static DataSet ExcuteDatasetStore(string storename, SqlParameter[] prams)
        {
            _connection = new SqlConnection(_connectionString);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandTimeout = 300;
            com.Parameters.AddRange(prams);
            SqlDataAdapter adap = new SqlDataAdapter(com);
            adap.Fill(ds);
            return ds;
        }
        public static void ExcuteStore(string storename)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandTimeout = 300;
            _connection.Open();

            com.ExecuteNonQuery();
            _connection.Close();
        }

        public static void ExcuteStore(string storename, SqlParameter[] prams)
        {
            _connection = new SqlConnection(_connectionString);
            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddRange(prams);
            _connection.Open();
            com.ExecuteNonQuery();
            _connection.Close();
        }
        public static object ExcuteScalarStore(string storename)
        {
            _connection = new SqlConnection(_connectionString);

            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandType = CommandType.StoredProcedure;
            _connection.Open();
            var o = com.ExecuteScalar();
            _connection.Close();
            return o;
        }

        public static object ExcuteScalarStore(string storename, SqlParameter[] prams)
        {
            _connection = new SqlConnection(_connectionString);
            SqlCommand com = new SqlCommand(storename, _connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddRange(prams);
            _connection.Open();
            var o = com.ExecuteScalar();
            _connection.Close();
            return o;
        }
        public static string toMD5(string pass)
        {
            MD5CryptoServiceProvider myMD5 = new MD5CryptoServiceProvider();
            byte[] myPass = System.Text.Encoding.UTF8.GetBytes(pass);
            myPass = myMD5.ComputeHash(myPass);

            StringBuilder s = new StringBuilder();
            foreach (byte p in myPass)
            {
                s.Append(p.ToString());
            }
            return s.ToString();
        }
        public static string GetSortDirection(ref string sortDirection)
        {
            if (sortDirection == "ASC")
            {
                sortDirection = "DESC";
            }
            else
            {
                sortDirection = "ASC";
            }
            return sortDirection;
        }
	}
}

