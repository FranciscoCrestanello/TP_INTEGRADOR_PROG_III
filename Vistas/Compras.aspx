<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="Vistas.Compras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFacturas" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="False" Text="Facturas"></asp:Label>
        <asp:GridView ID="gvfacturas" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
