using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase6.Clases
{
    public class ClsSuma
    {
        private static int operacion;
        public static bool operador { get; set; }
        public static int valor1 { get; set; }
        public static int valor2 { get; set; }


        public static int GetResultado()
        {
            if (operador)
            {
                operacion = valor1 + valor2;
            }
            else
            {
                operacion = valor1 - valor2;
            }
            return operacion;
        }

        public static void SetResultado(int res)

        {
            operacion = res;
        }

    }
}