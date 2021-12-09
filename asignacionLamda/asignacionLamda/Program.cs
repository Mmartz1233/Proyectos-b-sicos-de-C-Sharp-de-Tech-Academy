using System;
using System.Collections.Generic;
using System.Linq;
namespace asignacionLamda
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expresiones Lamda!");

            //paso 1.-En el método Main(), cree una lista de al menos 10 empleados.Cada empleado debe tener un nombre y apellido, así como una identificación.Al menos dos empleados deben tener el nombre de pila "Joe".
            List<Empleado> personas = new List<Empleado>();
            Empleado emp = new Empleado(1, "jo", "mam");
            personas.Add(new Empleado(1, "Joe", "Ruberts"));
            personas.Add(new Empleado(2, "Joe", "Anston"));
            personas.Add(new Empleado(3, "May", "Martz"));
            personas.Add(new Empleado(4, "Jul", "Huerta"));
            personas.Add(new Empleado(5, "Casi", "Rivers"));
            personas.Add(new Empleado(6, "Dan", "MMartz"));
            personas.Add(new Empleado(7, "Ale", "Abil"));
            personas.Add(new Empleado(8, "Joe", "Del"));
            personas.Add(new Empleado(9, "Liz", "Samp"));
            personas.Add(new Empleado(0, "Ari", "Samp"));
            //Paso 2.- Usando un bucle foreach, cree una nueva lista de todos los empleados con el nombre "Joe".
            List<Empleado> nueva = new List<Empleado>(); // creamos una nueva lista de tipo Empleado en donde agregaremos todas aquellas que sean igual a Joe
            foreach (Empleado indexperson in personas)
            {
              // Comparamos si el nombre de la persona es igual a Joe
               if (indexperson.Nombre == "Joe")
                {
                    //si es igual agregamos a la persona con el mismo nombre
                    nueva.Add(indexperson);
                    Console.WriteLine("Nombre agregado: "+indexperson.Nombre);
                 }

            }

            //paso 3.- Realice la misma acción nuevamente, pero esta vez con una expresión lambda.
            //creamos una nueva lista de tipo empleado, en donde  hacemos la comparacion de si nombre es igual a Joe, y con To List la creamos
            List<Empleado> nuevaLista = personas.Where(x => x.Nombre == "Joe").ToList();
            foreach (Empleado empleado in nuevaLista)
            {
                Console.WriteLine("Nombres similares: {0} {1}",empleado.ID, empleado.Nombre);
            }

            //Paso 4.- Usando una expresión lambda, haga una lista de todos los empleados con un número de Id mayor que 5.
            //creamos una nueva lista de tipo empleado, en donde  hacemos la comparacion de si el ID es mayor a 5, y con To List la creamos
            List<Empleado> listaMayoraCinco = personas.Where(x => x.ID > 5 ).ToList();
            foreach (Empleado empleado in listaMayoraCinco)
            {
                Console.WriteLine("ID mayor a cinco: {0} {1}", empleado.ID, empleado.Nombre);
            }


        }
    }
}
