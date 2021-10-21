using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenProgracionII_PrimerExamen
{
    class ClsPagos
    {
        static ClsPlantilla ems = new ClsPlantilla();

        int[] nPago = new int[10]; // Numero de Pago
        string[] fecha = new string[10];
        string[] hora = new string[10];

        string[] nombres = new string[10]; // Nombres
        string[] cedula = new string[10]; // Cedulas
        string[] apellido1 = new string[10]; // Apellidos
        string[] apellido2 = new string[10]; // ===
        byte[] nCaja = new byte[10]; // Numero de caja
        byte[] tipoServicio = new byte[10]; // Tipo de Servicio
        string[] nFactura = new string[10]; // Numero de Factura
        double[] mFactura = new double[10]; //Monto de Factura
        double[] mComision = new double[10]; //Monto de Comosión
        double[] mDeducido = new double[10]; //Monto deducido
        double[] mPagaC = new double[10]; // Monto pagado por el cliente
        double[] vuelto = new double[10]; //Vuelto
        int cont, op2,nActualCaja,nBuscar,op3,contNPago;
        double cActual;
        string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
        string horaActual = DateTime.Now.ToString("hh:mm tt");
        bool nEncontrado,nPagoComenzado;
        Char op;
        public ClsPagos()
        {
            cont = 0;
            nActualCaja = 1;
            nBuscar = 0;
            nPagoComenzado = false;
            contNPago = 0;

        }

    public void InicializarVectores() // Opcion 1 
    {
            for (int i = 0; i < 10; i++) // Aqui inicializamos todos los atributos 
            {
                // Para no dejar un espacio en blanco, los inicializamos como: **NO REGISTRADO**
                nPago[i] = 0;
                nombres[i] = "NO REGISTRADO";
                cedula[i] = "NO REGISTRADO";
                apellido1[i] = "NO REGISTRADO";
                apellido2[i] = "NO REGISTRADO";
                nCaja[i] = 0;
                tipoServicio[i] = 0;
                nFactura[i] = "NO REGISTRADO";
                mFactura[i] = 0;
                mComision[i] = 0;
                mDeducido[i] = 0;
                mPagaC[i] = 0;
                vuelto[i] = 0;
            }
            Console.WriteLine("*** SUS VECTORES ESTÁN INICIALIZADOS ***"); // Mostramos un MSJ para que el usuario entienda que ya se realizó el cambio.
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menu . . . ");
            Console.ReadKey(true);
            Console.Clear();
        }

     // ******************************************************************************
    public void RealizarPagos() // Opcion 2
        {
        
            op = 's';
            cActual = 0;
            Random r = new Random();
            Console.Clear();

            while ((op != 'n') && (cont < 10))

            {
                op2 = 0;
                contNPago++;
                nPagoComenzado = true;
                fecha[cont] = fechaActual;
                hora[cont] = horaActual;

                nPago[cont] = nActualCaja++;
                Console.WriteLine("Digite la cedula de la persona");// Preguntamos por la cedula
                cedula[cont] = Console.ReadLine();

                Console.WriteLine("Digite el nombre de la persona (NO INGRESE APELLIDOS)"); // Preguntamos por el nombre
                nombres[cont] = Console.ReadLine();

                Console.WriteLine("Digite el primer apellido");// Preguntamos por el apellido
                apellido1[cont] = Console.ReadLine();

                Console.WriteLine("Digite el segundo apellido");// Preguntamos por el apellido
                apellido2[cont] = Console.ReadLine();

                Console.WriteLine("***Tipos de Recibos***");
                Console.WriteLine("1- Recibo de Luz");
                Console.WriteLine("2- Recibo Telefono");
                Console.WriteLine("3- Recibo de Agua");

                while (op2 < 1 || op2 > 3)
                { 

                Console.Write("Ahora ingrese el tipo de servicio... ");
                op2 = Convert.ToInt32(Console.ReadLine());

                switch (op2)
                {

                    case 1:
                        tipoServicio[cont] = 1;
                        cActual = 0.04;
                        break;
                    case 2:
                        tipoServicio[cont] = 2;
                        cActual = 0.055;
                        break;
                    case 3:
                        tipoServicio[cont] = 3;
                        cActual = 0.065;
                        break;
          
                    default: 
                           Console.WriteLine("INGRESE SOLO UNAS DE LAS 3 OPCIONES");
                           break;
                            
                }

                }
               
                nCaja[cont] = Convert.ToByte(r.Next(1, 4)); // Genera solo numeros del 1 al 3

                Console.WriteLine("Digite el numero de la factura"); // Preguntamos por el numero de la factura
                nFactura[cont] = Console.ReadLine();

                Console.WriteLine("Digite el monto de la factura");// Preguntamos por el monto que va pagar
                mFactura[cont] = Convert.ToInt32(Console.ReadLine());

                mComision[cont] = mFactura[cont] * cActual; // Hacemos comision

                while (mPagaC[cont] < mFactura[cont]) // Aqui validamos que no ingrese un monto menor
                { 
               
                Console.WriteLine("Digite el monto con el cual va pagar");// Preguntamos por el monto con el va pagar
                mPagaC[cont] = Convert.ToInt32(Console.ReadLine());

                }
               

                mDeducido[cont] = mFactura[cont] - mComision[cont]; // Aqui restamos con lo que va pagar con la comision

                vuelto[cont] = mPagaC[cont] - mFactura[cont];


                Console.Clear();

                ems.formato();


                Console.SetCursorPosition(3, 6);
                Console.WriteLine("Numero de Pago:  " + nPago[cont]);
                Console.SetCursorPosition(50, 6);
                Console.WriteLine("Numero de caja:  " + nCaja[cont]);
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("Fecha:           " + fecha[cont]);
                Console.SetCursorPosition(50, 7);
                Console.WriteLine("Hora:    " + hora[cont]);

                Console.SetCursorPosition(3, 9);
                Console.WriteLine("Cedula:  " + cedula[cont]);
                Console.SetCursorPosition(50, 9);
                Console.WriteLine("Nombre:  " + nombres[cont]);
                Console.SetCursorPosition(3, 10);
                Console.WriteLine("Apellido1:  " + apellido1[cont]);
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("Apellido2:  " + apellido2[cont]);

                Console.SetCursorPosition(3, 12);
                Console.WriteLine("Tipo de Servicio:  " + tipoServicio[cont]);
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("[1-Electricidad 2-Telefono 3-Agua]");

                Console.SetCursorPosition(3, 14);
                Console.WriteLine("Numero de Factura:  " + nFactura[cont]);
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Monto Pagar:  " + mFactura[cont]);
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("Comision autorizada:  " + mComision[cont]);
                Console.SetCursorPosition(50, 15);
                Console.WriteLine("Paga con:  " + mPagaC[cont]);
                Console.SetCursorPosition(3, 16);
                Console.WriteLine("Monto deducido:  " + mDeducido[cont]);
                Console.SetCursorPosition(50, 16);
                Console.WriteLine("Vuelto:  " + vuelto[cont]);


                cont++;
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("Desea continuar?  s/n");  //Preguntamos si quiere continuar...
                op = Convert.ToChar(Console.ReadLine());
                Console.Clear();

            }

        }
        public void ConsultarPagos() // Opcion 3
        {
            {
                Console.Clear();
                ems.formato();
                nEncontrado = false;

                if (nPagoComenzado==false)

                {
                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("**Aun no se ha creado ningun numero de pago**");

                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                    return;
                }


                Console.SetCursorPosition(3, 6);
                Console.Write("Numero de pago:   "); // Preguntamos por el numero de pago
                nBuscar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nPago.Length; i++)
                {
                    if (nPago[i] == nBuscar)
                    {
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Dato Encontrado Posicion Vector " + i);
                        nEncontrado = true;


                        Console.SetCursorPosition(20, 21);
                        Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                        Console.ReadKey(true);
                        Console.Clear();

                        ems.formato();

                        Console.SetCursorPosition(3, 6);
                        Console.WriteLine("Numero de Pago:  " + nPago[i]);
                        Console.SetCursorPosition(50, 6);
                        Console.WriteLine("Numero de caja:  " + nCaja[i]);
                        Console.SetCursorPosition(3, 7);
                        Console.WriteLine("Fecha:           " + fecha[i]);
                        Console.SetCursorPosition(50, 7);
                        Console.WriteLine("Hora:    " + hora[i]);

                        Console.SetCursorPosition(3, 9);
                        Console.WriteLine("Cedula:  " + cedula[i]);
                        Console.SetCursorPosition(50, 9);
                        Console.WriteLine("Nombre:  " + nombres[i]);
                        Console.SetCursorPosition(3, 10);
                        Console.WriteLine("Apellido1:  " + apellido1[i]);
                        Console.SetCursorPosition(50, 10);
                        Console.WriteLine("Apellido2:  " + apellido2[i]);

                        Console.SetCursorPosition(3, 12);
                        Console.WriteLine("Tipo de Servicio:  " + tipoServicio[i]);
                        Console.SetCursorPosition(40, 12);
                        Console.WriteLine("[1-Electricidad 2-Telefono 3-Agua]");

                        Console.SetCursorPosition(3, 14);
                        Console.WriteLine("Numero de Factura:  " + nFactura[i]);
                        Console.SetCursorPosition(50, 14);
                        Console.WriteLine("Monto Pagar:  " + mFactura[i]);
                        Console.SetCursorPosition(3, 15);
                        Console.WriteLine("Comision autorizada:  " + mComision[i]);
                        Console.SetCursorPosition(50, 15);
                        Console.WriteLine("Paga con:  " + mPagaC[i]);
                        Console.SetCursorPosition(3, 16);
                        Console.WriteLine("Monto deducido:  " + mDeducido[i]);
                        Console.SetCursorPosition(50, 16);
                        Console.WriteLine("Vuelto:  " + vuelto[i]);

                        Console.SetCursorPosition(18, 21);
                        Console.WriteLine("Presione cualquier tecla para volver al menu . . . ");
                        Console.ReadKey(true);
                        Console.Clear();
 


                    }

                }
                if (nEncontrado==false)
                {

                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("Dato No Encontrado Ninguna Posicion Del Vector");
                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                }

            }


        }
        public void ModificarDatos() // Opcion 4
        {
            {
                Console.Clear();
                ems.formato();
                op = 's';

                if (nPagoComenzado == false)

                {
                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("**Aun no se ha creado ningun numero de pago**");

                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                    return;
                }


                Console.SetCursorPosition(3, 6);
                Console.Write("Numero de pago:   "); // Preguntamos por el numero de pago
                nBuscar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nPago.Length; i++)
                {
                    if (nPago[i] == nBuscar)
                    {
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Dato Encontrado Posicion Vector " + i);
                        nEncontrado = true;


                        Console.SetCursorPosition(20, 21);
                        Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                        Console.ReadKey(true);

                        Console.Clear();

                        while (op != 'n')
                        {

                            ems.formato();
                            op3 = 0;
                            op2 = 0;
                            Console.SetCursorPosition(3, 6);
                            Console.WriteLine("Numero de Pago:  " + nPago[i]);
                            Console.SetCursorPosition(50, 6);
                            Console.WriteLine("Numero de caja:  " + nCaja[i]);
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("1- Fecha:           " + fecha[i]);
                            Console.SetCursorPosition(50, 7);
                            Console.WriteLine("2- Hora:    " + hora[i]);

                            Console.SetCursorPosition(3, 9);
                            Console.WriteLine("3- Cedula:  " + cedula[i]);
                            Console.SetCursorPosition(50, 9);
                            Console.WriteLine("4- Nombre:  " + nombres[i]);
                            Console.SetCursorPosition(3, 10);
                            Console.WriteLine("5- Apellido1:  " + apellido1[i]);
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("6- Apellido2:  " + apellido2[i]);

                            Console.SetCursorPosition(3, 12);
                            Console.WriteLine("7- Tipo de Servicio:  " + tipoServicio[i]);
                            Console.SetCursorPosition(40, 12);
                            Console.WriteLine("[1-Electricidad 2-Telefono 3-Agua]");

                            Console.SetCursorPosition(3, 14);
                            Console.WriteLine("8- Numero de Factura:  " + nFactura[i]);
                            Console.SetCursorPosition(50, 14);
                            Console.WriteLine("Monto Pagar:  " + mFactura[i]);
                            Console.SetCursorPosition(3, 15);
                            Console.WriteLine("Comision autorizada:  " + mComision[i]);
                            Console.SetCursorPosition(50, 15);
                            Console.WriteLine("9- Paga con:  " + mPagaC[i]);
                            Console.SetCursorPosition(3, 16);
                            Console.WriteLine("Monto deducido:  " + mDeducido[i]);
                            Console.SetCursorPosition(50, 16);
                            Console.WriteLine("Vuelto:  " + vuelto[i]);

                            while (op3 < 1 || op3 > 9 )
                            {
                                Console.SetCursorPosition(3, 20);
                                Console.Write("Seleccione la opcion a modificar... ");
                                op3 = Convert.ToInt32(Console.ReadLine());

                                switch (op3)
                                {

                                    case 1:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        fecha[i] = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        hora[i] = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        cedula[i] = Console.ReadLine();
                                        break;

                                    case 4:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        nombres[i] = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        apellido1[i] = Console.ReadLine();
                                        break;
                                    case 6:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        apellido2[i] = Console.ReadLine();
                                        break;

                                    case 7:
                                        do
                                        {
                                            Console.SetCursorPosition(50, 20);
                                            Console.Write("Nuevo Dato... ");
                                            op2 = Convert.ToInt32(Console.ReadLine());
                                            switch (op2)
                                            {
                                                case 1:
                                                    tipoServicio[i] = 1;
                                                    cActual = 0.04;
                                                    break;
                                                case 2:
                                                    tipoServicio[i] = 2;
                                                    cActual = 0.055;
                                                    break;
                                                case 3:
                                                    tipoServicio[i] = 3;
                                                    cActual = 0.065;
                                                    break;

                                                default:
                                                    Console.SetCursorPosition(30, 23);
                                                    Console.WriteLine("*INGRESE SOLO UNAS DE LAS 3 OPCIONES*");
                                                    break;
                                            }
                                        } while (op2 < 1 || op2 > 3);
                                        mComision[i] = mFactura[i] * cActual;
                                        mDeducido[i] = mFactura[i] - mComision[i];
                                        break;



                                    case 8:
                                        Console.SetCursorPosition(50, 20);
                                        Console.Write("Nuevo Dato... ");
                                        nFactura[i] = Console.ReadLine();
                                        break;
                                    case 9:
                                        do
                                        {
                                            Console.SetCursorPosition(50, 20);
                                            Console.Write("Nuevo Dato... ");
                                            mPagaC[i] = Convert.ToInt32(Console.ReadLine());

                                        } while (mPagaC[i] < mFactura[i]);
                                        vuelto[i] = mPagaC[i] - mFactura[i];
                                        break;

                                    default:
                                        Console.SetCursorPosition(30, 23);
                                        Console.WriteLine("INGRESE SOLO UNAS DE LAS 9 OPCIONES");                                     
                                        break;
                                        

                                }
                                Console.SetCursorPosition(30, 21);
                                Console.WriteLine("Desea continuar?  s/n");  //Preguntamos si quiere continuar...
                                op = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                if (op == 'n')
                                {
                                ClsMenu.principal();
                                }
            

                            }
                        

                        }

                    }

                }
                if (nEncontrado == false)
                {

                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("Dato No Encontrado Ninguna Posicion Del Vector");
                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                }


            }

        }
        public void EliminacionDatos()
        {
            {
                Console.Clear();
                ems.formato();
                op = 's';

                if (nPagoComenzado == false)

                {
                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("**Aun no se ha creado ningun numero de pago**");

                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                    return;
                }


                Console.SetCursorPosition(3, 6);
                Console.Write("Numero de pago:   "); // Preguntamos por el numero de pago
                nBuscar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nPago.Length; i++)
                {
                    if (nPago[i] == nBuscar)
                    {
                        Console.SetCursorPosition(24, 11);
                        Console.WriteLine("Dato Encontrado Posicion Vector " + i);
                        nEncontrado = true;


                        Console.SetCursorPosition(24, 17);
                        Console.Write("Está seguro de eliminarlo? s/n ... ");
                        op = Convert.ToChar(Console.ReadLine());

                        if (op=='s')
                        {
                        nPago[i] = 0;
                        nombres[i] = "NO REGISTRADO";
                        cedula[i] = "NO REGISTRADO";
                        apellido1[i] = "NO REGISTRADO";
                        apellido2[i] = "NO REGISTRADO";
                        nCaja[i] = 0;
                        tipoServicio[i] = 0;
                        nFactura[i] = "NO REGISTRADO";
                        mFactura[i] = 0;
                        mComision[i] = 0;
                        mDeducido[i] = 0;
                        mPagaC[i] = 0;
                        vuelto[i] = 0;
                            Console.SetCursorPosition(26, 20);
                            Console.Write("Sus Datos fueron eliminados ");
                        }
                 
                        Console.SetCursorPosition(18, 21);
                        Console.WriteLine("Presione cualquier tecla para volver al menu . . . ");
                        Console.ReadKey(true);
                        Console.Clear();



                    }

                }
                if (nEncontrado == false)
                {

                    Console.SetCursorPosition(17, 11);
                    Console.WriteLine("Dato No Encontrado Ninguna Posicion Del Vector");
                    Console.SetCursorPosition(20, 21);
                    Console.WriteLine("Presione cualquier tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();

                }

            }

        }
        public void todosPagos()

        {
            int totalR; 
            double totalM;
            totalM = 0;
            totalR = 0;


            Console.Clear();
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("-Sistema Pago de Servicios Publicos-");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Tienda Monge - Ingreso de Datos");
            Console.WriteLine("");
            Console.WriteLine("# Pago	Fecha/Hora   Cedula     Nombre   Apellido1   Apellido2     Monto Recibo  ");
            Console.WriteLine("===================================================================================");
            for (int i = 0; i < contNPago; i++) // 
            {
                Console.WriteLine(fecha[i] + " " + hora[i] + " " + cedula[i] + " " + nombres[i] + "   " + apellido1[i] + "    " + apellido2[i] + "        " + mFactura[i]);
                totalR++;
                totalM += mFactura[i];
            }

            Console.WriteLine("===================================================================================");
            Console.SetCursorPosition(1, 19);
            Console.WriteLine("Total de Registros: "+ totalR);
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("Monto total    " + totalM);
            Console.SetCursorPosition(20, 21);
            Console.WriteLine("Presione cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();
        }

        public void pagosServicio()
        {
            int totalR;
            byte opUsuario;
            double totalM;
            totalM = 0;
            totalR = 0;
            opUsuario = 0;

            Console.Clear();
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("-Sistema Pago de Servicios Publicos-");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Tienda Monge - Ingreso de Datos");
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");
            Console.WriteLine("Seleccione codigo de Servicio       [1]Electricidad  [2]Telefono  [3] Agua");
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            do
            {
            opUsuario= Convert.ToByte(Console.ReadLine());
          
            } while (opUsuario < 1 || opUsuario > 3);
            Console.Clear();

            Console.SetCursorPosition(22, 3);
            Console.WriteLine("-Sistema Pago de Servicios Publicos-");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Tienda Monge - Ingreso de Datos");
            Console.WriteLine("");
            Console.WriteLine("# Pago	Fecha/Hora   Cedula     Nombre   Apellido1   Apellido2     Monto Recibo  ");
            Console.WriteLine("===================================================================================");

            for (int i = 0; i < contNPago; i++)
            {
                if (tipoServicio[i]==opUsuario)
                {
                    Console.WriteLine(fecha[i] + " " + hora[i] + " " + cedula[i] + " " + nombres[i] + "   " + apellido1[i] + "    " + apellido2[i] + "        " + mFactura[i]);
                    totalR++;
                    totalM += mFactura[i];

                }
            }
            Console.WriteLine("===================================================================================");
            Console.SetCursorPosition(1, 19);
            Console.WriteLine("Total de Registros: " + totalR);
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("Monto total    " + totalM);
            Console.SetCursorPosition(20, 21);
            Console.WriteLine("Presione cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();

        }

        public void pagosCodigos()
        {
            int totalR;
            byte opUsuario;
            double totalM;
            totalM = 0;
            totalR = 0;
            opUsuario = 0;

            Console.Clear();
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("-Sistema Pago de Servicios Publicos-");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Tienda Monge - Ingreso de Datos");
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("");
            Console.WriteLine("Seleccione codigo de Servicio       [1]Caja #1   [2]Caja #2  [3] Caja #3");
            Console.WriteLine("");
            Console.WriteLine("===================================================================================");
            do
            {
                opUsuario = Convert.ToByte(Console.ReadLine());

            } while (opUsuario < 1 || opUsuario > 3);
            Console.Clear();

            Console.SetCursorPosition(22, 3);
            Console.WriteLine("-Sistema Pago de Servicios Publicos-");
            Console.SetCursorPosition(25, 4);
            Console.WriteLine("Tienda Monge - Ingreso de Datos");
            Console.WriteLine("");
            Console.WriteLine("# Pago	Fecha/Hora   Cedula     Nombre   Apellido1   Apellido2     Monto Recibo  ");
            Console.WriteLine("===================================================================================");

            for (int i = 0; i < contNPago; i++)
            {
                if (nCaja[i] == opUsuario)
                {
                    Console.WriteLine(fecha[i] + " " + hora[i] + " " + cedula[i] + " " + nombres[i] + "   " + apellido1[i] + "    " + apellido2[i] + "        " + mFactura[i]);
                    totalR++;
                    totalM += mFactura[i];

                }
            }
            Console.WriteLine("===================================================================================");
            Console.SetCursorPosition(1, 19);
            Console.WriteLine("Total de Registros: " + totalR);
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("Monto total    " + totalM);
            Console.SetCursorPosition(20, 21);
            Console.WriteLine("Presione cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();


        }

        public void dineroComisionado()
        {
            int cantTransaccionesE, cantTransaccionesT, cantTransaccionesA,CantGlobal;
            double totalCE, totalCT, totalCA,totalCGlobal;
            cantTransaccionesE = 0;
            cantTransaccionesT = 0;
            cantTransaccionesA = 0;
            CantGlobal = 0;

            totalCGlobal = 0;
            totalCA = 0;
            totalCE = 0;
            totalCT = 0;



            Console.Clear();

            Console.SetCursorPosition(5, 1);
            Console.WriteLine("-Reporte Dinero Comisionado - Desgloce por Tipo de Servicio-");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("ITEM                    Cant.Transacciones                     Total Comisionado");
            Console.WriteLine("===================================================================================");
            for (int i = 0; i < contNPago; i++)
            {
                if (nCaja[i] == 1)
                {
                    cantTransaccionesE++;
                    totalCE += mFactura[i];
                }
                else if (nCaja[i] == 3)
                {

                    cantTransaccionesA++;
                    totalCA += mFactura[i];
                }
                else
                {
                    cantTransaccionesT++;
                    totalCT += mFactura[i];
                }
                
            }
            Console.WriteLine("1-Electricidad               " + cantTransaccionesE + "                                 " + totalCE);
            Console.WriteLine("2-Telefono                   " + cantTransaccionesT + "                                 " + totalCT);
            Console.WriteLine("3-Agua                       " + cantTransaccionesA + "                                 " + totalCA);

            Console.WriteLine("===================================================================================");
            CantGlobal = cantTransaccionesA + cantTransaccionesE + cantTransaccionesT;
            totalCGlobal = totalCA + totalCE + totalCT;
            Console.WriteLine("Total :                      "+ CantGlobal + "                                 " + totalCGlobal);
            Console.WriteLine("");
            Console.WriteLine("                  Presione cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();



        }



    }
   
}
