using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Screens
    {
        public static string getValue(string text, string[] array, int pos)
        {
            int totalline = Data.total;
            string value = string.Empty;

            value = text.Trim() + array[pos].Trim();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{text}{Data._blank.PadRight(div)}{array[pos].Trim()}{Data._blank.PadRight(5)}";

            return value;
        }

        public static string getValue(string text, int[] array, int pos)
        {
            int totalline = Data.total;
            string value = string.Empty;

            value = text.Trim() + array[pos];
            int line = value.Length;
            int div = (totalline - line);

            value = $"{text}{Data._blank.PadRight(div)}{array[pos]}{Data._blank.PadRight(5)}";

            return value;
        }

        public static string getValue(string text, float[] array, int pos)
        {
            int totalline = Data.total;
            string value = string.Empty;

            value = text.Trim() + array[pos];
            int line = value.Length;
            int div = (totalline - line);

            value = $"{text}{Data._blank.PadRight(div)}{array[pos]}{Data._blank.PadRight(5)}";

            return value;
        }

        public static string getValue(string text, float array)
        {
            int totalline = Data.total;
            string value = string.Empty;

            value = text.Trim() + array;
            int line = value.Length;
            int div = (totalline - line);

            value = $"{text}{Data._blank.PadRight(div)}{array}{Data._blank.PadRight(5)}";

            return value;
        }

        public static string getValue(string text)
        {
            int totalline = Data.total;
            string value = string.Empty;

            value = text.Trim();
            int line = value.Length;
            int div = (totalline - line);

            value = $"{text}{Data._blank.PadRight(div)}";

            return value;
        }

        public static void InsertData(int pos)
        {
            Console.Clear();
            Console.WriteLine("Sistema Pago de Servicios Publicos");
            Console.WriteLine("Tienda La Favorita - Ingreso de Datos");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Pago:", Data.ID, pos));
            Console.WriteLine(getValue("Fecha:", Data.Date, pos) + getValue("Hora:", Data.Time, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Cedula:", Data.Cedula, pos) + getValue("Nombre:", Data.Name, pos));
            Console.WriteLine(getValue("Apellido1:", Data.LastName1, pos) + getValue("Apellido2:", Data.LastName2, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Tipo de Servicio:", Data.TypeService, pos) + "[1- Electricidad  2- Telefono  3- Agua]");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Factura:", Data.BillNo, pos) + getValue("Monto Pagar:", Data.Ammount, pos));
            Console.WriteLine(getValue("Comision autorizada:", Data.Comision, pos) + getValue("Paga con:", Data.AmmountPay, pos));
            Console.WriteLine(getValue("Monto deducido:", Data.Reduce, pos) + getValue("Vuelto:", (Data.AmmountPay[pos] - Data.Ammount[pos])));
            Console.WriteLine();
        }

        public static void QueryData(int pos)
        {
            Console.Clear();
            Console.WriteLine("Sistema Pago de Servicios Publicos");
            Console.WriteLine("Tienda La Favorita - Consulta de Datos");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Pago:", Data.ID, pos));
            Console.WriteLine(getValue("Fecha:", Data.Date, pos) + getValue("Hora:", Data.Time, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Cedula:", Data.Cedula, pos) + getValue("Nombre:", Data.Name, pos));
            Console.WriteLine(getValue("Apellido1:", Data.LastName1, pos) + getValue("Apellido2:", Data.LastName2, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Tipo de Servicio:", Data.TypeService, pos) + "[1- Electricidad  2- Telefono  3- Agua]");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Factura:", Data.BillNo, pos) + getValue("Monto Pagar:", Data.Ammount, pos));
            Console.WriteLine(getValue("Comision autorizada:", Data.Comision, pos) + getValue("Paga con:", Data.AmmountPay, pos));
            Console.WriteLine(getValue("Monto deducido:", Data.Reduce, pos) + getValue("Vuelto:", (Data.AmmountPay[pos] - Data.Ammount[pos])));
            Console.WriteLine();
        }

        public static void  ModificarData(int pos)
        {
            Console.Clear();
            Console.WriteLine("Sistema Pago de Servicios Publicos");
            Console.WriteLine("Tienda La Favorita - Modificar Datos");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Pago:", Data.ID, pos));
            Console.WriteLine(getValue("A-Fecha:", Data.Date, pos) + getValue("B-Hora:", Data.Time, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("C-Cedula:", Data.Cedula, pos) + getValue("D-Nombre:", Data.Name, pos));
            Console.WriteLine(getValue("E-Apellido1:", Data.LastName1, pos) + getValue("F-Apellido2:", Data.LastName2, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("G-Tipo de Servicio:", Data.TypeService, pos) + "[1- Electricidad  2- Telefono  3- Agua]");
            Console.WriteLine();
            Console.WriteLine(getValue("H-Numero de Factura:", Data.BillNo, pos) + getValue("Monto Pagar:", Data.Ammount, pos));
            Console.WriteLine(getValue("Comision autorizada:", Data.Comision, pos) + getValue("I-Paga con:", Data.AmmountPay, pos));
            Console.WriteLine(getValue("Monto deducido:", Data.Reduce, pos) + getValue("Vuelto:", (Data.AmmountPay[pos] - Data.Ammount[pos])));
            Console.WriteLine();
            Console.WriteLine(getValue("Seleccione opcion a modificar: "));
            string value = Console.ReadLine().ToUpper();
            Console.WriteLine(getValue("Nuevo Dato: "));
            string nvalue = Console.ReadLine().ToUpper();
            Functions.ModificarCampo(value, nvalue, pos);
        }

        public static void EliminarData(int pos)
        {
            Console.Clear();
            Console.WriteLine("Sistema Pago de Servicios Publicos");
            Console.WriteLine("Tienda La Favorita - Eliminar Datos");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Pago:", Data.ID, pos));
            Console.WriteLine(getValue("Fecha:", Data.Date, pos) + getValue("Hora:", Data.Time, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Cedula:", Data.Cedula, pos) + getValue("Nombre:", Data.Name, pos));
            Console.WriteLine(getValue("Apellido1:", Data.LastName1, pos) + getValue("Apellido2:", Data.LastName2, pos));
            Console.WriteLine();
            Console.WriteLine(getValue("Tipo de Servicio:", Data.TypeService, pos) + "[1- Electricidad  2- Telefono  3- Agua]");
            Console.WriteLine();
            Console.WriteLine(getValue("Numero de Factura:", Data.BillNo, pos) + getValue("Monto Pagar:", Data.Ammount, pos));
            Console.WriteLine(getValue("Comision autorizada:", Data.Comision, pos) + getValue("Paga con:", Data.AmmountPay, pos));
            Console.WriteLine(getValue("Monto deducido:", Data.Reduce, pos) + getValue("Vuelto:", (Data.AmmountPay[pos] - Data.Ammount[pos])));
            Console.WriteLine();
            Console.WriteLine("Esta seguro de eliminar el dato S/N?");
            string value = Console.ReadLine().ToUpper();
            if (value == "S")
            {
                Data.ID = Data.ID.Where(e => e != Data.ID[pos]).ToArray();
                Data.Date = Data.Date.Where(e => e != Data.Date[pos]).ToArray();
                Data.Time = Data.Time.Where(e => e != Data.Time[pos]).ToArray();
                Data.Cedula = Data.Cedula.Where(e => e != Data.Cedula[pos]).ToArray();
                Data.Name = Data.Name.Where(e => e != Data.Name[pos]).ToArray();
                Data.LastName1 = Data.LastName1.Where(e => e != Data.LastName1[pos]).ToArray();
                Data.LastName2 = Data.LastName2.Where(e => e != Data.LastName2[pos]).ToArray();
                Data.TypeService = Data.TypeService.Where(e => e != Data.TypeService[pos]).ToArray();
                Data.BillNo = Data.BillNo.Where(e => e != Data.BillNo[pos]).ToArray();
                Data.Ammount = Data.Ammount.Where(e => e != Data.Ammount[pos]).ToArray();
                Data.Comision = Data.Comision.Where(e => e != Data.Comision[pos]).ToArray();
                Data.AmmountPay = Data.AmmountPay.Where(e => e != Data.AmmountPay[pos]).ToArray();
                Data.Reduce = Data.Reduce.Where(e => e != Data.Reduce[pos]).ToArray();
                Data.AmmountPay = Data.AmmountPay.Where(e => e != Data.AmmountPay[pos]).ToArray();
                Console.WriteLine("La informacion ya fue eliminada");
            } else
                Console.WriteLine("La informacion no fue eliminada");
        }
    }
}
