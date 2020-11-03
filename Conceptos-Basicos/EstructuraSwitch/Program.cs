using System;

namespace EstructuraSwitch
{
    class Program
    {
        static double sumaNumeros (double num1 , double num2)
        {
            return num1 + num2;
        }

        static double restarNumeros (double num1 , double num2)
        {
            return num1 - num2;
        }

        static void multiplicarNumeros (double num1 , double num2)
        {
            Console.WriteLine("La Multiplicacion de dos numeros es -> " + (num1 * num2));
        }

        static void divisionNumeros(double num1, double num2)
        {
            Console.WriteLine("La Division de dos numeros es -> " + (num1 / num2));
        }
        static void Main(string[] args)
        {
            // Ejemplo con estructura switch
            /*
                Programa que calcula las operaciones basicas
                1 - Sumar dos numero
                2 - Restar Dos Numeros
                3 - Multiplicar Dos Numeros
                3 - Dividir Dos numeros

                swith -> los case debe ser int char o string, no aceptan bool
             */

            // -> Con switch dentro de un while
            Console.WriteLine("Quiere realizar una operacion" + "\n1-SI" + "\n2-NO");
            int opcionWhile = int.Parse(Console.ReadLine());
            while(opcionWhile == 1)
            {
                double num1, num2;
                Console.WriteLine("Digite el numero 1 -> ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el numero 2 ->");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(
                    "===Programa que calcula las operaciones basicas===" +
                    "\n1 - Sumar dos numero" +
                    "\n2 - Restar Dos Numeros" +
                    "\n3 - Multiplicar Dos Numeros" +
                    "\n4 - Dividir Dos numeros" +
                    "\nSeleccione una opcion -> "
                );

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("La suma de numeros es -> " + sumaNumeros(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("La resta de numeros es -> " + restarNumeros(num1, num2));
                        break;
                    case 3:
                        multiplicarNumeros(num1, num2);
                        break;
                    case 4:
                        divisionNumeros(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.WriteLine("Quiere realizar una operacion" + "\n1-SI" + "\n2-NO");
                opcionWhile = int.Parse(Console.ReadLine());
            }

        }
    }
}
