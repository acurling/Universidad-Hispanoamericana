<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sistema.aspx.cs" Inherits="Clase6.sistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Buen dia :  <asp:Label ID="lnombre" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Resultado de la operacion :&nbsp;
            <asp:Label ID="lresultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
