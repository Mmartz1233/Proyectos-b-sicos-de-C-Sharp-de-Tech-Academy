using System;
using System.Collections.Generic;
using System.Text;

namespace usandoClasesStaticas
{
    class Operaciones//step 1 .- Crear una clase
    {
        //step 1.- En esa clase, cree un método void que genere un número entero. Haga que el método divida los datos que se le pasan por 2.
        public void Division(int a)
        {
            int div = a/ 2;
            Console.WriteLine("El numero es: "+ a);
            Console.WriteLine("La division es: "+ div);
        }
        //step 4 .- Cree un método con parámetros de salida.
        public int Suma(int b)
        {
            return b + b;
        }
        //step 5 .- Sobrecargar un método.
        public int Suma(int b, int a)
        {
            return b + a * b;
        }

        //Declara una clase estática.
        public static void Static()
        {
            Console.WriteLine("Soy estatica");
        }
    }
}
