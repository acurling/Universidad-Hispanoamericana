<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Clase6.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="css/Menuestilos.css">

    <title></title>
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
                        Usuarios Articulos Tiendas
                        <br />
                    </div>
                </li>
                <li class="dropdown"></li>
            </ul>
        </div>
        <%-- <footer>Derechos reservados </footer>--%>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Bienvenido :&nbsp;
            <asp:Label ID="lnombre" runat="server"></asp:Label>
        </p>
    </form>
   </body>

</html>
