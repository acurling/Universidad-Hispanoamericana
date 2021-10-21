using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UHClase3funcionesymetodos;

namespace UHClase3funcionesymetodos
{
    class Submenu
    {
       
        static Clsmenu menu = new Clsmenu();
       
        public void SubmenuReporte() {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Reporte 1 ");
                Console.WriteLine("2- Reporte 2 ");
                Console.WriteLine("3- Reporte 3");
                Console.WriteLine("4- Regresar ");
                Console.WriteLine("digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: Clsmenu.principal();
                            break;
                    
                }
            } while (opcion!=4);

        }

        public int NOmbre { private get; set; }





    }
}
