<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Clase9Login.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/menucss.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
  <li><a href="menu.aspx">INICIO</a></li>
  <li><a href="inicio.aspx">FACTURACION</a></li>
  <li class="dropdown">
    <a href="javascript:void(0)" class="dropbtn">CATALOGO</a>
    <div class="dropdown-content">
      <a href="#">SERVICIOS</a>
      <a href="usuarios.aspx">USUARIOS</a>
      <a href="#">EMPLEADOS</a>
      <a href="#">CLIENTES</a>
      <a href="#">RUTINAS</a>
   <li><a href="#news">CONTACTOS</a></li>
    </div>
  </li>
</ul>


        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LUSUARIO" runat="server" Font-Size="XX-Large" ForeColor="#009900"></asp:Label>
        </p>
    </form>
</body>
</html>
