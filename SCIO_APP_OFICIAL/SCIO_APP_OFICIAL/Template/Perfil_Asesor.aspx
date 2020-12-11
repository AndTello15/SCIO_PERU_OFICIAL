<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perfil_Asesor.aspx.cs" Inherits="SCIO_APP_OFICIAL.Template.Perfil_Asesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<link rel="stylesheet" href="../Estaticos/CSS/Perfiles.css" />
</head>
<body id="Fondo_Perfil">
   <iframe width="100%" height="650px"; style="margin:0px" src="../Layout/Perfil_Layout.aspx" frameborder="0"></iframe>
   <form runat="server">
       <div class="Tabla_Usuario">
            <div class="PosImagen">
                <label id="titulo" class="etiqueta_Perfil">Asesor</label>
                <div id="AsesorImagen"></div>
                <table class="credito" border="0">
                    <tr>
                        <td></td>
                        <td class="credito_etiqueta">Soles</td>
                        <td class="credito_etiqueta">Dolares</td>
                        <td class="credito_etiqueta">Horas</td>
                    </tr>
                    <tr>
                        <td class="credito_etiqueta">Credito</td>
                        <td><div id="soles" class="monto"></div></td>
                        <td><div id="Dolares" class="monto"></div></td>
                        <td><div id="Horas" class="monto"></div></td>
                    </tr>
                </table>
            </div>
            <div class="PosDatos">
                <table class="Tabla_Datos" border="0">
                   <tr style="height:70%">
                       <td class="ancho_columna">
                           <label class="etiqueta_Datos">Información del Contacto:</label><br /><br />
                           <label class="SeccionDatos">Nombres:</label><br />
                           <div id="NombresAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Apellidos:</label><br />
                           <div id="ApellidosAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Fecha de Nacimiento:</label><br />
                           <div id="FechaNacAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Correo:</label><br />
                           <div id="CorreoAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Celular:</label><br />
                           <div id="CelularAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                       </td>
                       <td class="ancho_columna">
                           <br /><br />
                           <label class="SeccionDatos">Departamneto:</label><br />
                           <div id="DepartamentoAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Provincia:</label><br />
                           <div id="ProvinciaAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Dirección:</label><br />
                           <div id="DireccionAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                           <label class="SeccionDatos">Redes Sociales:</label><br />
                           <div id="RedesSocialesAsesor" class="posDatosAsesor" runat="server">..............</div><br />
                       </td>
                   </tr>
                    <tr>
                        <td colspan="2" class="ancho_columna1"> <label class="SeccionDatos1">Recomendaciones:</label><br /><br /></td>
                    </tr>
               </table>
            </div>
            <div class="PosDescripcion">
                <label class="etiqueta_Datos">Descripción:</label>
                <div id="AsesorDescripcion" class="posAsesorDescripción"></div>
            </div>
            <div class="PosCursos">
                 <label class="etiqueta_Datos1">Cursos que Asesoro:</label>
            </div>
            <div class="PosTerminosyCondiciones">
                <label class="etiqueta_Datos1">Terminos y Condiciones:</label>
            </div>
      </div>
    </form>
</body>
</html>
|