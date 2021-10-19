using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN1
{
    class ClsPersona
    {
        float total_1; // cantidad de transacciones
        float total_2; // total de comisiones
        float Total_E; // total de comision electricidad
        float Total_T; // total de comision telefonico
        float Total_A; // total de comision agua
        float acum =  0; //  para el monto total
        float acum2 = 0; // Para los registros
        float Acum_E = 0; // total registros electricidad
        float Acum_T = 0; //  total registros telefonicos
        float Acum_A = 0; // total registros agua
        float acum3 = 0; // montos totales dependiendo del servicio
        float acum4 = 0; // para total de registros por caja del submenú
        float[] NumeroDePago = new float[10];
        string[] Fecha = new string[10];
        string[] Hora = new string[10];
        float[] Cedula = new float[10];
        string[] Nombre = new string[10];
        string [] Apellido1 = new string[10];
        string[] Apellido2= new string[10];
        float[] NumeroDeCaja = new float[10];
        string[] TipoDeServicio = new string[10];
        float[] NumeroDeFactura = new float [10];
        float[] MontoAPagar = new float[10];
        float[] MontoComision = new float[10];
        float[] MontoDeducido = new float[10];
        float[] MontoPagaCliente = new float[10];
        float[] Vuelto = new float[10];
        float posicion;
        public ClsPersona()
        {
            posicion = 0;
        }
        public ClsPersona(float pos)
        {
            posicion = pos;
        }

        public void inicializar()
        {
            for (int i = 0; i < 10; i++)
            {
                NumeroDePago [i] = 0;
                Fecha [i] = "*";
                Hora[i] = "*";
                Cedula[i] = 0;
                Nombre[i] = "*";
                Apellido1[i] = "*";
                Apellido2[i] = "*";
                NumeroDeCaja[i] = 0;
                TipoDeServicio[i] = "*";
                NumeroDeFactura[i] = 0;
                MontoAPagar[i] = 0;
                MontoComision[i] = 0;
                MontoDeducido[i] = 0;
                MontoPagaCliente[i] = 0;
                Vuelto[i] = 0;
                
            }
            Console.WriteLine("Vectores inicializados");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine();
            Console.WriteLine("                   Presione cualquier Tecla para volver al menú principal");
            Console.ReadLine();
            Console.Clear();
        }

        public void RealizarPagos()
        {
            bool error = false;
            do
            {
                error = false;
                try
                {
                    for (int i = 0; i < NumeroDePago.Length; i++)
                    {
                        Console.WriteLine("Digite el número de pago");
                        NumeroDePago[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite la fecha");
                        Fecha[i] = Console.ReadLine();
                        Console.WriteLine("Digite la hora");
                        Hora[i] = Console.ReadLine();
                        Console.WriteLine("Digite la cedula");
                        Cedula[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite su nombre");
                        Nombre[i] = Console.ReadLine();
                        Console.WriteLine("Digite su primer apellido");
                        Apellido1[i] = Console.ReadLine();
                        Console.WriteLine("Digite su segundo apellido");
                        Apellido2[i] = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Digite el numero de caja 1/2/3");
                            NumeroDeCaja[i] = float.Parse(Console.ReadLine());
                            if (NumeroDeCaja[i] != 1 && NumeroDeCaja[i] != 2 && NumeroDeCaja[i] != 3)
                            {
                                Console.WriteLine("Por favor digite un numero de caja disponible");
                            }
                        } while (NumeroDeCaja[i] != 1 && NumeroDeCaja[i] != 2 && NumeroDeCaja[i] != 3);
                       
                        do
                        {
                            Console.WriteLine("Digite el tipo de servicio / electricidad / agua / telefonico/ !!todo en minuscula.");
                            TipoDeServicio[i] = Console.ReadLine();
                            if (TipoDeServicio[i] != "electricidad" && TipoDeServicio[i] != "telefonico" && TipoDeServicio[i] != "agua")
                            {
                                Console.WriteLine("Por favor digite un servicio que este disponible");
                            }
                        } while (TipoDeServicio[i] != "electricidad" && TipoDeServicio[i] != "telefonico" && TipoDeServicio[i] != "agua");

                        Console.WriteLine();
                        Console.WriteLine("Digite el numero de factura");
                        NumeroDeFactura[i] = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el monto a pagar");
                        MontoAPagar[i] = float.Parse(Console.ReadLine());

                        if (TipoDeServicio[i] == "electricidad")
                        {
                            MontoComision[i] = ((float)(MontoAPagar[i] * 0.04));
                            Acum_E++;
                            Total_E = Total_E + MontoComision[i];
                        }
                        if (TipoDeServicio[i] == "telefonico")
                        {
                            MontoComision[i] = ((float)(MontoAPagar[i] * 0.055));
                            Acum_T++;
                            Total_T = Total_T + MontoComision[i];
                        }
                        if (TipoDeServicio[i] == "agua")
                        {
                            MontoComision[i] = ((float)(MontoAPagar[i] * 0.065));
                            Acum_A++;
                            Total_A = Total_A + MontoComision[i]; 
                        }
                        MontoDeducido[i] = ((float)(MontoAPagar[i] - MontoComision[i]));
                        do
                        {
                            Console.WriteLine("Digite digite el monto a pagar del cliente");
                            MontoPagaCliente[i] = float.Parse(Console.ReadLine());
                            if (MontoPagaCliente[i] < MontoAPagar[i])
                            {
                                Console.WriteLine("Tiene que digitar un monto mayor o igual correspondiente al monto a pagar");
                            }
                        } while (MontoPagaCliente[i] < MontoAPagar[i]);
                        
                        acum = acum + MontoPagaCliente[i];
                        acum2++;
                        Vuelto[i] = ((float)(MontoPagaCliente[i] - MontoAPagar[i]));
                        Console.WriteLine();
                        Console.WriteLine("¿Desea continuar? s/n");
                        char opcion = char.Parse(Console.ReadLine());
                        Console.Clear();
                        if (opcion == 'n' || opcion == 'N')
                        {
                            i = i + 21;
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida para cada apartado");
                    Console.WriteLine("Pulse cualquier tecla para iniciar de nuevo el proceso de pago / cada vez que ponga un digito nvalido tendrá que llenar todo desde 0");
                    for (int i = 0; i < 10; i++)
                    {
                        NumeroDePago[i] = 0;
                        Fecha[i] = "*";
                        Hora[i] = "*";
                        Cedula[i] = 0;
                        Nombre[i] = "*";
                        Apellido1[i] = "*";
                        Apellido2[i] = "*";
                        NumeroDeCaja[i] = 0;
                        TipoDeServicio[i] = "*";
                        NumeroDeFactura[i] = 0;
                        MontoAPagar[i] = 0;
                        MontoComision[i] = 0;
                        MontoDeducido[i] = 0;
                        MontoPagaCliente[i] = 0;
                        Vuelto[i] = 0;

                    }
                    Console.ReadLine();
                    error = true;
                   
                }
                
            } while (error);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pagos realizados");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine();
            Console.WriteLine("                   Presione cualquier Tecla para volver al menú principal");
            Console.ReadLine();
            Console.Clear();
        }

        public void ConsultarDatos()
        {
            bool error = false;
            do
            {
                error = false;
                char opcion2;
                try
                {
                    do
                    {
                        Console.WriteLine("Digite el número de pago a consultar");
                        float pago = float.Parse(Console.ReadLine());
                        for (int i = 0; i < NumeroDePago.Length; i++)
                        {

                            if (pago.Equals(NumeroDePago[i]))
                            {
                                Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                                Console.WriteLine();
                                Console.WriteLine("                    Tienda La Favorita - Consulta de Datos");
                                Console.WriteLine();
                                Console.WriteLine($"Numero de pago:    {NumeroDePago[i]}");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"                    Dato encontrado Posición vector {i}");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("                   Presione cualquier tecla para ver registro");
                                Console.ReadLine();
                                Console.Clear();


                                Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                                Console.WriteLine("                    Tienda La Favorita - Consulta de Datos");
                                Console.WriteLine();
                                Console.WriteLine($"Número de pago:       {NumeroDePago[i]}");
                                Console.WriteLine($"Fecha:                {Fecha[i]}              Hora:           {Hora[i]}");
                                Console.WriteLine();
                                Console.WriteLine($"Cedula:               {Cedula[i]}              Nombre:         {Nombre[i]}");
                                Console.WriteLine($"Apellido1:            {Apellido1[i]}              Apellido2:      {Apellido2[i]}");
                                Console.WriteLine($"Tipo de servicio:     {TipoDeServicio[i]}");
                                Console.WriteLine($"NumeroDeFactura:      {NumeroDeFactura[i]}              Monto Pagar:    {MontoAPagar[i]}");
                                Console.WriteLine($"Comisión autorizada:  {MontoComision[i]}          Paga con:       {MontoPagaCliente[i]}");
                                Console.WriteLine($"Monto deducido:       {MontoDeducido[i]}          Vuelto:         {Vuelto[i]}");
                            }
                        }
                        if (pago != NumeroDePago[0] && pago != NumeroDePago[1] && pago != NumeroDePago[2] && pago != NumeroDePago[3] && pago != NumeroDePago[4] && pago != NumeroDePago[5] && pago != NumeroDePago[6] && pago != NumeroDePago[7] && pago != NumeroDePago[8] && pago != NumeroDePago[9])
                        {
                            Console.WriteLine("No se encontro el número de pago");
                        }
                        Console.WriteLine("==============================================================================================");
                        Console.WriteLine("¿Desea continuar?  s/n");
                        opcion2 = char.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (opcion2 != 'n' && opcion2 != 'N');

                   
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida");
                    Console.WriteLine("Presione cualquier tecla para comenzar de nuevo");
                    Console.ReadLine();
                    error = true;

                }
                
            } while (error);
            Console.Clear();
            Console.WriteLine("Consulta terminada");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine();
            Console.WriteLine("                   Presione cualquier Tecla para volver al menú principal");
            Console.ReadLine();
            Console.Clear();
        }
        public void ModificarPago()
        {
            bool error = false;
            do
            {
                error = false;
                char opcion2;

                try
                {
                    do
                    {
                        Console.WriteLine("Digite el número de pago que desea modificar");
                        float pago = float.Parse(Console.ReadLine());

                        for (int i = 0; i < NumeroDePago.Length; i++)
                        {

                            if (pago.Equals(NumeroDePago[i]))
                            {
                                Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                                Console.WriteLine();
                                Console.WriteLine("                    Tienda La Favorita - Modificar Pagos");
                                Console.WriteLine();
                                Console.WriteLine($"Numero de pago:    {NumeroDePago[i]}");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"                    Dato encontrado Posición vector {i}");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("                   Presione cualquier tecla para ver registro");
                                Console.ReadLine();
                                Console.Clear();


                                Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                                Console.WriteLine("                    Tienda La Favorita - Modificar Pagos");
                                Console.WriteLine();
                                Console.WriteLine($"Número de pago:       {NumeroDePago[i]}");
                                Console.WriteLine($"A-Fecha:              {Fecha[i]}               B-Hora:         {Hora[i]}");
                                Console.WriteLine();
                                Console.WriteLine($"C-Cedula:             {Cedula[i]}              D-Nombre:        {Nombre[i]}");
                                Console.WriteLine($"Apellido1:            {Apellido1[i]}               Apellido2:      {Apellido2[i]}");
                                Console.WriteLine($"G-Tipo de servicio:   {TipoDeServicio[i]}");
                                Console.WriteLine($"H-NumeroDeFactura:    {NumeroDeFactura[i]}                Monto Pagar:   {MontoAPagar[i]}");
                                Console.WriteLine($"Comisión autorizada:  {MontoComision[i]}          I-Paga con:       {MontoPagaCliente[i]}");
                                Console.WriteLine($"Monto deducido:       {MontoDeducido[i]}            Vuelto:         {Vuelto[i]}");
                                Console.WriteLine();
                                Console.WriteLine("Digite la opcion que quiere modificar");
                                char opcion = char.Parse(Console.ReadLine());
                                if (opcion == 'a' || opcion == 'A')
                                {
                                    Console.WriteLine("Digite una nueva fecha");
                                    Fecha[i] = Console.ReadLine();
                                }
                                if (opcion == 'b' || opcion == 'B')
                                {
                                    Console.WriteLine("Digite una nueva hora");
                                    Hora[i] = Console.ReadLine();
                                }
                                if (opcion == 'c' || opcion == 'C')
                                {
                                    Console.WriteLine("Digite una nueva cédula");
                                    Cedula[i] = float.Parse(Console.ReadLine());
                                }
                                if (opcion == 'd' || opcion == 'D')
                                {
                                    Console.WriteLine("Digite un nuevo nombre");
                                    Nombre[i] = Console.ReadLine();

                                }
                                if (opcion == 'e' || opcion == 'E')
                                {
                                    Console.WriteLine("Vuelva a digitar el primer apellido");
                                    Apellido1[i] = Console.ReadLine();
                                }
                                if (opcion == 'f' || opcion == 'F')
                                {
                                    Console.WriteLine("Vuelva a digitar el segundo apellido");
                                    Apellido2[i] = Console.ReadLine();
                                }
                                if (opcion == 'g' || opcion == 'G')
                                {
                                    Console.WriteLine("Vuelva a digitar el tipo de servicio / todo en minuscula");
                                    if (TipoDeServicio[i] == "electricidad")
                                    {
                                        Total_E = Total_E - MontoComision[i];
                                        Acum_E--;
                                    }
                                    if (TipoDeServicio[i] == "agua")
                                    {
                                        Total_A = Total_A - MontoComision[i];
                                        Acum_A--;
                                    }
                                    if (TipoDeServicio[i] == "telefonico")
                                    {
                                        Total_T = Total_T - MontoComision[i];
                                        Acum_T--;
                                    }

                                    TipoDeServicio[i] = Console.ReadLine();

                                    if (TipoDeServicio[i] == "electricidad")
                                    {                                       
                                        MontoComision[i] = ((float)(MontoAPagar[i] * 0.04));
                                        MontoDeducido[i] = ((float)(MontoAPagar[i] - MontoComision[i]));
                                        Total_E = Total_E + MontoComision[i];
                                        Acum_E++;
                                    }
                                    if (TipoDeServicio[i] == "telefonico")
                                    {
                                        MontoComision[i] = ((float)(MontoAPagar[i] * 0.055));
                                        MontoDeducido[i] = ((float)(MontoAPagar[i] - MontoComision[i]));
                                        Total_T = Total_T + MontoComision[i];
                                        Acum_T++;
                                    }
                                    if (TipoDeServicio[i] == "agua")
                                    {
                                        MontoComision[i] = ((float)(MontoAPagar[i] * 0.065));
                                        MontoDeducido[i] = ((float)(MontoAPagar[i] - MontoComision[i]));
                                        Total_A = Total_A + MontoComision[i];
                                        Acum_A++;
                                    }
                                }
                                if (opcion == 'h' || opcion == 'H')
                                {
                                    Console.WriteLine("Digite un nuevo número de factura");
                                    NumeroDeFactura[i] = float.Parse(Console.ReadLine());
                                }
                                if (opcion == 'i' || opcion == 'I')
                                {
                                    Console.WriteLine("Digite el nuevo monto a pagar del cliente");
                                    MontoPagaCliente[i] = float.Parse(Console.ReadLine());
                                    Vuelto[i] = ((float)(MontoPagaCliente[i] - MontoAPagar[i]));

                                }

                            }
                        }
                        if (pago != NumeroDePago[0] && pago != NumeroDePago[1] && pago != NumeroDePago[2] && pago != NumeroDePago[3] && pago != NumeroDePago[4] && pago != NumeroDePago[5] && pago != NumeroDePago[6] && pago != NumeroDePago[7] && pago != NumeroDePago[8] && pago != NumeroDePago[9])
                        {
                            Console.WriteLine("No se encontro el número de pago");
                        }
                        Console.WriteLine("==============================================================================================");
                        Console.WriteLine("¿Desea continuar?  s/n");
                        opcion2 = char.Parse(Console.ReadLine());
                        Console.Clear();
                        
                    } while (opcion2 != 'n' && opcion2 != 'N');
                    

                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida");
                    Console.WriteLine("Presione cualquier tecla para comenzar de nuevo");
                    Console.ReadLine();
                    error = true;


                }
             
            } while (error);
            Console.WriteLine("Modificación terminada");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine();
            Console.WriteLine("            Presione cualquier Tecla para volver al menú principal");
            Console.ReadLine();
            Console.Clear();
        }
         public void BorrarPago()
        {
            bool error = false;
            do
            {
                error = false;
                try
                {
                    Console.WriteLine("Digite el número de pago que desea borrar");
                    float pago = float.Parse(Console.ReadLine());
                    for (int i = 0; i < NumeroDePago.Length; i++)
                    {
                        if (pago.Equals(NumeroDePago[i]))
                        {
                            Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                            Console.WriteLine();
                            Console.WriteLine("                    Tienda La Favorita - Consulta de Datos");
                            Console.WriteLine();
                            Console.WriteLine($"Numero de pago:    {NumeroDePago[i]}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"                    Dato encontrado Posición vector {i}");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("                   Presione cualquier tecla para ver registro");
                            Console.ReadLine();
                            Console.Clear();


                            Console.WriteLine("                      Sistema Pago de Servicios Públicos              ");
                            Console.WriteLine("                    Tienda La Favorita - Consulta de Datos");
                            Console.WriteLine();
                            Console.WriteLine($"Número de pago:       {NumeroDePago[i]}");
                            Console.WriteLine($"Fecha:                {Fecha[i]}              Hora:           {Hora[i]}");
                            Console.WriteLine();
                            Console.WriteLine($"Cedula:               {Cedula[i]}              Nombre:         {Nombre[i]}");
                            Console.WriteLine($"Apellido1:            {Apellido1[i]}              Apellido2:      {Apellido2[i]}");
                            Console.WriteLine($"Tipo de servicio:     {TipoDeServicio[i]}");
                            Console.WriteLine($"NumeroDeFactura:      {NumeroDeFactura[i]}              Monto Pagar:    {MontoAPagar[i]}");
                            Console.WriteLine($"Comisión autorizada:  {MontoComision[i]}          Paga con:       {MontoPagaCliente[i]}");
                            Console.WriteLine($"Monto deducido:       {MontoDeducido[i]}          Vuelto:         {Vuelto[i]}");
                            Console.WriteLine();
                            Console.WriteLine("Desea borrar este pago s/n");
                            char opcion = char.Parse(Console.ReadLine());
                            if (opcion == 's')
                            {
                                NumeroDePago[i] = 0;
                                Fecha[i] = "*";
                                Hora[i] = "*";
                                Cedula[i] = 0;
                                Nombre[i] = "*";
                                Apellido1[i] = "*";
                                Apellido2[i] = "*";
                                NumeroDeCaja[i] = 0;
                                if (TipoDeServicio[i] == "electricidad")
                                {
                                    Total_E = Total_E - MontoComision[i];
                                    Acum_E--;
                                }
                                if (TipoDeServicio[i] == "telefonico")
                                {
                                    Total_T = Total_T - MontoComision[i];
                                    Acum_T--;
                                }
                                if (TipoDeServicio[i] == "agua")
                                {
                                    Total_A = Total_A - MontoComision[i];
                                    Acum_A--;
                                }
                                TipoDeServicio[i] = "*";
                                NumeroDeFactura[i] = 0;
                                MontoAPagar[i] = 0;
                                MontoComision[i] = 0;
                                MontoDeducido[i] = 0;
                                MontoPagaCliente[i] = 0;
                                Vuelto[i] = 0;
                                Console.WriteLine();
                                Console.WriteLine("Se borró el pago");
                            }
                            if (opcion != 's')
                            {
                                Console.WriteLine();
                                Console.WriteLine("No se borró este pago");
                            }
                        }
                    }
                    if (pago != NumeroDePago[0] && pago != NumeroDePago[1] && pago != NumeroDePago[2] && pago != NumeroDePago[3] && pago != NumeroDePago[4] && pago != NumeroDePago[5] && pago != NumeroDePago[6] && pago != NumeroDePago[7] && pago != NumeroDePago[8] && pago != NumeroDePago[9])
                    {
                        Console.WriteLine("No se encontro el número de pago");
                    }
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida");
                    Console.WriteLine("Presione cualquier tecla para comenzar de nuevo");
                    Console.ReadLine();
                    error = true;

                }
               
            } while (error);
            
            Console.Clear();
            Console.WriteLine("Modificación terminada");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine();
            Console.WriteLine("                   Presione cualquier Tecla para volver al menú principal");
            Console.ReadLine();
            Console.Clear();

        }
        public void Submenu()
        {
            bool error = false;
            do
            {
                error = false;
                int opcion = 0;
                try
                {
                    do
                    {

                        Console.WriteLine("***** SUBMENÚ DE REPORTES *****");
                        Console.WriteLine("1- Ver todos los pagos");
                        Console.WriteLine("2- Ver pagos por tipo de servicio");
                        Console.WriteLine("3- Ver pagos por códigos de caja");
                        Console.WriteLine("4- Ver dinero comisionado por servicios");
                        Console.WriteLine("5- Regresar al menú principal");
                        Console.WriteLine();
                        Console.WriteLine("Digite su opcion");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("                            Sistemas Pago Servicios Públicos                               ");
                                Console.WriteLine("         Tienda La Favorita - Reporte Todos los Pagos por Tipo de Servicio                                           ");
                                Console.WriteLine("# pago  Fecha   Hora   cedula    Nombre    Apellido 1   Apellido 2    Monto recibo");
                                Console.WriteLine("==============================================================================================");
                                for (int i = 0; i < NumeroDeCaja.Length; i++)
                                {
                                    Console.WriteLine($"{NumeroDePago[i]}          { Fecha[i] }         { Hora[i]}        {Cedula[i]}       {Nombre[i]}         {Apellido1[i]}          {Apellido2[i]}          {MontoPagaCliente[i]} ");
                                }
                                Console.WriteLine("==============================================================================================");
                                Console.WriteLine($"Total de registros {acum2}                                         Monto total {acum}");
                                Console.WriteLine();
                                Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                Console.ReadLine();
                                Console.Clear();

                                break;
                            case 2:
                                acum3 = 0;
                                Console.WriteLine("                            Sistemas Pago Servicios Públicos                               ");
                                Console.WriteLine("                     Tienda La Favorita - Reporte Todos los Pagos                 ");
                                Console.WriteLine("==============================================================================================");
                                Console.WriteLine();
                                Console.WriteLine("Digite el tipo de servicio                           electricidad / telefonico / agua");
                                string servicio = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("==============================================================================================");
                                Console.WriteLine();
                                Console.WriteLine("                       Presione cualquier tecla para ver Registro");
                                Console.ReadLine();
                                Console.Clear();
                               
                                Console.WriteLine("                            Sistemas Pago Servicios Públicos                               ");
                                Console.WriteLine("         Tienda La Favorita - Reporte Todos los Pagos por Tipo de Servicio                 ");
                                Console.WriteLine("# pago  Fecha   Hora   cedula    Nombre    Apellido 1   Apellido 2    Monto recibo");
                                Console.WriteLine("================================================================================================================");
                                for (int i = 0; i < TipoDeServicio.Length; i++)
                                {
                                    if (servicio.Equals(TipoDeServicio[i]))
                                    {
                                        Console.WriteLine($"{NumeroDePago[i]}          { Fecha[i] }         { Hora[i]}        {Cedula[i]}       {Nombre[i]}         {Apellido1[i]}          {Apellido2[i]}          {MontoPagaCliente[i]} ");
                                        acum3 = acum3 + MontoPagaCliente[i];
                                    }
                                    
                                    
                                }
                                Console.WriteLine("=================================================================================================================");
                                if (servicio == "electricidad")
                                {
                                    Console.WriteLine($"Total de registros {Acum_E}                                         Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (servicio == "telefonico")
                                {
                                    Console.WriteLine($"Total de registros {Acum_T}                                         Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (servicio == "agua")
                                {
                                    Console.WriteLine($"Total de registros {Acum_A}                                         Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (servicio != "electricidad" && servicio != "telefonico" && servicio != "agua")
                                {
                                    Console.WriteLine("No se encontro el servicio");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                                break;
                            case 3:
                                acum3 = 0;
                                acum4 = 0;
                                Console.WriteLine("                            Sistemas Pago Servicios Públicos                               ");
                                Console.WriteLine("         Tienda La Favorita - Reporte Todos los Pagos por código de caja                 ");
                                Console.WriteLine("=======================================================================================================================");
                                Console.WriteLine("Digite el numero de caja                               1 / 2 / 3");
                                float nc = float.Parse(Console.ReadLine());
                                Console.WriteLine("=======================================================================================================================");
                                Console.WriteLine();
                                Console.WriteLine("                       Presione cualquier tecla para ver Registro");
                                Console.ReadLine();
                                Console.Clear();
                                
                                Console.WriteLine("Sistema Pago de servicios públicos");
                                Console.WriteLine("Tienda La Favorita- Reporte de todos los pagos por código de  cajeros");
                                Console.WriteLine("# pago  Fecha   Hora   cedula    Nombre    Apellido 1   Apellido 2    Monto recibo");
                                Console.WriteLine("======================================================================================================================");
                                for (int i = 0; i < NumeroDeCaja.Length; i++)
                                {
                                    if (nc.Equals(NumeroDeCaja[i]))
                                    {
                                        Console.WriteLine($"{NumeroDePago[i]}          { Fecha[i] }         { Hora[i]}        {Cedula[i]}       {Nombre[i]}         {Apellido1[i]}          {Apellido2[i]}          {MontoPagaCliente[i]} ");
                                        acum4++;
                                        acum3 = acum3 + MontoPagaCliente[i];
                                    }
                                    
                                }
                                if (nc == 1)
                                {
                                    Console.WriteLine("=================================================================================================================");
                                    Console.WriteLine($"Total de registros {acum4}                                           Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (nc == 2)
                                {
                                    Console.WriteLine("=================================================================================================================");
                                    Console.WriteLine($"Total de registros {acum4}                                           Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (nc == 3)
                                {
                                    Console.WriteLine("================================================================================================================");
                                    Console.WriteLine($"Total de registros {acum4}                                           Monto total {acum3}");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                if (nc != 1 && nc != 2 && nc != 3)
                                {
                                    Console.WriteLine("================================================================================================================");
                                    Console.WriteLine($"No se encontro el número de caja");
                                    Console.WriteLine();
                                    Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                                break;
                            case 4:
                                total_1 = Acum_A + Acum_E + Acum_T;
                                total_2 = Total_A + Total_E + Total_T;
                                Console.WriteLine("     Reporte Dinero Comisionado - Desgloce por Tipo de Servicio");
                                Console.WriteLine("______________________________________________________________________________");
                                Console.WriteLine("ITEM                    Cant. Transacciones             Total comisionado");
                                Console.WriteLine("______________________________________________________________________________");
                                Console.WriteLine($"1-Electricidad                {Acum_E}                       {Total_E}            ");
                                Console.WriteLine($"2-Telefono                    {Acum_T}                       {Total_T}            ");
                                Console.WriteLine($"1-Agua                        {Acum_A}                       {Total_A}            ");
                                Console.WriteLine("______________________________________________________________________________");
                                Console.WriteLine($"TOTAL                         {total_1}                      {total_2}            ");
                                Console.WriteLine("______________________________________________________________________________");
                                Console.WriteLine();
                                Console.WriteLine("                   Presione cualquier Tecla para ver registro");
                                Console.ReadLine();
                                Console.Clear();

                                break;
                            case 5: break;

                            default: break;
                        }

                    } while (opcion != 5);
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vuelva a digitar una opcion válida");
                    Console.WriteLine("Presione cualquier tecla para comenzar de nuevo");
                    Console.ReadLine();
                    error = true;
                }

               
            } while (error);
            Console.Clear();
            
               
                                
        }

        }

      
    }

