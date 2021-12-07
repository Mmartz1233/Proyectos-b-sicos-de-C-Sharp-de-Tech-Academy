using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionInterfaz
{
    //step 2...- Haga que su clase de empleado del ejercicio anterior herede esa interfaz e implemente el método Quit () de la forma que elija.
    class Empleado : Person, IQuittable
    {
        
        public override void SayName()
        {
            Console.WriteLine("Nombre completo: {0} {1}", firstName, lastName);
        }
        public new void Quit()
        {
            Console.WriteLine("Soy una interfaz");
        }
    }
}
