using System;

namespace exepciones_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = int.MaxValue;

            //otra forma de tratar un problema de exepcion unchecked es lo contrario de checked
            //solo funcionan con int y con long cheked y uncheked
            //int numero2 = checked(numero + 50);
            //System.Console.WriteLine(numero2);
            int numero;
            System.Console.WriteLine("Introduce un numero de mes");
            numero = Int32.Parse(Console.ReadLine());
            try {
                System.Console.WriteLine("Es el Mes -> {0}" , nombreMes(numero));
            } catch (Exception e) {
                System.Console.WriteLine("Mensaje de la exepcion -> " + e.Message);
            }

            System.Console.WriteLine("Continuacion------->");
        }

        public static string nombreMes (int mes) {
            switch(mes) {
                case 1:
                    return "Enero";
                
                case 2:
                    return "Febrero";
                
                case 3:
                    return "Marzo";
                
                case 4:
                    return "Abril";
                
                case 5:
                    return "Mayo";
                
                case 6:
                    return "Junio";
                
                case 7:
                    return "Julio";
                
                case 8:
                    return "Agosto";
                
                case 9:     
                    return "Septiembre";
                
                case 10:
                    return "Octubre";
                
                case 11:
                    return "Noviembre";
                
                case 12:
                    return "Diciembre";
                
                default:
                //lance un objeto en vez de retornar algo y truene el programa
                    throw new ArgumentOutOfRangeException();
                
            }
        }
    }
}
