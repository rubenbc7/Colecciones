using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Rubén", "1313137"));
            alumnos.Add(new Alumno("Laura", "1389617"));

            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre: " + alumno.Nombre);
                Console.WriteLine("Matricula: " + alumno.Matricula);
                Console.WriteLine(" ");
            }
            Console.Read();

        }
    }
}
