using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_programacion2
{
    // Greivin Gazo Sandoval
    //Examen 1 Programacion 2
    class MenuPrincipal
    {
        static int opcion;

        static readonly ServiciosPublicos serviciospublicos = new ServiciosPublicos();


        public MenuPrincipal()
        {
            opcion = 0;


        }
        public MenuPrincipal(int op)
        {
            opcion = op;
        }
        public static void Inicio()
        {
              
            do
            {
                do
                {
                    Console.WriteLine("***** MENU PRINCIPAL ******");
                    Console.WriteLine("1-Inicializar vectores");
                    Console.WriteLine("2-Entrando al sistema de pagos");
                    Console.WriteLine("3-Consulta de pagos");
                    Console.WriteLine("4-Eliminar pago del sistema");
                    Console.WriteLine("5-Modificar datos de los pagos");
                    Console.WriteLine("6-Menu de reportes");
                    Console.WriteLine("7-Salir");
                    
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            serviciospublicos.Inicializarvectores();
                            break;
                        case 2:
                            serviciospublicos.PagoServicios();

                            break;
                        case 3:
                            serviciospublicos.ConsultarPagos();
                            break;
                        case 4:
                            serviciospublicos.EliminarPagos();
                            break;
                        case 5:
                            serviciospublicos.ModificarPagos();
                            break;
                        case 6:

                            int opcion2;


                            {
                                Console.WriteLine("1-Reporte de todos los pagos");
                                Console.WriteLine("2-Reporte por tipo de servicio");
                                Console.WriteLine("3-Regresar al menu principal");
                                opcion2 = Convert.ToInt32(Console.ReadLine());

                                switch (opcion2)
                                {
                                    case 1:
                                        serviciospublicos.Reportetotal();
                                        break;
                                    case 2:
                                        serviciospublicos.ReporteTipoServicio();
                                        break;
                                    case 3:
                                        Console.WriteLine("Se esta regresando al menu principal");
                                        break;
                                    default:
                                        break;

                                }
                            }

                            break;

                        case 7:
                            Environment.Exit(-1);
                            break;
                        default:
                            break;
                    }
                } while (opcion != 7);
           } while (opcion != 3);
         
        }
    }
}
