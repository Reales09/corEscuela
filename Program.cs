using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2023,
             TiposDeEscuela.Primaria,             
              ciudad: "Bogotá"
             );

             var arregloCursos = new Curso[3];  

             arregloCursos[0] = new Curso(){
                 Nombre = "101", 
             };

              arregloCursos[1] = new Curso(){
                 Nombre = "201", 
             };

                arregloCursos[2] = new Curso(){
                 Nombre = "301", 
             };
            
            Console.WriteLine(escuela);

            System.Console.WriteLine("==============");

            ImprimirCursosWhile(arregloCursos);

            
           
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
    
}

    
