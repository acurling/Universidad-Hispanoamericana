using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase6CalculadoraWebUPI
{
    public class ClsUsuario
    {
        // Atributos
        private static string nombre { get; set; }
        private static int clave { get; set; }

        //Constructor
        public ClsUsuario(string Nombre, int Clave)
        {
            ClsUsuario.nombre = Nombre;
            ClsUsuario.clave = Clave;
        }

        public ClsUsuario()
        {

        }

        // metodos


        public static string GetNombre()
        {
            return ClsUsuario.nombre;
        }

        public static void SetNombre(string Nombre)
        {
            ClsUsuario.nombre = Nombre;
        }


        public static int GetClave()
        {
            return ClsUsuario.clave;
        }

        public static void SetClave(int Clave)
        {
            ClsUsuario.clave = Clave;
        }


    }
}