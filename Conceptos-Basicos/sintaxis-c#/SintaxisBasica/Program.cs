using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxis Basica en C#
            // Declarando Variables
            int edadPersona, edadPersona2, edadPersona3, edadPersona4;

            double montoCuenta = 3045.45;
            bool statusEmpleado = false;
            edadPersona = 23;
            int numeroUno = 10 , numeroDos = 2 , divisionNumeros;

            Console.WriteLine($"Edad Persona -> { edadPersona } anios, esto usa interpolacion de strings");
            Console.WriteLine("Monto total en al cuenta -> " + montoCuenta);
            if (statusEmpleado)
            {
                Console.WriteLine("El empleado esta actualmente laborando");
            } else
            {
                Console.WriteLine("El empleado no esta actualmente laborando");
            }

            // Operadores aritmeticos generales en C# , son iguales -> + , - , * , / , %
            Console.WriteLine("Suma de numeros -> " + (numeroUno + numeroDos));
            Console.WriteLine("Resta de numeros -> " + (numeroUno - numeroDos));
            Console.WriteLine("Multiplicacion de numeros -> " + (numeroUno * numeroDos));
            if (numeroDos == 0)
            {
                Console.WriteLine("No se puede dividir por -> " + numeroDos);
            } else
            {
                divisionNumeros = numeroUno / numeroDos;
                Console.WriteLine("Division de numeros -> " + divisionNumeros);
            }
            Console.WriteLine("Modulo de un numero -> " + (numeroUno % numeroDos));

            // Plus del operador = , estas tres variables tienen el mismo valor
            edadPersona2 = edadPersona3 = edadPersona4 = 30;
            Console.WriteLine("<========================================================>");
            Console.WriteLine("Persona Dos -> " + edadPersona2 + "\nPersona Tres -> " + edadPersona3 + "\nPersona Cuatro -> " + edadPersona4);


            // Parseo de numeros , Entrada de datos por consola por medio del usuario

            Console.WriteLine("Introduce el numero Uno: ");
            // ojo aqui ocurre el parseo de numero string a int
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el numero Dos: ");
            double numTwo = double.Parse(Console.ReadLine());

            double SumaNum = numOne + numTwo;

            Console.WriteLine($"Resultado de la suma -> { SumaNum }");

            //Console.ReadLine();
            Console.WriteLine("Digite su nombre -> ");
            string name = Console.ReadLine();
            Console.WriteLine($"My name is -> { name }");
        }
    }
}
