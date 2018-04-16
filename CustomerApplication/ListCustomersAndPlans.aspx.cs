using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerApplication
{
    public partial class ListCustomersAndPlans : System.Web.UI.Page
    {
        ClsBllCustomer ObjBll = new ClsBllCustomer();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ObjBll.ReturnDetails();
            GridView1.DataBind();
        }
    }
}