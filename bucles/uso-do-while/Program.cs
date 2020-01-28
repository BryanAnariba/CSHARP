using System;

namespace uso_do_while
{
    class Program
    {
        static bool verCredenciales (string usuario , string contrasenia) {
            string user = "BryAnariba";
            string password = "asd456";
            if (usuario == user && contrasenia ==password) {
                return true;
            } else {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string usuario, password;
            do {
                System.Console.WriteLine("Digite el Usuario");
                usuario = Console.ReadLine();
                System.Console.WriteLine("Digite la contraseña");
                password = Console.ReadLine();
            }while (verCredenciales(usuario, password) == false);

            System.Console.WriteLine("Bienvenido");
        }
    }
}
