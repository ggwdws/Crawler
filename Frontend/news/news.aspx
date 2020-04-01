<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="xinwen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>News</title>
    
</head>
<body>
    <form id="form1" runat="server">

        <div>
            Page Number：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Keyword：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" /><asp:Label
                ID="Label2" runat="server" Text=""></asp:Label><br />
            
        </div>
    </form>
</body>
</html>
