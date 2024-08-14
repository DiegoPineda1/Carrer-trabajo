using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera.Clases
{
    public class carrera
    {
        public string nombre {  get; set; }
        public string titulo { get; set; }
        private List<DetalleCarrera> lstdetalle;

        public carrera(string nombre, string titulo)
        {
            this.nombre = nombre;
            this.titulo = titulo;
            this.lstdetalle = new List<DetalleCarrera>();
        }
        public void AgregarDetalle(DetalleCarrera detalle) 
        {
            lstdetalle.Add(detalle);
        }
        public void MostrarDetalle()
        {
            Console.WriteLine($"Carrera: {nombre}");
            foreach(var  detalle in lstdetalle)
            {
                Console.WriteLine(detalle.ToString());
            }
        }
    }
}
