using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6CalculadoraWebUPI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            ClsUsuario usuario = new ClsUsuario();
            ClsUsuario.SetNombre(tusuario.Text);
            ClsUsuario.SetClave(int.Parse(tclave.Text));
         
            try
            {
                if (ClsUsuario.GetClave() == 123)
                {
                    Response.Redirect("Calculadora.aspx");
                }
                else
                {
                    lmensaje.Text = "usuario o clave incorrectos";
                }
            }
            catch (Exception ex)
            {

                lmensaje.Text = "usuario o clave incorrectos";
            }

          
        }
    }
}