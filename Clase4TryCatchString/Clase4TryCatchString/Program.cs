using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4TryCatchString
{
    class Program
    {
        static double val = 0;
        static string numero = "";
        static ConsoleKeyInfo chr;
        static void Main(string[] args)
        {
            //Funcion para ingresar numeros

            // Pick a file that is not there  
            string path = @"C:\ALEX\Carlos.txt";
            // Create a FileStream  
            FileStream fs = default;
            try
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                // Open FileStream  
                fs = File.Open(path, FileMode.Open);
                // Read a file that is not there  
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFound. {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Clean up start!");

                // Release resources here  
                //fs.Close();
                Console.ReadLine();
            }

        }

        public static void SolicitaDatos()
        {
            int num1 = 5;
            int num2 = 0;

            int[] arreglo = new int[5];

            try
            {
                int resultado = num1 / 1;
                Console.WriteLine(resultado);
                arreglo[4] = 7;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error indice");
               
            }

            finally 
            {
                Console.WriteLine("cerrar archivo");
                Console.ReadLine();

            }
        }
    }
}
