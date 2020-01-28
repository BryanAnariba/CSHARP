using System;

namespace exepciones_cheked_uncheked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked {
                int numero = int.MaxValue;//valor maximo permitido por un int
                int numeroMas = numero + 20;//si agrego veinte debe caer pero lo hace con cheked
                System.Console.WriteLine(numeroMas);
            }

        }
    }
}
