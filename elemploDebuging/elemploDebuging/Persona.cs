using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace elemploDebuging
{
    class Persona
    {
       //Creo propiedades
       public string Nombre { set; get; }
       public string App { set; get; }
        //Creo un constructor parametrizado
        public Persona(string nombre, string app)
        {
            this.Nombre = nombre;
            this.App = app;
        }
        //Creo la funcion para comparar objetos 
        public override bool Equals(object obj)
        {
            if (obj is Persona)
            {
                Persona temp = (Persona)obj;
                if (Nombre == temp.Nombre) 
                    return true;
            }
            return false;
        }
        //creo un constructor parametrizado
        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
        //declaro una funcion para comparar de la misma clase Persona
        public static bool operator ==(Persona a, Persona b)
        {
            return a.Equals(b);
        }
        //al declarar la primera funcion para comparar, opr default me pide la segunda en negacion
        public static bool operator !=(Persona a, Persona b)
        {
            return !(a.Equals(b));
        }

    }
}
