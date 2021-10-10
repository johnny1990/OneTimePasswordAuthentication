<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="OneTimePasswordAppAuthentication.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login succesfully!!!!! Token Works for&nbsp;
            <asp:Label ID="Label1" runat="server" ></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to Main Page" />
            <br />
        </div>
    </form>
</body>
</html>
