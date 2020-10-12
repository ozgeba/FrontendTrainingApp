<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FrontendTrainingApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HOME</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            HTTP STATUS : <asp:Label ID="lblStatus" runat="server"></asp:Label>
            <br /><asp:Label ID="lblFromBackend" runat="server"></asp:Label>
            <br /><asp:TextBox ID="txtInput" runat="server" Text="INPUT"></asp:TextBox>
            <br /><asp:Button ID="btnSend" runat="server" Text="SEND REQUEST" OnClick="btnSend_Click" />
        </div>
    </form>
</body>
</html>
