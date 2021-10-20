using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
    public class ConsultarPagos
    {


        public int indexPago;
        public int pagoSubMenu;


      public  ConsultarPagos() {


            Console.WriteLine("Selecciono Consultar pagos");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese el numero de pago que desea consultar");
            indexPago = Int32.Parse(Console.ReadLine());
            if (indexPago <= InicializarVectores.numeroDePago[indexPago])
            {

                foreach(int i in InicializarVectores.numeroDePago) {

                    if (indexPago==i)
                    
                    
                    {

                        Console.WriteLine($"Su pago ha sido encontrado, posicion: {indexPago}");

                        Console.WriteLine("");
                        Console.WriteLine("\t1 - Ver registro de pago");
                        Console.WriteLine("\tOtra tecla - Salir al menu principal");
                        pagoSubMenu = Int32.Parse(Console.ReadLine());

                        if (pagoSubMenu == 1)
                        {


                            Console.WriteLine($"---------------------------      Consulta de Factura      ---------------------------");
                            Console.WriteLine("");
                            Console.WriteLine($"     Numero De Pago: {InicializarVectores.numeroDePago[indexPago]}            Caja Numero: {InicializarVectores.caja[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Fecha: {InicializarVectores.fecha[indexPago]}            Hora: {InicializarVectores.hora[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Cedula: {InicializarVectores.cedulaUser[indexPago]}            Nombre: {InicializarVectores.nombre[indexPago]}     Apellidos: {InicializarVectores.apellido[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Tipo De Pago: {InicializarVectores.servicioPago[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Numero De Factura: {InicializarVectores.numeroDeFactura[indexPago]}                           Monto a Pagar: {InicializarVectores.pagoSinComision[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Comision Autorizada: {InicializarVectores.pagoConComision[indexPago]}            Paga con: {InicializarVectores.pagoCon[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine($"     Monto Deducido: {InicializarVectores.montoTotalPagado[indexPago]}                  El Vuelto es: {InicializarVectores.vueltoAlCliente[indexPago]}");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine($"-------------------------  Para Regresar al menu toque cualquier tecla  -----------------------");



                            Console.ReadKey();
                            Menu menuinicial01 = new Menu();






                        }


                        else {

                            Console.WriteLine("Numero de Factura no encontrado");
                            Console.ReadKey();
                            Menu menuinicial00 = new Menu();


                        }






                    }// end if 




                }// end foreach

                Console.WriteLine("El numero de factura no se encontro");
                Console.WriteLine("Toque cualquier tecla para regresar al menu");
                Console.ReadKey();
                Menu menuinicial = new Menu();

                


            } //end if externo







        } // end metodo control pagos 






    }
}
