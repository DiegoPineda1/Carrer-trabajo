using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera.Clases
{
    public class Asignatura
    {
        public string nombre {  get; set; }

        public Asignatura(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
        {
            string aux = nombre;
            return aux;
        }
    }
}
