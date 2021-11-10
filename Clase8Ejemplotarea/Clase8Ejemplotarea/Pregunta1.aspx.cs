using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase8Ejemplotarea
{
    public partial class Pregunta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                Formulario.Respuesta1 = "A";
            }
            else if (r2.Checked)
            {
                Formulario.Respuesta1 = "B";
            }
            else if (r3.Checked)
            {
                Formulario.Respuesta1 = "C";
            }
            else if (r4.Checked)
            {
                Formulario.Respuesta1 = "D";
            }
            else if (r5.Checked)
            {
                Formulario.Respuesta1 = "E";
            }
            else if (r6.Checked)
            {
                Formulario.Respuesta1 = "F";
            }

            Response.Redirect("PREGUNTA2.ASPX");
        }
    }
}