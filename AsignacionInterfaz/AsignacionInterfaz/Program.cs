using System;

namespace AsignacionInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //step 3 .- Utilice polimorfismo para crear un objeto de tipo IQuittable y llame al método Quit () en él. Sugerencia: un objeto puede ser de un tipo de interfaz si implementa esa interfaz específica.
            IQuittable emp = new Empleado();
            emp.Quit();
           
            
            IQuittable aub = (IQuittable)emp;
            aub.Quit();


            Empleado emp1 = new Empleado();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.SayName();


        }
        
      


    }
}
