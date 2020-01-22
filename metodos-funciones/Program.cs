using System;

namespace metodos
{
    class Program
    {
                                /*LOS METODOS O FUNCIONES VAN DENTRO DE LA CLASE*/

/******************************************************************************************************************/
        //FUNCION QUE RETORNA NO PARAMETROS Y NO TIENE POR EL MOMENTO STATIC VOID DESPUES CON OBJETOS
        static void sumaNumeros() {
            int numero1 = 5;
            int numero2 = 5;
            int res = numero1 + numero2;
            Console.WriteLine("La Suma de Los Numeros es 5 y 5 es -> {0}" , res);
        }
        static void restarNumeros() {
            int numero1 = 5;
            int numero2 = 5;
            int res = numero1 - numero2;
            Console.WriteLine("La Resta de los numeros es 5 y 5 es -> {0}" , res);
        }
        static void multiplicarNumeros() {
            int numero1 = 5;
            int numero2 = 5;
            int res = numero1 * numero2;
            Console.WriteLine("La Multiplicacion de los numeros es 5 y 5 es -> {0}" , res);
        }
        static void divisionNumeros() {
            double numero1 = 5;
            double numero2 = 5;
            if (numero2 == 0) {
                Console.WriteLine("No se Puede Dividir Por Cero");
            } else {
                double res = (numero1 / numero2);
                Console.WriteLine("La Division De los numeros 5 y 5 es -> {0}" , res);
            }
        }
        static void moduloNumeros() {
            double numero1 = 5;
            double numero2 = 5;
            double res = numero1 % numero2;
            Console.WriteLine("El Modulo de los numeros 5 y 5 es -> {0}" , res);
        }

/******************************************************************************************************************/
        //FUNCION QUE RETORNA PARAMETROS PERO SIN PARAMETROS EN LOS PARENTESIS
        static int sumNum() {
            int numero1 = 5;
            int numero2 = 5;
            return numero1 + numero2;
        }
        static int restNum() {
            int numero1 = 5;
            int numero2 = 5;
            return numero1 - numero2;
        }
        static int multNum() {
            int numero1 = 5;
            int numero2 = 5;
            return numero1 * numero2;
        }
        static double divNum() {
            double numero1 = 5;
            double numero2 = 5;
            double res = (numero1 / numero2);
            return res;
        }
        static double modNum() {
            double numero1 = 5;
            double numero2 = 5;
            return (numero1%numero2);
        }

/******************************************************************************************************************/
       //FUNCION QUE NO RETORNA PARAMETROS PERO TIENE PARAMETROS
       static void sNum(int numero1 , int numero2) {
           int suma = numero1 + numero2;
           System.Console.WriteLine("Suma de Numeros -> {0}" , suma);
       }
       static void rNum(int numero1 , int numero2) {
           int resta = numero1 - numero2;
           System.Console.WriteLine("Resta de Numeros -> {0}" , resta);
       }
       static void mNum(double numero1 , double numero2) {
           double multiplicacion = numero1 * numero2;
           System.Console.WriteLine($"Multiplicacion de Numeros -> {multiplicacion}");
       }
       static void dNum(double numero1 , double numero2) {
           double division = numero1 / numero2;
           System.Console.WriteLine($"Division de Numeros -> {division}");
       }
       static void moNum(double numero1 , double numero2) {
           double modulo = numero1 % numero2;
           System.Console.WriteLine($"Modulo de Numero -> {modulo}"); 
       } 

/******************************************************************************************************************/
        //FUNCTION QUE RETORNA PARAMETROS Y TIENE PARAMETROS EN SU FUNCION
        static double addNumbers(double num1 , double num2) {
            return num1 + num2;
        }
        static double substractNumbers(double num1 , double num2) {
            return num1 - num2;
        }
        static double multiplyNumbers(double num1 , double num2) {
            return num1 * num2;
        }
        static double divideNumbers(double num1 , double num2) {
            return num1 / num2;
        } 
        static double moduleNumbers(double num1 , double num2) {
            return num1 % num2;
        }
        static void Main(string[] args)
        {
            /*METODOS EN C# ES IGUAL QUE EN JAVA practicamente funciones*/
            /*
                                sintaxis
                tipo_dato_devuelto nombre_metodo(parametros) {
                    cuerpo del metodo
                }
            */

            // despliegue de metodos sin parametros y sin return
            sumaNumeros();
            restarNumeros();
            multiplicarNumeros();
            divisionNumeros();
            moduloNumeros();

            // despliegue de metodos sin parametros y con return
            double suma = sumNum();
            System.Console.WriteLine("Suma -> {0}" , suma);
            double resta = restNum();
            System.Console.WriteLine("Resta -> {0}" , resta);
            double multiplicacion = multNum();
            System.Console.WriteLine("Multiplicacion -> {0}" , multiplicacion);
            double division = divNum();
            System.Console.WriteLine("Division -> {0}" , division);
            double modulo = modNum();
            System.Console.WriteLine("Modulo -> {0}" , modulo);

            // despliege de metodos sin return pero con parametros
            sNum(10,10);
            rNum(10,10);
            mNum(10,10);
            dNum(10,10);
            moNum(10,10);

            // despliegue de metodos con parametros y que retornan numeros
            System.Console.WriteLine("Digite el Primer Numero -> ");
            double num1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite el Segundo Numero -> ");
            double num2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Suma -> {0}" , addNumbers(num1 , num2));
            System.Console.WriteLine("Resta -> {0}" , substractNumbers(num1 , num2));
            System.Console.WriteLine("Multiplicacion -> {0}" , multiplyNumbers(num1 , num2));
            System.Console.WriteLine("Division -> {0}" , divideNumbers(num1 , num2));
            System.Console.WriteLine("Modulo -> {0}" , moduleNumbers(num1 , num2));

        }
    }
}
