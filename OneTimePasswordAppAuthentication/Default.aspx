<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OneTimePasswordAppAuthentication._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            UserId: <asp:TextBox ID="TextBoxUserId" runat="server" style="margin-left: 27px" Width="157px"></asp:TextBox>
            <br />
            DateTime:<asp:TextBox ID="TextBoxDateTime" runat="server" style="margin-left: 14px" Width="155px"></asp:TextBox>
            <br />
            <br />
       
            <asp:RadioButtonList ID="rbType" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Alphanumeric token" Value="1" Selected="True" />
                <asp:ListItem Text="Numeric token" Value="2" />
            </asp:RadioButtonList>
      
    
            <br />
      
    
            <asp:Button ID="btnGenerate" Text="Generate OTP" runat="server" OnClick="GenerateOTP" />
 
 
            OTP:
            <asp:Label ID="lblOTP" runat="server" />


            <br />
            <asp:Label ID="LBl30Seconds" runat="server" ></asp:Label>
            <br />
            <br />
            Token:
            <asp:TextBox ID="TextBoxValidateToken" runat="server" style="margin-left: 11px" Width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ValidateOTP" runat="server" Text="Validate OTP Token" Width="136px" OnClick="ValidateOTP_Click" />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <br />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Label ID="TimerTick" runat="server" Interval="1000"></asp:Label>
            <br />


        </div>
        <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick">
        </asp:Timer>
    </form>
</body>
</html>

