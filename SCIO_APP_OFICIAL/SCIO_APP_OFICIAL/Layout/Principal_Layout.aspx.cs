using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace SCIO_APP_OFICIAL.Layout
{
    public partial class Principal_Layout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<div id='Fase'>");
            Response.Write("<ul class='nav'>");
            Response.Write("<li id='Prenatal' class='CFase'>Fase Prenatal");
            Response.Write("<ul class='Area_Cursos1'>1");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Infancia' class='CFase'>Infancia");
            Response.Write("<ul class='Area_Cursos1'>2");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Niñez' class='CFase'>Niñez");
            Response.Write("<ul class='Area_Cursos1'>3");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Adolescencia' class='CFase'>Adolescencia");
            Response.Write("<ul class='Area_Cursos1'>");
            CursosAdolescencia();
            CursosPreUniversitario();
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Juventud' class='CFase'>Juventud");
            Response.Write("<ul class='Area_Cursos1'>5");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Adultez' class='CFase'>Adultez");
            Response.Write("<ul class='Area_Cursos1'>6");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("<li id='Ancianidad' class='CFase'>Ancianidad");
            Response.Write("<ul class='Area_Cursos1'>7");
            Response.Write("</ul>");
            Response.Write("</li>");
            Response.Write("</ul>");
            Response.Write("</div>");
            
        }

        protected void btn_AbrirMenu_Click(object sender, EventArgs e)
        {
        }
        public void CursosAdolescencia()
        {
            string conectionString = "datasource = remotemysql.com; port = 3306; username = gap7pg0CNi; password = gWlNkYFNAH; database = gap7pg0CNi; ";

            string consultaSMate = "Select * from curso where Nivel='SECUNDARIA' and Area='MATEMATICA'";
            string consultaSCta = "Select * from curso where Nivel='SECUNDARIA' and Area='CIENCIA TECNOLOGIA Y AMBIENTE'";
            string consultaSComun= "Select * from curso where Nivel='SECUNDARIA' and Area='COMUNICACION'";
            string consultaSIdioma = "Select * from curso where Nivel='SECUNDARIA' and Area='IDIOMAS'";
            string consultaSComp = "Select * from curso where Nivel='SECUNDARIA' and Area='COMPUTO'";
            string consultaSCS = "Select * from curso where Nivel='SECUNDARIA' and Area='CIENCIAS SOCIALES'";
            string consultaSAC = "Select * from curso where Nivel='SECUNDARIA' and Area='ARTE Y CULTURA'";

            MySqlConnection databaseConnection = new MySqlConnection(conectionString);
            DataSet m = new DataSet();

            MySqlDataAdapter Smenmate = new MySqlDataAdapter(consultaSMate, databaseConnection);
            MySqlDataAdapter SmenCta = new MySqlDataAdapter(consultaSCta, databaseConnection);
            MySqlDataAdapter SmenComun = new MySqlDataAdapter(consultaSComun, databaseConnection);
            MySqlDataAdapter SmenIdioma = new MySqlDataAdapter(consultaSIdioma, databaseConnection);
            MySqlDataAdapter SmenComp = new MySqlDataAdapter(consultaSComp, databaseConnection);
            MySqlDataAdapter SmenSCS = new MySqlDataAdapter(consultaSCS, databaseConnection);
            MySqlDataAdapter SmenSAC = new MySqlDataAdapter(consultaSAC, databaseConnection);

            Smenmate.Fill(m, "CURSOSMATE");
            SmenCta.Fill(m, "CURSOSCTA");
            SmenComun.Fill(m, "CURSOSCOMUN"); 
            SmenIdioma.Fill(m, "CURSOSIDIOMA");
            SmenComp.Fill(m, "CURSOSCOMPUTO"); 
            SmenSCS.Fill(m, "CURSOSCS"); 
            SmenSAC.Fill(m, "CURSOSAC"); 

            int numeroRegistorsMate = m.Tables["CURSOSMATE"].Rows.Count;
            int numeroRegistrosCta = m.Tables["CURSOSCTA"].Rows.Count;
            int numeroRegistrosComun = m.Tables["CURSOSCOMUN"].Rows.Count;
            int numeroRegistrosIdioma = m.Tables["CURSOSIDIOMA"].Rows.Count;
            int numeroRegistrosComp = m.Tables["CURSOSCOMPUTO"].Rows.Count;
            int numeroRegistrosSCS = m.Tables["CURSOSCS"].Rows.Count;
            int numeroRegistrosSAC = m.Tables["CURSOSAC"].Rows.Count;
            
            Response.Write("<label id='lblSecundaria'>SECUNDARIA</label>");
            Response.Write("<label id='Mate'>Matemática</label>");
            Response.Write("<div id='posCurso'>");
            for(int i=0; i<numeroRegistorsMate;i++)
            {
                string nombreCurso = m.Tables["CURSOSMATE"].Rows[i][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='CTA'>Ciencia Tecnolología y Ambiente</label>");
            Response.Write("<div id='posCursoCTA'>");
            for(int cta=0;cta<numeroRegistrosCta;cta++)
            {
                string nombreCurso = m.Tables["CURSOSCTA"].Rows[cta][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='Comun'>Comunicación</label>");
            Response.Write("<div id='posCursoComun'>");
            for (int comun = 0; comun < numeroRegistrosComun; comun++)
            {
                string nombreCurso = m.Tables["CURSOSCOMUN"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='Idioma'>Idiomas</label>");
            Response.Write("<div id='posCursoIdioma'>");
            for (int comun = 0; comun < numeroRegistrosIdioma; comun++)
            {
                string nombreCurso = m.Tables["CURSOSIDIOMA"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='Computo'>Computo</label>");
            Response.Write("<div id='posCursoComputo'>");
            for (int comun = 0; comun < numeroRegistrosComp; comun++)
            {
                string nombreCurso = m.Tables["CURSOSCOMPUTO"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='CS'>Ciencias Sociales</label>");
            Response.Write("<div id='posCursoCS'>");
            for (int comun = 0; comun < numeroRegistrosSCS; comun++)
            {
                string nombreCurso = m.Tables["CURSOSCS"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='AC'>Arte y Cultura</label>");
            Response.Write("<div id='posCursoAC'>");
            for (int comun = 0; comun < numeroRegistrosSAC; comun++)
            {
                string nombreCurso = m.Tables["CURSOSAC"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");

        }
        public void CursosPreUniversitario()
        {
            string conectionString = "datasource = remotemysql.com; port = 3306; username = gap7pg0CNi; password = gWlNkYFNAH; database = gap7pg0CNi";

            string consultaPreMate = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='MATEMATICA'";
            string consultaPreCta = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='CIENCIA,TECNOLOGIA Y AMBIENTE'";
            string consultaPreComun = "Select * from curso where Nivel='PRE-UNIVERSITARIO' and Area='COMUNICACIÓN'";
            
            MySqlConnection databaseConnection = new MySqlConnection(conectionString);
            DataSet m = new DataSet();

            MySqlDataAdapter Premenmate = new MySqlDataAdapter(consultaPreMate, databaseConnection);
            MySqlDataAdapter PremenCta = new MySqlDataAdapter(consultaPreCta, databaseConnection);
            MySqlDataAdapter PremenComun = new MySqlDataAdapter(consultaPreComun, databaseConnection);

            Premenmate.Fill(m, "CURSOSMATE");
            PremenCta.Fill(m, "CURSOSCTA");
            PremenComun.Fill(m, "CURSOSCOMUN");

            int numeroRegistorsMate = m.Tables["CURSOSMATE"].Rows.Count;
            int numeroRegistrosCta = m.Tables["CURSOSCTA"].Rows.Count;
            int numeroRegistrosComun = m.Tables["CURSOSCOMUN"].Rows.Count;

            Response.Write("<label id='lblPreuniversitario'>PREUNIVERSITARIO</label>");
            Response.Write("<label id='PreMate'>Matemática</label>");
            Response.Write("<div id='posCursoPreMate'>");
            for (int i = 0; i < numeroRegistorsMate; i++)
            {
                string nombreCurso = m.Tables["CURSOSMATE"].Rows[i][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='PreCTA'>Ciencia Tecnolología y Ambiente</label>");
            Response.Write("<div id='posCursoPreCTA'>");
            for (int cta = 0; cta < numeroRegistrosCta; cta++)
            {
                string nombreCurso = m.Tables["CURSOSCTA"].Rows[cta][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
            Response.Write("<label id='PreComun'>Comunicación</label>");
            Response.Write("<div id='posCursoPreComun'>");
            for (int comun = 0; comun < numeroRegistrosComun; comun++)
            {
                string nombreCurso = m.Tables["CURSOSCOMUN"].Rows[comun][4].ToString();
                string htmlcurso = string.Format("<label class='curso'>{0}</label></br>", nombreCurso);
                Response.Write(htmlcurso);
            }
            Response.Write("</div>");
        }

    }
}