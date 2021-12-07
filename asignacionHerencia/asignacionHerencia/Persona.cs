using System;
using System.Collections.Generic;
using System.Text;

namespace asignacionHerencia
{
    public class Persona
    {
        //paso 1 .- asígnele dos propiedades, cada una de ellas de tipo cadena de datos. Uno llamado FirstName, el otro LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //paso 2.- Dé a esta clase un método vacío llamado SayName () que no toma parámetros y simplemente escribe el nombre completo de la persona 
        public void SayName()
        {

            Console.WriteLine("Nombre: {0}   {1}",FirstName, LastName);
           
        }

   
    }
}
