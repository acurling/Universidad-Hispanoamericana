using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPardo
{
    class MenuPrincipal
    {
        static Factura Facturar = new Factura();
        static int opcion;
        static Submenu SubmenuReportes = new Submenu();
        public static void menu()
        {
            opcion = 0;
            do
            {
                Console.WriteLine("****Menú Principal****");
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Realizar Pagos");
                Console.WriteLine("3- Consultar Pagos");
                Console.WriteLine("4- Modificar Pagos");
                Console.WriteLine("5- Eliminar Pagos");
                Console.WriteLine("6- Submenú Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Facturar.InicializarVectores(); break;
                    case 2: Facturar.RealizarPago(); break;
                    case 3: Facturar.ConsultarPago(); break;
                    case 4: Facturar.ModificarPago(); break;
                    case 5: Facturar.EliminarPago(); break;
                    case 6: SubmenuReportes.SubmenuReportes(); break;
                    case 7: break;
                    
                    default:

                        Console.WriteLine("No digitó una opción valida, vuelva a ingresar una opción");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        
                        break;

                }
            } while (opcion!=7);

        }



    }
}
