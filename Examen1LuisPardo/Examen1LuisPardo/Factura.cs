using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1LuisPardo
{
    class Factura
    {
        string hora = DateTime.Now.ToString("hh:mm:ss tt");
        string fecha = DateTime.Now.ToString("dd-MM-yyyy");
        string[] factura = new string[10];

        public void InicializarVectores()
        {
            for (int i = 0; i < factura.Length; i++)
            {
                factura[i] = "";
                

            }

        }

        public void RealizarPago()
        {
            

            int luz = 1, telefono = 2;
            int[] NumeroPago = new int[] { 1 }; string[] fecha = new string[10]; string[] hora = new string[10];
            int[] cedula = new int[10]; string[] nombre = new string[10]; string[] apellido1 = new string[10];
            string[] apellido2 = new string[10]; int[] NumeroCaja = new int[10];
            int[] TipoServicio = new int[10]; int[] NumeroFactura = new int[10];
            double[] MontoPagar = new double[10]; double[] MontoComision = new double[10];
            double[] MontoDeducido = new double[10]; double[] MontoCliente = new double[10];
            double[] MontoVuelto = new double[10];

            for (int i = 0; i < factura.Length; i++)
            {
                
                Console.WriteLine($"El Número de Pago asignado es { NumeroPago[i] }");
                NumeroPago[i] = NumeroPago[i++];                
                Console.WriteLine("Ingrese la Cédula");
                cedula[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el primer Apellido");
                apellido1[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo Apellido");
                apellido2[i] = Console.ReadLine();
                Random rndom = new Random();
                NumeroCaja[i] = rndom.Next(1, 3);
                Console.WriteLine($"El Número de Caja asignado es {NumeroCaja[i]}");                
                Console.WriteLine("Ingrese el Tipo de Servicio:");
                Console.WriteLine("1- Recibo de Luz");
                Console.WriteLine("2- Recibo de Telefóno");
                Console.WriteLine("3- Recibo de Agua");
                TipoServicio[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Número de Factura");
                NumeroFactura[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Monto a Pagar");
                MontoPagar[i] = double.Parse(Console.ReadLine());
                if (TipoServicio[i] == luz)
                    MontoComision[i] = MontoPagar[i] * 0.04;
                else
                    if (TipoServicio[i] == telefono)
                    MontoComision[i] = MontoPagar[i] * 0.055;
                else
                    MontoComision[i] = MontoPagar[i] * 0.065;
                Console.WriteLine($"La comision es de {MontoComision[i]}");
                
                MontoDeducido[i] = MontoPagar[i] - MontoComision[i];
                Console.WriteLine($"El monto deducido es de {MontoDeducido[i]}");
                Console.WriteLine("Ingrese el Monto del Cliente");
                MontoCliente[i] = double.Parse(Console.ReadLine());
                MontoVuelto[i] = MontoCliente[i] - MontoPagar[i];
                Console.WriteLine($"El vuelto es de {MontoVuelto[i]}");
                System.Console.Clear();



                Console.WriteLine($"                             Sistema de Pago de Servicios Públicos                            ");
                Console.WriteLine("                             Tienda La Favorita - Ingreso de Datos                            ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"  Numero de Pago:      {NumeroPago}                        Número de Caja: {NumeroCaja}");
                Console.WriteLine("");
                Console.WriteLine($"  Fecha:               {fecha}                             Hora:           {hora}");
                Console.WriteLine("");
                Console.WriteLine($"  Cedula:              {cedula}                            Nombre:         {nombre}");
                Console.WriteLine($"  Apellido1:           {apellido1}                         Apellido2:      {apellido2}");
                Console.WriteLine("");
                Console.WriteLine($"  Tipo de Servicio:    {TipoServicio}          [1-Electricidad  2-Teléfono  3-Agua]");
                Console.WriteLine("");
                Console.WriteLine($"  Numero De Factura:   {NumeroFactura}                     Monto a Pagar:  {MontoPagar}");                
                Console.WriteLine($"  Comisión autorizada: {MontoComision}                     Paga con:       {MontoCliente}");                
                Console.WriteLine($"  Monto deducido:      {MontoDeducido}                     Vuelto:         {MontoVuelto}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                      Desea Continuar S/N?                                    ");



                Console.ReadKey();
            }

        }

        public void ConsultarPago()
        { 
            string buscarPago = "";
        
            Console.WriteLine("Ingrese el Número de Pago que desea consultar");
            buscarPago = Console.ReadLine();

            

        }
        public void ModificarPago()
        {
            string modificarPago = "";

            Console.WriteLine("Ingrese el Número de Pago que desea Modificar");
            modificarPago = Console.ReadLine();



        }
        public void EliminarPago()
        {
            string eliminarPago = "";

            Console.WriteLine("Ingrese el Número de Pago que desea Eliminar");
            eliminarPago = Console.ReadLine();

        }
        

    }
}
