﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="SCIO_APP_OFICIAL.Template.Registro"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
<link rel="stylesheet" href="../Estaticos/CSS/Estilos_Principal.css" />
    <link rel="stylesheet" href="../Estaticos/CSS/Registro.css" />
    <script type="text/javascript" src="../Estaticos/js/Registro.js"></script>
    <script type="text/javascript" src="../Estaticos/js/Registro2.js"></script>
</head>
<body>
 <div class="Tabla">
     <div class="Logo">
    </div>
     <div class="Menu">
        <label class="titulo"> Continuando con su Suscribción .....</label>
     </div>
 </div>
 <div class="Tabla1">
    <form class="Formulario" runat="server">
        <label class="etiqueta">Nombres:</label><asp:TextBox ID="txtNombres" CssClass="Texto" runat="server"></asp:TextBox><br /><br />
        <label class="etiqueta">Apellidos:</label><asp:TextBox ID="txtApellidos" CssClass="Texto" runat="server"></asp:TextBox><br /><br />
        <label class="etiqueta">Fecha de Nacimiento:</label><input id="Fecha" type="date" class="Texto" /><br /><br />
        <label class="etiqueta">Edad:</label><asp:TextBox ID="txtEdad" CssClass="Texto" runat="server" ></asp:TextBox><br /><br />
        <label class="etiqueta">Documento de Identificación:</label><asp:DropDownList ID="cbo_DocIdentificacion" CssClass="cbo_select Texto" runat="server"></asp:DropDownList><br /><br />
        <label class="etiqueta">Numero de Documento:</label><asp:TextBox ID="txtNumDocumento" CssClass="Texto" runat="server" ></asp:TextBox><br /><br />
        <label class="etiqueta">Departamento:</label><asp:DropDownList ID="cbo_Departamento" CssClass="cbo_select Texto" runat="server"></asp:DropDownList><br /><br />
        <label class="etiqueta">Provincia:</label><asp:DropDownList ID="cbo_Provincia" CssClass="cbo_select Texto" runat="server"></asp:DropDownList><br /><br />
        <label class="etiqueta">Dirección:</label><asp:TextBox ID="txtDireccion" CssClass="Texto" runat="server"></asp:TextBox><br /><br />
        <label class="etiqueta">Foto:</label><asp:TextBox ID="txtFoto" CssClass="Texto" runat="server" ReadOnly="True"></asp:TextBox><asp:Button ID="btn_BuscarFoto" CssClass="boton" runat="server" Text="Buscar" /><br /><br />
        <label class="etiqueta">Ocupación:</label><label class="radioInput"><input type="radio" id="Rbtn_Asesor" class="radioboton" name="Ocupacion" value="Asesor" onclick="MostrarAsesor()" />Asesor<i class="Asesor"></i></label>
                                                   <label class="radioInput"><input type="radio" id="Rbtn_Estudiante" class="radioboton" name="Ocupacion" value="Estudiante" onclick="MostrarEstudiante()" />Estudiante<i class="Estudiante"></i></label>
        <asp:Button ID="BtnAceptar" CssClass="boton" runat="server" Text="Aceptar"></asp:Button>
    </form>
    <div id="idSeleccion" class="SeleccionCursos" runat="server">
            <button id="btn_Prenatal" class="btnCursos" value ="Fase Prenatal">Fase Prenatal</button><br /><br />
            <button id="btnNinez" class="btnCursos" value="Niñez" >Niñez</button><br /><br />
            <button id="btnAdolescencia" class="btnCursos" onclick="AdolesCursos()">Adolescencia</button><br /><br />
            <div id="AdolescenciaCursos">
                <button id="BtnSecundaria" class="btnArea" onclick="Cursos_Secundaria()">Secundaria</button><br />
                <div id="TablaSecundariaCursos">
                    <div id="Matematica_Secu">
                        <label class="NombCurso">Matemática</label>
                        <div id="Secundaria" runat="server"></div>
                    </div>
                    <div id="CTA_Secu" >
                        <label class="NombCurso">Ciencia Tecnología y Ambiente</label>
                        <div id="cursosCTA" runat="server"></div> 
                    </div>
                     <div id="Idiomas_Secu" >
                        <label class="NombCurso">Idiomas</label>
                        <div id="cursosIdioma" runat="server"></div> 
                    </div>
                    <div id="Ciencias_Sociales_Secu">
                        <label class="NombCurso">Ciencias Sociales</label>
                        <div id="cursosSociales" runat="server"></div>
                    </div>
                    <div id="Comunicacion_Secu">
                        <label class="NombCurso">Comunicación</label>
                        <div id="cursosComunicacion" runat="server"></div>
                    </div>
                    <div id="AyC_Secu">
                        <label class="NombCurso">Arte y Cultura</label>
                        <div id="cursosAyC" runat="server"></div>
                    </div>
                    <div id="Computo_Secu">
                        <label class="NombCurso">Cómputo</label>
                        <div id="cursosComputo" runat="server"></div>
                    </div>
                </div>
                <button id="BtnPreUniversitario" class="btnArea" onclick="Cursos_PreUniversitario()">Preuniversitario</button><br />
                <div id="TablaPreuniversitarioCursos">
                    <div id="PreMatematica" >
                        <label class="NombCurso">Matemática</label>
                        <div id="PreMatecur" runat="server"></div>
                    </div>
                    <div id="PreCTAregistro" >
                        <label class="NombCurso">Ciencia Tecnología y Ambiente</label>
                        <div id="PreCTAcur" runat="server"></div> 
                    </div>
                     <div id="PreComunicacion" >
                        <label class="NombCurso">Comunicación</label>
                        <div id="PreComunicacioncur" runat="server"></div> 
                    </div>
                </div>
            </div>
            <button id="btnJuventud" class="btnCursos">Juventud</button><br /><br />
            <button id="btnAdultez" class="btnCursos">Adultez</button><br /><br />
            <button id="btnAncianidad" class="btnCursos">Ancianidad</button><br /><br />
     </div>
     <div id="idEstudiante" class="Ocu_Estudiante">
         <label class="etiqueta">Fase:</label><select id="cbo_Fase" class="cbo_select Texto"></select><br /><br />
         <label class="etiqueta">Nivel:</label><select id="cbo_Nivel" class="cbo_select Texto"></select><br /><br /> 
    </div>
 </div>
</body>
</html>
