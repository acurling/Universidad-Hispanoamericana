using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgracionII_PrimerExamen
{
    class ClsMenu
    {
        static int op=0; //Definimos la variable para saber la opcion del usuario
        static ClsPagos emp = new ClsPagos();
        public static void principal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
          
            op = 0;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("********MENU PRINCIPAL********");
                Console.WriteLine("1- Inicializar Vectores");
                Console.WriteLine("2- Realizar Pagos");
                Console.WriteLine("3- Consultar Pagos");
                Console.WriteLine("4- Modificar Pagos");
                Console.WriteLine("5- Eliminar Pagos");
                Console.WriteLine("6- Submenú Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("================================");
                Console.WriteLine("Ingrese la opcion que desee...");
                op = Convert.ToInt32(Console.ReadLine());


                switch (op) // Mediante un switch ponemos las opciones
                {
                    case 1:
                        emp.InicializarVectores();  
                        break;

                    case 2:
                        emp.RealizarPagos();
                        break;

                    case 3:
                        emp.ConsultarPagos();
                        
                        break;

                    case 4:
                        emp.ModificarDatos();
                        
                        break;

                    case 5:
                        emp.EliminacionDatos();
                        
                        break;

                    case 6:
                        Console.Clear();
                        op = 0;
                        do
                        {
                            Console.WriteLine("================================");
                            Console.WriteLine("***** SUBMENU REPORTES ******");
                            Console.WriteLine("1- Ver todos los Pagos");
                            Console.WriteLine("2- Ver Pagos por tipo de Servicio");
                            Console.WriteLine("3- Ver Pagos por código de caja");
                            Console.WriteLine("4- Ver Dinero Comisionado por servicios");
                            Console.WriteLine("5- Regresar Menú Principal");
                            Console.WriteLine("================================");
                            op = Convert.ToInt32(Console.ReadLine());

                            switch (op)
                            {
                                case 1:            // Sub menu - Opcion 1 
                                    emp.todosPagos();
                                    break;

                                case 2:            // Sub menu - Opcion 2
                                    emp.pagosServicio();
                                    break;

                                case 3:            // Sub menu - Opcion 3 
                                    emp.pagosCodigos();
                                    break;

                                case 4:            // Sub menu - Opcion 4 
                                    emp.dineroComisionado();
                                    break;

                                case 5:            // Sub menu - Opcion 5 (Salida)
                                    break;

                                default:
                                    break;
                            }

                        } while (op != 5);
                        Console.Clear();

                        break;

                    case 7: break;

                    default: break;
                }
            } while (op!=7);

        }
    }
}
