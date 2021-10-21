using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3funcionesymetodos
{
   class Vehiculo
    {
        //Atributos globales
        String color, modelo;
        float cilindraje, pasajeros;
        int anioFrabricacion;

        // constructor : inicializar atributos
        public Vehiculo()  // sirve para inicializar una clase
        {
            color = "rojo";
            pasajeros = 5;
            cilindraje = 2000;
            anioFrabricacion = 2021;
            modelo = "4x4";
        }
        public Vehiculo(string color, float cantidad, float cilindraje, string modelo, int anio)  // sirve para inicializar una clase
        {
            this.color = color;
            pasajeros = cantidad;
            this.cilindraje = cilindraje;
            anioFrabricacion = anio;
            this.modelo = modelo; ;
        }
        public Vehiculo(String color)
        {
            this.color = color;
        }

        //

        public void AgregarVehiculo() { }
        public void BorrarVehiculo() { }
        public void ModificarVehiculo() { }

        public void ConsultarVehiculo() { }
        public void ReporteMiVehiculo()

        {
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("**** Menu principal ***** ");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("___________________________");

            Console.SetCursorPosition(10, 18);
            Console.WriteLine("___________________________");

            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Color: ");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine(this.color);

            Console.SetCursorPosition(25, 10);
            Console.WriteLine("Pasajeros: ");
            Console.SetCursorPosition(25, 11);
            Console.WriteLine(this.pasajeros);

            Console.SetCursorPosition(25, 13);
            Console.WriteLine("Motor: ");
            Console.SetCursorPosition(25, 14);
            Console.WriteLine(this.cilindraje);


            Console.SetCursorPosition(10, 13);
            Console.WriteLine("Fabricacion: ");
            Console.SetCursorPosition(10, 14);
            Console.WriteLine(this.anioFrabricacion);

            Console.SetCursorPosition(45, 10);
            Console.WriteLine("Modelo: ");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine(this.modelo);

            Console.SetCursorPosition(45, 13);
            Console.WriteLine("Dueno: ");
            Console.SetCursorPosition(45, 14);
            Console.Write("Alexander Benjamin ");
            Console.ReadLine(); 


        }
    }

    
}
