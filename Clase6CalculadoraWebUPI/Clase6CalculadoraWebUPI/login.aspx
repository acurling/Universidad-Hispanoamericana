<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Clase6CalculadoraWebUPI.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body {
            background-image: url("Fondo3.jpg");
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #FFFFFF;
            text-align: center;
            font-size: xx-large;
            background-color: #99CCFF;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="5"><strong>INGRESO AL SISTEMA<br />
                        <br />
                        <asp:Image ID="Image1" runat="server" Height="116px" ImageUrl="~/imauser.png" />
                        </strong></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="3" rowspan="2" class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
&nbsp;&nbsp;
                        <asp:TextBox ID="tusuario" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="tclave" runat="server" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:Label ID="lmensaje" runat="server" ForeColor="Red"></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="bingresar" runat="server" Height="52px" OnClick="bingresar_Click" Text="INGRESAR" Width="134px" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
