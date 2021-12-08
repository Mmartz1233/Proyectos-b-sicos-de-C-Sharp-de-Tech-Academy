using System;

namespace elemploDebuging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operador de sobrecarga!");
            //Instancion dos  objetos
            Persona per = new Persona("may");
            Persona per1 = new Persona("may");
            //comparo si son iguales 
            if (per == per1)
            {
                Console.WriteLine("son iguales");
            }else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}
