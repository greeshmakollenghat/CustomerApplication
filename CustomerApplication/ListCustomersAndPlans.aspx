<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCustomersAndPlans.aspx.cs" Inherits="CustomerApplication.ListCustomersAndPlans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddCustomer.aspx" >Add Customer</asp:HyperLink> |
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AddPlan.aspx" >Add Plan</asp:HyperLink>
        </div>
    </form>
</body>
</html>
