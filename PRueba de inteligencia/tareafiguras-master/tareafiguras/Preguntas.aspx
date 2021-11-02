<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preguntas.aspx.cs" Inherits="tareafiguras.Preguntas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #000000;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
            background-color: #000000;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style6 {
            height: 23px;
            width: 419px;
            background-color: #000000;
        }
        .auto-style7 {
            color: #CC0000;
        }
        .auto-style8 {
            color: #FF0000;
        }
        .auto-style9 {
            background-color: #000000;
        }
        .auto-style10 {
            width: 419px;
            background-color: #000000;
        }
        .auto-style11 {
            color: #FFFFFF;
            font-size: medium;
        }
        .auto-style12 {
            color: #FFFFFF;
        }
        .auto-style13 {
            color: #FF0000;
            background-color: #000000;
        }
        .auto-style14 {
            color: #FFFFFF;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Formulario de Preguntas</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style10">
                    <br />
                    <span class="auto-style11">A</span><br class="auto-style11" />
                    <br class="auto-style11" />
                    <br class="auto-style11" />
                    <span class="auto-style11">Elija La figura faltante?</span><br class="auto-style7" />
                    <br class="auto-style7" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="bA" runat="server" OnClick="Button1_Click" Text="Agregar" BackColor="#CCCCCC" BorderColor="White" ForeColor="Blue" />
                </td>
                <td class="auto-style9">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style4" Height="281px" ImageUrl="~/figura 1.png" Width="356px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><span class="auto-style12">Respuesta</span>&nbsp; =&nbsp;&nbsp;
                    <asp:TextBox ID="RrespuestaA" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="153px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"><strong><span class="auto-style12">B</span><br class="auto-style12" />
                    <br class="auto-style12" />
                    <span class="auto-style12">&nbsp;
                    </span>
                    <br class="auto-style12" />
                    <br class="auto-style12" />
                    <br class="auto-style12" />
                    </strong><span class="auto-style12">Elija La figura faltante?&nbsp;&nbsp;&nbsp;&nbsp;
                    </span>
                    <br class="auto-style12" />
&nbsp;<br class="auto-style8" />
                    <br class="auto-style8" />
                    <br class="auto-style8" />
                    <br />
                    <asp:Button ID="bB" runat="server" Text="Agregar" BackColor="#CCCCCC" BorderColor="White" ForeColor="#0066FF" />
                </td>
                <td class="auto-style9">
                    <asp:Image ID="Image2" runat="server" Height="284px" ImageUrl="~/figura 2.png" Width="374px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10"><span class="auto-style12">Respuesta&nbsp; =&nbsp;</span>&nbsp;
                    <asp:TextBox ID="RrespuestaB" runat="server" Height="20px" Width="153px"></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"><span class="auto-style14">C</span><br class="auto-style14" />
                    <br class="auto-style14" />
                    <br class="auto-style14" />
                    <span class="auto-style14">Elija La figura faltante?&nbsp;
                    </span>
                    <br class="auto-style14" />
                    <br class="auto-style14" />
                    <br class="auto-style14" />
                    <br class="auto-style13" />
                    <br class="auto-style9" />
                    <br class="auto-style9" />
                    <asp:Button ID="bC" runat="server" Text="Agregar" BackColor="#CCCCCC" BorderColor="White" CssClass="auto-style9" ForeColor="#0066FF" OnClick="bC_Click" />
                </td>
                <td class="auto-style9">
                    <asp:Image ID="Image3" runat="server" Height="229px" ImageUrl="~/figura 3.png" Width="361px" CssClass="auto-style9" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10"><span class="auto-style12">Respuesta&nbsp; =</span>&nbsp;&nbsp;
                    <asp:TextBox ID="Rrespuestac" runat="server" Height="20px" Width="153px"></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#FFFBD6" />
                        <DynamicSelectedStyle BackColor="#FFCC66" />
                        <Items>
                            <asp:MenuItem ImageUrl="~/6560334-un-botón-verde-con-la-palabra-inicio-en-ella-.jpg" NavigateUrl="~/Inicio.aspx" Text="Inicio" Value="Inicio"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#FFCC66" />
                    </asp:Menu>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CUESTIONARIOConnectionString %>" InsertCommand="INSERT INTO RESPUESTA (RespuestaA,RespuestaB,RespuestaC) values (@RespuestaA,@RespuestaB,@RespuestaC)" SelectCommand="SELECT * FROM [RESPUESTA]">
            <InsertParameters>
                <asp:ControlParameter ControlID="RrespuestaA" Name="RespuestaA" PropertyName="Text" />
                <asp:ControlParameter ControlID="RrespuestaB" Name="RespuestaB" PropertyName="Text" />
                <asp:ControlParameter ControlID="Rrespuestac" Name="RespuestaC" PropertyName="Text" />
            </InsertParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
