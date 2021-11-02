<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="tareafiguras.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            color: #9966FF;
        }
        .auto-style3 {
            width: 1563px;
            height: 660px;
            background-color: #000000;
        }
        .auto-style4 {
            font-size: xx-large;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <span class="auto-style4">&nbsp;Pagina Principal&nbsp;</span><span class="auto-style2"> </span>
        </div>
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <Items>
                <asp:MenuItem Text="Iniciar Prueba" Value="Iniciar Prueba" ImageUrl="~/36248382-iniciar-botón-verde-vidrioso.jpg">
                    <asp:MenuItem NavigateUrl="~/Usuarios.aspx" Text="Usuarios" Value="Usuarios" ImageUrl="~/47147368-user-circular-vector-pink-web-icon-button.jpg"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Preguntas.aspx" Text="Preguntas" Value="Preguntas" ImageUrl="~/png-transparent-super-mario-world-super-mario-3d-world-paper-mario-blocks-angle-heroes-nintendo-thumbnail.png"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Reporte" Value="Reporte" ImageUrl="~/descarga (1).png" NavigateUrl="~/Reporte.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Salir" Value="Salir" ImageUrl="~/53403804-signo-icono-salir-salir-botón-.jpg"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
    </form>
</body>
</html>
