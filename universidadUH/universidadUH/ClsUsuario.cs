using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace universidadUH
{
    public class ClsUsuario
    {
        /* Atributos de la clase */
        private static string nombre { get; set; }
        private static string clave { get; set; }

        // Constructor de la clase
        public ClsUsuario(string nom, string contrasena)
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

        public static Boolean ConsultarUsuario()
        {

            return true;
    }


        public static Boolean AgregarUsuario()
        {
            Boolean existe = false;
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["UHUNIVERSIDADConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            try
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into usuario (nombre,clave)  " +
                    "values ('" + nombre + "','" + clave + "')", conexion);
                comando.ExecuteNonQuery();
                existe = true;

            }
            catch (Exception  ex)
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
