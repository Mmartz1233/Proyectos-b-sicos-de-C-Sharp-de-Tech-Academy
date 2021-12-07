using System;

namespace asignacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Empleado emp = new Empleado();
            string val1 = emp.FirstName = "Muestra";
            string val2 = emp.LastName = "Estudiante";
            emp.SayName();
            
            
        }
        
    }
}
