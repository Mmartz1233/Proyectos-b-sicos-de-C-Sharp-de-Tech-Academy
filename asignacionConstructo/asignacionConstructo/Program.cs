using System;

namespace asignacionConstructo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //paso2 .- Cree una variable con la palabra clave "var". llamo a un constructor
            var contacto = new Nombre("Mayra", "Martz", 28);
            // Llamo al siguiente constructor
            var gen = new Nombre("Mujer");
            //paso 1.- Cree una variable constante.
            const string live = "Mexico";
            //Encadena dos constructores juntos.

            Console.WriteLine("El contacto {0} {1} {2} vive en {3} y es {4}", contacto.Nom, contacto.App, contacto.Edad, live, gen.Sexo);
   
        }
    }
    public class Nombre
    {
        // Creando propiedades
        public String Nom { get; set; }
        public String App { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }

        //creando constructor parametrizado
        public Nombre(String nom, String app, int edad)
        {
            this.Nom = nom;
            this.App = app;
            this.Edad = edad;
        }

        public Nombre(String sex)
        {
            this.Sexo = sex;
        }


    }
}
