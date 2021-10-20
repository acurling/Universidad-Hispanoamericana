namespace ExamenBernalGutierrezQuesada
{
    public class InicializarVectores
    {

        public static int[] pagoNumero;

        public static string[] fecha;
        public static string[] hora;
        public static int[] cedulaUser;
        public static string[] nombre;
        public static string[] apellido;
        public static int[] numeroDePago;
        public static int[] numeroDeFactura;
        public static string[] servicioPago;
        public static double[] pagoSinComision;
        public static double[] pagoConComision;
        public static double[] pagoCon;
        public static double[] montoTotalPagado;
        public static double[] vueltoAlCliente;
        public static int[] caja;
        public static int prinInC=0;



        public InicializarVectores() {

            pagoNumero = new int[10];
            fecha = new string[10];
            hora = new string[10];
            cedulaUser = new int[10];
            nombre = new string[10];
            apellido = new string[10];
            numeroDeFactura = new int[10];
            numeroDePago = new int[10];
            servicioPago = new string[10];
            pagoSinComision = new double[10];
            montoTotalPagado = new double[10];
            vueltoAlCliente = new double[10];
            pagoConComision = new double[10];
            pagoCon= new double[10];
            caja = new int[10];



            

            if (prinInC==0) {
                prinInC=77;

            
            }




        
        
        }





    }








}
