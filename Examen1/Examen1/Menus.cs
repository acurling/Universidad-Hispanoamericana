using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Menus
    {
        public static void MainMenu()
        {
            int option = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine(" 1- Inicializar Vectores");
                Console.WriteLine(" 2- Realizar Pagos");
                Console.WriteLine(" 3- Consultar Pagos");
                Console.WriteLine(" 4- Modificar Pagos");
                Console.WriteLine(" 5- Eliminar Pagos");
                Console.WriteLine(" 6- Submenu Reportes");
                Console.WriteLine(" 7- Salir");
                Console.WriteLine("Seleccione una opcion: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Functions.InitValues();
                        break;
                    case 2:
                        Functions.RealizarPagos();
                        break;
                    case 3:
                        Functions.QueryData();
                        break;
                    case 4:
                        Functions.ModificarPagos();
                        break;
                    case 5:
                        Functions.EliminarPagos();
                        break;
                    case 6:
                        SubMenu();
                        break;
                    case 7: break;
                    default:
                        Console.WriteLine("Opcion Invalida. Intente de nuevo.");
                        break;
                }
            } while (option != 7);
        }

        public static void SubMenu()
        {
            int option = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Submenu Reportes");
                Console.WriteLine(" 1- Ver todos los pagos");
                Console.WriteLine(" 2- Ver Pagos por tipo de Servicio");
                Console.WriteLine(" 3- Ver Pagos por codigo de caja");
                Console.WriteLine(" 4- Ver Dinero Comisionado por servicios");
                Console.WriteLine(" 5- Regresar al menu principal");
                Console.WriteLine("Seleccione una opcion: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Reports.Report1();
                        break;
                    case 2:
                        Reports.Report21();
                        break;
                    case 3:
                        Reports.Report31();
                        break;
                    case 4:
                        Reports.Report41();
                        break;
                    case 5:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida. Intente de nuevo.");
                        break;
                }
            } while (option != 5);
        }
    }
}
