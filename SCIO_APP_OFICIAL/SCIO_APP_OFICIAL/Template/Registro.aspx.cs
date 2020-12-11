using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SCIO_APP_OFICIAL.Template
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cursos();
            Cursos_PreUniversitario();
        }
        protected void Cursos()
        {
            string conectionString = "datasource = remotemysql.com; port = 3306; username = gap7pg0CNi; password = gWlNkYFNAH; database = gap7pg0CNi; ";
            string consultaSMate = "Select * from curso where Nivel='SECUNDARIA' and Area='MATEMATICA'";
            string consultaSCTA = "Select * from curso where Nivel='SECUNDARIA' and Area='CIENCIA TECNOLOGIA Y AMBIENTE'";
            string consultaSIdiomas = "Select * from curso where Nivel='SECUNDARIA' and Area='IDIOMAS'";
            string consultaSSociales = "Select * from curso where Nivel='SECUNDARIA' and Area='CIENCIAS SOCIALES'";
            string consultaSComunicacion = "Select * from curso where Nivel='SECUNDARIA' and Area='COMUNICACION'";
            string consultaSAyC = "Select * from curso where Nivel='SECUNDARIA' and Area='ARTE Y CULTURA'";
            string consultaSComputo = "Select * from curso where Nivel='SECUNDARIA' and Area='COMPUTO'";
            MySqlConnection databaseConnection = new MySqlConnection(conectionString);
            MySqlDataAdapter Smenmate = new MySqlDataAdapter(consultaSMate, databaseConnection);
            MySqlDataAdapter SmenCTA = new MySqlDataAdapter(consultaSCTA, databaseConnection);
            MySqlDataAdapter SmenIdiomas = new MySqlDataAdapter(consultaSIdiomas, databaseConnection);
            MySqlDataAdapter SmenSociales = new MySqlDataAdapter(consultaSSociales, databaseConnection);
            MySqlDataAdapter SmenComunicacion = new MySqlDataAdapter(consultaSComunicacion, databaseConnection);
            MySqlDataAdapter SmenAyC = new MySqlDataAdapter(consultaSAyC, databaseConnection);
            MySqlDataAdapter SmenComputo = new MySqlDataAdapter(consultaSComputo, databaseConnection);
            DataSet m = new DataSet();
            Smenmate.Fill(m, "Matematica");
            SmenCTA.Fill(m, "CTA");
            SmenIdiomas.Fill(m, "Idiomas");
            SmenSociales.Fill(m, "Sociales");
            SmenComunicacion.Fill(m, "Comunicacion");
            SmenAyC.Fill(m, "AyC");
            SmenComputo.Fill(m, "Computo");
            StringBuilder cursos = new StringBuilder();
            StringBuilder cursoCTA = new StringBuilder();
            StringBuilder cursoIdioma = new StringBuilder();
            StringBuilder cursoSociales = new StringBuilder();
            StringBuilder cursoComunicacion = new StringBuilder();
            StringBuilder cursoAyC = new StringBuilder();
            StringBuilder cursoComputo = new StringBuilder();
            int numeroCursosMate = m.Tables["Matematica"].Rows.Count;
            int numeroCursosCTA = m.Tables["CTA"].Rows.Count;
            int numeroCursosIdiomas = m.Tables["Idiomas"].Rows.Count;
            int numeroCursosSociales = m.Tables["Sociales"].Rows.Count;
            int numeroCursosComunicacion = m.Tables["Comunicacion"].Rows.Count;
            int numeroCursosAyC = m.Tables["AyC"].Rows.Count;
            int numeroCursosComputo = m.Tables["Computo"].Rows.Count;
            for (int i = 0; i < numeroCursosMate; i++)
            {
                string idcursos = m.Tables["Matematica"].Rows[i][0].ToString();
                string nombrecursos = m.Tables["Matematica"].Rows[i][4].ToString();
                string labelcursos = "<label class='custom-checkbox'>";
                string checkbox = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursos);
                string spam = "<spam class='chkcursos'></spam>";
                string labelcursos1 = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursos);
                
                cursos.Append(labelcursos);
                cursos.Append(checkbox);
                cursos.Append(spam);
                cursos.Append(labelcursos1);
            }
            for (int cta = 0; cta < numeroCursosCTA; cta++)
            {
                string idcursosCTA = m.Tables["CTA"].Rows[cta][0].ToString();
                string nombrecursosCTA = m.Tables["CTA"].Rows[cta][4].ToString();
                string labelcursosCTA = "<label class='custom-checkbox'>";
                string checkboxCTA = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosCTA);
                string spamCTA = "<spam class='chkcursos'></spam>";
                string labelcursos1CTA = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosCTA);
                
                cursoCTA.Append(labelcursosCTA);
                cursoCTA.Append(checkboxCTA);
                cursoCTA.Append(spamCTA);
                cursoCTA.Append(labelcursos1CTA);
            }
            for (int idioma = 0; idioma < numeroCursosIdiomas; idioma++)
            {
                string idcursosIdioma = m.Tables["Idiomas"].Rows[idioma][0].ToString();
                string nombrecursosIdioma = m.Tables["Idiomas"].Rows[idioma][4].ToString();
                string labelcursosIdioma= "<label class='custom-checkbox'>";
                string checkboxIdioma = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosIdioma);
                string spamIdioma = "<spam class='chkcursos'></spam>";
                string labelcursos1Idioma = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosIdioma);
                
                cursoIdioma.Append(labelcursosIdioma);
                cursoIdioma.Append(checkboxIdioma);
                cursoIdioma.Append(spamIdioma);
                cursoIdioma.Append(labelcursos1Idioma);
            }
            for (int sociales = 0; sociales  < numeroCursosSociales; sociales++)
            {
                string idcursosSociales = m.Tables["Sociales"].Rows[sociales][0].ToString();
                string nombrecursosSociales = m.Tables["Sociales"].Rows[sociales][4].ToString();
                string labelcursosSociales = "<label class='custom-checkbox'>";
                string checkboxSociales = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosSociales);
                string spamSociales = "<spam class='chkcursos'></spam>";
                string labelcursos1Sociales = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosSociales);
                
                cursoSociales.Append(labelcursosSociales);
                cursoSociales.Append(checkboxSociales);
                cursoSociales.Append(spamSociales);
                cursoSociales.Append(labelcursos1Sociales);
            }
            for (int comunicacion = 0; comunicacion < numeroCursosComunicacion; comunicacion++)
            {
                string idcursosComunicacion = m.Tables["Comunicacion"].Rows[comunicacion][0].ToString();
                string nombrecursosComunicacion = m.Tables["Comunicacion"].Rows[comunicacion][4].ToString();
                string labelcursosComunicacion = "<label class='custom-checkbox'>";
                string checkboxComunicacion = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosComunicacion);
                string spamComunicacion = "<spam class='chkcursos'></spam>";
                string labelcursos1Comunicacion = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosComunicacion);
                
                cursoComunicacion.Append(labelcursosComunicacion);
                cursoComunicacion.Append(checkboxComunicacion);
                cursoComunicacion.Append(spamComunicacion);
                cursoComunicacion.Append(labelcursos1Comunicacion);
            }
            for (int AyC = 0; AyC < numeroCursosAyC; AyC++)
            {
                string idcursosAyC = m.Tables["AyC"].Rows[AyC][0].ToString();
                string nombrecursosAyC = m.Tables["AyC"].Rows[AyC][4].ToString();
                string labelcursosAyC = "<label class='custom-checkbox'>";
                string checkboxAyC = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosAyC);
                string spamAyC = "<spam class='chkcursos'></spam>";
                string labelcursos1AyC = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosAyC);
                
                cursoAyC.Append(labelcursosAyC);
                cursoAyC.Append(checkboxAyC);
                cursoAyC.Append(spamAyC);
                cursoAyC.Append(labelcursos1AyC);
            }
            for (int computo = 0; computo < numeroCursosComputo; computo++)
            {
                string idcursosComputo = m.Tables["Computo"].Rows[computo][0].ToString();
                string nombrecursosComputo = m.Tables["Computo"].Rows[computo][4].ToString();
                string labelcursosComputo = "<label class='custom-checkbox'>";
                string checkboxComputo = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosComputo);
                string spamComputo = "<spam class='chkcursos'></spam>";
                string labelcursos1Computo = string.Format("<spam class='chk_texto'>{0}</spam></label><br /><br />", nombrecursosComputo);
                
                cursoComputo.Append(labelcursosComputo);
                cursoComputo.Append(checkboxComputo);
                cursoComputo.Append(spamComputo);
                cursoComputo.Append(labelcursos1Computo);
            }
            cursosComputo.InnerHtml = cursoComputo.ToString();
            cursosAyC.InnerHtml = cursoAyC.ToString();
            cursosComunicacion.InnerHtml = cursoComunicacion.ToString();
            cursosSociales.InnerHtml = cursoSociales.ToString();
            cursosIdioma.InnerHtml = cursoIdioma.ToString();
            cursosCTA.InnerHtml = cursoCTA.ToString();  
            Secundaria.InnerHtml = cursos.ToString();
        }
        private void Cursos_PreUniversitario()
        {
            string conectionString = "datasource = remotemysql.com; port = 3306; username = gap7pg0CNi; password = gWlNkYFNAH; database = gap7pg0CNi;";
            string consultaPreMate = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='MATEMATICA'";
            string consultaPreCTA = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='CIENCIA,TECNOLOGIA Y AMBIENTE'";
            string consultaPreComunicacion = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='COMUNICACION'";
            MySqlConnection databaseConnection = new MySqlConnection(conectionString);
            MySqlDataAdapter Pmenmate = new MySqlDataAdapter(consultaPreMate, databaseConnection);
            MySqlDataAdapter PmenCTA = new MySqlDataAdapter(consultaPreCTA, databaseConnection);
            MySqlDataAdapter PmenComunicacion = new MySqlDataAdapter(consultaPreComunicacion, databaseConnection);
            DataSet m = new DataSet();
            Pmenmate.Fill(m, "Matematica");
            PmenCTA.Fill(m, "CTA");
            PmenComunicacion.Fill(m, "Comunicacion");
            StringBuilder Precursos = new StringBuilder();
            StringBuilder PrecursoCTA = new StringBuilder();
            StringBuilder PrecursoComunicacion = new StringBuilder();
            int numeroPreCursosMate = m.Tables["Matematica"].Rows.Count;
            int numeroPreCursosCTA = m.Tables["CTA"].Rows.Count;
            int numeroPreCursosComunicacion = m.Tables["Comunicacion"].Rows.Count;
            
            for (int i = 0; i < numeroPreCursosMate; i++)
            {
                string idcursos = m.Tables["Matematica"].Rows[i][0].ToString();
                string nombrecursos = m.Tables["Matematica"].Rows[i][4].ToString();
                string labelcursos = "<label class='custom-checkbox'>";
                string checkbox = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursos);
                string spam = "<spam class='chkcursos'></spam>";
                string labelcursos1 = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursos);

                Precursos.Append(labelcursos);
                Precursos.Append(checkbox);
                Precursos.Append(spam);
                Precursos.Append(labelcursos1);
            }

            for (int cta = 0; cta < numeroPreCursosCTA; cta++)
            {
                string idcursosCTA = m.Tables["CTA"].Rows[cta][0].ToString();
                string nombrecursosCTA = m.Tables["CTA"].Rows[cta][4].ToString();
                string labelcursosCTA = "<label class='custom-checkbox'>";
                string checkboxCTA = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosCTA);
                string spamCTA = "<spam class='chkcursos'></spam>";
                string labelcursos1CTA = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosCTA);

                PrecursoCTA.Append(labelcursosCTA);
                PrecursoCTA.Append(checkboxCTA);
                PrecursoCTA.Append(spamCTA);
                PrecursoCTA.Append(labelcursos1CTA);
            }


            for (int comunicacion = 0; comunicacion < numeroPreCursosComunicacion; comunicacion++)
            {
                string idcursosComunicacion = m.Tables["Matematica"].Rows[comunicacion][0].ToString();
                string nombrecursosComunicacion = m.Tables["Matematica"].Rows[comunicacion][4].ToString();
                string labelcursosComunicacion = "<label class='custom-checkbox'>";
                string checkboxComunicacion = string.Format("<input id='{0}' type='checkbox' class='checkbox' value='{0}' />", idcursosComunicacion);
                string spamComunicacion = "<spam class='chkcursos'></spam>";
                string labelcursos1Comunicacion = string.Format("<spam class='chk_texto'>{0}</spam></label><br />", nombrecursosComunicacion);

                PrecursoComunicacion.Append(labelcursosComunicacion);
                PrecursoComunicacion.Append(checkboxComunicacion);
                PrecursoComunicacion.Append(spamComunicacion);
                PrecursoComunicacion.Append(labelcursos1Comunicacion);
            }
            PreMatecur.InnerHtml = Precursos.ToString();
            PreCTAcur.InnerHtml = PrecursoCTA.ToString();
            PreComunicacioncur.InnerHtml = PrecursoComunicacion.ToString();
        }
    }
}