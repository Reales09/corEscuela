namespace CoreEscuela.Entidades
{
    public class Escuela
    {
         public string UniqueId { get; private set; } = System.Guid.NewGuid().ToString();
         
        string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }  

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposDeEscuela TipoEscuela  { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela(string nombre, int año,
         TiposDeEscuela tipo,
         string pais="",
        string ciudad=""){

            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;

        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}