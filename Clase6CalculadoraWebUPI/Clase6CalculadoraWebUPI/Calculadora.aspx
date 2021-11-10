<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Clase6CalculadoraWebUPI.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            font-size: large;
            color: #FF0066;
            height: 24px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">CALCULADORA WEB</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Lusuario" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="86px" ImageUrl="~/homeicono.png" OnClick="ImageButton1_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="73px" ImageUrl="~/iconocorreo.jpg" OnClick="ImageButton2_Click" Width="84px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Numero1"></asp:Label>
&nbsp;:&nbsp;&nbsp;
            <asp:TextBox ID="tvalor1" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero2"></asp:Label>
&nbsp;:&nbsp;&nbsp;
            <asp:TextBox ID="tvalor2" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="LRES" runat="server" Text="Resultado:"></asp:Label>
            &nbsp;
            <asp:Label ID="lresultado" runat="server" Font-Size="Large" Font-Strikeout="False" Font-Underline="False" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            INDIQUE COMO DESEA HACER LA OPERACION&nbsp;&nbsp;
            <asp:RadioButton ID="R1" Text="Radio Button"  runat="server" AutoPostBack="True" Checked="True" GroupName="op1" OnCheckedChanged="R1_CheckedChanged" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="R2" Text="CheckBox" runat="server" AutoPostBack="True" GroupName="op1" OnCheckedChanged="R2_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="R3" Text="Dropdownlist" runat="server" AutoPostBack="True" GroupName="op1" OnCheckedChanged="R3_CheckedChanged" />
            <br />
            <br />
            <asp:Button ID="bcalcular" runat="server" Height="65px" Text="Calcular" Width="147px" OnClick="bcalcular_Click" />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="csuma" Text="Suma" runat="server" />
            <br />
            <asp:CheckBox ID="cresta" Text="Resta" runat="server" />
            <br />
            ----------------------<br />
            <asp:RadioButton ID="rsuma" Text="SUMA" runat="server" GroupName="OPERACIONES" Checked="True" />
            <br />
            <asp:RadioButton ID="rresta" Text="RESTA" runat="server" GroupName="OPERACIONES" />
            <br />
            -----------------------------<br />
            <asp:DropDownList ID="Doperaciones" runat="server" Height="37px" Width="150px">
                <asp:ListItem>SUMA</asp:ListItem>
                <asp:ListItem Selected="True">RESTA</asp:ListItem>
                <asp:ListItem>MULTIPLICACION</asp:ListItem>
                <asp:ListItem>DIVISION</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
