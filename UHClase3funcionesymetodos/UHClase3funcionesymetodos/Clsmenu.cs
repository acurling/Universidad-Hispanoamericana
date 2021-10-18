using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3funcionesymetodos
{
    class Clsmenu
    {

        // atributos
        static int opcion; // Variable Global
       static Clsempleado emp = new Clsempleado(); // instanciar una clase
        static Submenu Menureportes = new Submenu();
          public static void principal()
        {
          opcion = 0;
           do
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("1- Inicializar");
                Console.WriteLine("2- Agregar Empleado");
                Console.WriteLine("3- Consultar Empleado");
                Console.WriteLine("4- Modificar Empleado");
                Console.WriteLine("5- Reporte");
                Console.WriteLine("6- Reporte de prueba");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {

                    case 1: emp.inicializar();
                            break;
                    case 2: emp.AgregarEmpleado(); break;
                    case 3: emp.ConsultarEmpleado();
                                break;
                    case 4: emp.ModificarEmpleado();
                            break;
                    case 5: Menureportes.SubmenuReporte(); break;
                    case 6: Rep.principal(); break;
                    case 7: break;
                    default:
                        break;
                }
            } while (opcion!=7);
        }

      
    }

}
