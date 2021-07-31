using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsApp1
{
    public class sqlhelper
    {
        public static DataTable GetDataTable(string sql, params SqlParameter[] paras)
        {

            DataTable dt = new DataTable();
            string connString = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (paras != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(paras);
                }

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            return dt;
        }
    }
}
