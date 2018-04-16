using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace CustomerApplication
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        ClsBllCustomer Objbll = new ClsBllCustomer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Objbll.CustName = TxtName.Text;
            Objbll.CustEmail = TxtEmail.Text;
            int id = Objbll.ReturnID();

            Objbll.CustPlanID = id;
            if (ChkPlan.Checked==true)
            {
                Session["Name"] = Objbll.CustName;
                Session["Email"] = Objbll.CustEmail;
                Session["PlanID"] = Objbll.CustPlanID;
                Response.Redirect("~/AddPlan.aspx");
            }
            else
            {
                Objbll.PlanName = null;
                Objbll.PlanFixedCost = 0;
                Objbll.PlanVarCost = 0;
                DataTable dt = new DataTable();
                dt.Columns.Add("CustPlanID", typeof(int));
                dt.Columns.Add("PlanName", typeof(string));
                dt.Columns.Add("PlanFixedCost", typeof(decimal));
                dt.Columns.Add("PlanVarCost", typeof(decimal));
                DataRow dr = dt.NewRow();
                dr["CustPlanID"] = Objbll.CustPlanID;
                dr["PlanName"] = Objbll.PlanName;
                dr["PlanFixedCost"] = Objbll.PlanFixedCost;
                dr["PlanVarCost"] = Objbll.PlanVarCost;
                dt.Rows.Add(dr);
                Objbll.Details = dt;
                Objbll.SaveToDB();
                ClearControls();
                Response.Redirect("ListCustomersAndPlans.aspx");
            }
        }
        private void ClearControls()
        {
            TxtName.Text = "";
            TxtEmail.Text = "";
        }
    }
}