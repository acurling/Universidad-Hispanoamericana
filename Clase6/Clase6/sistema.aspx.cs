using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6
{
    public partial class sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lnombre.Text = CsUsuario.GetNombre();
       
            lresultado.Text =  Convert.ToString(Clases.ClsSuma.GetResultado());
        }
    }
}