using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6
{
    public partial class CatalogoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            CsUsuario.Setnombre(tusuario.Text);
            CsUsuario.SetClave(tclave.Text);

            if (CsUsuario.Agregarusuario())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario ha sido ingresado');", true);
                tusuario.Text = "";
                tclave.Text = "";
                GridView1.DataBind();
            } else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario o clave incorrecto');", true);
            }
        }
    }
}