using System;

namespace exepciones_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            System.Console.WriteLine("Eres Bienvenido al Sistema llego la ora de adivinar el numero");
            Random numeroA = new Random();
            int numero = numeroA.Next(0,100);
            int intentos = 1;
            System.Console.WriteLine("Digite el Numero para ver si le pegas");
            try {
                num = Int32.Parse(Console.ReadLine());//METERLO EN EXEPCION
            } catch (FormatException ex) {
                System.Console.WriteLine("No has Introducido un Valor Numerico Valido , valor por defecto  0");
            }
            while (num != numero) {
                if (num > numero) {
                    System.Console.WriteLine("El Numero Tecleado es mayor que el que hay que adivinar");
                } else {
                    if (num < numero) {
                        System.Console.WriteLine("El Numero Tecleado es menor que el que hay que adivinar");
                    }
                }
                intentos ++; 
                System.Console.WriteLine("Digite el Numero para ver si le pegas");
                try {
                    num = Int32.Parse(Console.ReadLine());
                } catch (FormatException ex) {
                    System.Console.WriteLine("No has Introducido un Valor Numerico Valido, valor por defecto 0");
                }
            }
            System.Console.WriteLine("Felicidades atinaste al numero.");
            System.Console.WriteLine("Lo Hiciste en {0}" , intentos , " Intentos");
        }
    }
}
