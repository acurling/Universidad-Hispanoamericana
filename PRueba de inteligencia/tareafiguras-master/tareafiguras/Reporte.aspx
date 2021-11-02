<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="tareafiguras.Reporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #FFFFFF;
            text-align: center;
            background-color: #000000;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 0px;
            background-color: #000000;
        }
        .auto-style4 {
            width: 328px;
        }
        .auto-style5 {
            width: 328px;
            height: 244px;
            background-color: #000000;
        }
        .auto-style6 {
            height: 244px;
            background-color: #000000;
        }
        .auto-style7 {
            background-color: #000000;
        }
        .auto-style8 {
            width: 100%;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            REPORTE DE ESTADISTICAS</div>
        <table class="auto-style2">
            <tr>
                <td>
                    <table class="auto-style8">
                        <tr>
                            <td class="auto-style5">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" CssClass="auto-style7" DataKeyNames="Cedula" DataSourceID="SqlDataSource3" GridLines="Horizontal" Height="207px" Width="333px">
                                    <Columns>
                                        <asp:BoundField DataField="Cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="Cedula" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                        <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                                    </Columns>
                                    <FooterStyle BackColor="White" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#487575" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#275353" />
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CUESTIONARIOConnectionString %>" SelectCommand="SELECT * FROM [USUARIOS]"></asp:SqlDataSource>
                            </td>
                            <td class="auto-style6">
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" CssClass="auto-style3" DataSourceID="SqlDataSource2" GridLines="Horizontal" Height="205px" Width="337px">
                                    <Columns>
                                        <asp:BoundField DataField="RespuestaA" HeaderText="RespuestaA" SortExpression="RespuestaA" />
                                        <asp:BoundField DataField="RespuestaB" HeaderText="RespuestaB" SortExpression="RespuestaB" />
                                        <asp:BoundField DataField="RespuestaC" HeaderText="RespuestaC" SortExpression="RespuestaC" />
                                    </Columns>
                                    <FooterStyle BackColor="White" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#487575" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#275353" />
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CUESTIONARIOConnectionString %>" SelectCommand="SELECT * FROM [RESPUESTA]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                                    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <DynamicMenuStyle BackColor="#FFFBD6" />
                                    <DynamicSelectedStyle BackColor="#FFCC66" />
                                    <Items>
                                        <asp:MenuItem ImageUrl="~/6560334-un-botón-verde-con-la-palabra-inicio-en-ella-.jpg" NavigateUrl="~/Inicio.aspx" Text="Inicio" Value="Inicio"></asp:MenuItem>
                                    </Items>
                                    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <StaticSelectedStyle BackColor="#FFCC66" />
                                </asp:Menu>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
