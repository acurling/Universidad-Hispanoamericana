using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Reports
    {
        static int _total = 20;
        private static string getReportName(string text)
        {
            string value = string.Empty;
            if (!string.IsNullOrEmpty(text))
                value = text;

            return value;
        }

        private static string setTitle(int Total, string text)
        {
            int totalline = Total;
            string value = string.Empty;

            value = text.Trim();
            int line = value.Length;
            int div = (totalline - line) / 2;

            value = $"{Data._blank.PadLeft(div)}{text}";

            return value;
        }

        public static string getValue(string text)
        {
            int totalline = _total;
            string value = string.Empty;

            value = text.Trim();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{value}{Data._blank.PadRight(div)}";

            return value;
        }

        public static string getValue(string[] array, int pos)
        {
            int totalline = _total;
            string value = string.Empty;

            value = array[pos].Trim();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{value}{Data._blank.PadRight(div)}";

            return value;
        }

        public static string getValue(int[] array, int pos)
        {
            int totalline = _total;
            string value = string.Empty;

            value = array[pos].ToString();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{value}{Data._blank.PadRight(div)}";

            return value;
        }

        public static string getValue(float[] array, int pos)
        {
            int totalline = _total;
            string value = string.Empty;

            value = array[pos].ToString();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{value}{Data._blank.PadRight(div)}";

            return value;
        }

        public static void Report1()
        {
            string t1 = "Sistema Pago de Servicios Publicos";
            string t2 = "Tienda La Favorita - Reporte Todos los Pagos";
            string t3 = $"{getValue("#Pago")}{getValue("Fecha/")}{getValue("Hora Pago")}{getValue("Cedula")}{getValue("Nombre")}{getValue("Apellido1")}{getValue("Apellido2")}{getValue("Monto Recibido")}";
            int s3 = t3.Length;
            bool exists = false;
            int cont = 0;
            float total = 0;

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(setTitle(s3, getReportName(t2)));
            Console.WriteLine();
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));

            for (int i = 0; i < Data.ID.Length; i++)
            {
                if (Data.ID[i] != 0)
                {
                    Console.WriteLine($"{getValue(Data.ID, i)}{getValue(Data.Date, i)}{getValue(Data.Time, i)}{getValue(Data.Cedula, i)}{getValue(Data.Name, i)}{getValue(Data.LastName1, i)}{getValue(Data.LastName2, i)}{Data._blank.PadRight(5)}{getValue(Data.Ammount, i)}");
                    exists = true;
                    total += Data.Ammount[i];
                    cont++;
                }                    
            }

            if (!exists)
                Console.WriteLine("Sin Datos");

            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine(getValue("Total de Registros " + cont) +  Data._blank.PadRight(115) + getValue("Monto Total " + total));
            Console.ReadKey();
        }

        public static void Report21()
        {
            string t1 = "Sistema Pago de Servicios Publicos";
            string t2 = "Tienda La Favorita - Reporte Todos los Pagos por Tipo de Servicio";
            string t3 = $"{getValue("#Pago")}{getValue("Fecha/")}{getValue("Hora Pago")}{getValue("Cedula")}{getValue("Nombre")}{getValue("Apellido1")}{getValue("Apellido2")}{getValue("Monto Recibido")}";
            int s3 = t3.Length;
            bool exists = false;
            int cont = 0;
            float total = 0;

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(setTitle(s3, getReportName(t2)));
            Console.WriteLine();
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine();
            Console.WriteLine($"Seleccione codigo de Servicio       [1] Electricidad    [2] Telefono    [3] Agua");
            Console.WriteLine();
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine();
            Console.WriteLine("Ingrese el codigo del servicio: ");
            int cod = int.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    Report22(1);
                    break;
                case 2:
                    Report22(2);
                    break;
                case 3:
                    Report22(3);
                    break;
            }
        }

        public static void Report22(int cod)
        {
            string t1 = "Sistema Pago de Servicios Publicos";
            string t2 = "Tienda La Favorita - Reporte Todos los Pagos por Tipo de Servicio";
            string t3 = $"{getValue("#Pago")}{getValue("Fecha/")}{getValue("Hora Pago")}{getValue("Cedula")}{getValue("Nombre")}{getValue("Apellido1")}{getValue("Apellido2")}{getValue("Monto Recibido")}";
            int s3 = t3.Length;
            bool exists = false;
            int cont = 0;
            
            float total = 0;

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(setTitle(s3, getReportName(t2)));
            Console.WriteLine();
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));

            for (int i = 0; i < Data.ID.Length; i++)
            {
                if (Data.ID[i] != 0)
                {
                    if (Data.TypeService[i] == cod)
                    {
                        Console.WriteLine($"{getValue(Data.ID, i)}{getValue(Data.Date, i)}{getValue(Data.Time, i)}{getValue(Data.Cedula, i)}{getValue(Data.Name, i)}{getValue(Data.LastName1, i)}{getValue(Data.LastName2, i)}{Data._blank.PadRight(5)}{getValue(Data.Ammount, i)}");
                        exists = true;
                        total += Data.Ammount[i];
                        cont++;
                    }
                }
            }

            if (!exists)
                Console.WriteLine("Sin Datos");

            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine(getValue("Total de Registros " + cont) + Data._blank.PadRight(115) + getValue("Monto Total " + total));
            Console.ReadKey();
        }

        public static void Report31()
        {
            string t1 = "Sistema Pago de Servicios Publicos";
            string t2 = "Tienda La Favorita - Reporte Todos los Pagos por Codigo De Cajero";
            string t3 = $"{getValue("#Pago")}{getValue("Fecha/")}{getValue("Hora Pago")}{getValue("Cedula")}{getValue("Nombre")}{getValue("Apellido1")}{getValue("Apellido2")}{getValue("Monto Recibido")}";
            int s3 = t3.Length;
            bool exists = false;
            int cont = 0;
            float total = 0;

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(setTitle(s3, getReportName(t2)));
            Console.WriteLine();
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine();
            Console.WriteLine($"Seleccione codigo de Cajero:       [1] Caja #1    [2] Caja #2    [3] Caja #3");
            Console.WriteLine();
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine();
            Console.WriteLine("Ingrese el codigo del servicio: ");
            int cod = int.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    Report32(1);
                    break;
                case 2:
                    Report32(2);
                    break;
                case 3:
                    Report32(3);
                    break;
            }
        }

        public static void Report32(int cod)
        {
            string t1 = "Sistema Pago de Servicios Publicos";
            string t2 = "Tienda La Favorita - Reporte Todos los Pagos por Codigo De Cajero";
            string t3 = $"{getValue("#Pago")}{getValue("Fecha/")}{getValue("Hora Pago")}{getValue("Cedula")}{getValue("Nombre")}{getValue("Apellido1")}{getValue("Apellido2")}{getValue("Monto Recibido")}";
            int s3 = t3.Length;
            bool exists = false;
            int cont = 0;

            float total = 0;

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(setTitle(s3, getReportName(t2)));
            Console.WriteLine();
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));

            for (int i = 0; i < Data.ID.Length; i++)
            {
                if (Data.ID[i] != 0)
                {
                    if (Data.CashierNo[i] == cod)
                    {
                        Console.WriteLine($"{getValue(Data.ID, i)}{getValue(Data.Date, i)}{getValue(Data.Time, i)}{getValue(Data.Cedula, i)}{getValue(Data.Name, i)}{getValue(Data.LastName1, i)}{getValue(Data.LastName2, i)}{Data._blank.PadRight(5)}{getValue(Data.Ammount, i)}");
                        exists = true;
                        total += Data.Ammount[i];
                        cont++;
                    }
                }
            }

            if (!exists)
                Console.WriteLine("Sin Datos");

            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine(getValue("Total de Registros " + cont) + Data._blank.PadRight(115) + getValue("Monto Total " + total));
            Console.ReadKey();
        }

        public static void Report41()
        {
            string t1 = "Reporte Dinero Comisionado - Desgloce por Tipo de Servicio";           
            string t3 = $"{getValue("ITEM")}{getValue("Cant. Transacciones")}{getValue("Total Comisionado")}";
            int s3 = t3.Length;
            int cont1 = 0, cont2 = 0, cont3 = 0;
            float total1 = 0, total2 = 0,  total3 = 0;
            int[] values1 = new int[3];
            float[] values2 = new float[3];

            Console.Clear();
            Console.WriteLine(setTitle(s3, getReportName(t1)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine(setTitle(s3, getReportName(t3)));
            Console.WriteLine(Data._blank.PadRight(s3, '='));

            for (int i = 0; i < Data.ID.Length; i++)
            {
                if (Data.ID[i] != 0)
                {
                    if (Data.TypeService[i] == 1)
                    {
                        cont1++;
                        total1 += Data.Comision[i];
                        values1[0] = cont1;
                        values2[0] = total1;
                    }
                    else if (Data.TypeService[i] == 2)
                    {
                        cont2++;
                        total2 += Data.Comision[i];
                        values1[1] = cont2;
                        values2[1] = total2;
                    }
                    else
                    {
                        cont3++;
                        total3 += Data.Comision[i];
                        values1[2] = cont3;
                        values2[2] = total3;
                    }
                }
            }

            Console.WriteLine(getValue("1- Electricidad") + getValue(values1[0].ToString()) + getValue(values2[0].ToString()));
            Console.WriteLine(getValue("2- Telefono") + getValue(values1[1].ToString()) + getValue(values2[1].ToString()));
            Console.WriteLine(getValue("3- Agua") + getValue(values1[2].ToString()) + getValue(values2[2].ToString()));
            Console.WriteLine(Data._blank.PadRight(s3, '='));
            Console.WriteLine(getValue("Total") + getValue((cont1 + cont2 + cont3).ToString()) + getValue("Monto Total") + getValue((total1 + total2 + total3).ToString()));
            Console.ReadKey();
        }
    }
}
