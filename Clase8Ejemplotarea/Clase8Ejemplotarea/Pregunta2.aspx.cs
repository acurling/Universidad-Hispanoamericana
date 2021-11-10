using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase8Ejemplotarea
{
    public partial class Pregunta2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                Formulario.Respuesta2 = "A";
            }
            else if (r2.Checked)
            {
                Formulario.Respuesta2 = "B";
            }
            else if (r3.Checked)
            {
                Formulario.Respuesta2 = "C";
            }
            else if (r4.Checked)
            {
                Formulario.Respuesta2 = "D";
            }
            else if (r5.Checked)
            {
                Formulario.Respuesta2 = "E";
            }
            else if (r6.Checked)
            {
                Formulario.Respuesta2 = "F";
            }
            Response.Redirect("REPORTES.ASPX");
        }
    }
}