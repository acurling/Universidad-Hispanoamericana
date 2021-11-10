<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pregunta2.aspx.cs" Inherits="Clase8Ejemplotarea.Pregunta2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PREGUNTA 2
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="484px" ImageUrl="~/Imagenes/IMG2.jpg" Width="666px" />

            <br />
            <br />
            <br />

            <asp:RadioButton ID="r1" Text="A"   runat="server" GroupName="XX" />
            <br />  
            <asp:RadioButton ID="r2" Text="B" runat="server" GroupName="XX" /><br /> 
            <asp:RadioButton ID="r3" Text="C" runat="server" GroupName="XX" /><br /> 
            <asp:RadioButton ID="r4" Text="D" runat="server" GroupName="XX" /><br /> 
            <asp:RadioButton ID="r5" Text="E" runat="server" GroupName="XX" /><br /> 
            <asp:RadioButton ID="r6" Text="F" runat="server" GroupName="XX" /><br /> 
            <br />
            <asp:Button ID="Button2" runat="server" Text="SIGUIENTE" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
