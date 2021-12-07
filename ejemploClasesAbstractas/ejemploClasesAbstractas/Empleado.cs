using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploClasesAbstractas
{
    //step3.- Cree otra clase llamada Empleado y haga que herede de la clase Persona.
    class Empleado :Person
    {
        //step 4 .- Implemente el método SayName () dentro de la clase Employee.
        public override void SayName()
        {
            Console.WriteLine("Nombre completo: {0} {1}", firstName, lastName);
        }
    }
}
