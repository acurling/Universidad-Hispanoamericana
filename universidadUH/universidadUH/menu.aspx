<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="universidadUH.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu principal</title>
    <link rel="stylesheet" type="text/css" href="css/MenuEstilos.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
<ul>
  <li><a href="#home">Inicio</a></li>
  <li><a href="#news">Noticias</a></li>
  <li class="dropdown">
    <a href="javascript:void(0)" class="dropbtn">Catalogo</a>
    <div class="dropdown-content">
      <a href="CatalogoUsuario.aspx">Usuarios</a>
      <a href="#">Articulos</a>
      <a href="#">Empleados</a>
    </div>
  </li>
</ul>
        </div>
    <p>
        &nbsp;</p>
    <p>
        Bienvenido :&nbsp;
        <asp:Label ID="lusuario" runat="server" Font-Size="X-Large"></asp:Label>
        </p>

    </form>

    <button class="button button1">Ingresar</button>
    <button class="button button2">Borrar</button>
    <button class="button button5">Modificar</button>
     
    <footer>  Derechos reservados 2022 UH </footer>
</body>

  
</html>
