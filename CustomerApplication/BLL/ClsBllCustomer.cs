using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace CustomerApplication
{
    
    public class ClsBllCustomer
    {
        ClsDalCustomer ObjDal = new ClsDalCustomer();
        private Int32 Var_CustID;
        public Int32 CustID
        {
            get { return Var_CustID; }
            set { Var_CustID = value; }
        }
        private string Var_CustName;
        public string CustName
        {
            get { return Var_CustName; }
            set { Var_CustName = value; }
        }
        private string Var_CustEmail;
        public string CustEmail
        {
            get { return Var_CustEmail; }
            set { Var_CustEmail = value; }
        }
        private Int32 Var_CustPlanID;
        public Int32 CustPlanID
        {
            get { return Var_CustPlanID; }
            set { Var_CustPlanID = value; }
        }
        private string Var_PlanName;
        public string PlanName
        {
            get { return Var_PlanName; }
            set { Var_PlanName = value; }
        }
        private decimal Var_PlanFixedCost;
        public decimal PlanFixedCost
        {
            get { return Var_PlanFixedCost; }
            set { Var_PlanFixedCost = value; }
        }
        private decimal Var_PlanVarCost;
        public decimal PlanVarCost
        {
            get { return Var_PlanVarCost; }
            set { Var_PlanVarCost = value; }
        }
        private DataTable Var_Details;
        public DataTable Details
        {
            get { return Var_Details; }
            set { Var_Details = value; }
        }
        private Int32 Var_PlanId;
        public Int32 PlanId
        {
            get { return Var_PlanId; }
            set { Var_PlanId = value; }
        }
        public void SaveToDB()
        {
            ObjDal.SaveToDB(this);
        }
        public DataTable ReturnDetails()
        {
            return ObjDal.ReturnDetails();
        }
        public int ReturnID()
        {
           return  ObjDal.ReturnID();
        }
        public int ReturnPlanID()
        {
            return ObjDal.ReturnPlanID();
        }
    }
}