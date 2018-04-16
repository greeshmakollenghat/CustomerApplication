<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="CustomerApplication.AddCustomer" %>

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
                    <td>Customer Name:</td>
                    <td>
                        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ControlToValidate="TxtName" ForeColor="Red"></asp:RequiredFieldValidator></td>

                </tr>
                <tr>
                    <td>Customer Email:</td>
                    <td>
                        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email Required " ControlToValidate="TxtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="TxtEmail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="ChkPlan" Text="Add Plan For Customers" runat="server" />
                    </td>
                 </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
