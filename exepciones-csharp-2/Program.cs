using System;

namespace exepciones_csharp_2
{
    class Program
    {
        static void Main(string[] args)
        {
                                    //CAPTURA DE MULTIPLES EXEPCIONES EN C#
            int numero = 0;
            System.Console.WriteLine("Digite un Numero");
            try {
                numero = Int32.Parse(Console.ReadLine());
            } catch (Exception ex) {//capturamos multiples exepciones
                System.Console.WriteLine("Ha Ocurrido un Error en la insercion del numero {0}" , ex.Message);
            } 

            System.Console.WriteLine("Numero Tecleado -> {0}" , numero);
        }
    }
}
