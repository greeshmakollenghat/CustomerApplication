using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CustomerApplication
{
    public class ClsSqlHelp
    {
        public SqlConnection dbcon;
        public DataTable ObjTable;
        public SqlDataAdapter ObjAdapter;
        public void OpenConnection()
        {
             dbcon =new SqlConnection( ConfigurationManager.ConnectionStrings["Varcon"].ToString());
            if(dbcon.State==ConnectionState.Closed)
            {
                dbcon.Open();
            }
            else
            {
                dbcon.Close();
            }
        }
        public DataTable ReturnTable(SqlCommand ObjSqlCmd)
        {
            OpenConnection();
            ObjSqlCmd.Connection = dbcon;
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;
            ObjTable = new DataTable();
            ObjAdapter = new SqlDataAdapter(ObjSqlCmd);
            ObjAdapter.Fill(ObjTable);
            return ObjTable;
        }
    }
}