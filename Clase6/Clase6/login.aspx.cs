using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            CsUsuario.Setnombre(tusuario.Text);
            CsUsuario.SetClave(tclave.Text);

            Clases.ClsSuma.valor1 = int.Parse(tvalor1.Text);
            Clases.ClsSuma.valor2 = int.Parse(tvalor2.Text);

            if (rsuma.Checked)
            {
                Clases.ClsSuma.operador = true;
            } else
            {
                Clases.ClsSuma.operador = false;
            }

            Response.Redirect("Sistema.aspx");

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            Sqlusuario.Insert();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            Sqlusuario.Delete();    
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            Sqlusuario.Update();
        }
    }
}