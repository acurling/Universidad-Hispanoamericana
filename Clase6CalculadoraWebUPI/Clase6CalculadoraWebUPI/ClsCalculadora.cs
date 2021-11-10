using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase6CalculadoraWebUPI
{
    public class ClsCalculadora
    {

        public static float num1 { get; set; }
        public static float num2 { get; set; }
        float resultado = 0;

        // constructor

        public ClsCalculadora(float n1, float n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public float Sumar() 
        {
            resultado = num1 + num2;
            return resultado;
        }

        public float restar()
        {
            resultado = num1 - num2;
            return resultado;
        }
        public float respuesta()
        {
            return resultado;
        }
    }
}
