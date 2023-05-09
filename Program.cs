using System;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();    

            printer.WriteTitle("Bienvenidos a la escuela"); 

            printer.Beep();

            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            printer.DibujarLinea(20);
            printer.WriteTitle("Cursos de la escuela");
            printer.DibujarLinea(20);

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
            else
            {
                return;
            }
        }
    }
}




