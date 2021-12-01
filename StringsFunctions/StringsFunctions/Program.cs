using System;
using System.Text;

namespace StringsFunctions
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Utilizando funciones con strings!");
            string name = "Mayra";
            string saludo = name+" te dice \" hola \" \n Esta es una nueva linea \t Y hola con tabulador"; //usando tabuladores, saltos de linea y comlillas en una oracion
            string filename = @"C:\Users\Mayra";
            bool trueOrfalse = name.Contains("s"); //le pregunta si el nombre contiene una y
            trueOrfalse = name.EndsWith("a");//le pregunta si el nombre termina con una a
            StringBuilder may = new StringBuilder(); //creando un nuevo objeto de la clase System.text
            may.Append("My name is Mayra,");
            may.Append(" my lastname is Martz,");
            may.Append(" nice too meet you.!");
            Console.WriteLine("El nombre "+name+ " tiene "+name.Length+" letras");//concatenando palabras
            Console.WriteLine(may);
            Console.WriteLine(name.Length);//determina la longitud de la palabra
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(trueOrfalse); // lee la ultima instruccion declarada, en este caso a la de si termina o no con a
            Console.WriteLine(saludo);
            Console.ReadLine();
            Console.Read();
        }
    }
}
