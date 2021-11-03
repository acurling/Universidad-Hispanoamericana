using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Estudiante
    {
        // Atributos
        String[] cedula = new string[10];
        String[] nombre = new string[10];
        String[] promedio = new string[10];
        int pos, Notafinal;
        String A = "";

        //Constructores
        public Estudiante()
        {
            pos = 0;
            Notafinal = 0;

        }

       

        public void Inicializarvectores()
        {

            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                promedio[i] = "";
             
            }
        }
        public void Agregarestudiante()
        {
            char opcion = 's';
            do
            {
                Console.WriteLine("Digite el nombre del estudiante");
                nombre[pos] = Console.ReadLine();
                Console.WriteLine("Digite la cedula del estudiante");
                cedula[pos] = Console.ReadLine();
                pos++;
                Console.WriteLine("Digite el promedio del estudiante");
                promedio[pos] = Console.ReadLine();
                pos++;
                Console.WriteLine("Por favor digite el promedio para evaluar si el estudiante aprobo");
                Notafinal = Convert.ToInt32(Console.ReadLine());
                if (Notafinal >= 70)
                    A = "Aprobado";

                else
                    A ="Desaprobado";
                Console.WriteLine(A);
                Console.ReadLine();
                

                Console.WriteLine("Desea agregar otro estudiante S/N");
                opcion = Convert.ToChar(Console.ReadLine());

            } while (opcion != 'n');
        }



        public void Consultarestudiante()
        {
            Console.WriteLine("Ingrese la cedula:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < cedula.Length; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"El estudiante se llama: {nombre[i]}");
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El estudiante no existe");
            }
        }


        public void Eliminarestudiantes()
        {
            if (nombre == null)
            {
                Console.Clear();
                Console.WriteLine("NO hay estudiantes para eliminar");
                _ = Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Por favor digite la cedula de estudiante que desea eliminar?");
                String busqueda = Console.ReadLine();
                for (int i = 0; i < cedula.Length; i++)
                {
                    if (busqueda == cedula[i])
                    {
                        nombre[i] = null;
                        cedula[i] = null;
                        promedio[i] = null;

                    }
                }
            }
        }


        public void Modificarestudiante()
        {
            
        }



        public void Reportetotal()

        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("***** REPORTE DE Estudiantes completo *****");
            Console.WriteLine(" Nombre      Cedula           Promedio       ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"{nombre[i]}          {cedula[i]}                          {promedio[i]}        ");

            }
            Console.WriteLine("-------------------------------------------------------------------------");

        }

        public void Reportecondicion()

        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("***** REPORTE DE Estudiantes por condicion *****");
            Console.WriteLine(" Nombre              Promedio       ");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"{nombre[i]}                          {promedio[i]}         ");

            }
            Console.WriteLine("-------------------------------------");

        }


    }
}
