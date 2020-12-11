<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perfil_Layout.aspx.cs" Inherits="SCIO_APP_OFICIAL.Layout.Perfil_Layout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<link rel="stylesheet" href="../Estaticos/CSS/Estilos_Principal.css" />
<link rel="stylesheet" href="../Estaticos/CSS/Perfiles.css" />
</head>
<body>
    <div class="Tabla">
         <div class="Logo">
         </div>
         <div class="Menu">
             <form runat="server">
                 <label class="Promociones">Promos</label>
                 <label class="Membresias">Membresias</label>
                 <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
                 <asp:Button ID="Btn_Buscar" runat="server" Text="Buscar" />
             </form>
         </div>
   </div>
</body>
</html>
