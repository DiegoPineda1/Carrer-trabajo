using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera.Clases
{
    public class DetalleCarrera
    {
        public double anioCursado {  get; set; }
        public int cuatrimestre {  get; set; }
        public int materia {  get; set; }
        public Asignatura Asignatura {  get; set; }

        public DetalleCarrera(double anioCursado, int cuatrimestre, int materia, Asignatura asignatura)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.materia = materia;
            Asignatura = asignatura;
        }
        public override string ToString()
        {
            string aux = $"Año cursado {anioCursado} - Cuatrimestre {cuatrimestre} - Materia {materia} - Asignatura {Asignatura.ToString()}";
            return aux;
        }
    }
}
