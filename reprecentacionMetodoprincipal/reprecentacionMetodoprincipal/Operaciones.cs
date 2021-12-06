using System;
using System.Collections.Generic;
using System.Text;

namespace reprecentacionMetodoprincipal
{
    class Operaciones //step 1.- Crear una clase.
    {
        //sobre carga de metodos: crear un metodo con el mismo nombre pero con diferentes atributos, el tipo de retorno puede cambiar 
        //step1.- cree un método que tome un número entero, cree una operación matemática para este número entero (suma, resta, etc.), luego devuelva la respuesta como un número entero.
        public  int Suma(int a)
        {
            return a + a;
        }
        //step 3 .- Agregue un segundo método a la clase con el mismo nombre  que tomará un decimal, cree una operación matemática diferente para él y luego devuelva la respuesta como un número entero.
        public  int Suma(decimal x)
        {
            //de decimal a int
            int equis = Convert.ToInt32(x);
          
            return equis - equis;
        }
        //step 5.- Agregue un tercer método a la clase, con el mismo nombre, que tomará una cadena, la convertirá a un número entero si es posible, le hará una operación matemática diferente y luego devolverá la respuesta como un número entero.
        public  int Suma(string letra1)
        {
          return Int32.Parse(letra1) * Int32.Parse(letra1);
        }
       
    }
}
