using System;

namespace MetodosOrFunciones
{
    class Program
    {
        // Posibles propiedades de la clase o atributos con sus respectivos modificadores de acceso


        // Declarando Metodos
        // Ejemplo Suma de numeros retorna entero para poder usarlo en cualquier proceso
        static int sumarNumeros(int numeroUno, int numeroDos)
        {
            return (numeroUno + numeroDos);
        }

        // Ejemplo muestra tu nombre , no retorna nada solo realiza el procedimiento
        static void muestraNombre(string nombreCompleto)
        {
            Console.WriteLine("Nombre Completo -> " + nombreCompleto);
        }

        // Ejemplo Sobrecarga de metodos , la llamada depende de la cantidad de parametros que envies 
        static int multiplicarNumeros (int n1 , int n2)
        {
            return n1 + n2;
        }

        // Si se fijan el 3 parametro es opcional osea depende de nustras necesidades se envia o no
        static int multiplicarNumeros (int num1 , int num2 , int num3=0)
        {
            return num1 + num2 + num3;
        }

        static void Main(string[] args)
        {
            // Metodos o Funciones -> trozos de codigo que retornan o realizan un calculo o operacion en concreto
            // OJO -> En c# o java todo metodo debe ir en una clase, en otros lenguajes como php y javascript etc no es asi.
            /*
                Sintaxis -> Descripcion de la estructura de un metodo, en c# o java un metodo o funcion es lo mismo
                
                tipoDatoRetorno nombreMetodo () {
                    // Instrucciones
                    return resultados;
                }
             */
            int resultado = sumarNumeros(3, 8);
            string nombreCompleto;
            Console.WriteLine("Suma de numeros -> " +  resultado);

            Console.WriteLine("\nDigita tu nombre completo -> ");
            nombreCompleto = Console.ReadLine();
            muestraNombre(nombreCompleto);

            Console.WriteLine(multiplicarNumeros(5,5 , 5));
            Console.WriteLine(multiplicarNumeros(51,5));
        }
    }
}
