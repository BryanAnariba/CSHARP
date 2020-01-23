using System;

namespace cajeroAutomatico
{
    class Program
    {
        public double saldoPersona = 12000;
        public string password = "asd456";
        static double verificarSaldo() {
            return saldoPersona;
        }
        static double retiroEfectivo (double monto) {
            return 0.2;
        }
        static string cambioContrasenia (string passwordActual , string passwordNuevo) {
            return "asd";
        }
        static void Main(string[] args)
        {
            int opcion;
            do {
                System.Console.WriteLine("Bienvenido Atm XXXXXXXX");
                System.Console.WriteLine("Opciones a Realizar:");
                System.Console.WriteLine("1- Verificar Saldo");
                System.Console.WriteLine("2- Retiro Efectivo");
                System.Console.WriteLine("3- Cambio Contraseña");
                System.Console.WriteLine("4- Salir");
                System.Console.WriteLine("Seleccione Una Opcion -> ");
                opcion = Int32.Parse(Console.ReadLine());
            } while(opcion < 1 || opcion > 4);
            if (opcion == 1) {
                System.Console.WriteLine("Su Saldo Actual es -> {0}" , verificarSaldo());
            } else {
                if (opcion == 2) {

                }
            }

        }
    }
}
