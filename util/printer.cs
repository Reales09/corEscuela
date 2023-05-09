using static System.Console;

namespace CoreEscuela.Util


{
    public static class printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam, '=');
            WriteLine(linea);
        }

        public static void WriteTitle(String titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }

    }


}
