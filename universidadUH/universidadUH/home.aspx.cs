using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace universidadUH
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            ClsUsuario.Setnombre(tusuario.Text);
            ClsUsuario.SetClave(tclave.Text);

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["UHUNIVERSIDADConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            try
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("select Nombre, clave from usuario  " +
                    "where nombre =  '" + ClsUsuario.GetNombre() + "'   and clave = '" + ClsUsuario.GetClave() + "'", conexion);
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

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Revisar la conexion');", true);
            }
            finally
            {
                conexion.Close();
            }

        }

    }
}
