using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace universidadUH
{
    public partial class CatalogoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            //Sqlusuarios.Insert();
            ClsUsuario.Setnombre(tnombre.Text);
            ClsUsuario.SetClave(tclave.Text);
            if (ClsUsuario.AgregarUsuario())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario ha sido  ingresado');", true);
            }
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            Sqlusuarios.Delete();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            Sqlusuarios.Update();
        }
    }
}