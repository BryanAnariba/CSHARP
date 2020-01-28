using System.Net;
using System;

namespace uso_while
{
    class Program
    {
        static bool comprobacionPassword (string email , string password) {
            if (email == "saariel115@gmail.com" && password == "asd456") {
                return true;
            } else {
                return false;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite el Correo");
            string email = Console.ReadLine();
            System.Console.WriteLine("Digite La Contraseña");
            string password = Console.ReadLine();
            bool alerta = comprobacionPassword(email , password);

            //Ejemplo Constraseña y Usuario con while
            while(alerta != true) {
                System.Console.WriteLine("-----------Contraseña Incorrecta-----------");
                System.Console.WriteLine("Digite el Correo");
                email = Console.ReadLine();
                System.Console.WriteLine("Digite La Contraseña");
                password = Console.ReadLine();
                alerta = comprobacionPassword(email , password);
            }
            System.Console.WriteLine("Eres Bienvenido al Sistema llego la ora de adivinar el numero");
            Random numeroA = new Random();
            int numero = numeroA.Next(0,100);
            int intentos = 1;
            System.Console.WriteLine("Digite el Numero para ver si le pegas");
            int num = Int32.Parse(Console.ReadLine());
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
                num = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Felicidades atinaste al numero.");
            System.Console.WriteLine("Lo Hiciste en {0}" , intentos , " Intentos");
        }
    }
}
