using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingrear_Click(object sender, EventArgs e)
        {
            CsUsuario.Setnombre(tusuario.Text);
            CsUsuario.SetClave(tclave.Text);

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["UPIConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            try
            {
               
                conexion.Open();
                SqlCommand comando = new SqlCommand("select Nombre, clave from usuario  " +
                    "where nombre =  '" + CsUsuario.GetNombre() + "'   and clave = '" + CsUsuario.GetClave() + "'", conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    Response.Redirect("menu.aspx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Usuario no existe');", true);
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Reviar la conexion');", true);
            }
           finally
            {
                conexion.Close();
            }     
            
        }
    }
}