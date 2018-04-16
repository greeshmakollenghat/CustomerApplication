using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CustomerApplication
{
    public partial class AddPlan : System.Web.UI.Page
    {
        ClsBllCustomer ObjBll = new ClsBllCustomer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            ObjBll.PlanName = TxtPlanName.Text;
            ObjBll.PlanFixedCost = Convert.ToDecimal(TxtFixedCost.Text);
            ObjBll.PlanVarCost = Convert.ToDecimal(TxtVarCost.Text);
            if (Session["PlanID"]==null)
            {
                int PlanId = ObjBll.ReturnPlanID();
               
                ObjBll.PlanId = PlanId;
                ObjBll.CustName = "";
                ObjBll.CustEmail = "";
                ObjBll.CustPlanID = PlanId;
                DataTable dt = new DataTable();
                dt.Columns.Add("PlanId", typeof(int));
                dt.Columns.Add("PlanName", typeof(string));
                dt.Columns.Add("PlanFixedCost", typeof(decimal));
                dt.Columns.Add("PlanVarCost", typeof(decimal));
                DataRow dr = dt.NewRow();
                dr["PlanName"] = ObjBll.PlanName;
                dr["PlanFixedCost"] = ObjBll.PlanFixedCost;
                dr["PlanVarCost"] = ObjBll.PlanVarCost;
                dt.Rows.Add(dr);
                ObjBll.CustName = ObjBll.CustName;
                ObjBll.CustEmail = ObjBll.CustEmail;
                ObjBll.CustPlanID = ObjBll.CustPlanID;
                ObjBll.Details = dt;
                ObjBll.SaveToDB();
                ClearControls();
                Response.Redirect("ListCustomersAndPlans.aspx");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("PlanName", typeof(string));
                dt.Columns.Add("PlanFixedCost", typeof(decimal));
                dt.Columns.Add("PlanVarCost", typeof(decimal));
                DataRow dr = dt.NewRow();
                dr["PlanName"] = ObjBll.PlanName;
                dr["PlanFixedCost"] = ObjBll.PlanFixedCost;
                dr["PlanVarCost"] = ObjBll.PlanVarCost;
                dt.Rows.Add(dr);
                ObjBll.CustName = Session["Name"].ToString();
                ObjBll.CustEmail = Session["Email"].ToString();
                //if (Session["PlanID"] != "")
                //{
                    ObjBll.CustPlanID = Convert.ToInt32(Session["PlanID"]);
                    ObjBll.Details = dt;
                    ObjBll.SaveToDB();
                //}
                ClearControls();
                Response.Redirect("ListCustomersAndPlans.aspx");
            }
        }
        private void ClearControls()
        {
            TxtPlanName.Text = "";
            TxtFixedCost.Text = "";
            TxtVarCost.Text = "";

                Session["Name"] = "";
                Session["Email"] = "";
                Session["PlanID"] = "";
            Session.Clear();
            
        }
    }
}