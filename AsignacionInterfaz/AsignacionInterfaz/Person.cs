using System;
using System.Collections.Generic;
using System.Text;

namespace AsignacionInterfaz
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //step 2 .- Dale el método SayName().
        public abstract void SayName();//no contiene implementacion en el metodo abstracto

    }
}
