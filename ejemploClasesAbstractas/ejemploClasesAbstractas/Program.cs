using System;

namespace ejemploClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 5.- Dentro del método Main (), cree una instancia de un objeto Employee con firstName "Sample" y lastName "Student". Llame al método SayName () en el objeto.
            Console.WriteLine("Hello World!");
            Empleado emp = new Empleado();
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
        }
    }
}
