<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="157px" Width="651px">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Text="Press To check" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="49px" OnClick="Button2_Click" Text="Press to Continue" Width="325px" />
        <br />
    
    </div>
    </form>
</body>
</html>
