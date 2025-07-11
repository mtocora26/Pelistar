namespace Pelistar.Clases
{
    public class Pelicula : Contenido
    {
        public int DuracionMinutos { get; set; }

        public Pelicula() : base() {}

        public Pelicula(int id, string titulo, string director, int anio, bool esFavorito, double calificacion, string genero, Estado estado, int duracionMinutos)
            : base(id, titulo, director, anio, esFavorito, calificacion, genero, estado)
        {
            DuracionMinutos = duracionMinutos;
        }

        public override void cambiarEstado(Estado nuevoEstado)
            {
                estado = nuevoEstado;
                Console.WriteLine($"[Pelicula] Estado cambiado a: {estado}");
            }

            public override void marcarComoFavorito()
            {
                esFavorito = true;
                Console.WriteLine("[Pelicula] ¡Esta película es ahora tu favorita!");
            }

            public override void quitarDeFavoritos()
            {
                esFavorito = false;
                Console.WriteLine("[Pelicula] Se quitó de favoritos.");
            }
        }
}
