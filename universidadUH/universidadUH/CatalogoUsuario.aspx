<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuario.aspx.cs" Inherits="universidadUH.CatalogoUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Universidad UH</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Catalogo de Usuarios</h1>
            <asp:GridView ID="GridView1" runat="server" Height="146px" Width="239px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="Sqlusuarios" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="clave" HeaderText="Clave" SortExpression="clave" />
                    <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="Sqlusuarios" runat="server" ConnectionString="<%$ ConnectionStrings:UHUNIVERSIDADConnectionString %>" DeleteCommand="delete usuario where codigo = @codigo" InsertCommand="insert into usuario (Nombre, clave,edad) values(@nombre,@clave,@edad)" SelectCommand="SELECT * FROM [Usuario] where Codigo= @codigo" UpdateCommand="update usuario set nombre = @nombre, Clave=@clave where codigo = @codigo">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="tcodigo" Name="codigo" PropertyName="Text" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="tnombre" Name="nombre" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tclave" Name="clave" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tedad" Name="edad" PropertyName="Text" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="codigo" PropertyName="SelectedValue" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="tnombre" Name="nombre" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tclave" Name="clave" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tcodigo" Name="codigo" PropertyName="Text" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            Codigo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tcodigo" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tclave" runat="server"></asp:TextBox>
            <br />
            <br />
            Edad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tedad" runat="server"></asp:TextBox>
            <br />
            <br />
            Filtro&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlfiltronombres" DataTextField="Nombre" DataValueField="Codigo" Height="24px" Width="140px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sqlfiltronombres" runat="server" ConnectionString="<%$ ConnectionStrings:UHUNIVERSIDADConnectionString %>" SelectCommand="SELECT [Nombre], [Codigo] FROM [Usuario]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Button ID="bingresar" runat="server" Text="INGRESAR" BackColor="#6699FF" BorderColor="#FF3300" OnClick="bingresar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bborrar" runat="server" Text="BORRAR" BackColor="#66FF66" BorderColor="#FF3300" OnClick="bborrar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bmodificar" runat="server" Text="MODIFICAR" BackColor="#FFCC66" BorderColor="#FF3300" OnClick="bmodificar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bconsulta" runat="server" Height="37px" Text="Consulta" Width="130px" />
            <br />
        </div>
    </form>
</body>
</html>
