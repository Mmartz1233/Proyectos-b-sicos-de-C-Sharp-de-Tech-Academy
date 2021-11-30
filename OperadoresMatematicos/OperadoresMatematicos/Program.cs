using System;

namespace OperadoresMatematicos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("****************Programa de comparación de ingresos anónimos*************************");
            Console.WriteLine("****************Persona 1*************************");
            Console.WriteLine("¿Tarifa por hora?");
            string tarifa = Console.ReadLine();
            Console.WriteLine("horas trabajadas por semana?");
            string horas = Console.ReadLine();


            /********************Operaciones**********************/
            double ntarifa = Convert.ToDouble(tarifa);
            int nhoras = Convert.ToInt32(horas);
            double salario = ntarifa * nhoras * 52;
            Console.WriteLine("Salario anual de la persona 1 es: "+salario);

            //salario = tarifa * hora *52

            Console.WriteLine("****************Persona 2*************************");
            Console.WriteLine("¿Tarifa por hora?");
            string tarifa2 = Console.ReadLine();
            Console.WriteLine("horas trabajadas por semana?");
            string horas2 = Console.ReadLine();

            /********************Operaciones**********************/
            double ntarifa2 = Convert.ToDouble(tarifa2);
            int nhoras2 = Convert.ToInt32(horas2);
            double salario2 = ntarifa2 * nhoras2 * 52;
            Console.WriteLine("Salario anual de la persona 2 es: " + salario2);


            /********************comparacion**********************/
            Console.WriteLine("¿La Persona 1 gana más dinero que la Persona 2?");
            bool tof = salario > salario2;
            Console.WriteLine(tof.ToString());














            Console.Read();
        }
    }
}
