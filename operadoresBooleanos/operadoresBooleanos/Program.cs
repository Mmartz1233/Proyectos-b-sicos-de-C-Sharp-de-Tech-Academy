using System;

namespace operadoresBooleanos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("****************Seguro de automovil*******************");
            Console.WriteLine("¿Cuál es tu edad?");
            string edad = Console.ReadLine();
            Console.WriteLine("¿Alguna vez ha tenido un DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("¿Cuántas multas por exceso de velocidad tienes?");
            string multas = Console.ReadLine();

            /**********************Conversiones**********************/
            int nedad = Convert.ToInt32(edad);
            int nmultas = Convert.ToInt32(multas);

            /**********************Comparaciones**********************/
            bool res = nedad > 15 && dui == "false" && nmultas < 3;
            Console.WriteLine("¿Debes ser Calificado?" + res);

            Console.Read();
        }
    }
}
