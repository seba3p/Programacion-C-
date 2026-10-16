using System;
using System.IO;

namespace practicaprogramacion
{
    class Empleado
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int SueldoRandom { get; private set; }

        public Empleado(int doc, string nombre, string apellido)
        {
            DNI = doc;
            Nombre = nombre;
            Apellido = apellido;

            Random rnd = new Random();
            SueldoRandom = rnd.Next(300, 1001);
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, DNI: {DNI}, Sueldo: {SueldoRandom}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            Empleado empleado1 = new Empleado(12345678, "Juan", "Pérez");
            empleado1.Mostrar();
            string contenido= "";        
                contenido += $"{empleado1.DNI};";
                contenido += $"{empleado1.Apellido}, ";
                contenido += $"{empleado1.Nombre};";
                contenido += $"{empleado1.SueldoRandom}";
            File.WriteAllText(@"c:\temp\Nomina2.txt",contenido);
            Console.WriteLine("Archivo guardado correctamente.");
        }
    }
}
