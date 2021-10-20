using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Functions
    {
        static int cant = Data.cant;

        public static void InitValues()
        {
            try
            {
                for (int i = 0; i < cant; i++)
                {
                    Data.ID[i] = 0;
                    Data.Date[i] = null;
                    Data.Time[i] = null;
                    Data.Cedula[i] = null;
                    Data.Name[i] = null;
                    Data.LastName1[i] = null;
                    Data.LastName2[i] = null;
                    Data.CashierNo[i] = 0;
                    Data.TypeService[i] = 0;
                    Data.BillNo[i] = 0;
                    Data.Ammount[i] = 0;
                    Data.Comision[i] = 0;
                    Data.Reduce[i] = 0;
                    Data.AmmountPay[i] = 0;
                }

                Console.Clear();
                Console.WriteLine("Valores Inicializados. Presione cualquier TECLA para continuar.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }            
        }

        private static int pos = 1;

        private static string InsertData(string text, string[] array, int id)
        {
            string value = string.Empty;

            Console.WriteLine(text);
            value = Console.ReadLine().ToUpper();

            if (!string.IsNullOrEmpty(value))
                array[id] = value.Trim();
            else
                Console.WriteLine("Debe ingresar un valor, favor intente de nuevo.");

            return value;
        }

        private static int InsertData(string text, int[] array, int id)
        {
            int value = 0;

            Console.WriteLine(text);
            value = int.Parse(Console.ReadLine());
            array[id] = value;

            return value;
        }

        private static float InsertData(string text, float[] array, int id)
        {
            float value = 0;

            Console.WriteLine(text);
            value = float.Parse(Console.ReadLine());
            array[id] = value;

            return value;
        }

        
        public static void RealizarPagos()
        {            
            try
            {
                DateTime date = DateTime.Now;
                var rand = new Random();
                string option = "N";

                do
                {
                    if (pos <= cant)
                    {
                        Console.Clear();
                        Data.ID[pos] = pos;
                        Data.Date[pos] = date.ToString("dd/MM/yyyy");
                        Data.Time[pos] = date.ToString("hh:mm tt");
                        InsertData("Ingrese la Cedula: ", Data.Cedula, pos);
                        InsertData("Ingrese el Nombre: ", Data.Name, pos);
                        InsertData("Ingrese el Apellido 1: ", Data.LastName1, pos);
                        InsertData("Ingrese el Apellido 2: ", Data.LastName2, pos);
                        Data.CashierNo[pos] = rand.Next(1, 4);
                        int serv = InsertData("Ingrese el Tipo de Servicio: ", Data.TypeService, pos);
                        InsertData("Ingrese el Numero de Factura: ", Data.BillNo, pos);
                        InsertData("Ingrese el Monto a Pagar: ", Data.Ammount, pos);

                        switch (serv)
                        {
                            case 1:
                                Data.Comision[pos] = Data.Ammount[pos] * 0.04f;
                                break;
                            case 2:
                                Data.Comision[pos] = Data.Ammount[pos] * 0.055f;
                                break;
                            case 3:
                                Data.Comision[pos] = Data.Ammount[pos] * 0.065f;
                                break;
                        }

                        InsertData("Ingrese el Monto con el que paga: ", Data.AmmountPay, pos);
                        Data.Reduce[pos] = Data.Ammount[pos] - Data.Comision[pos];
                        Screens.InsertData(pos);
                        pos++;
                        Console.WriteLine("Desea continuar S/N?");
                        option = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        Console.WriteLine("Vectores Llenos.");
                        Console.ReadKey();
                    }
                        
                } while (option != "N") ;                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }

        private static int ValidateData(string text, int[] array)
        {
            int value = 0;
            Console.WriteLine(text);
            value = int.Parse(Console.ReadLine());
            Boolean exists = false;
            int id = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (value.Equals(array[i]))
                {
                    id = i;
                    exists = true;
                }
            }
            
            return id;
        }

        public static void QueryData()
        {
            string option = "N";

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema Pago de Servicios Publicos");
                Console.WriteLine("Tienda La Favorita - Consulta de Datos");
                Console.WriteLine();
                int bill = ValidateData("Numero de Pago:", Data.ID);
                Console.WriteLine();

                if (bill != 0)
                {
                    Console.WriteLine($"Dato Encontrado Posicion Vector {bill}");
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier Tecla para ver Registro");
                    Console.ReadKey();
                    Screens.QueryData(bill);
                }
                else
                    Console.WriteLine($"Pago no se encuentra Registrado");

                Console.WriteLine("Desea continuar S/N?");
                option = Console.ReadLine().ToUpper();
            } while (option != "N");                       
        }

        public static void ModificarPagos()
        {
            string option = "N";

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema Pago de Servicios Publicos");
                Console.WriteLine("Tienda La Favorita - Modificar Pagos");
                Console.WriteLine();
                int bill = ValidateData("Numero de Pago:", Data.ID);
                Console.WriteLine();

                if (bill != 0)
                {
                    Console.WriteLine($"Dato Encontrado Posicion Vector {bill}");
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier Tecla para ver Registro");
                    Console.ReadKey();
                    Screens.ModificarData(bill);
                }
                else
                    Console.WriteLine($"Pago no se encuentra Registrado");

                Console.WriteLine("Desea continuar S/N?");
                option = Console.ReadLine().ToUpper();
            } while (option != "N");
        }

        public static void ModificarCampo(string option, string nvalue, int id)
        {
            switch (option)
            {
                case "A":
                    Data.Date[id] = nvalue;
                    break;
                case "B":
                    Data.Time[id] = nvalue;
                    break;
                case "C":
                    Data.Cedula[id] = nvalue;
                    break;
                case "D":
                    Data.Name[id] = nvalue;
                    break;
                case "E":
                    Data.LastName1[id] = nvalue;
                    break;
                case "F":
                    Data.LastName2[id] = nvalue;
                    break;
                case "G":
                    Data.TypeService[id] = int.Parse(nvalue);
                    break;
                case "H":
                    Data.BillNo[id] = int.Parse(nvalue);
                    break;
                case "I":
                    Data.AmmountPay[id] = float.Parse(nvalue);
                    break;
            }
        }

        public static void EliminarPagos()
        {
            string option = "N";

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema Pago de Servicios Publicos");
                Console.WriteLine("Tienda La Favorita - Eliminar Pagos");
                Console.WriteLine();
                int bill = ValidateData("Numero de Pago:", Data.ID);
                Console.WriteLine();

                if (bill != 0)
                {
                    Console.WriteLine($"Dato Encontrado Posicion Vector {bill}");
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier Tecla para ver Registro");
                    Console.ReadKey();
                    Screens.EliminarData(bill);
                }
                else
                    Console.WriteLine($"Pago no se encuentra Registrado");

                Console.WriteLine("Desea continuar S/N?");
                option = Console.ReadLine().ToUpper();
            } while (option != "N");
        }
    }
}
