<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news5.aspx.cs" Inherits="xinwen5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>News</title>
    <style type="text/css">
			* {
				margin: 0;
				padding: 0;
			}
			
			.wrap {
				width: 600px;
				margin: 0px auto;
			}
			
			.menu {
				width: 600px;
				height: 20px;
				
				position: sticky;
				top: 0px;
			}
			
			.menu ul li {
				float: left;
				list-style-type: none;
				padding: 0 40px;
			}
			
			.content ul li img:hover {
				transform: scale(1.2);
			}
			
			.content ul li {
				height: 110px;
				overflow: hidden;
				border-bottom: 1px solid lavender;
				background: white;
				list-style-type: none;
				transition-duration: 0.5s;
				margin: 10px 10px 5px 0;
			}
			
			.content ul li:hover {
				background-color: lavender;
				transition-duration: 0.5s;
			}
			
			.content .left {
				overflow: hidden;
				transition-duration: 0.5s;
				width: 140px;
				height: 80px;
				/*background: green;*/
				float: left;
				margin-right: 20px;
			}
			
			.content .right {
				width: 400px;
				float: left;
				/*background: pink;*/
			}
			
			.right_top {
				height: 60px;
			}
			
			.right_bottom {
				margin_top: 50px;
			}
			
			.right_bottom_left span {
				color: blue;
				font-size: 12px;
			}
		</style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="wrap">
            <div class="menu">
                <ul>
                    <li>&nbsp;</li>
                    <li>&nbsp;</li>
                    <li>
                        <asp:Button ID="Button1" runat="server" Text="Search Again" Style="width: 100px; height: 20px;"
                            OnClick="Button1_Click" />
                    </li>
                    <li>&nbsp;</li>
                    <li>&nbsp;</li>
                </ul>
            </div>
            <div class="content">
                <ul>
                    <li style="height: 40px; font-size: 32px; text-align: center;">CGTN</li>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <li style="height: 40px; font-size: 32px; text-align: center;">GitHub</li>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
