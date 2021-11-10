<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contactenos.aspx.cs" Inherits="Clase6CalculadoraWebUPI.EnviarCorreos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            PARA:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tpara" runat="server" Height="31px" Width="285px"></asp:TextBox>
            <br />
            <br />
            <br />
            MENSAJE:<br />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tmensaje" runat="server" Height="153px" TextMode="MultiLine" Width="557px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Bemvoar" runat="server" Height="72px" OnClick="Bemvoar_Click" Text="Enviar" Width="146px" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
