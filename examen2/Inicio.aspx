<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen22.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #000000;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Servicios publicos</div>
        <table class="auto-style3">
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="75px" ImageUrl="~/agua.png" OnClick="ImageButton1_Click" Width="65px" />
                    <asp:ImageButton ID="ImageButton4" runat="server" CssClass="auto-style2" Height="71px" ImageUrl="~/cable.jpg" OnClick="ImageButton4_Click" Width="62px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="Tnombre" runat="server" Height="17px" Width="154px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cedula :
                    <asp:TextBox ID="Tcedula" runat="server" Height="19px" Width="137px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="68px" ImageUrl="~/cel.png" OnClick="ImageButton3_Click" Width="66px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="68px" ImageUrl="~/luz.png" Width="58px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="Tdireccion" runat="server" Height="18px" OnTextChanged="TextBox3_TextChanged" Width="157px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono :
                    <asp:TextBox ID="Ttelefono" runat="server" Height="22px" Width="133px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p class="auto-style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bagregar" runat="server" OnClick="bagregar_Click" Text="Agregar" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Cedula" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="Cedula" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EXAMEN2DBConnectionString %>" InsertCommand="INSERT INTO Clientes (Cedula,Nombre,Telefono,Direccion) values (@Cedula, @Nombre, @Telefono,@Direccion)" SelectCommand="SELECT * FROM [Clientes]">
            <InsertParameters>
                <asp:ControlParameter ControlID="Tcedula" Name="Cedula" PropertyName="Text" />
                <asp:ControlParameter ControlID="Tnombre" Name="Nombre" PropertyName="Text" />
                <asp:ControlParameter ControlID="Ttelefono" Name="Telefono" PropertyName="Text" />
                <asp:ControlParameter ControlID="Tdireccion" Name="Direccion" PropertyName="Text" />
            </InsertParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
