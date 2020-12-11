<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal_Logeado.aspx.cs" Inherits="SCIO_APP_OFICIAL.Template.Principal_Logeado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<link rel="stylesheet" href="../Estaticos/CSS/Estilos_Principal.css" />
</head>
<body id="Fondo">
    <iframe width="100%" height="650px"; style="margin:0px" src="../Layout/Principal_Layout.aspx" frameborder="0"></iframe>
    <form runat="server">
    <asp:Menu ID="BtnUsuario" runat="server" Orientation="Horizontal">
        <Items>
            <asp:MenuItem Text="Nombre Usuario" Value="Mi Perfil">
                <asp:MenuItem Text="Mi Perfil" Value="Mi Perfil"></asp:MenuItem>
                <asp:MenuItem Text="Cerrar Sesion" Value="Cerrar Sesion"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
        <LevelMenuItemStyles>
            <asp:MenuItemStyle Font-Underline="False" ForeColor="#1D2731" HorizontalPadding="4px" VerticalPadding="5px" Width="130%" />
            <asp:MenuItemStyle BackColor="White" Font-Underline="False" ForeColor="#0B3C5D" HorizontalPadding="4px" VerticalPadding="6px" Width="140%" />
        </LevelMenuItemStyles>
    </asp:Menu>
    </form>
</body>
</html>
