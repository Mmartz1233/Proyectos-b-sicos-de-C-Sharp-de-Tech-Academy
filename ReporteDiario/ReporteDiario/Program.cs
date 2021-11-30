using System;

namespace ReporteDiario
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**********The Tech Academy**********");
            Console.WriteLine("***Informe diario del estudiante****");
            Console.WriteLine("1. ¿Cómo te llamas?"); //Imprimir datos en pantalla
            string nombre = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("2. ¿En qué curso estás?");//Imprimir datos en pantalla
            string curso = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("3. ¿Qué número de página?");//Imprimir datos en pantalla
            string numpag = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("4. ¿Necesitas ayuda con algo?  Responda \" true \" o \" false \"");//Imprimir datos en pantalla
            string help = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("5. ¿Hubo alguna experiencia positiva que le gustaría compartir? Por favor proporcione detalles.");//Imprimir datos en pantalla
            string experiencia = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("6. ¿Hay algún otro comentario que le gustaría proporcionar? Por favor sea especifico.");//Imprimir datos en pantalla
            string comentario = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("7. ¿Cuántas horas estudiaste hoy?");//Imprimir datos en pantalla
            string horas = Console.ReadLine();//guardando datos en un string
            Console.WriteLine("Gracias por sus respuestas. Un instructor responderá a esto en breve. ¡Qué tengas un lindo día!");//Imprimir datos en pantalla


            //Casting
            int pag = Convert.ToInt32(numpag); //convirtiendo de string a int
            bool ayuda = Convert.ToBoolean(help); //convirtiendo de string a bool
            int horasstudiando = Convert.ToInt32(horas);//convirtiendo de string a int

         












            Console.Read();
        }
    }
}
