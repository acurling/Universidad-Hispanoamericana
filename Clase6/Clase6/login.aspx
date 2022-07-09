<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Clase6.login" %>

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
            <br />

            Usuario :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:TextBox ID="tusuario" runat="server"></asp:TextBox>
            <br />
            <br />
            Contraseña:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tclave" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Valor1:<asp:TextBox ID="tvalor1" runat="server"></asp:TextBox>
            <br />
            <br />
            Valor2:
            <asp:TextBox ID="tvalor2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="rsuma" runat="server" Text="Suma" GroupName="operadores" />
            <br />
            <br />
            <asp:RadioButton ID="rresta" runat="server" Text="Resta" GroupName="operadores" />
            <br />
            <br />
        </div>
        
        <div>
            <asp:Button ID="bingresar" runat="server" Text="Ingresa" Height="40px" OnClick="bingresar_Click" Width="103px" />

            <br />
            <br />
            <br />
            nombre:  
            &nbsp;&nbsp;&nbsp;
            <br />

            <br >
             &nbsp;&nbsp;&nbsp;
            <br />  
            <br />

             &nbsp;&nbsp;&nbsp;
           

            <br />
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="Sqlusuario" GridLines="Horizontal" Height="209px" Width="331px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <asp:SqlDataSource ID="Sqlusuario" runat="server" ConnectionString="<%$ ConnectionStrings:UPIConnectionString %>" SelectCommand="SELECT * FROM [USUARIO]" DeleteCommand="delete usuario where codigo = @codigo" InsertCommand="Insert into USUARIO (nombre, clave) values (@nombre, @clave)" UpdateCommand="update usuario set clave=@clave , nombre = @nombre where codigo = @codigo
">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="tcodigo" Name="codigo" PropertyName="Text" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="tnombre" Name="nombre" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tclave2" Name="clave" PropertyName="Text" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="tclave2" Name="clave" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tnombre" Name="nombre" PropertyName="Text" />
                    <asp:ControlParameter ControlID="tcodigo" Name="codigo" PropertyName="Text" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            Codigo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tcodigo" runat="server"></asp:TextBox>
            <br />
            <br />
             nombre:  
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
            <br />

            <br />
            Clave:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
            <asp:TextBox ID="tclave2" runat="server"></asp:TextBox>
            <br />

             &nbsp;&nbsp;&nbsp;
           
            <br />
            <asp:Button ID="bagregar" runat="server" Text="Agregar" OnClick="bagregar_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bborrar" runat="server" Text="Borrar" OnClick="bborrar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bmodificar" runat="server" Text="Modificar" OnClick="bmodificar_Click" />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
