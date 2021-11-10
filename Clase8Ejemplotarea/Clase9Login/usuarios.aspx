<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="Clase9Login.usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Usuarios</title>
    <link rel="stylesheet" type="text/css" href="css/menucss.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <ul>
 <li><a href="menu.aspx">INICIO</a></li>
  <li><a href="#news">FACTURACION</a></li>
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
            <br />
            <br />
            CATALOGO DE USUARIOS

            <br />  
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            <br />

            CORREO:<asp:TextBox ID="TCORREO" runat="server"></asp:TextBox>
            CONTRASENA: <asp:TextBox ID="TCONTRASENA" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="BCONTINUAR" runat="server" Text="Agregar" />

        </div>
    </form>
</body>
</html>
