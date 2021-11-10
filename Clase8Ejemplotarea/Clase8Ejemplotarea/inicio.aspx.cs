using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase8Ejemplotarea
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BINICIAR_Click(object sender, EventArgs e)
        {
            
            Formulario.Nombre = tnombre.Text;
            Formulario.Edad = byte.Parse(tedad.Text);
            Formulario.genero = dgenero.Text;

            Response.Redirect("PREGUNTA1.ASPX");
        }
    }
}