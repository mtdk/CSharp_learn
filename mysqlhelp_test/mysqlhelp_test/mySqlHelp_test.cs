using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace mysqlhelp_test
{
    public static class mySqlHelp_test
    {
        private static readonly string connStr = "server=127.0.0.1;uid=testqh;pwd=123456;database=mtsystemdb;charset=utf8;";

        //执行增、删、改的方法:ExcuteNonQuery()
        public static int ExcuteNonQuery(string sql, params MySqlParameter[] pms)
        {
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using(MySqlCommand cmd=new MySqlCommand(sql,con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //封装一个执行返回单个对象的方法:ExecuteScalar()
        public static object ExecuteScalar(string sql, params MySqlParameter[] pms)
        {
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //执行查询多行多列数据的方法:ExecuteReader
        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] pms)
        {
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    try
                    {
                        con.Open();
                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }
                    catch (Exception)
                    {
                        con.Close();
                        con.Dispose();
                        throw;
                    }
                }
            }
        }

        //执行返回DataTable的方法
        public static DataTable ExcuteDataTable(string sql, params MySqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connStr))
            {
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
