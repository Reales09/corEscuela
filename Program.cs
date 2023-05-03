using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();    

            WriteLine("==================================");  
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("==========================");
            WriteLine("Cursos de la escuela");
            WriteLine("==========================");

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




