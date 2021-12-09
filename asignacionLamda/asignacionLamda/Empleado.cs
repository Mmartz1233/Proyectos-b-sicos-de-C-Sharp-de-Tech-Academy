using System;
using System.Collections.Generic;
using System.Text;

namespace asignacionLamda
{
    class Empleado
    {
        //Paso1.- creamos sus propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string App { get; set; }

        //paso2.- creamos el constructor
        public Empleado() { }
        public Empleado(int id, string nom, string app)
        {
            this.ID = id;
            this.Nombre = nom;
            this.App = app;
        }
       

    }
}
