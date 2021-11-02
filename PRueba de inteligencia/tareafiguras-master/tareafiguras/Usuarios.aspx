<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="tareafiguras.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 108%;
            height: 336px;
        }
        .auto-style2 {
            font-size: xx-large;
            color: #003399;
            background-color: #009933;
        }
        .auto-style3 {
            width: 544px;
            background-color: #009933;
        }
        .auto-style4 {
            width: 544px;
            height: 284px;
            background-color: #669900;
        }
        .auto-style5 {
            height: 284px;
            background-color: #669900;
        }
        .auto-style6 {
            color: #FFFFFF;
        }
        .auto-style7 {
            background-color: #009933;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            Catalogo de usuarios</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"><span class="auto-style6">Nombre :</span><asp:TextBox ID="tnombre" runat="server" BorderColor="Black" CssClass="auto-style6" OnTextChanged="tnombre_TextChanged" ForeColor="Black"></asp:TextBox>
                    <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Genero :</span><asp:TextBox ID="tgenero" runat="server" BorderColor="Black" CssClass="auto-style6" Height="19px" Width="135px" ForeColor="Black"></asp:TextBox>
                    <br class="auto-style6" />
                    <br class="auto-style6" />
                    <br class="auto-style6" />
                    <span class="auto-style6">Cedula :&nbsp; </span>
                    <asp:TextBox ID="tcedula" runat="server" BorderColor="Black" CssClass="auto-style6" Width="119px" ForeColor="Black"></asp:TextBox>
                    <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fecha :</span><asp:TextBox ID="tfecha" runat="server" BorderColor="#333333" CssClass="auto-style6" Height="18px" Width="125px" ForeColor="Black"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cedula" DataSourceID="SqlDataUsuarios" Height="178px" Width="273px">
                        <Columns>
                            <asp:BoundField DataField="Cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="Cedula" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                            <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="bagregar" runat="server" BackColor="Silver" BorderColor="#99FF66" OnClick="Button1_Click" Text="Agregar" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="bborrar" runat="server" BackColor="#CCCCCC" BorderColor="#99FF66" OnClick="bborrar_Click" Text="Borrar" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="bmodificar" runat="server" BackColor="#999999" BorderColor="#66FF33" OnClick="bmodificar_Click" Text="Modificar" />
&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style7">
                    <asp:SqlDataSource ID="SqlDataUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:CUESTIONARIOConnectionString %>" DeleteCommand="DELETE USUARIOS WHERE Cedula = @Cedula" InsertCommand="INSERT INTO USUARIOS (Cedula,Nombre,Genero,Fecha) values (@Cedula, @Nombre, @Genero, @Fecha)" OnSelecting="SqlDataUsuarios_Selecting" SelectCommand="SELECT * FROM [USUARIOS]" UpdateCommand="UPDATE USUARIOS SET Nombre = @Nombre, Genero = @Genero WHERE Cedula = @Cedula">
                        <DeleteParameters>
                            <asp:ControlParameter ControlID="tcedula" Name="Cedula" PropertyName="Text" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:ControlParameter ControlID="tcedula" Name="Cedula" PropertyName="Text" />
                            <asp:ControlParameter ControlID="tnombre" Name="Nombre" PropertyName="Text" />
                            <asp:ControlParameter ControlID="tgenero" Name="Genero" PropertyName="Text" />
                            <asp:ControlParameter ControlID="tfecha" Name="Fecha" PropertyName="Text" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:ControlParameter ControlID="tnombre" Name="Nombre" PropertyName="Text" />
                            <asp:ControlParameter ControlID="tgenero" Name="Genero" PropertyName="Text" />
                            <asp:ControlParameter ControlID="tcedula" Name="Cedula" PropertyName="Text" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem ImageUrl="~/6560334-un-botón-verde-con-la-palabra-inicio-en-ella-.jpg" NavigateUrl="~/Inicio.aspx" Text="Inicio" Value="Inicio"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
    </form>
</body>
</html>
