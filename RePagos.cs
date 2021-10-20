using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
   public class RePagos
    {

        public int pagoN;

        public string fechaC;
        public string horaC;
        public int cedulaC;
        public string nombreC;
        public string apellidoC;
        public int numeroDePago;
        public int canEs;
        public int servicioO;
        public string servicioN = "";
        public double pagoTotal;
        public double comision ;
        public double montoPaga;
        public double pagaCon;
        public int numeroFac;

        public double vuelto;






        public RePagos()
        {


        int numeroDepago = 0;
        int indexC = 0;
            canEs=0;
            Console.WriteLine("Selecciono Pagos");
            Console.WriteLine("");
            Console.WriteLine("Por favor indique la cantidad de pagos que desea ingresar");
            canEs = Int32.Parse(Console.ReadLine());
            if (canEs>=10) {
                Console.WriteLine("");
                Console.WriteLine("El programa se diseño para 10 usuarios o pagos");
                Console.WriteLine("");
                Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                Console.ReadKey();
                Menu menuinicial = new Menu();


            }


            while (indexC > 10 || indexC < canEs)
            {


                Console.WriteLine("Por favor digite el nombre del usuario");
                nombreC = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Por favor digite los apellidos del usuario");
                apellidoC = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Por favor digite la cedula del usuario ");
                cedulaC = Int32.Parse(Console.ReadLine()); 
                Console.WriteLine("");
                Console.WriteLine("Por favor digite el numero De Factura ");
                numeroFac = Int32.Parse(Console.ReadLine()); 
                Console.WriteLine("");
                Console.WriteLine("Por favor digite el numero del servicio que desea pagar");
                Console.WriteLine("\t1 - Pagar el recibo del servicio electrico");
                Console.WriteLine("\t2 - Pagar el Telefono");
                Console.WriteLine("\t3 - Pagar el recibo de Agua");
                servicioO = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite el monto a pagar");
                montoPaga = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (servicioO)
                {
                    case 1:
                        servicioN = "Servicio Electrico";
                        break;
                    case 2:
                        servicioN = "Servicio Telefonico";
                        break;
                     case 3:
                        servicioN = "Servicio De Agua Publica";
                        break;


                    default:
                        Console.WriteLine("No se selecciono ninguna opcion valida");
                        Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                        Console.ReadKey();
                        Menu menuinicial = new Menu();
                        break;
                }


               

                switch(servicioN)
                {
                    case "Servicio Electrico":
                         comision= 4/montoPaga;
                        comision = comision * 100;

                        break;
                    case "Servicio Telefonico":
                        comision = 5.5/montoPaga;
                        comision = comision*100;

                        break;
                    case "Servicio De Agua Publica":
                        comision = 6.5/ montoPaga;
                        comision = comision*100;
                        break;


                  
                }


                Console.WriteLine("Por favor digite con cuanto esta pagando");
                pagaCon = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");


                string hora = DateTime.Now.ToString("hh:mm:ss tt");
                string fecha = DateTime.Now.ToString("dd-MM-yyyy");
                pagoTotal = montoPaga - comision;
                vuelto = pagaCon - montoPaga;
                Random r = new Random();
                int cajaR = r.Next(1, 3);
                System.Console.Clear();

                Console.WriteLine($"---------------------------Prefactura Generada---------------------------");
                Console.WriteLine("");
                Console.WriteLine($"     Numero De Pago: {numeroDepago}               Caja Numero: {cajaR}");
                Console.WriteLine("");
                Console.WriteLine($"     Fecha: {fecha}               Hora: {hora}" );
                Console.WriteLine("");
                Console.WriteLine($"     Cedula: {cedulaC}               Nombre: {nombreC}     Apellidos: {apellidoC}");
                Console.WriteLine("");
                Console.WriteLine($"     Tipo De Pago: {servicioN}");
                Console.WriteLine("");             
                Console.WriteLine($"     Numero De Factura: {numeroFac}                            Monto a Pagar: {montoPaga}");
                Console.WriteLine("");
                Console.WriteLine($"     Comision Autorizada: {comision}            Paga con: {pagaCon}");
                Console.WriteLine("");
                Console.WriteLine($"     Monto Deducido: {pagoTotal}                  El Vuelto es: {vuelto}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                Desea Continuar S/N                        ");
                char pagoVerif = Console.ReadKey().KeyChar;

                string pagoVerifR = Convert.ToString(pagoVerif); //esto lo converti debido a que los if no soportan comparacion directa con char o no se como hacerlo

                if(montoPaga>pagaCon) {
                 Console.WriteLine("Lo sentimos no podemos realizar la transaccion ya que el monto a pagar es superior a los fondos proporcionados");
                 Console.WriteLine("");
                 Console.WriteLine("Volviendo al menu principal, tocar cualquier tecla para regresar");
                 Console.ReadKey();
                 Menu menuinicial = new Menu();


                }

                System.Console.Clear();
                if (pagoVerifR == "S" || pagoVerifR == "s")
                {

                    InicializarVectores.nombre[indexC] = nombreC;
                    InicializarVectores.apellido[indexC] = apellidoC;
                    InicializarVectores.cedulaUser[indexC] = cedulaC;
                    InicializarVectores.numeroDeFactura[indexC] = numeroFac;
                    InicializarVectores.servicioPago[indexC] = servicioN;
                    InicializarVectores.montoTotalPagado[indexC] = pagoTotal;
                    InicializarVectores.pagoSinComision[indexC] = montoPaga;
                    InicializarVectores.pagoConComision[indexC] = comision;
                    InicializarVectores.pagoCon[indexC] = pagaCon;
                    InicializarVectores.hora[indexC] = hora;
                    InicializarVectores.fecha[indexC] = fecha;
                    InicializarVectores.caja[indexC] = cajaR;
                    InicializarVectores.numeroDePago[indexC] = numeroDepago;
                    InicializarVectores.vueltoAlCliente[indexC] = vuelto;



                    numeroDepago++;

                    indexC++;
                    Console.WriteLine("");
                    Console.WriteLine("Pago agregado exitosamente...");

                } // end of if

                else {
                    Console.WriteLine("");
                    Console.WriteLine("Volviendo al menu principal, tocar cualquier tecla para regresar");
                    Console.ReadKey();
                    Menu menuinicial = new Menu();

                } // end of else 








            }// end While



            } ///end the metodo







        }
}
