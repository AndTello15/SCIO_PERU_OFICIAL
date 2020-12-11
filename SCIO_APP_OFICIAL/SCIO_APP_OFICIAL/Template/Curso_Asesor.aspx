<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Curso_Asesor.aspx.cs" Inherits="SCIO_APP_OFICIAL.Template.Curso_Asesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<link rel="stylesheet" href="../Estaticos/CSS/Curso.css" />
</head>
<body style="width:100%;">
<div class="Tabla">
    <div class="Logo">
    </div>
    <div class="Menu">
        <label class="posCurso">Curso</label><br />
        <label class="posIngresar">Ingresar</label>
        <button class="boton">Suscribirse</button><br />
        <label class="Contenido">Descripción y/o mensaje</label>
    </div>
</div>
<div class="Cuerpo">
    <br />
    <form runat="server">
    <label class="etiqueta">Docentens Disponibles:</label>
    <asp:DropDownList ID="cbo_Hora" CssClass="cbo_select" runat="server"></asp:DropDownList>
    <input type="date" class="Fecha" />
    <br />
    <div class="profesores_Disponibles" runat="server">
        <div class="ImagenAsesor"></div>
    </div>
    <label class="DatosSesion">Datos de la Sesión</label><br />
    <div class="PosMonto"><label class="Inversion">Inversion:</label><label id="monto" class="Inversión" runat="server">xxxx</label><br /><br />
        <asp:Button ID="Btn_Sesion" CssClass="boton2" runat="server" Text="Ir a mi Sesión" /><br /><br />
        <asp:Button ID="Btn_Separar" CssClass="boton2" runat="server" Text="Separar Sesión" />
    </div>
    </form>
</div>
</body>
</html>
