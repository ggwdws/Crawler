using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class D_SQL_Common_TongGao
{
    public static string ConnString = "Data Source = 192.1.120.4;Initial Catalog = 网站管理;User Id = wzdl;Password = dkbwz;";
    public static void PrepareCommand(SqlConnection conn, SqlCommand cmd, string cmdText)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = cmdText;
    }
    public static DataTable ReadDataTable(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);

            SqlDataReader odr = cmd.ExecuteReader();
            DataTable dt = new DataTable("0");
            for (int i = 0; i < odr.VisibleFieldCount; i++)
                dt.Columns.Add(odr.GetName(i), typeof(string));
            while (odr.Read())
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < odr.VisibleFieldCount; i++)
                    dr[i] = odr[i].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
    public static int GetExecuteNonQuery(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            return cmd.ExecuteNonQuery();
        }
    }
    public static bool Exist(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            SqlDataReader odr = cmd.ExecuteReader();
            return odr.Read();
        }
    }
    #endregion
}

public class D_SQL_Common_ZhongXin
{
    public static string ConnString = "Data Source = 192.1.120.4;Initial Catalog = 利润成本;User Id = lrcb;Password = liruncb;";
    public static void PrepareCommand(SqlConnection conn, SqlCommand cmd, string cmdText)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = cmdText;
    }
    public static DataTable ReadDataTable(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);

            SqlDataReader odr = cmd.ExecuteReader();
            DataTable dt = new DataTable("0");
            for (int i = 0; i < odr.VisibleFieldCount; i++)
                dt.Columns.Add(odr.GetName(i), typeof(string));
            while (odr.Read())
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < odr.VisibleFieldCount; i++)
                    dr[i] = odr[i].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
    public static int GetExecuteNonQuery(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            return cmd.ExecuteNonQuery();
        }
    }
    public static bool Exist(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            SqlDataReader odr = cmd.ExecuteReader();
            return odr.Read();
        }
    }
    #endregion
}

public class D_SQL_Common_DongLi
{
    public static string ConnString = "Data Source = 192.1.120.4;Initial Catalog = 网站管理;User Id = sa;Password = 94321000;";
    public static void PrepareCommand(SqlConnection conn, SqlCommand cmd, string cmdText)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = cmdText;
    }
    public static DataTable ReadDataTable(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);

            SqlDataReader odr = cmd.ExecuteReader();
            DataTable dt = new DataTable("0");
            for (int i = 0; i < odr.VisibleFieldCount; i++)
                dt.Columns.Add(odr.GetName(i), typeof(string));
            while (odr.Read())
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < odr.VisibleFieldCount; i++)
                    dr[i] = odr[i].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
    public static int GetExecuteNonQuery(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            return cmd.ExecuteNonQuery();
        }
    }
    public static bool Exist(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            SqlDataReader odr = cmd.ExecuteReader();
            return odr.Read();
        }
    }
    #endregion
}

public class D_SQL_Common_ZiDongHua
{
    public static string ConnString = "Data Source = 192.1.66.2;Initial Catalog = wuzi;User Id = sa;Password = hutianmin;";
    public static void PrepareCommand(SqlConnection conn, SqlCommand cmd, string cmdText)
    {
        if (conn.State != ConnectionState.Open)
            conn.Open();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = cmdText;
    }
    public static DataTable ReadDataTable(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);

            SqlDataReader odr = cmd.ExecuteReader();
            DataTable dt = new DataTable("0");
            for (int i = 0; i < odr.VisibleFieldCount; i++)
                dt.Columns.Add(odr.GetName(i), typeof(string));
            while (odr.Read())
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < odr.VisibleFieldCount; i++)
                    dr[i] = odr[i].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
    public static int GetExecuteNonQuery(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            return cmd.ExecuteNonQuery();
        }
    }
    public static bool Exist(string strSQL)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(conn, cmd, strSQL);
            SqlDataReader odr = cmd.ExecuteReader();
            return odr.Read();
        }
    }
    #endregion
}
