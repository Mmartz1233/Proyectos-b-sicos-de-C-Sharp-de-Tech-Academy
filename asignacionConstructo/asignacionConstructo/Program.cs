using System;

namespace asignacionConstructo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //paso2 .- Cree una variable con la palabra clave "var". llamo a un constructor
            
            // Llamo al siguiente constructor
           
            var nombre = new Nombre("Mayra");
           //paso 1.- Cree una variable constante.
            const string live = "Mexico";
            //Encadena dos constructores juntos.
            Nombre contacto = nombre, d = new Nombre(28);
            Console.WriteLine("el contacto {0} tiene {1} anios de edad y vive en {1}",nombre.Nom,nombre.Edad, live);


   
        }
    }
    public class Nombre
    {
        //Creando variables
        public int edad;
        public string name;
  

        // Creando propiedades
          public String Nom { get; set; }
         public int Edad { get; set; }
      
        //creando constructor 
        public Nombre() : this("", 0)
        {

        }
        //creando constructor parametrizado
        public Nombre(String nom, int edad)
        {
            this.Nom = nom;
            this.Edad = edad;
        }
        public Nombre(int edad):this("", edad)
        {
        }
        public Nombre(string nom):this(nom, 28)
        {

        }
       


    }
}
