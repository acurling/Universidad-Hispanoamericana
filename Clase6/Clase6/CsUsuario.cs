using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Clase6
{
    public class CsUsuario
    {
        /* Atributos de la clase usuario */
        private static string nombre { get; set; }
        private static string clave { get; set; }

        /* constructor de la clase */
        public CsUsuario(string nom, string contrasena)
        {
            nombre = nom;
            clave = contrasena;
        }

        /* Metodos de la clase Get = devolver un valor  Set = Asignar un valor*/

        public static string GetNombre() { return nombre; }
        public static string GetClave() { return clave; }

        public static void Setnombre(string nom)
        {
            nombre = nom;
        }
        public static void SetClave(String contrasena)
        {
            clave = contrasena;
        }

        public static Boolean Agregarusuario()
        {
            Boolean existe = false;
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["UPIConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            try
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into usuario  " +
                    "values ('" + nombre + "','" + clave + "')", conexion);
                comando.ExecuteNonQuery();
                existe = true;

            }
            catch (Exception)
            {
                conexion.Close();
            }
            finally
            {
                conexion.Close();
            }
            return existe;
        }
    }
}
