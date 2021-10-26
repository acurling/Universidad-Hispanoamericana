using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPardo
{
    class Submenu
    {

        static MenuPrincipal menu = new MenuPrincipal();
        public void SubmenuReportes(){

            int opcion = 0;
            do
            {
                Console.WriteLine("**Submenú de Reportes**");
                Console.WriteLine("1- Ver todos los Pagos");
                Console.WriteLine("2- Ver Pagos por tipo de Servicio");
                Console.WriteLine("3- Ver pagos por código de caja");
                Console.WriteLine("4- Ver Dinero Comicionado por Servicios");
                Console.WriteLine("5- Regresar a Menú Principal");
                Console.WriteLine("Digite una opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Reportes.VerPagos(); break;
                    case 2: Reportes.VerPagosServicio(); break;
                    case 3: Reportes.VerPagosCaja(); break;
                    case 4: Reportes.VerDineroCom(); break;
                    case 5: MenuPrincipal.menu(); break;
                    
                    default:

                        Console.WriteLine("No digitó una opción valida, vuelva a ingresar una opción");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        break;
                                                
                }

            } while (opcion!=5);

        }
    }
}
