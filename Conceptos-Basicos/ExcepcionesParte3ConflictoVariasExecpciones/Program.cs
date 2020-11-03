using System;

namespace ExcepcionesParte3ConflictoVariasExecpciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio de conflicto de execpciones
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
                catch (FormatException ex) // Capturamos la excepcion exacta al error y la de introducir string en un numero
                {
                    Console.WriteLine("Dede introducir un numero");
                    pruebaNumero = 0;
                }
                catch (Exception ex) // Excepcion general
                {
                    Console.WriteLine("Ha Ocurrido un error en la digitalizacion del numero -> Vuelva a intentarlo nuevamente");
                    pruebaNumero = 0;
                }

                if (pruebaNumero > aleatorio) Console.WriteLine("El numero tecleado es mayor al aleatorio");

                if (pruebaNumero < aleatorio) Console.WriteLine("El numero tecleado es menor al aleatorio");
            } while (pruebaNumero != aleatorio);

            Console.WriteLine("Felicidades el numero aleatorio es -> " + aleatorio);
            Console.WriteLine("NEXT CODE LINE");

            // Execpcion con filtros
            Random numero2 = new Random();
            int aleatorio2 = numero.Next(0, 100);
            int pruebaNumero2;
            do
            {
                Console.WriteLine("Digite un numero para ver si esta comprendido entre 0 y 100");

                // Aqui si tecleas un string hay un error, para que no trunque el programa realizaremos una exception
                try
                {
                    pruebaNumero2 = int.Parse(Console.ReadLine());
                } // Aqui Expection captura todas las execpciones menos la de FormatException
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha Ocurrido un error en la digitalizacion del numero -> Vuelva a intentarlo nuevamente");
                    pruebaNumero2 = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe introducir un numero-> Vuelva a intentarlo nuevamente");
                    pruebaNumero2 = 0;

                }
                if (pruebaNumero2 > aleatorio2) Console.WriteLine("El numero tecleado es mayor al aleatorio");

                if (pruebaNumero2 < aleatorio2) Console.WriteLine("El numero tecleado es menor al aleatorio");
            } while (pruebaNumero2 != aleatorio2);

            Console.WriteLine("Felicidades el numero aleatorio es -> " + aleatorio2);
            Console.WriteLine("NEXT CODE LINE");

        }
    }
}
