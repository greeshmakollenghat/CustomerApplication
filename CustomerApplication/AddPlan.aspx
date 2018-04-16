<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPlan.aspx.cs" Inherits="CustomerApplication.AddPlan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <table>
                <tr>
                   <td>Plan Name:</td>
                    <td>
                        <asp:TextBox ID="TxtPlanName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Plan Name Required" ControlToValidate="TxtPlanName" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                   <td>PlanFixedCost:</td>
                    <td>
                        <asp:TextBox ID="TxtFixedCost" runat="server"></asp:TextBox></td>
                </tr>
                   <tr>
                   <td>PlanVarCost:</td>
                    <td>
                        <asp:TextBox ID="TxtVarCost" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
