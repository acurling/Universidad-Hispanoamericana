using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3funcionesymetodos
{
    class Clsempleado
    {
        /// Las clases son objetos que constan de atributos, metodos, constructores
        /// atributos 
        String[] nombre = new string[3];
        String[] cedula = new string[3];
        int posicion;

        // constructor sirve para inicializar atributos

        public Clsempleado()
        {
            posicion = 0;
        }

        public Clsempleado(int pos)
        {
            posicion = pos;
        }

        // metodos (Agregar, Borrar, Modificar, Consultar)


        public void inicializar()
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                nombre[i] = "";
                cedula[i] = "";
            }
            posicion = 0;
        }
        public void AgregarEmpleado()
        {
            char opcion;
            opcion = 's';

            DateTime fecha;
            while ((opcion != 'n') && (posicion < 3)) { 
                Console.WriteLine("Digite el nombre:");
            nombre[posicion] = Console.ReadLine();
            Console.WriteLine("Digite la cedula:");
            cedula[posicion] = Console.ReadLine();
            posicion++;
            Console.WriteLine("Desea continuar s/n");
            opcion = Convert.ToChar(Console.ReadLine());
        }
    }

        public void Reporte() 
        {

            Console.SetCursorPosition(45, 10);
            Console.WriteLine("****** REPORTE EMPLEADOS ******* ");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("___________________________");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Cedula");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("___________________________");
            int contador = 14;
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.SetCursorPosition(40, contador++);
                Console.WriteLine($"{nombre[i]}    {cedula[i]}");
                Console.SetCursorPosition(40, contador++);
                Console.WriteLine($"{nombre[i]}    {cedula[i]}");
            }
            
        }

        public void ConsultarEmpleado()
        {
            Console.WriteLine("digite una cedula");
            string ced = Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"El empleado se llama: {nombre[i]}");
                } 
            }
            Console.WriteLine();
        }

        public void BorrarEmpleado()
        {

        }

        public void ModificarEmpleado()
        {
            Console.WriteLine("digite una cedula");
            string ced = Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine("Digite el nombre:");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite la cedula:");
                    cedula[i] = Console.ReadLine();
                }
            }
            Console.WriteLine();
        }
    }
}


