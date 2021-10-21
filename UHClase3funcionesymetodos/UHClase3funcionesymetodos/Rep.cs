using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3funcionesymetodos
{
    class Rep
    {

        public static void principal()
        {
            // setting the window size
            Console.SetWindowSize(63, 63);

            // setting buffer size of console
            Console.SetBufferSize(80, 80);

            // using the method
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("Menu principal");
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("___________________________");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("Edad");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Cedula");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("___________________________");
            Console.Write("Press any key to continue . . . ");

            Console.ReadKey(true);

        }
    }
}
