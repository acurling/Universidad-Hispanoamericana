using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UhClase1
{
    internal class Program
    {
        static void Main(string[] args)  // procedimiento ( void)
        {
            //  Tipos de datos
            //Leccion 1

            int num1 = 0;
            int num2, num3;
            byte b = 125;
            short s = -5;
            long l = 5554587;
            ulong r = 8965;

            double doble = 23.555555d;
            float flotante = 56.54f;
            float total=0, salario = 0;

            string nombre = "Hoy es Viernes";
            char caracter = 'c';
            byte opcion = 0;
            Boolean boleana = true;

            var variable = "texto";

            dynamic dinamica = 25;
            dinamica = 301.65f;
            dinamica = " hola mundo";
            dinamica = false;

            num1 = num1 + 1;

            //contadores y acumuladores
            // contadores
            num1 = num1 + 1;
            num1++;
            ++num1;
            num1 = num1 - 1;
            num1--;
            --num1;

            // acumuladores

            total = total + salario;
            total += salario;

            total = 1;

            for (int i = 0; i <= 100 ; i++)
            {
       
                total *= i;
            }
            Console.WriteLine(total);
            Console.ReadLine();
            do
            {
                opcion = 1;
                Console.WriteLine("Digite un valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite otro valor");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("suma de {0} + {1} = {2}", num1, num2, (num1 + num2));
                Console.WriteLine($"suma de {num1} + {num2} = {num1 + num2}");
                Console.WriteLine("Suma de " + num1 + " + " + num2 + " es: " + (num1 + num2));

                while (num1 < 10)
                {
                    Console.WriteLine(num1);
                    num1 = num1 + 1;
                }
                // Condiciones y ciclos
                // if, do while, while
                if (num1 > num2)
                {
                    Console.WriteLine("{0} es mayor que {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} es mayor que {1}", num2, num1);
                }

                Console.WriteLine("Digite una opcion 1-continuar o 2-Salir");
                opcion = byte.Parse(Console.ReadLine());
               
            } while (opcion != 2 );

            

            Console.Read();
      

        }
    }
}

