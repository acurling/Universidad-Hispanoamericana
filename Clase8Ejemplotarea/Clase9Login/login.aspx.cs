using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase9Login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["GIMNASIOConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT EMAIL, clave FROM Usuario WHERE EMAIL = '" + TUSUARIO.Text + "' AND CLAVE = '" + TCLAVE.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                USUARIO.CORREO = registro.GetValue(0).ToString();
                Response.Redirect("menu.aspx");

            }
            else {
                Response.Write("<script>alert('Clave o usuario incorrecto');</script>");
            }
            conexion.Close();

        }
    }
}