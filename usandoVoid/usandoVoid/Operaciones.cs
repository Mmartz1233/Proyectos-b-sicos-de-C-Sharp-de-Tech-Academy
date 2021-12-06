using System;
using System.Collections.Generic;
using System.Text;

namespace usandoVoid
{
    class Operaciones //step 1.- Crear una clase.
    {
        //step 1 .- cree un método void que tome dos números enteros como parámetros. Haga que el método realice una operación matemática en el primer número entero y muestre el segundo número entero en la pantalla.
        public void Suma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine("el segundo numero es: "+b);
            Console.WriteLine("la suma de los dos numeros son: "+suma);
        }
    }
}
