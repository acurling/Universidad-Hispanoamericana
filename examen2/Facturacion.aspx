<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="Examen22.Facturacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 138px;
        }
        .auto-style4 {
            width: 123px;
        }
        .auto-style5 {
            width: 138px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 123px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Facturación</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Numero de factura&nbsp; </td>
                <td>
                    <asp:TextBox ID="Tnfactura" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style4">Monto</td>
                <td>
                    <asp:TextBox ID="Tmonto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Codigo de servicio</td>
                <td class="auto-style6">
                    <asp:TextBox ID="Tcodigo" runat="server" Height="16px" Width="120px"></asp:TextBox>
                </td>
                <td class="auto-style7">Descuento</td>
                <td class="auto-style6">
                    <asp:TextBox ID="Tdescuento" runat="server" Height="16px" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Mes</td>
                <td>
                    <asp:TextBox ID="Tmes" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="bagregar" runat="server" OnClick="bagregar_Click" Text="Agregar" />
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="NFactura" DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField DataField="NFactura" HeaderText="NFactura" ReadOnly="True" SortExpression="NFactura" />
                            <asp:BoundField DataField="CodigoServicio" HeaderText="CodigoServicio" SortExpression="CodigoServicio" />
                            <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes" />
                            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
                            <asp:BoundField DataField="Descuento" HeaderText="Descuento" SortExpression="Descuento" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EXAMEN2DBConnectionString2 %>" InsertCommand="INSERT INTO Facturacion(NFactura, CodigoServicio, Mes, Monto, Descuento) values (@NFactura, @CodigoServicio, @Mes, @Monto, @Descuento)" SelectCommand="SELECT * FROM [Facturacion]">
                        <InsertParameters>
                            <asp:ControlParameter ControlID="Tnfactura" Name="NFactura" PropertyName="Text" />
                            <asp:ControlParameter ControlID="Tcodigo" Name="CodigoServicio" PropertyName="Text" />
                            <asp:ControlParameter ControlID="Tmes" Name="Mes" PropertyName="Text" />
                            <asp:ControlParameter ControlID="Tmonto" Name="Monto" PropertyName="Text" />
                            <asp:ControlParameter ControlID="Tdescuento" Name="Descuento" PropertyName="Text" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/53403804-signo-icono-salir-salir-botón-.jpg" OnClick="ImageButton1_Click" />
    </form>
</body>
</html>
