using System;

namespace exepciones_csharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(0,100);
            int adivinaNum ;
            int intentos = 0;
            do {
                System.Console.WriteLine("Digite un Numero");

                //EXEPCIONES CON FILTROS
                try {
                    adivinaNum = Int32.Parse(Console.ReadLine());

                    //captura todas las exepcions exepto la de tipo formatExepction
                } catch (Exception e) when (e.GetType() != typeof(FormatException)) {
                    System.Console.WriteLine("Error , corrigelo {0}" , e);
                    adivinaNum = 0;
                } catch (FormatException e) {
                    System.Console.WriteLine("Has introducido Texto , por defecto damos 0 {0}" , e);
                    adivinaNum = 0;
                }

                intentos ++ ;
                if (adivinaNum < numero) {
                    System.Console.WriteLine("Cerca pero el numero es menor que el aleatorio");
                }
                if (adivinaNum > numero) {
                    System.Console.WriteLine("Cerca pero el numero es mayor que el aleatorio");
                }
            } while (adivinaNum != numero);

            System.Console.WriteLine("Felicidades atinaste el numero es -> {0}", numero);
            System.Console.WriteLine($"Lo hiciste en { intentos }");

        }
    }
}
