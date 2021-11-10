<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Clase8Ejemplotarea.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            PRUEBA PSICOLOGICA
            <br />
            <br />
            <asp:Label ID="label1" runat="server" Text="Nombre:  "></asp:Label>
            <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
        
            <br />  
            <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tedad" runat="server" Height="22px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Genero"></asp:Label>
            :&nbsp;
            <asp:DropDownList ID="dgenero" runat="server">
                <asp:ListItem Selected="True">Femenino</asp:ListItem>
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Otro</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />

            <asp:Button ID="BINICIAR" runat="server" Text="INICIO" Height="68px" OnClick="BINICIAR_Click" Width="113px" />
        </div>
    </form>
</body>
</html>
