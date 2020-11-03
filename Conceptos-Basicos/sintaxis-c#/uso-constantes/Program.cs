using System;

namespace uso_constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes -> espacios de memoria cuyo valor no cambiara durante su ejecucion, por convension van en mayusculas
            const string HOST = "localhost";
            const int PORT = 3306;
            const string DB = "test";
            Console.WriteLine($"MYSQL Connection With consts vars -> { HOST }:{ PORT }/{ DB }");

            // Ejercicio -> Calcular el area de un circulo
            const double PI = 3.1416;
            double radioCirculo;
            double calculoArea;
            Console.WriteLine("\nDigite el radio del circulo -> ");
            radioCirculo = double.Parse(Console.ReadLine());

            calculoArea = PI * (Math.Pow(radioCirculo , 2));
            Console.WriteLine($"El area del circulo es -> { calculoArea }");
            
        }
    }
}
 