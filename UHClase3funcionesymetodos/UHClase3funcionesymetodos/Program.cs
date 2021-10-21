using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3funcionesymetodos
{
    class Program
    {
        static string nombre = "Lucia";  // variable globales
        static float salario = 5000;
        static void Main(string[] args)
        {
            // Clsmenu.principal();
            //Rep.principal();

            Vehiculo carro = new Vehiculo(); //
            carro.ReporteMiVehiculo();
            Console.ReadLine();

            carro = new Vehiculo("Negro", 2, 3000, "Impreza", 2022);

            //Vehiculo carro1 = new Vehiculo("Negro", 2, 3000, "Impreza", 2022);
            carro.ReporteMiVehiculo();
            Console.ReadLine();
            

        }

        static void empleado(string nombre) {  // metodo 
           nombre = "Luis";  // variable local
            float salario = 1000;
            Console.WriteLine($"El empleado {nombre} gana es: {salario}");
        }

        //funciones tienes caracteristicas: tipo dato, NO usan void, return
        static string calculoSalario()
        {
            float total = (Program.salario*1.13f);
            String resultado = "El salario de Lucia es " + total;
            return resultado;
        
        }

        static void suma() {   // los metodos usan la palabra void
            int resultado = 0; // variable local
            resultado = 5 + 3;
            Console.WriteLine(resultado);
        }

        static void resta() {
            int resultado = 0;
            resultado = 5 - 3;
            Console.WriteLine(resultado);
        }


    }
}
