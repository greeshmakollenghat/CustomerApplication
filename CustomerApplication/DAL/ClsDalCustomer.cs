using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace CustomerApplication
{
    public class ClsDalCustomer : ClsSqlHelp
    {
        public SqlCommand ObjSqlCmd;
        public int CustId;
        public int PlanId;
        public void SaveToDB(ClsBllCustomer ObjBll)
        {
               
            OpenConnection();
            ObjSqlCmd = new SqlCommand("SP_Customer");
            ObjSqlCmd.Connection = dbcon;
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;
            ObjSqlCmd.Parameters.Add("@CustName", SqlDbType.VarChar).Value = ObjBll.CustName;
            ObjSqlCmd.Parameters.Add("@CustEmail", SqlDbType.VarChar).Value = ObjBll.CustEmail;
            ObjSqlCmd.Parameters.Add("@CustPlanID", SqlDbType.Int).Value = ObjBll.CustPlanID;
            ObjSqlCmd.Parameters.Add("@mytable", SqlDbType.Xml).Value = ConvertToXml(ObjBll.Details);
            ObjSqlCmd.Parameters.Add("@Flag", SqlDbType.Int).Value = 1;
            ObjSqlCmd.ExecuteNonQuery();

        }
        public int ReturnID()
        {
            OpenConnection();
            ObjSqlCmd = new SqlCommand("SP_Customer");
            ObjSqlCmd.Connection = dbcon;
            ObjSqlCmd.Parameters.Add("@Flag", SqlDbType.Int).Value = 5;
            DataTable Dt = ReturnTable(ObjSqlCmd);
            foreach(DataRow dr in Dt.Rows)
            {
                CustId = Convert.ToInt32(dr["CuurentID"]);
            }
           return CustId;
        }
        public int ReturnPlanID()
        {
            OpenConnection();
            ObjSqlCmd = new SqlCommand("SP_Customer");
            ObjSqlCmd.Connection = dbcon;
            ObjSqlCmd.Parameters.Add("@Flag", SqlDbType.Int).Value = 6;
            DataTable Dt = ReturnTable(ObjSqlCmd);
            foreach (DataRow dr in Dt.Rows)
            {
                PlanId = Convert.ToInt32(dr["PlanId"]);
            }
            return PlanId;
        }
            private string ConvertToXml(DataTable Details)
        {
            string Result;
            Details.TableName = "Mytable";
            using (StringWriter sw = new StringWriter())
            {
                Details.WriteXml(sw);
                Result = sw.ToString();
            }
            return Result;
        }
        public DataTable ReturnDetails()
        {
            ObjSqlCmd = new SqlCommand("SP_Customer");
            ObjSqlCmd.CommandType = CommandType.StoredProcedure;
            ObjSqlCmd.Parameters.Add("@Flag", SqlDbType.Int).Value = 2;
            return ReturnTable(ObjSqlCmd);
        }
        
    }
}