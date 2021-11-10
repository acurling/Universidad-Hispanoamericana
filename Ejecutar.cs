using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    class Ejecucion
    {
        public static char[] texto;
        public static int[] inversa;

        public void InicializarVector()

        {
            texto = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write(texto); Console.WriteLine();


            inversa = new int[27];
            for (int i = 0; i < 27; i++)
            {
                inversa[i] = i;
                Console.Write(i);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Vectores ListoS"); Console.WriteLine(" ");
        }

        public void EncriptaTexto()

        {
            Console.Write("Digite el texto a encriptar: ");
            string guardatxt;
            guardatxt = Console.ReadLine();
            char[] texto1;
            int[] almacena;
            texto1 = guardatxt.ToCharArray(0, guardatxt.Length);
            almacena = new int[27];

            for (int i = 0; i < texto1.Length; i++)
            {
                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto1[i] == texto[j])

                    {
                        almacena[i] = inversa[j];
                        Console.Write(almacena[i]);
                    }
                }

            }

        } 

        public void DesencriptaNumero()

        {
            Console.Write("Digite el número a desencriptar: ");
            string guardanum;
            guardanum = Console.ReadLine();
            int almacenar = int.Parse(guardanum);
            int[] almacenar2;
            almacenar2 = new int[100];

            for (int i = 0; i < guardanum.Length; i++)
            {
                //almacenar = guardanum[i];
                {
                    if (almacenar == inversa[i]) almacenar2[i] = texto[i];
                }

                Console.Write(almacenar2);

            }
        }
    }
}
