<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="auto-style1">Username: </span>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1"></asp:TextBox>
        <br class="auto-style1" />
        <span class="auto-style1">Password:&nbsp; </span>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        </strong>
        <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Login" Width="347px" />
    
        <br />
    
    </div>
    </form>
</body>
</html>
