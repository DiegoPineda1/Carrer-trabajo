using Carrera.Clases;


class Program
{
    static void Main(string[] args)
    {
        carrera carrera = new carrera("Programacion","Tecnico Superio En Programacion");

        Asignatura asignatura1 = new Asignatura("Algoritmos y Estructuras de Datos");
        DetalleCarrera detalleCarrera1 = new DetalleCarrera(2, 4, 20, asignatura1);

        Asignatura asignatura2 = new Asignatura("Matemáticas Discretas");
        DetalleCarrera detalleCarrera2 = new DetalleCarrera(3, 3, 20, asignatura2);
        carrera.AgregarDetalle(detalleCarrera1);
        carrera.AgregarDetalle(detalleCarrera2);
        carrera.MostrarDetalle();


    }
}