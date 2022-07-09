<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="Clase6.CatalogoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CaTALOGO DE USUARIOS</title>
    <link rel="stylesheet" type="text/css" href="css/Menuestilos.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

           
            <ul>
                <li><a href="menu.aspx">Inicio</a></li>
                <li><a href="#news">noticias</a></li>
                <li class="dropdown">
                    <a href="javascript:void(0)" class="dropbtn">Catalogo</a>
                    <div class="dropdown-content">
                        <a href="CatalogoUsuarios.aspx">Usuarios</a>
                        <a href="#">Articulos</a>
                        <a href="#">Tiendas</a>
                    </div>
                </li>
            </ul>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UPIConnectionString %>" SelectCommand="SELECT * FROM [USUARIO]"></asp:SqlDataSource>
            <br />
            <br />
            usuario:&nbsp;
            <asp:TextBox ID="tusuario" runat="server"></asp:TextBox>
            <br />
            <br />
            Clave:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tclave" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="bagregar" runat="server" Text="Agregar" OnClick="bagregar_Click" />
    </form>
   <%-- <footer>Derechos reservados </footer>--%>
</body>
</html>
