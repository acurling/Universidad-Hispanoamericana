using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
    public class Mpagos
    {
        public int indexEdiPago;
        public int subMenuEdi;
        public int servicioEdi;
        public Mpagos() {



            Console.WriteLine("Selecciono Editar pagos");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese el numero de pago que desea editar");
            indexEdiPago = Int32.Parse(Console.ReadLine());

            if (indexEdiPago <= InicializarVectores.numeroDePago[indexEdiPago])
            {
                foreach (int i in InicializarVectores.numeroDePago)
                {

                    if (i == indexEdiPago) {



                        Console.WriteLine($"Su pago ha sido encontrado, posicion: {indexEdiPago}");



                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"---------------------------      Edicion de Factura      ---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine($"     Numero De Pago: {InicializarVectores.numeroDePago[indexEdiPago]}            Caja Numero: {InicializarVectores.caja[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Fecha: {InicializarVectores.fecha[indexEdiPago]}            Hora: { InicializarVectores.hora[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Cedula: {InicializarVectores.cedulaUser[indexEdiPago]}            Nombre: {InicializarVectores.nombre[indexEdiPago]}     Apellidos: {InicializarVectores.apellido[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Tipo De Pago: {InicializarVectores.servicioPago[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Numero De Factura: {InicializarVectores.numeroDeFactura[indexEdiPago]}                           Monto a Pagar: {InicializarVectores.pagoSinComision[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Comision Autorizada: {InicializarVectores.pagoConComision[indexEdiPago]}            Paga con: {InicializarVectores.pagoCon[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Monto Deducido: {InicializarVectores.montoTotalPagado[indexEdiPago]}                  El Vuelto es: {InicializarVectores.vueltoAlCliente[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------  Para cualquier tecla para editar el registro  -----------------------");
                        Console.ReadKey();
                        System.Console.Clear();








                        Console.WriteLine($"-----SUB-MENU-----");

                        Console.WriteLine("");
                        Console.WriteLine("\t1 - Editar Nombre");
                        Console.WriteLine("\t2 - Editar Apellidos");
                        Console.WriteLine("\t3 - Editar Cedula");
                        Console.WriteLine("\t4 - Editar Servicio pagado");
                        subMenuEdi = Int32.Parse(Console.ReadLine());

                        switch(subMenuEdi) {
                            case 1:
                                Console.WriteLine("Por favor digite el nuevo nombre");
                                InicializarVectores.nombre[indexEdiPago] = Console.ReadLine();

                                break;



                            case 2:

                                Console.WriteLine("Por favor digite los nuevos apellidos");
                                InicializarVectores.apellido[indexEdiPago] = Console.ReadLine();

                                break;


                            case 3:
                                Console.WriteLine("Por favor digite el nuevo de cedula");
                               
                                InicializarVectores.cedulaUser[indexEdiPago]= Int32.Parse(Console.ReadLine());

                                break;



                            case 4:
                                Console.WriteLine("Por favor digite el numero del servicio al cual quiere cambiar");
                                Console.WriteLine("");
                                Console.WriteLine("\t1 - Pagar el recibo del servicio electrico");
                                Console.WriteLine("\t2 - Pagar el Telefono");
                                Console.WriteLine("\t3 - Pagar el recibo de Agua");
                                servicioEdi = Int32.Parse(Console.ReadLine());

                                switch (servicioEdi)
                                {
                                    case 1:
                                        InicializarVectores.servicioPago[indexEdiPago] = "Servicio Electrico";
                                        break;
                                    case 2:
                                        InicializarVectores.servicioPago[indexEdiPago] = "Servicio Telefonico";
                                        break;
                                    case 3:
                                        InicializarVectores.servicioPago[indexEdiPago] = "Servicio De Agua Publica";
                                        break;
                                }






                                        break;


                            default:
                                Console.WriteLine("No se selecciono ninguna opcion valida");
                                Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                                Console.ReadKey();
                                Menu menuinicial = new Menu();
                                break;






                        } // end swith


















                        Console.WriteLine("Registro editado exitosamente");
                        Console.WriteLine("Pulse cualquier tecla para ver el estado final del registro");
                        Console.ReadKey();
                        System.Console.Clear();

                        Console.WriteLine($"---------------------------      Edicion de Factura      ---------------------------");
                        Console.WriteLine("");
                        Console.WriteLine($"     Numero De Pago: {InicializarVectores.numeroDePago[indexEdiPago]}            Caja Numero: {InicializarVectores.caja[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Fecha: {InicializarVectores.fecha[indexEdiPago]}            Hora: { InicializarVectores.hora[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Cedula: {InicializarVectores.cedulaUser[indexEdiPago]}            Nombre: {InicializarVectores.nombre[indexEdiPago]}     Apellidos: {InicializarVectores.apellido[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Tipo De Pago: {InicializarVectores.servicioPago[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Numero De Factura: {InicializarVectores.numeroDeFactura[indexEdiPago]}                           Monto a Pagar: {InicializarVectores.pagoSinComision[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Comision Autorizada: {InicializarVectores.pagoConComision[indexEdiPago]}            Paga con: {InicializarVectores.pagoCon[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine($"     Monto Deducido: {InicializarVectores.montoTotalPagado[indexEdiPago]}                  El Vuelto es: {InicializarVectores.vueltoAlCliente[indexEdiPago]}");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------  Para Regresar al menu toque cualquier tecla  ------------------");

                        Console.ReadKey();

                        Menu menuinicial007 = new Menu();






                    } // end If interno 1

                  










                }// End Foreach









            }// end if externo

            else {

                Console.WriteLine("El numero de factura no se encontro");
                Console.WriteLine("Toque cualquier tecla para regresar al menu");
                Console.ReadKey();
                Menu menuinicial = new Menu();


            }
            




        }





    }
}
