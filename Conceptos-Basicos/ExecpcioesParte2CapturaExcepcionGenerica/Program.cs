using System;

namespace ExecpcioesParte2CapturaExcepcionGenerica
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

                // Aqui si tecleas un string hay un error, para que no trunque el programa realizaremos una exception
                try
                {
                    pruebaNumero = int.Parse(Console.ReadLine());
                }
                catch (Exception ex) // Capturamos varias excepciones
                {
                    Console.WriteLine("Ha Ocurrido un error en la digitalizacion del numero -> Vuelva a intentarlo nuevamente");
                    pruebaNumero = 0;
                }

                if (pruebaNumero > aleatorio) Console.WriteLine("El numero tecleado es mayor al aleatorio");

                if (pruebaNumero < aleatorio) Console.WriteLine("El numero tecleado es menor al aleatorio");
            } while (pruebaNumero != aleatorio);

            Console.WriteLine("Felicidades el numero aleatorio es -> " + aleatorio);
            Console.WriteLine("NEXT CODE LINE");
        }
    }
}
