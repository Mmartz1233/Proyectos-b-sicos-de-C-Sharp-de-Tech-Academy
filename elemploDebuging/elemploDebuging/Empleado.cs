using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace elemploDebuging
{
    class Empleado : Persona
    {
        //Creo propiedades
        public string Nombre { set; get; }
        public string App { set; get; }
        public string ID { get; set; }
        //Creo un constructor parametrizado
        public Empleado(string id, string nombre, string app):base(nombre, app)
        {
            this.ID = id;
         
        }
        //Creo la funcion




    }
}
