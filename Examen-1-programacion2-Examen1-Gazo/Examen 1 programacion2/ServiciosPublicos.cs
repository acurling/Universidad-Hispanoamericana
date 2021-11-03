using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_programacion2
{
    class ServiciosPublicos
    {
        String[] CajaNumero = new string[10];
        String[] Hora = new string[10];
        String[] NumeroPago = new string[10];
        String[] Fecha = new string[10];
        String[] Cedula = new string[10];
        String[] Nombre = new string[10];
        String[] Apellido = new string[10];
        String[] Apellido2 = new string[10];
        String[] TipoServicio = new string[10];
        String[] NumeroFactura = new string[10];
        String[] MontoPagar = new string[10];
        String[] MontoComicion = new string[10];
        String[] MontoDeducido = new string[10];
        String[] MontoPagaCliente = new string[10];
        String[] Vuelto = new string[10];
        
        int pos;
        decimal num1, num2, resultado, num3, resultado1, resultado2 ;
        

        //Constructores
        public ServiciosPublicos()
        {
            pos = 0;
            
            num1 = 0.0m; num2 = 0.0m; resultado = 0.0m; num3 = 0.0m; resultado1 = 0.0m; resultado2 = 0.0m;
        }



        public void Inicializarvectores()
        {

            for (int i = 0; i < NumeroPago.Length; i++)
            {
                Cedula[i] = "";
                Nombre[i] = "";
                Apellido[i] = "";
                Apellido2[i] = "";
                NumeroFactura[i] = "";
                NumeroPago[i] = "";
                Fecha[i] = "";
                TipoServicio[i] = "";
                MontoPagar[i] = "";
                MontoComicion[i] = "";
                MontoDeducido[i] = "";
                MontoPagaCliente[i] = "";
                Vuelto[i] = "";
                Hora[i] = "";
                CajaNumero[i] = "";
            }
        }
        public void PagoServicios()
        {
            char opcion = 's';
            do
            {
                Console.WriteLine("Digite el Servicio que desea pagar (Electricidad,Agua,Telefono)");
                TipoServicio[pos] = Console.ReadLine();
                Console.WriteLine("Digite el numero de pago");
                NumeroPago[pos] = Console.ReadLine();
                Console.WriteLine("Digite el nombre ");
                Nombre[pos] = Console.ReadLine();
                Console.WriteLine("Digite el primer apellido  ");
                Apellido[pos] = Console.ReadLine();
                Console.WriteLine("Digite el el segundo apellido ");
                Apellido2[pos] = Console.ReadLine();
                Console.WriteLine("Digite el numero de cedula");
                Cedula[pos] = Console.ReadLine();
                Console.WriteLine("Digite el monto a pagar");
                MontoPagar[pos] = Console.ReadLine();
                Console.WriteLine("Iniciando el proceso de pago");
                Console.WriteLine("Digite el monto a pagar");
                num2= int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el valor de la comicion (Electricidad = 4 ,agua = 6, telefono = 5");
                num1 = int.Parse(Console.ReadLine());
                resultado = (num1 * num2)/100;
                Console.WriteLine($"La comicion  es de:{resultado}");
                MontoComicion[pos] = Convert.ToString(resultado);
                Console.WriteLine("Digite el monto con el cual se paga");
                num3 = int.Parse(Console.ReadLine());
                MontoPagaCliente[pos] = Convert.ToString(num3);
                resultado1 = (num3 - num2);
                Console.WriteLine($"El vuelto es de:{resultado1}");
                Vuelto[pos] = Convert.ToString(resultado1);
                resultado2 = (num2 - resultado);
                Console.WriteLine($"El monto deducido es de:{resultado2}");
                MontoDeducido[pos] = Convert.ToString(resultado2);
                string Date = DateTime.Now.ToString("dd-MM-yyyy");
                Console.WriteLine("La Fecha es {0}.", Date);
                Fecha[pos] = Convert.ToString(Date);
                string datetime = DateTime.Now.ToString("hh:mm:ss tt");
                Console.WriteLine("La hora es {0}.", datetime);
                Hora[pos] = Convert.ToString(datetime);
                Random NumeroDeCaja = new Random();
                Console.WriteLine("El numero de caja es {0}", NumeroDeCaja.Next(1,3));
                Console.ReadLine();
                CajaNumero[pos] = Convert.ToString(NumeroDeCaja);
                pos++;
                Console.WriteLine("Desea agregar otro pago s/n");
                opcion = Convert.ToChar(Console.ReadLine());

            } while (opcion != 'n');
        }



        public void ConsultarPagos()
        {
            Console.WriteLine("Ingrese El numero de pago:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < NumeroPago.Length; i++)
            {
                if (ced.Equals(NumeroPago[i]))
                {
                    Console.WriteLine($"El pago de {TipoServicio[i]} esta a nombre de : {Nombre[i]}   {Apellido[i]}    {Apellido2[i]} y tiene un valor de {MontoPagar[i]} ");
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Pago no existe");
            }
        }


        public void EliminarPagos()
        {
            char opcion1 = 'n';
            do
            {
                Console.WriteLine("Esta seguro de eliminar el pago s/n");
                opcion1 = Convert.ToChar(Console.ReadLine());

                if (NumeroPago == null)
             {
                Console.Clear();
                Console.WriteLine("NO Existen pagos para eliminar");
                _ = Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Por favor digite el numero de pago que desea eliminar?");
                String busqueda = Console.ReadLine();
                

                    for (int i = 0; i < NumeroPago.Length; i++)
                {
                    if (busqueda == NumeroPago[i])
                    {
                        Cedula[i] = null;
                        Nombre[i] = null;
                        Apellido[i] = null;
                        Apellido2[i] = null;
                        NumeroFactura[i] = null;
                        NumeroPago[i] = null;
                        Fecha[i] = null;
                        TipoServicio[i] = null;
                        MontoPagar[i] = null;
                        MontoComicion[i] = null;
                        MontoDeducido[i] = null;
                        MontoPagaCliente[i] = null;
                        Vuelto[i] = null;
                        Hora[i] = null;
                        CajaNumero[i] = null;      
                    }
               }
                }
               
            } while (opcion1 != 's');
        }


        public void ModificarPagos()
        {
            Console.WriteLine("Ingrese El numero de pago:");
            string mod = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < NumeroPago.Length; i++)
            {
                if (mod.Equals(NumeroPago[i]))
                {
                    Console.WriteLine("Digite el Servicio que desea pagar (Electricidad,Agua,Telefono)");
                    TipoServicio[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el numero de pago");
                    NumeroPago[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el nombre ");
                    Nombre[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el primer apellido  ");
                    Apellido[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el el segundo apellido ");
                    Apellido2[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el numero de cedula");
                    Cedula[pos] = Console.ReadLine();
                    Console.WriteLine("Digite el monto a pagar");
                    MontoPagar[pos] = Console.ReadLine();
                    Console.WriteLine("Iniciando el proceso de pago");
                    Console.WriteLine("Digite el monto a pagar");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el valor de la comicion (Electricidad = 4 ,agua = 6, telefono = 5");
                    num1 = int.Parse(Console.ReadLine());
                    resultado = (num1 * num2) / 100;
                    Console.WriteLine($"La comicion  es de:{resultado}");
                    MontoComicion[pos] = Convert.ToString(resultado);
                    Console.WriteLine("Digite el monto con el cual se paga");
                    num3 = int.Parse(Console.ReadLine());
                    MontoPagaCliente[pos] = Convert.ToString(num3);
                    resultado1 = (num3 - num2);
                    Console.WriteLine($"El vuelto es de:{resultado1}");
                    Vuelto[pos] = Convert.ToString(resultado1);
                    resultado2 = (num2 - resultado);
                    Console.WriteLine($"El monto deducido es de:{resultado2}");
                    MontoDeducido[pos] = Convert.ToString(resultado2);
                    string Date = DateTime.Now.ToString("dd-MM-yyyy");
                    Console.WriteLine("La Fecha es {0}.", Date);
                    Fecha[pos] = Convert.ToString(Date);
                    string datetime = DateTime.Now.ToString("hh:mm:ss tt");
                    Console.WriteLine("La hora es {0}.", datetime);
                    Hora[pos] = Convert.ToString(datetime);
                    Random NumeroDeCaja = new Random();
                    Console.WriteLine("El numero de caja es {0}", NumeroDeCaja.Next(1, 3));
                    Console.ReadLine();
                    CajaNumero[pos] = Convert.ToString(NumeroDeCaja);
                    existe = true;
                    pos++;
                    Console.Clear();
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Pago no existe");
            }


        }



        public void Reportetotal()

        {
            Console.Clear();
            Console.SetCursorPosition(45, 10); 
            Console.WriteLine("***** Reporte de Facturas *****");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("Cedula");
            Console.SetCursorPosition(70, 12);
            Console.WriteLine("Monto de factura");
            Console.SetCursorPosition(90, 12);
            Console.WriteLine("Fecha");
            Console.SetCursorPosition(105, 12);
            Console.WriteLine("# pago");
            Console.SetCursorPosition(110, 12);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            
            int contador = 14;
            for (int i = 0; i < Nombre.Length; i++)
            {
                Console.SetCursorPosition(40, contador++);
                Console.WriteLine($"{Nombre[i]}            {Cedula[i]}           {MontoPagar[i]}           {Fecha[i]}             {NumeroPago[i]}             ");

            }
           

        }

        public void ReporteTipoServicio()

        {
            Console.Clear();
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("***** Reporte por tipo de servicio *****");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("Cedula");
            Console.SetCursorPosition(70, 12);
            Console.WriteLine("Monto de factura");
            Console.SetCursorPosition(90, 12);
            Console.WriteLine("Fecha");
            Console.SetCursorPosition(105, 12);
            Console.WriteLine("# pago");
            Console.SetCursorPosition(110, 12);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

            int contador = 14;
            for (int i = 0; i < TipoServicio.Length; i++)
            {
                Console.SetCursorPosition(40, contador++);
                Console.WriteLine($"{Nombre[i]}            {TipoServicio[i]}           {MontoPagar[i]}           {Fecha[i]}             {NumeroPago[i]}             ");

            }


        }


    }
}
  
