using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
    public class Reportes
    {

      public int controRe;
      public int cotrolRe2;
      public string servicioR;

        public Reportes() {


            Console.WriteLine("Bienvenido al SUB Menu Reportes");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t1 - Ver todos los pagos");
            Console.WriteLine("\t2 - Ver pagos por tipo de servicio");
            Console.WriteLine("\t3 - Ver pagos por codigo de caja");
            Console.WriteLine("\t4 - Ver dinero comisionado por servicio");
            Console.WriteLine("\t5 - Regresar al menu principal");
            controRe = Int32.Parse(Console.ReadLine());


            switch (controRe) { 
            
                    case 1:


                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("#Pago      Fecha/hora      Pago     Cedula       Apellidos         Monto Recibido");
                    for (int i = 0; i < 10; i++)
                    {
                        

                        Console.WriteLine($"{InicializarVectores.numeroDePago[i]}  {InicializarVectores.fecha[i]}/{InicializarVectores.hora[i]}  {InicializarVectores.pagoSinComision[i]}  {InicializarVectores.cedulaUser[i]}     {InicializarVectores.apellido[i]}      {InicializarVectores.pagoCon[i]} " );

















                    }
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------");



                    break;





                case 2:

                    Console.WriteLine("");
                    Console.WriteLine("Ver pagos por tipos de servicio");
                    Console.WriteLine("");
                    Console.WriteLine("\t1 - Electricidad");
                    Console.WriteLine("\t2 - Telefono");
                    Console.WriteLine("\t3 - Agua");
                    Console.WriteLine("");
                    cotrolRe2 = Int32.Parse(Console.ReadLine());

                    //servicioR


                    switch (controRe)
                    {
                        case 1:
                            servicioR = "Servicio Electrico";
                            break;
                        case 2:
                            servicioR = "Servicio Telefonico";
                            break;
                        case 3:
                            servicioR = "Servicio De Agua Publica";
                            break;
                    }




                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("#Pago      Fecha/hora      Pago     Cedula       Apellidos         Monto Recibido");




                    foreach (int i in InicializarVectores.numeroDePago)
                    {


                        if(InicializarVectores.servicioPago[i]== servicioR) {

                         Console.WriteLine($"{InicializarVectores.numeroDePago[i]}  {InicializarVectores.fecha[i]}/{InicializarVectores.hora[i]}  {InicializarVectores.pagoSinComision[i]}  {InicializarVectores.cedulaUser[i]}     {InicializarVectores.apellido[i]}         {InicializarVectores.pagoCon[i]} ");


                            break;



                        }










                    }


                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------");











                    break;



                case 3:

                    Console.WriteLine("");
                    Console.WriteLine("Ver pagos por tipos de caja ");
                    Console.WriteLine("");
                    Console.WriteLine("\t1 -  Caja #1");
                    Console.WriteLine("\t2 -  Caja #2");
                    Console.WriteLine("\t3 -  Caja #3");
                    Console.WriteLine("");
                    cotrolRe2 = Int32.Parse(Console.ReadLine());

                    //servicioR


         




                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("#Pago      Fecha/hora      Pago     Cedula       Apellidos         Monto Recibido");




                    foreach (int i in InicializarVectores.caja)
                    {


                        if (InicializarVectores.caja[i] == cotrolRe2)
                        {

                            Console.WriteLine($"{InicializarVectores.numeroDePago[i]}  {InicializarVectores.fecha[i]}/{InicializarVectores.hora[i]}  {InicializarVectores.pagoSinComision[i]}  {InicializarVectores.cedulaUser[i]}     {InicializarVectores.apellido[i]}          {InicializarVectores.pagoCon[i]} ");


                            break;



                        }










                    }


                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------");







                    break;


                case 4:

                    Console.WriteLine("Las disculpas del caso profe me faltaron unos minutos para completarlo :) ");



                    break;



                case 5:



                    Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                    Console.ReadKey();
                    Menu menuinicial = new Menu();
                    break;


                 


                default:
                    Console.WriteLine("No se selecciono ninguna opcion valida");
                    Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                    Console.ReadKey();
                    Menu menuinicial0057 = new Menu();
                    break;







            } // en swith













        }






    }
}
