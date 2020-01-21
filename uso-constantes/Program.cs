using System;

namespace uso_constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimiendo Un Mensaje por Consola");

            /*
                usar una constante entera por ejemplo , por convencion en mayuscular y 
                las constantes deben declararse y asignar un valor en la misma line
            */
            const int NUMERO=50;
            const int NUMERO2=50;
            const int SUMA=NUMERO2 + NUMERO;
            Console.WriteLine("Suma De Constantes -> {0}{1}{2}{3}{4}" , NUMERO , " y " , NUMERO2 , " es -> " , SUMA);

            /*
                Calcular radio de un circulo con pi
            */
            const double PI = 3.141516;
            double res;
            Console.WriteLine("Digite El Valor del Radio -> ");
            double radio = double.Parse(Console.ReadLine()); 
            res = PI*(Math.Pow(radio , 2));//dos campos son double
            Console.WriteLine($"El Area del Circulo es -> {res}");
        }
    }
}
