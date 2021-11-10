using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    class Menu
    {
        ConsoleKeyInfo op;
        Ejecucion vector = new Ejecucion();

        public void inicio()
        {
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("******* MENU *******");
                Console.WriteLine("--------------------");
                Console.WriteLine("a- Inicializa vector");
                Console.WriteLine("b- Encripta texto a número");
                Console.WriteLine("c- Desencripta de número a texto");
                Console.WriteLine("d- Salir");

                op = Console.ReadKey(true);
                Console.WriteLine();
                switch (op.Key)

                {
                    case ConsoleKey.A:
                        vector.InicializarVector();
                        break;

                    case ConsoleKey.B:
                        vector.EncriptaTexto();
                        break;

                    case ConsoleKey.C:
                        vector.DesencriptaNumero();
                        break;

                    case ConsoleKey.D: break;

                    default:
                        Console.WriteLine("Debe digitar un caracter válido"); Console.WriteLine(""); Console.WriteLine("");

                        break;
                }
            } while (op.Key != ConsoleKey.D);
        }
    }
}
