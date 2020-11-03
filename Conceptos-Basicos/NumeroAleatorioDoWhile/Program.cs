using System;

namespace NumeroAleatorioDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int pruebaNumero;
            do
            {
                Console.WriteLine("Digite un numero para ver si esta comprendido entre 0 y 100");
                pruebaNumero = int.Parse(Console.ReadLine());
                if (pruebaNumero > aleatorio) Console.WriteLine("El numero tecleado es mayor al aleatorio");

                if (pruebaNumero < aleatorio) Console.WriteLine("El numero tecleado es menor al aleatorio");
            } while (pruebaNumero != aleatorio);

            Console.WriteLine("Felicidades el numero aleatorio es -> " + aleatorio);
            Console.WriteLine("NEXT CODE LINE");
        }
    }
}
