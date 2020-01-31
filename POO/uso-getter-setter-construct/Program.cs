using System;

namespace uso_getter_setter_construct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los constructores sirven para inicializar las caracteristicas de los objetos
            Coche cocheUno = new Coche("Honda CRV");//instanciamos y damos estado inicial con el constructor
            cocheUno.setExtras(true , "Cuero");
            System.Console.WriteLine(cocheUno.getInformacionCoche());
            System.Console.WriteLine(cocheUno.getExtras());
            
            Coche cocheDos = new Coche("Ford Escape");//instanciamos y damos estado inicial con el constructor
            cocheDos.setExtras(false , "Normal");
            System.Console.WriteLine(cocheDos.getInformacionCoche());
            System.Console.WriteLine(cocheDos.getExtras());

            //Usando Sobrecarga de constructores
            Coche cocheTres = new Coche("Kia" , 950 , 155 , 295);
            System.Console.WriteLine(cocheTres.getInformacionCoche());
            System.Console.WriteLine(cocheTres.getExtras());
        }
    }

    class Coche {
        private string color;
        private double peso;
        private double largo;
        private double ancho;
        private int ruedas;
        private bool climatizador;
        private string tapiceria;
        private string marca;

        public Coche (string marca) 
        {
            this.marca = marca;
            color = "Blanco" ;
            peso = 780;
            largo = 320;
            ancho = 155;
            ruedas = 4;
            tapiceria = "Tela";
        }

        public Coche 
            (
                string marca , 
                double peso , 
                double ancho , 
                double largo
            ) 
        {
            this.ruedas = 4;
            this.marca = marca;
            this.peso = peso;
            this.ancho = ancho;
            this.largo = ancho;
            tapiceria = "Tela";
        }

        public void setExtras (bool climatizador , string tapiceria) {//los setter no devuelven nada
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras () {
            return "------EXTRAS EN EL COCHE------" + "\nClimatizador -> " + this.climatizador +
                    "\nTapiceria -> " + this.tapiceria;
        }

        
        public string getInformacionCoche () {
            return  "------------ Datos Coche -> " + this.marca +  
                    "\nColor -> " + this.color + 
                    "\nPeso -> " + this.peso + 
                    "\nLargo -> " + this.largo + 
                    "\nAncho -> " + this.ancho + 
                    "\nRuedas -> " + this.ruedas;
        }
    }
}
