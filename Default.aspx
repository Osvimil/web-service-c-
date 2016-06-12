<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="texto" runat="server" Text="Texto"></asp:Label>
        <asp:TextBox ID="texton" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="nombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="nombren" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="fecha" runat="server" Text="Fecha"></asp:Label>
&nbsp;<asp:TextBox ID="fechan" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="hora" runat="server" Text="Hora"></asp:Label>
&nbsp;<asp:TextBox ID="horan" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="HORA Y FECHA" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="HOLA MUNDO" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="HOLA CON TU NOMBRE" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="HORA Y FECHA SEPARADAS" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="NOMBRE MAQUINA" OnClick="Button5_Click" />
        </div>
    </form>
</body>
</html>
