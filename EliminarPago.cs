using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBernalGutierrezQuesada
{
   public class EliminarPago
    {


        public int indexEpago;
        public int eliminarP;
        public EliminarPago() {




            Console.WriteLine("Por favor digite el numero de pago que desea eliminar");
            indexEpago = Int32.Parse(Console.ReadLine());

            if (indexEpago < 10)
            {
                foreach (int i in InicializarVectores.numeroDePago)
                {




                    if (i == indexEpago)
                    {
                        Console.WriteLine($"Esta seguro que desea eliminar el registro: {indexEpago} ");
                        Console.WriteLine("");
                        Console.WriteLine("\t1 - Si");
                        Console.WriteLine("\t2 - No");
                        eliminarP = Int32.Parse(Console.ReadLine());

                        if (eliminarP == 1)
                        {



                            InicializarVectores.nombre[indexEpago] = "";
                            InicializarVectores.apellido[indexEpago] = "";
                            InicializarVectores.cedulaUser[indexEpago] = 0;
                            InicializarVectores.numeroDeFactura[indexEpago] = 0;
                            InicializarVectores.servicioPago[indexEpago] = "";
                            InicializarVectores.montoTotalPagado[indexEpago] = 0;
                            InicializarVectores.pagoSinComision[indexEpago] = 0;
                            InicializarVectores.pagoConComision[indexEpago] = 0;
                            InicializarVectores.pagoCon[indexEpago] = 0;
                            InicializarVectores.hora[indexEpago] = "";
                            InicializarVectores.fecha[indexEpago] = "";
                            InicializarVectores.caja[indexEpago] = 0;
                            InicializarVectores.numeroDePago[indexEpago] = 0;
                            InicializarVectores.vueltoAlCliente[indexEpago] = 0;

                            Console.WriteLine("");
                            Console.WriteLine($"Registro: {indexEpago}  Eliminado exitosamente");
                            Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                            Console.ReadKey();
                            Menu menuinicial = new Menu();














                        }

                        else {

                            Console.WriteLine("No se elimino ningun registro");
                            Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                            Console.ReadKey();
                            Menu menuinicial = new Menu();




                        }










                    } /// end if interno 








                    } // end foreach










                } // end if externo



            else {
                Console.WriteLine("El pago no existe");
                Console.WriteLine("Volviendo al menu principal al tocar cualquier tecla");
                Console.ReadKey();
                Menu menuinicial = new Menu();




            }










        }







    }
}
