using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN1
{
    class ClsMenu
    {
        static bool error = false;
        static int opcion;
        static ClsPersona per = new ClsPersona();
        public static void principal()
        {

            do
            {
                error = false;
                opcion = 0;
                try
                {
                    do
                    {
                        Console.WriteLine("***** MENU *****");
                        Console.WriteLine("1- Inicializar vectores");
                        Console.WriteLine("2- Realizar pagos ");
                        Console.WriteLine("3- Consultar pagos");
                        Console.WriteLine("4- Modificar pagos");
                        Console.WriteLine("5- Eliminar pagos");
                        Console.WriteLine("6- Submenú de reportes");
                        Console.WriteLine("7- Salir");
                        Console.WriteLine();
                        Console.WriteLine("Digite su opción");
                        opcion = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion)
                        {
                            case 1: per.inicializar(); break;
                            case 2: per.RealizarPagos(); break;
                            case 3: per.ConsultarDatos(); break;
                            case 4: per.ModificarPago(); break;
                            case 5: per.BorrarPago(); break;
                            case 6: per.Submenu(); break;
                            case 7: break;

                            default: break;
                        }


                    } while (opcion != 7);
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida");
                    Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                    Console.ReadLine();
                    Console.Clear();
                    error = true;
                    
                }
                
            } while (error);
            
        }
        
    }
}
