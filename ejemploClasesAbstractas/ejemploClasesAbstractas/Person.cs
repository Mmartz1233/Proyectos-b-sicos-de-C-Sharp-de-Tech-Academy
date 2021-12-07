using System;
using System.Collections.Generic;
using System.Text;

namespace ejemploClasesAbstractas
{
    //step 1.- Cree una clase abstracta llamada Person con dos propiedades: string firstName y string lastName.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //step 2 .- Dale el método SayName().
        public abstract void SayName();//no contiene implementacion en el metodo abstracto
        
    }
}
