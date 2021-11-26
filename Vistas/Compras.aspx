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
            <asp:Label ID="Lblusuario" runat="server"></asp:Label>
            <br />
        </div>
        <asp:Label ID="lblFacturas" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="False" Text="Facturas"></asp:Label>
        <asp:GridView ID="gvfacturas" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvfacturas_SelectedIndexChanging" Width="438px" OnSelectedIndexChanged="gvfacturas_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="N Factura">
                    <ItemTemplate>
                        <asp:Label ID="Lbl_it_Nfactura" runat="server" Text='<%# Bind("Cod_Venta_V") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Codigo de Cliente">
                    <ItemTemplate>
                        <asp:Label ID="Lbl_it_CC" runat="server" Text='<%# Bind("Cod_Cliente_V") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total de La compra">
                    <ItemTemplate>
                        <asp:Label ID="Lbl_it_TF" runat="server" Text='<%# Bind("TotalFactura_V") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha">
                    <ItemTemplate>
                        <asp:Label ID="Llb_it_Fecha" runat="server" Text='<%# Bind("FechaFactura_V") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="Lbl_Fdetalles" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Detalles de Factura" Visible="False"></asp:Label>
        <asp:GridView ID="gvDfacturas" runat="server" Visible="False">
        </asp:GridView>
    </form>
</body>
</html>
