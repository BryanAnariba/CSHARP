using System;

namespace estructura_switch
{
    class Program
    {
        static double calHip(double num1 , double num2) {
            return Math.Sqrt(Math.Pow(num1 , 2) + Math.Pow(num2 , 2));
        }
        static double calRoot(double num1) {
            return Math.Sqrt(num1);
        }
        static double calPotencia(double numero , double potencia) {
            return Math.Pow(numero , potencia);
        }
        static void Main(string[] args)
        {
            int opcion;
            System.Console.WriteLine("Opciones A Realizar");
            System.Console.WriteLine("1- Calculo Hipotenusa");
            System.Console.WriteLine("2- Calculo Raiz Numero");
            System.Console.WriteLine("3- Potencia de un Numero");
            opcion = Int32.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    System.Console.WriteLine("Digite El Cateto A ->");
                    double a = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite El Cateto B ->");
                    double b = double.Parse(Console.ReadLine());
                    double res = calHip(a , b);
                    System.Console.WriteLine("Valor de la Hipotenusa -> {0}" , res);
                break;
                case 2:
                    System.Console.WriteLine("Digite El Numero A Saber Su Raiz ->");
                    double num = double.Parse(Console.ReadLine());
                    double result = calRoot(num);
                    System.Console.WriteLine("Raiz del Numero es -> {0}" , result);
                break;
                case 3:
                    System.Console.WriteLine("Digite el Numero -> ");
                    double numero = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Digite La potencia del numero -> ");
                    double potencia = double.Parse(Console.ReadLine());
                    double resultado = calPotencia(numero , potencia);
                    System.Console.WriteLine("Value is -> {0}" , resultado);
                break;
                default:
                    System.Console.WriteLine("Opcion No Valida");
                break;
            }
        }
    }
}
