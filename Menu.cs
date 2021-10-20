using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
    public class Menu
    {


        public Menu()
        {
            System.Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"-------------------- Menu Del Cajero--------------");
            Console.WriteLine("\n");
            Console.WriteLine("\tA - Inicializar Vectores");
            Console.WriteLine("\tB - Realizar Pagos");
            Console.WriteLine("\tC - Consultar Pagos");
            Console.WriteLine("\tD - Modificar Pagos");
            Console.WriteLine("\tE - Eliminar Pagos");
            Console.WriteLine("\tF - Sub-menu Reportes");
            Console.WriteLine("\tG - Salir");
            


            //Esto permite que solo se pueda ingresar un caracter letra o numero//
            char seleccion = Console.ReadKey().KeyChar;


           

            //Lo convierto a string para poder usar el switch 
            string seleConversion = Convert.ToString(seleccion);

            //Convierte el caracter a mayuscula, con numeros no produce error.
            string selecRevisada = seleConversion.ToUpper();


            Console.WriteLine(" es la tecla seleccionada ");

            System.Console.Clear();


            // solo se ejecuta el Swith si la opcion es valida
            if (selecRevisada == "A" || selecRevisada == "B" ||
                selecRevisada == "C" || selecRevisada == "D" ||
                selecRevisada == "E" || selecRevisada == "F" ||
                selecRevisada == "G")

            {

                Console.WriteLine("\n");
                Console.WriteLine("\n");

                switch (selecRevisada)
                {
                    case "A":

                        Console.WriteLine("");
                        Console.WriteLine("Arreglos inicializados");
                        Console.WriteLine("");

                        InicializarVectores iniciarV = new InicializarVectores();
                        

                        break;

                    case "B":

                        if (InicializarVectores.prinInC == 77)
                        {


                            Console.WriteLine("");
                            Console.WriteLine("Realizar Pagos");
                            Console.WriteLine("");
                            System.Console.Clear();

                            RePagos pagos = new RePagos();  



                        }
                        else {
                            Console.WriteLine("Debe De iniciar los arreglos primero");
                            System.Console.Clear();

                        }
                        



                        break;

                    case "C":

                        if (InicializarVectores.prinInC == 77)
                        {
                            Console.WriteLine("");
                        Console.WriteLine("Consultando Datos..");
                        Console.WriteLine("");
                

                        ConsultarPagos consulta = new ConsultarPagos();

                        }
                        else
                        {
                            Console.WriteLine("Debe De iniciar los arreglos primero");
                            System.Console.Clear();

                        }



                        break;

                    case "D":
                        Console.WriteLine("Modificar Pagos");
                        Console.WriteLine("");
                        Mpagos pagosV = new Mpagos();




                        break;

                    case "E":

                        Console.WriteLine("Eliminar Pagos");
                        Console.WriteLine("");
                        EliminarPago eliminarPago = new EliminarPago();

                        break;


                    case "F":

                        Console.WriteLine("Reportes");
                        Console.WriteLine("");
                        Reportes reporten = new Reportes();



                        break;

                    case "G":

                        //Recien aprendido :)  
                        Environment.Exit(0);

                        break;

                }

            }



            else {

                Console.WriteLine("  Por favor digite una opcion valida del menu");
               
          
                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                Console.ReadKey();
                Console.WriteLine("\n");
                Menu menuinicial = new Menu();




            }



            

            Console.WriteLine("Presione cualquier tecla para regresar al menu");
            Console.ReadKey();
            Menu menuinicial03 = new Menu();


















            //End T



        }//End Class



} //menuP
}
