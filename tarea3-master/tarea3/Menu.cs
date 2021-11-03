using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Greivin Gazo Sandoval
namespace tarea3
{
    class Menu
    {
        
        static int opcion; 

        static readonly Estudiante estudiante = new Estudiante(); 

      
        public Menu()  
        {
            opcion = 0;


        }
        public Menu(int op)  
        {
            opcion = op;
        }
        public static void principal() 
        {
            do
            {
                do
                {
                    Console.WriteLine("***** MENU PRINCIPAL ******");
                    Console.WriteLine("1-Inicializar vectores");
                    Console.WriteLine("2-Incluir estudiantes");
                    Console.WriteLine("3-Buscar estudiantes");
                    Console.WriteLine("4-Eliminar estudiante");
                    Console.WriteLine("5-Modificar datos de los estudiantes");
                    Console.WriteLine("6-Menu de reportes");
                    Console.WriteLine("7-Salir");
                    Console.WriteLine("Ingrese una opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            estudiante.Inicializarvectores();
                            break;
                        case 2:
                            estudiante.Agregarestudiante();
                            break;
                        case 3:
                            estudiante.Consultarestudiante();
                            break;
                        case 4:
                            estudiante.Eliminarestudiantes();
                            break;
                        case 5:
                            estudiante.Modificarestudiante();
                            break;
                        case 6:

                            int opcion1;


                            {
                                Console.WriteLine("1-Reporte de estudiantes por condicion");
                                Console.WriteLine("2-Reporte de todos los datos de los estudiantes");
                                Console.WriteLine("3-Regresar al menu principal");
                                opcion1 = Convert.ToInt32(Console.ReadLine());

                                switch (opcion1)
                                {
                                    case 1:
                                        estudiante.Reportecondicion();
                                        break;
                                    case 2:
                                        estudiante.Reportetotal();
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